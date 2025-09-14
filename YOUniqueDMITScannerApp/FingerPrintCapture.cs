using ScanAPIHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Media.Imaging;

namespace YouniqueDMITFingurePrintCaptureApp
{
    public partial class FingerPrintCapture : Form
    {
        delegate void SetTextCallback(string text);

        const int FTR_ERROR_EMPTY_FRAME = 4306; /* ERROR_EMPTY */
        const int FTR_ERROR_MOVABLE_FINGER = 0x20000001;
        const int FTR_ERROR_NO_FRAME = 0x20000002;
        const int FTR_ERROR_USER_CANCELED = 0x20000003;
        const int FTR_ERROR_HARDWARE_INCOMPATIBLE = 0x20000004;
        const int FTR_ERROR_FIRMWARE_INCOMPATIBLE = 0x20000005;
        const int FTR_ERROR_INVALID_AUTHORIZATION_CODE = 0x20000006;

        /* Other return codes are Windows-compatible */
        const int ERROR_NO_MORE_ITEMS = 259;                // ERROR_NO_MORE_ITEMS
        const int ERROR_NOT_ENOUGH_MEMORY = 8;              // ERROR_NOT_ENOUGH_MEMORY
        const int ERROR_NO_SYSTEM_RESOURCES = 1450;         // ERROR_NO_SYSTEM_RESOURCES
        const int ERROR_TIMEOUT = 1460;                     // ERROR_TIMEOUT
        const int ERROR_NOT_READY = 21;                     // ERROR_NOT_READY
        const int ERROR_BAD_CONFIGURATION = 1610;           // ERROR_BAD_CONFIGURATION
        const int ERROR_INVALID_PARAMETER = 87;             // ERROR_INVALID_PARAMETER
        const int ERROR_CALL_NOT_IMPLEMENTED = 120;         // ERROR_CALL_NOT_IMPLEMENTED
        const int ERROR_NOT_SUPPORTED = 50;                 // ERROR_NOT_SUPPORTED
        const int ERROR_WRITE_PROTECT = 19;                 // ERROR_WRITE_PROTECT
        const int ERROR_MESSAGE_EXCEEDS_MAX_SIZE = 4336;    // ERROR_MESSAGE_EXCEEDS_MAX_SIZE

        private Device m_hDevice;
        private bool m_bCancelOperation;
        private byte[] m_Frame;
        private bool m_bScanning;
        private byte m_ScanMode;
        private bool m_bIsLFDSupported;
        private bool m_bExit;

        class ComboBoxItem
        {
            public ComboBoxItem(String value, int interfaceNumber)
            {
                m_String = value;
                m_InterfaceNumber = interfaceNumber;
            }

            public override string ToString()
            {
                return m_String;
            }

            public int interfaceNumber
            {
                get
                {
                    return m_InterfaceNumber;
                }
            }

            private String m_String;
            private int m_InterfaceNumber;
        }
        Data data;
        private Thread WorkerThread;
               
