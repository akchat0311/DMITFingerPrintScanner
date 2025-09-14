using AForge.Video.DirectShow;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YouniqueDMITFingurePrintCaptureApp
{
    public partial class PhotoCapture : Form
    {
        private VideoCapture capture;
        private Thread cameraThread;
        private bool running = false;
        private Bitmap lastFrame;
        Data data;
        public PhotoCapture(ref Data data)
        {
            InitializeComponent();
            this.data = data;
            this.Load += Form1_Load;
            this.FormClosing += Form1_FormClosing;
            LoadAvailableCameras();
        }

        private void LoadAvailableCameras()
        {
            CameraList.Items.Clear();

            var videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in videoDevices)
            {
                CameraList.Items.Add(device.Name);  // "Integrated Webcam", "Logitech BRIO"
            }

            if (CameraList.Items.Count > 0)
                CameraList.SelectedIndex = 0;
            else
            {
                SystemSounds.Exclamation.Play();
                CustomMessageBox.Show("No cameras detected!","Alert");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (running)
            {
                running = false;
                cameraThread?.Join();
                capture?.Release();
            }
            if (CameraList.SelectedIndex < 0)
            {
                SystemSounds.Exclamation.Play();
                CustomMessageBox.Show("Please select a camera.", "Alert");
                return;
            }

            // Map selected index back to device index
            int camIndex = CameraList.SelectedIndex;

            // Use OpenCvSharp to start streaming this camera
            capture = new VideoCapture(camIndex, VideoCaptureAPIs.DSHOW);
            if (!capture.IsOpened())
            {
                SystemSounds.Exclamation.Play();
                CustomMessageBox.Show("Failed to open selected camera.", "Alert");
                return;
            }
            running = true;
            cameraThread = new Thread(CameraLoop);
            cameraThread.IsBackground = true;
            cameraThread.Start();
        }

        private void CameraLoop()
        {
            using (var frame = new Mat())
            {
                while (running)
                {
                    capture.Read(frame);
                    if (!frame.Empty())
                    {
                        Bitmap bmp = BitmapConverter.ToBitmap(frame);

                        lastFrame?.Dispose();
                        lastFrame = (Bitmap)bmp.Clone();

                        CameraStreamBox.Invoke(new Action(() =>
                        {
                            CameraStreamBox.Image?.Dispose();
                            CameraStreamBox.Image = (Bitmap)bmp.Clone();
                        }));
                    }
                    Thread.Sleep(30);
                }
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            running = false;
            cameraThread?.Join();
            capture?.Release();
            Application.Exit();
        }

        private void GrabPhotoBtn_Click(object sender, EventArgs e)
        {
            if (lastFrame != null)
            {
                CapturedPhotoBox.Image?.Dispose();
                CapturedPhotoBox.Image = (Bitmap)lastFrame.Clone();
            }
            else
            {
                SystemSounds.Exclamation.Play();
                CustomMessageBox.Show("No frame available.", "Alert");
            }
        }
        private void FacePhotoBtn_Click(object sender, EventArgs e)
        {
            string path = this.data.photoPath + "/FacePhoto.bmp";
            CapturedPhotoBox.Image.Save(path);
            SystemSounds.Exclamation.Play(); 
            CustomMessageBox.Show($"FacePhoto saved at {path} successfully.", "Alert");
        }

        private void LeftATDBtn_Click(object sender, EventArgs e)
        {
            string path = this.data.photoPath + "/LeftATD.bmp";
            CapturedPhotoBox.Image.Save(path);
            SystemSounds.Exclamation.Play(); 
            CustomMessageBox.Show($"Left hand ATD photo saved at {path} successfully.", "Alert");
        }

        private void RightATDBtn_Click(object sender, EventArgs e)
        {
            string path = this.data.photoPath + "/RightATD.bmp";
            CapturedPhotoBox.Image.Save(path);
            SystemSounds.Exclamation.Play(); 
            CustomMessageBox.Show($"Right hand ATD photo saved at {path} successfully.", "Alert");
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            running = false;

            // Wait for camera thread to exit
            if (cameraThread != null && cameraThread.IsAlive)
            {
                cameraThread.Join(1000); // Wait up to 1 second
            }

            // Release camera resources safely
            if (capture != null)
            {
                capture.Release();
                capture.Dispose();
                capture = null;
            }

            // Show the next form
            if (Program.pd_form != null && !Program.pd_form.IsDisposed)
            {
                Program.pd_form.Show();
                this.Hide(); // Use Hide instead of Dispose for smoother navigation
            }
            else
            {
                SystemSounds.Exclamation.Play(); 
                CustomMessageBox.Show("Next form is not available.", "Alert");
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
    }
}
