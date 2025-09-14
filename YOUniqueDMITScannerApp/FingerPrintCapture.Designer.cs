using System.Drawing;

namespace YouniqueDMITFingurePrintCaptureApp
{
    partial class FingerPrintCapture
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FingerPrintCapture));
            this.m_cmbInterfaces = new System.Windows.Forms.ComboBox();
            this.m_picture = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.StartBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkBoxAutoSave = new System.Windows.Forms.CheckBox();
            this.comboSide = new System.Windows.Forms.ComboBox();
            this.SideLabel = new System.Windows.Forms.Label();
            this.comboFinger = new System.Windows.Forms.ComboBox();
            this.FingerLabel = new System.Windows.Forms.Label();
            this.L1ScanPoint = new System.Windows.Forms.PictureBox();
            this.L2ScanPoint = new System.Windows.Forms.PictureBox();
            this.L3ScanPoint = new System.Windows.Forms.PictureBox();
            this.L4ScanPoint = new System.Windows.Forms.PictureBox();
            this.L5ScanPoint = new System.Windows.Forms.PictureBox();
            this.R1ScanPoint = new System.Windows.Forms.PictureBox();
            this.R2ScanPoint = new System.Windows.Forms.PictureBox();
            this.R3ScanPoint = new System.Windows.Forms.PictureBox();
            this.R4ScanPoint = new System.Windows.Forms.PictureBox();
            this.R5ScanPoint = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LastfileLabel = new System.Windows.Forms.Label();
            this.FileNamelabel = new System.Windows.Forms.Label();
            this.FingerPrintNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.m_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.L1ScanPoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.L2ScanPoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.L3ScanPoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.L4ScanPoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.L5ScanPoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.R1ScanPoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.R2ScanPoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.R3ScanPoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.R4ScanPoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.R5ScanPoint)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_cmbInterfaces
            // 
            this.m_cmbInterfaces.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_cmbInterfaces.FormattingEnabled = true;
            this.m_cmbInterfaces.Location = new System.Drawing.Point(264, 655);
            this.m_cmbInterfaces.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m_cmbInterfaces.Name = "m_cmbInterfaces";
            this.m_cmbInterfaces.Size = new System.Drawing.Size(104, 24);
            this.m_cmbInterfaces.TabIndex = 1;
            this.m_cmbInterfaces.Visible = false;
            this.m_cmbInterfaces.SelectedIndexChanged += new System.EventHandler(this.m_cmbInterfaces_SelectedIndexChanged);
            // 
            // m_picture
            // 
            this.m_picture.Location = new System.Drawing.Point(7, 15);
            this.m_picture.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m_picture.Name = "m_picture";
            this.m_picture.Size = new System.Drawing.Size(363, 543);
            this.m_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m_picture.TabIndex = 6;
            this.m_picture.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(387, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(825, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(4, 4);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(819, 299);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SaveBtn);
            this.panel1.Controls.Add(this.StartBtn);
            this.panel1.Controls.Add(this.BackBtn);
            this.panel1.Location = new System.Drawing.Point(387, 289);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 59);
            this.panel1.TabIndex = 13;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.Location = new System.Drawing.Point(336, 11);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(100, 38);
            this.SaveBtn.TabIndex = 2;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // StartBtn
            // 
            this.StartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartBtn.Location = new System.Drawing.Point(31, 12);
            this.StartBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(127, 37);
            this.StartBtn.TabIndex = 1;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.YellowGreen;
            this.BackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.Location = new System.Drawing.Point(615, 12);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(121, 37);
            this.BackBtn.TabIndex = 0;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.checkBoxAutoSave);
            this.panel2.Controls.Add(this.comboSide);
            this.panel2.Controls.Add(this.SideLabel);
            this.panel2.Controls.Add(this.comboFinger);
            this.panel2.Controls.Add(this.FingerLabel);
            this.panel2.Location = new System.Drawing.Point(387, 188);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(825, 92);
            this.panel2.TabIndex = 14;
            // 
            // checkBoxAutoSave
            // 
            this.checkBoxAutoSave.AutoSize = true;
            this.checkBoxAutoSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAutoSave.Location = new System.Drawing.Point(31, 4);
            this.checkBoxAutoSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxAutoSave.Name = "checkBoxAutoSave";
            this.checkBoxAutoSave.Size = new System.Drawing.Size(192, 29);
            this.checkBoxAutoSave.TabIndex = 4;
            this.checkBoxAutoSave.Text = "Enable Auto Save";
            this.checkBoxAutoSave.UseVisualStyleBackColor = true;
            this.checkBoxAutoSave.CheckedChanged += new System.EventHandler(this.checkBoxAutoSave_CheckedChanged);
            // 
            // comboSide
            // 
            this.comboSide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSide.FormattingEnabled = true;
            this.comboSide.Location = new System.Drawing.Point(631, 48);
            this.comboSide.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboSide.Name = "comboSide";
            this.comboSide.Size = new System.Drawing.Size(160, 33);
            this.comboSide.TabIndex = 3;
            // 
            // SideLabel
            // 
            this.SideLabel.AutoSize = true;
            this.SideLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SideLabel.Location = new System.Drawing.Point(568, 53);
            this.SideLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SideLabel.Name = "SideLabel";
            this.SideLabel.Size = new System.Drawing.Size(52, 25);
            this.SideLabel.TabIndex = 2;
            this.SideLabel.Text = "Side";
            // 
            // comboFinger
            // 
            this.comboFinger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboFinger.FormattingEnabled = true;
            this.comboFinger.Location = new System.Drawing.Point(111, 48);
            this.comboFinger.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboFinger.Name = "comboFinger";
            this.comboFinger.Size = new System.Drawing.Size(160, 33);
            this.comboFinger.TabIndex = 1;
            this.comboFinger.SelectedIndexChanged += new System.EventHandler(this.comboFinger_SelectedIndexChanged);
            // 
            // FingerLabel
            // 
            this.FingerLabel.AutoSize = true;
            this.FingerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FingerLabel.Location = new System.Drawing.Point(29, 54);
            this.FingerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FingerLabel.Name = "FingerLabel";
            this.FingerLabel.Size = new System.Drawing.Size(67, 25);
            this.FingerLabel.TabIndex = 0;
            this.FingerLabel.Text = "Finger";
            // 
            // L1ScanPoint
            // 
            this.L1ScanPoint.BackColor = System.Drawing.Color.Transparent;
            this.L1ScanPoint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.L1ScanPoint.Location = new System.Drawing.Point(369, 182);
            this.L1ScanPoint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.L1ScanPoint.Name = "L1ScanPoint";
            this.L1ScanPoint.Size = new System.Drawing.Size(33, 26);
            this.L1ScanPoint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.L1ScanPoint.TabIndex = 15;
            this.L1ScanPoint.TabStop = false;
            // 
            // L2ScanPoint
            // 
            this.L2ScanPoint.BackColor = System.Drawing.Color.Transparent;
            this.L2ScanPoint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.L2ScanPoint.Location = new System.Drawing.Point(303, 28);
            this.L2ScanPoint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.L2ScanPoint.Name = "L2ScanPoint";
            this.L2ScanPoint.Size = new System.Drawing.Size(33, 26);
            this.L2ScanPoint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.L2ScanPoint.TabIndex = 16;
            this.L2ScanPoint.TabStop = false;
            // 
            // L3ScanPoint
            // 
            this.L3ScanPoint.BackColor = System.Drawing.Color.Transparent;
            this.L3ScanPoint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.L3ScanPoint.Location = new System.Drawing.Point(237, 13);
            this.L3ScanPoint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.L3ScanPoint.Name = "L3ScanPoint";
            this.L3ScanPoint.Size = new System.Drawing.Size(33, 26);
            this.L3ScanPoint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.L3ScanPoint.TabIndex = 17;
            this.L3ScanPoint.TabStop = false;
            // 
            // L4ScanPoint
            // 
            this.L4ScanPoint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.L4ScanPoint.Location = new System.Drawing.Point(190, 21);
            this.L4ScanPoint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.L4ScanPoint.Name = "L4ScanPoint";
            this.L4ScanPoint.Size = new System.Drawing.Size(33, 26);
            this.L4ScanPoint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.L4ScanPoint.TabIndex = 18;
            this.L4ScanPoint.TabStop = false;
            // 
            // L5ScanPoint
            // 
            this.L5ScanPoint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.L5ScanPoint.Location = new System.Drawing.Point(137, 66);
            this.L5ScanPoint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.L5ScanPoint.Name = "L5ScanPoint";
            this.L5ScanPoint.Size = new System.Drawing.Size(33, 26);
            this.L5ScanPoint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.L5ScanPoint.TabIndex = 19;
            this.L5ScanPoint.TabStop = false;
            // 
            // R1ScanPoint
            // 
            this.R1ScanPoint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.R1ScanPoint.Location = new System.Drawing.Point(415, 182);
            this.R1ScanPoint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.R1ScanPoint.Name = "R1ScanPoint";
            this.R1ScanPoint.Size = new System.Drawing.Size(33, 26);
            this.R1ScanPoint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.R1ScanPoint.TabIndex = 20;
            this.R1ScanPoint.TabStop = false;
            // 
            // R2ScanPoint
            // 
            this.R2ScanPoint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.R2ScanPoint.Location = new System.Drawing.Point(483, 28);
            this.R2ScanPoint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.R2ScanPoint.Name = "R2ScanPoint";
            this.R2ScanPoint.Size = new System.Drawing.Size(33, 26);
            this.R2ScanPoint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.R2ScanPoint.TabIndex = 21;
            this.R2ScanPoint.TabStop = false;
            // 
            // R3ScanPoint
            // 
            this.R3ScanPoint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.R3ScanPoint.Location = new System.Drawing.Point(552, 12);
            this.R3ScanPoint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.R3ScanPoint.Name = "R3ScanPoint";
            this.R3ScanPoint.Size = new System.Drawing.Size(33, 26);
            this.R3ScanPoint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.R3ScanPoint.TabIndex = 22;
            this.R3ScanPoint.TabStop = false;
            // 
            // R4ScanPoint
            // 
            this.R4ScanPoint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.R4ScanPoint.Location = new System.Drawing.Point(600, 17);
            this.R4ScanPoint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.R4ScanPoint.Name = "R4ScanPoint";
            this.R4ScanPoint.Size = new System.Drawing.Size(33, 26);
            this.R4ScanPoint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.R4ScanPoint.TabIndex = 23;
            this.R4ScanPoint.TabStop = false;
            // 
            // R5ScanPoint
            // 
            this.R5ScanPoint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.R5ScanPoint.Location = new System.Drawing.Point(652, 66);
            this.R5ScanPoint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.R5ScanPoint.Name = "R5ScanPoint";
            this.R5ScanPoint.Size = new System.Drawing.Size(33, 26);
            this.R5ScanPoint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.R5ScanPoint.TabIndex = 24;
            this.R5ScanPoint.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.R5ScanPoint);
            this.panel3.Controls.Add(this.R4ScanPoint);
            this.panel3.Controls.Add(this.R3ScanPoint);
            this.panel3.Controls.Add(this.R2ScanPoint);
            this.panel3.Controls.Add(this.R1ScanPoint);
            this.panel3.Controls.Add(this.L5ScanPoint);
            this.panel3.Controls.Add(this.L4ScanPoint);
            this.panel3.Controls.Add(this.L3ScanPoint);
            this.panel3.Controls.Add(this.L2ScanPoint);
            this.panel3.Controls.Add(this.L1ScanPoint);
            this.panel3.Location = new System.Drawing.Point(387, 389);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(827, 309);
            this.panel3.TabIndex = 25;
            // 
            // LastfileLabel
            // 
            this.LastfileLabel.AutoSize = true;
            this.LastfileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastfileLabel.Location = new System.Drawing.Point(392, 357);
            this.LastfileLabel.Name = "LastfileLabel";
            this.LastfileLabel.Size = new System.Drawing.Size(158, 25);
            this.LastfileLabel.TabIndex = 26;
            this.LastfileLabel.Text = "Last File Saved: ";
            // 
            // FileNamelabel
            // 
            this.FileNamelabel.AutoSize = true;
            this.FileNamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileNamelabel.Location = new System.Drawing.Point(549, 357);
            this.FileNamelabel.Name = "FileNamelabel";
            this.FileNamelabel.Size = new System.Drawing.Size(0, 25);
            this.FileNamelabel.TabIndex = 27;
            // 
            // FingerPrintNameLabel
            // 
            this.FingerPrintNameLabel.AutoSize = true;
            this.FingerPrintNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FingerPrintNameLabel.Location = new System.Drawing.Point(556, 356);
            this.FingerPrintNameLabel.Name = "FingerPrintNameLabel";
            this.FingerPrintNameLabel.Size = new System.Drawing.Size(0, 25);
            this.FingerPrintNameLabel.TabIndex = 28;
            // 
            // FingerPrintCapture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 705);
            this.Controls.Add(this.FingerPrintNameLabel);
            this.Controls.Add(this.FileNamelabel);
            this.Controls.Add(this.LastfileLabel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.m_picture);
            this.Controls.Add(this.m_cmbInterfaces);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FingerPrintCapture";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Capture Finger Prints";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormClosed);
            this.Load += new System.EventHandler(this.OnFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.m_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.L1ScanPoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.L2ScanPoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.L3ScanPoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.L4ScanPoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.L5ScanPoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.R1ScanPoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.R2ScanPoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.R3ScanPoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.R4ScanPoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.R5ScanPoint)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox m_cmbInterfaces;
        private System.Windows.Forms.PictureBox m_picture;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label FingerLabel;
        private System.Windows.Forms.ComboBox comboSide;
        private System.Windows.Forms.Label SideLabel;
        private System.Windows.Forms.ComboBox comboFinger;
        private System.Windows.Forms.PictureBox L1ScanPoint;
        private System.Windows.Forms.CheckBox checkBoxAutoSave;
        private System.Windows.Forms.PictureBox L2ScanPoint;
        private System.Windows.Forms.PictureBox L3ScanPoint;
        private System.Windows.Forms.PictureBox L4ScanPoint;
        private System.Windows.Forms.PictureBox L5ScanPoint;
        private System.Windows.Forms.PictureBox R1ScanPoint;
        private System.Windows.Forms.PictureBox R2ScanPoint;
        private System.Windows.Forms.PictureBox R3ScanPoint;
        private System.Windows.Forms.PictureBox R4ScanPoint;
        private System.Windows.Forms.PictureBox R5ScanPoint;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LastfileLabel;
        private System.Windows.Forms.Label FileNamelabel;
        private System.Windows.Forms.Label FingerPrintNameLabel;
    }
}