        public FingerPrintCapture(ref Data data)
        {
            InitializeComponent();

           // m_btnClose.Enabled = false;
            m_hDevice = null;
            m_ScanMode = 0;
            m_bScanning = false;
            m_bExit = false;
            this.data = data;
            string[] SideList = { "Left", "Center", "Right" };
            string[] FingerList = { "L1", "L2", "L3", "L4", "L5", "R1", "R2", "R3", "R4", "R5" };
            comboFinger.Items.AddRange(FingerList);
            comboSide.Items.AddRange(SideList);
            comboFinger.SelectedIndex = 0;
            comboSide.SelectedIndex = 0;           
            this.Load += OnFormLoad;

        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            try
            {
                int defaultInterface = ScanAPIHelper.Device.BaseInterface;
                FTRSCAN_INTERFACE_STATUS[] status = ScanAPIHelper.Device.GetInterfaces();
                for (int interfaceNumber = 0; interfaceNumber < status.Length; interfaceNumber++)
                {
                    if (status[interfaceNumber] == FTRSCAN_INTERFACE_STATUS.FTRSCAN_INTERFACE_STATUS_CONNECTED)
                    {
                        int index = m_cmbInterfaces.Items.Add(new ComboBoxItem(interfaceNumber.ToString(), interfaceNumber));
                        if (defaultInterface == interfaceNumber)
                        {
                            m_cmbInterfaces.SelectedIndex = index;
                        }
                    }
                }
         
                m_ScanMode = 0;

                if (m_cmbInterfaces.SelectedIndex >= 0)
                {
                    OnOpenDevice(sender, e);

                    StartBtn.Enabled = true;
                    SaveBtn.Enabled = true;
                    checkBoxAutoSave.Checked = true;
                    // comboFinger.Enabled = true;
                    //comboSide.Enabled = true;

                }
                else
                {
                    StartBtn.Enabled = false;
                    SaveBtn.Enabled = false;
                    comboFinger.Enabled = false;
                    comboSide.Enabled = false;
                    checkBoxAutoSave.Enabled = false;
                }

                
                //if (m_hDevice != null)
                //    OnTestGetFrame(sender, e);
            }
            catch (ScanAPIException ex)
            {
                ShowError(ex);
            }

        }

        private void m_cmbInterfaces_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (m_cmbInterfaces.SelectedIndex != -1)
            {
                ComboBoxItem item = (ComboBoxItem)m_cmbInterfaces.Items[m_cmbInterfaces.SelectedIndex];
                try
                {
                    ScanAPIHelper.Device.BaseInterface = item.interfaceNumber;
                    // m_btnOpenDevice.Enabled = true;
                }
                catch (ScanAPIException ex)
                {
                    ShowError(ex);
                }
            }
            else
            {
                //m_btnOpenDevice.Enabled = false;
            }

        }

        private void ShowError(ScanAPIException ex)
        {
            string szMessage;
            switch (ex.ErrorCode)
            {
                case FTR_ERROR_EMPTY_FRAME:
                    szMessage = "Empty Frame";

                    break;

                case FTR_ERROR_MOVABLE_FINGER:
                    szMessage = "Movable Finger";
                    break;

                case FTR_ERROR_NO_FRAME:
                    szMessage = "Fake Finger";
                    break;

                case FTR_ERROR_HARDWARE_INCOMPATIBLE:
                    szMessage = "Incompatible Hardware";
                    break;

                case FTR_ERROR_FIRMWARE_INCOMPATIBLE:
                    szMessage = "Incompatible Firmware";
                    break;

                case FTR_ERROR_INVALID_AUTHORIZATION_CODE:
                    szMessage = "Invalid Authorization Code";
                    break;

                case ERROR_NOT_ENOUGH_MEMORY:
                    szMessage = "Error code ERROR_NOT_ENOUGH_MEMORY";
                    break;

                case ERROR_NO_SYSTEM_RESOURCES:
                    szMessage = "Error code ERROR_NO_SYSTEM_RESOURCES";
                    break;

                case ERROR_TIMEOUT:
                    szMessage = "Error code ERROR_TIMEOUT";
                    break;

                case ERROR_NOT_READY:
                    szMessage = "Error code ERROR_NOT_READY";
                    break;

                case ERROR_BAD_CONFIGURATION:
                    szMessage = "Error code ERROR_BAD_CONFIGURATION";
                    break;

                case ERROR_INVALID_PARAMETER:
                    szMessage = "Error code ERROR_INVALID_PARAMETER";
                    break;

                case ERROR_CALL_NOT_IMPLEMENTED:
                    szMessage = "Error code ERROR_CALL_NOT_IMPLEMENTED";
                    break;

                case ERROR_NOT_SUPPORTED:
                    szMessage = "Error code ERROR_NOT_SUPPORTED";
                    break;

                case ERROR_WRITE_PROTECT:
                    szMessage = "Error code ERROR_WRITE_PROTECT";
                    break;

                case ERROR_MESSAGE_EXCEEDS_MAX_SIZE:
                    szMessage = "Error code ERROR_MESSAGE_EXCEEDS_MAX_SIZE";
                    break;

                default:
                    szMessage = String.Format("Error code: {0}", ex.ErrorCode);
                    break;
            }
            //SetMessageText( szMessage );


        }

        private void OnOpenDevice(object sender, EventArgs e)
        {
            try
            {
                m_hDevice = new Device();
                m_hDevice.Open();              

                m_cmbInterfaces.Enabled = false;
                
            }
            catch (ScanAPIException ex)
            {
                if (m_hDevice != null)
                {
                    m_hDevice.Dispose();
                    m_hDevice = null;
                }
                ShowError(ex);
            }

        }

        private void OnCloseDevice(object sender, EventArgs e)
        {
            m_bCancelOperation = true;
            Size size = m_hDevice.ImageSize;
            m_hDevice.Dispose();
            m_hDevice = null;

            m_picture.Image = null;


            m_cmbInterfaces.Enabled = true;
     
            Program.pd_form.Show();
            this.Dispose();
        }

        private void GetFrame()
        {
            try
            {
                if (m_ScanMode == 0)

                    m_Frame = m_hDevice.GetFrame();
                else
                    m_Frame = m_hDevice.GetImage(m_ScanMode);
     
            }
            catch (ScanAPIException ex)
            {
                if (m_Frame != null)
                    m_Frame = null;
                ShowError(ex);
            }
        }

        private void OnTestGetFrame(object sender, EventArgs e)
        {
            scanningFinger_Highlight();
            if (!m_bScanning)
            {
                m_bCancelOperation = false;
                
                StartBtn.Enabled = false;
               
                WorkerThread = new Thread(new ThreadStart(CaptureThread));
                WorkerThread.Start();
            }
            else
            {
                m_bCancelOperation = true;
               
                StartBtn.Enabled = true;
                
            }
        }

        private void CaptureThread()
        {
            m_bScanning = true;
            while (!m_bCancelOperation)
            {
                GetFrame();
                if (m_Frame != null)
                {
                    MyBitmapFile myFile = new MyBitmapFile(m_hDevice.ImageSize.Width, m_hDevice.ImageSize.Height, m_Frame);
                    MemoryStream BmpStream = new MemoryStream(myFile.BitmatFileData);
                    Bitmap Bmp = new Bitmap(BmpStream);
                    m_picture.Image = Bmp;
                }
                else
                    m_picture.Image = null;
                Thread.Sleep(10);
            }
            m_bScanning = false;
        }

        private void OnFormClosed(object sender, FormClosedEventArgs e)
        {
            m_bExit = true;
            m_bCancelOperation = true;
            if (m_hDevice != null)
            {
                m_hDevice.Dispose();
                m_hDevice = null;
            }
        }

        private void m_btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlgSave = new SaveFileDialog();
            dlgSave.Filter = "bmp files (*.bmp)|*.bmp|wsq files (*.wsq)|*.wsq";
            if (dlgSave.ShowDialog() == DialogResult.OK)
            {
                if (dlgSave.FilterIndex == 1)
                {
                    MyBitmapFile myFile = new MyBitmapFile(m_hDevice.ImageSize.Width, m_hDevice.ImageSize.Height, m_Frame);
                    FileStream file = new FileStream(dlgSave.FileName, FileMode.Create);
                    file.Write(myFile.BitmatFileData, 0, myFile.BitmatFileData.Length);
                    file.Close();
                    
                }
                else //wsq
                {
                    float fBitRate = 0.75f; // in the range of 0.75 - 2.25, lower value with higher compression rate
                    byte[] wsqImage = m_hDevice.WSQ_FromRawImage(m_Frame, m_hDevice.ImageSize.Width, m_hDevice.ImageSize.Height, fBitRate);
                    if (wsqImage != null)
                    {
                        FileStream file = new FileStream(dlgSave.FileName, FileMode.Create);
                        file.Write(wsqImage, 0, wsqImage.Length);
                        file.Close();
                        
                    }
                }
            }
        }


        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_NOCLOSE = 0x200;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_NOCLOSE;
                return cp;
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            m_bCancelOperation = true;
            m_bExit = true;
            //Size size = m_hDevice.ImageSize;
            if (WorkerThread != null && WorkerThread.IsAlive)
                WorkerThread.Join(1000);

            if (m_hDevice != null)
            {
                m_hDevice.Dispose();
                m_hDevice = null;
            }
            m_picture.Image = null;
            m_cmbInterfaces.Enabled = true;           

            Program.pd_form.Show();
            this.Dispose();

        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            OnTestGetFrame(sender, e);
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (m_picture.Image != null)
            {
                m_bCancelOperation = true;

                string path = this.data.photoPath + "/" + comboFinger.SelectedItem.ToString() + "-" + comboSide.SelectedItem.ToString() + ".jpg";
                m_picture.Image.Save(path);
                SystemSounds.Exclamation.Play();
                CustomMessageBox.Show($"FingerPrint image saved at {path}","Alert");
                this.FingerPrintNameLabel.Text = comboFinger.SelectedItem.ToString() + "-" + comboSide.SelectedItem.ToString() + ".jpg"; ;
                if (checkBoxAutoSave.Checked)
                {
                    if (comboFinger.SelectedIndex < comboFinger.Items.Count)
                    {
                        if (comboFinger.SelectedIndex == comboFinger.Items.Count - 1 && comboSide.SelectedIndex == comboSide.Items.Count - 1)
                        {
                            SystemSounds.Exclamation.Play();
                            CustomMessageBox.Show("All FingerPrints are saved successfully.","Alert");
                            return;
                        }
                        if (comboSide.SelectedIndex < comboSide.Items.Count - 1)
                        {
                            comboSide.SelectedIndex += 1;
                        }
                        else
                        {
                           if (comboFinger.SelectedIndex != comboFinger.Items.Count - 1)
                            {
                                comboFinger.SelectedIndex += 1;
                                comboSide.SelectedIndex = 0;

                            }
                            else
                            {

                            }
                            
                        }
                    }
                    else
                    {
                       // comboFinger.SelectedIndex = 0;
                    }

                }                
                    OnTestGetFrame(sender, e);
            }
        }


        private void checkBoxAutoSave_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAutoSave.Checked)
            {
                comboFinger.Enabled = false;
                comboSide.Enabled = false;
            }
            else
            {
                comboFinger.Enabled = true;
                comboSide.Enabled = true;
            }

        }
        
        PictureBox scanningFigure;

        private void scanningFinger_Highlight()
        {
            switch (comboFinger.SelectedItem.ToString())
            {
                case "L1":
                    scanningFigure = L1ScanPoint;
                    break;
                case "L2":
                    scanningFigure = L2ScanPoint;
                    break;
                case "L3":
                    scanningFigure = L3ScanPoint;
                    break;
                case "L4":
                    scanningFigure = L4ScanPoint;
                    break;
                case "L5":
                    scanningFigure = L5ScanPoint;
                    break;
                case "R1":
                    scanningFigure = R1ScanPoint;
                    break;
                case "R2":
                    scanningFigure = R2ScanPoint;
                    break;
                case "R3":
                    scanningFigure = R3ScanPoint;
                    break;
                case "R4":
                    scanningFigure = R4ScanPoint;
                    break;
                case "R5":
                    scanningFigure = R5ScanPoint;
                    break;
            }
            scanningFigure.Image = Image.FromFile("GreenDot.gif");
            scanningFigure.BringToFront();
        }
        
        private void comboFinger_SelectedIndexChanged(object sender, EventArgs e)
        {

            string folderPath = this.data.photoPath;

            if (File.Exists(folderPath + "/L1-Right.jpg") && File.Exists(folderPath + "/L1-Center.jpg") && File.Exists(folderPath + "/L1-Left.jpg"))
            { 

                L1ScanPoint.Image = Image.FromFile("RedDot.gif");
                L1ScanPoint.BringToFront();

            }
            else
            {
                L1ScanPoint.Image = null;
                L1ScanPoint.SendToBack();
            }


            if (File.Exists(folderPath + "/L2-Right.jpg") && File.Exists(folderPath + "/L2-Center.jpg") && File.Exists(folderPath + "/L2-Left.jpg"))
            {
                L2ScanPoint.Image = Image.FromFile("RedDot.gif");
                L2ScanPoint.BringToFront();

            }
            else
            {
                L2ScanPoint.Image = null;
                L2ScanPoint.SendToBack();
            }

                if (File.Exists(folderPath + "/L3-Right.jpg") && File.Exists(folderPath + "/L3-Center.jpg") && File.Exists(folderPath + "/L3-Left.jpg"))

            {
                L3ScanPoint.Image = Image.FromFile("RedDot.gif");
                L3ScanPoint.BringToFront();

            }
            else
            {
                L3ScanPoint.Image = null;
                L3ScanPoint.SendToBack();
            }

            if (File.Exists(folderPath + "/L4-Right.jpg") && File.Exists(folderPath + "/L4-Center.jpg") && File.Exists(folderPath + "/L4-Left.jpg"))

            {
                L4ScanPoint.Image = Image.FromFile("RedDot.gif");
                L4ScanPoint.BringToFront();

            }
            else
            {
                L4ScanPoint.Image = null;
                L4ScanPoint.SendToBack();
            }

            if (File.Exists(folderPath + "/L5-Right.jpg") && File.Exists(folderPath + "/L5-Center.jpg") && File.Exists(folderPath + "/L5-Left.jpg"))

            {
                L5ScanPoint.Image = Image.FromFile("RedDot.gif");
                L5ScanPoint.BringToFront();

            }
            else
            {
                L5ScanPoint.Image = null;
                L5ScanPoint.SendToBack();
            }

            if (File.Exists(folderPath + "/R1-Right.jpg") && File.Exists(folderPath + "/R1-Center.jpg") && File.Exists(folderPath + "/R1-Left.jpg"))

            {
                R1ScanPoint.Image = Image.FromFile("RedDot.gif");
                R1ScanPoint.BringToFront();

            }
            else
            {
                R1ScanPoint.Image = null;
                R1ScanPoint.SendToBack();
            }

            if (File.Exists(folderPath + "/R2-Right.jpg") && File.Exists(folderPath + "/R2-Center.jpg") && File.Exists(folderPath + "/R2-Left.jpg"))

            {
                R2ScanPoint.Image = Image.FromFile("RedDot.gif");
                R2ScanPoint.BringToFront();

            }
            else
            {
                R2ScanPoint.Image = null;
                R2ScanPoint.SendToBack();
            }

            if (File.Exists(folderPath + "/R3-Right.jpg") && File.Exists(folderPath + "/R3-Center.jpg") && File.Exists(folderPath + "/R3-Left.jpg"))
            {
                R3ScanPoint.Image = Image.FromFile("RedDot.gif");
                R3ScanPoint.BringToFront();

            }
            else
            {
                R3ScanPoint.Image = null;
                R3ScanPoint.SendToBack();
            }

            if (File.Exists(folderPath + "/R4-Right.jpg") && File.Exists(folderPath + "/R4-Center.jpg") && File.Exists(folderPath + "/R4-Left.jpg"))

            {
                R4ScanPoint.Image = Image.FromFile("RedDot.gif");
                R4ScanPoint.BringToFront();

            }
            else
            {
                R4ScanPoint.Image = null;
                R4ScanPoint.SendToBack();
            }

            if (File.Exists(folderPath + "/R5-Right.jpg") && File.Exists(folderPath + "/R5-Center.jpg") && File.Exists(folderPath + "/R5-Left.jpg"))
            {
                R5ScanPoint.Image = Image.FromFile("RedDot.gif");
                R5ScanPoint.BringToFront();

            }
            else
            {
                R5ScanPoint.Image = null;
                R5ScanPoint.SendToBack();
            }

        }

         
    }

   

}



