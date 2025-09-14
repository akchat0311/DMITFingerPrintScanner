namespace YouniqueDMITFingurePrintCaptureApp
{
    partial class PhotoCapture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhotoCapture));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CameraStreamBox = new System.Windows.Forms.PictureBox();
            this.CapturedPhotoBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BackBtn = new System.Windows.Forms.Button();
            this.RightATDBtn = new System.Windows.Forms.Button();
            this.LeftATDBtn = new System.Windows.Forms.Button();
            this.FacePhotoBtn = new System.Windows.Forms.Button();
            this.GrabPhotoBtn = new System.Windows.Forms.Button();
            this.CameraList = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CameraStreamBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CapturedPhotoBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1299, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.1612F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.8388F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 602F));
            this.tableLayoutPanel1.Controls.Add(this.CameraStreamBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.CapturedPhotoBox, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(29, 164);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1303, 450);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // CameraStreamBox
            // 
            this.CameraStreamBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CameraStreamBox.Location = new System.Drawing.Point(4, 4);
            this.CameraStreamBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CameraStreamBox.Name = "CameraStreamBox";
            this.CameraStreamBox.Size = new System.Drawing.Size(603, 442);
            this.CameraStreamBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CameraStreamBox.TabIndex = 0;
            this.CameraStreamBox.TabStop = false;
            // 
            // CapturedPhotoBox
            // 
            this.CapturedPhotoBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CapturedPhotoBox.Location = new System.Drawing.Point(705, 4);
            this.CapturedPhotoBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CapturedPhotoBox.Name = "CapturedPhotoBox";
            this.CapturedPhotoBox.Size = new System.Drawing.Size(594, 442);
            this.CapturedPhotoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CapturedPhotoBox.TabIndex = 1;
            this.CapturedPhotoBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BackBtn);
            this.panel1.Controls.Add(this.RightATDBtn);
            this.panel1.Controls.Add(this.LeftATDBtn);
            this.panel1.Controls.Add(this.FacePhotoBtn);
            this.panel1.Controls.Add(this.GrabPhotoBtn);
            this.panel1.Controls.Add(this.CameraList);
            this.panel1.Location = new System.Drawing.Point(33, 632);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1295, 74);
            this.panel1.TabIndex = 2;
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.YellowGreen;
            this.BackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.Location = new System.Drawing.Point(1142, 21);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(100, 41);
            this.BackBtn.TabIndex = 5;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // RightATDBtn
            // 
            this.RightATDBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightATDBtn.Location = new System.Drawing.Point(937, 22);
            this.RightATDBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RightATDBtn.Name = "RightATDBtn";
            this.RightATDBtn.Size = new System.Drawing.Size(143, 39);
            this.RightATDBtn.TabIndex = 4;
            this.RightATDBtn.Text = "Right ATD";
            this.RightATDBtn.UseVisualStyleBackColor = true;
            this.RightATDBtn.Click += new System.EventHandler(this.RightATDBtn_Click);
            // 
            // LeftATDBtn
            // 
            this.LeftATDBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftATDBtn.Location = new System.Drawing.Point(771, 22);
            this.LeftATDBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LeftATDBtn.Name = "LeftATDBtn";
            this.LeftATDBtn.Size = new System.Drawing.Size(128, 41);
            this.LeftATDBtn.TabIndex = 3;
            this.LeftATDBtn.Text = "Left ATD";
            this.LeftATDBtn.UseVisualStyleBackColor = true;
            this.LeftATDBtn.Click += new System.EventHandler(this.LeftATDBtn_Click);
            // 
            // FacePhotoBtn
            // 
            this.FacePhotoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacePhotoBtn.Location = new System.Drawing.Point(587, 23);
            this.FacePhotoBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FacePhotoBtn.Name = "FacePhotoBtn";
            this.FacePhotoBtn.Size = new System.Drawing.Size(147, 41);
            this.FacePhotoBtn.TabIndex = 2;
            this.FacePhotoBtn.Text = "Face Photo";
            this.FacePhotoBtn.UseVisualStyleBackColor = true;
            this.FacePhotoBtn.Click += new System.EventHandler(this.FacePhotoBtn_Click);
            // 
            // GrabPhotoBtn
            // 
            this.GrabPhotoBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.GrabPhotoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrabPhotoBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GrabPhotoBtn.Location = new System.Drawing.Point(415, 22);
            this.GrabPhotoBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GrabPhotoBtn.Name = "GrabPhotoBtn";
            this.GrabPhotoBtn.Size = new System.Drawing.Size(152, 39);
            this.GrabPhotoBtn.TabIndex = 1;
            this.GrabPhotoBtn.Text = "Grab Photo";
            this.GrabPhotoBtn.UseVisualStyleBackColor = false;
            this.GrabPhotoBtn.Click += new System.EventHandler(this.GrabPhotoBtn_Click);
            // 
            // CameraList
            // 
            this.CameraList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CameraList.FormattingEnabled = true;
            this.CameraList.Location = new System.Drawing.Point(19, 21);
            this.CameraList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CameraList.Name = "CameraList";
            this.CameraList.Size = new System.Drawing.Size(360, 33);
            this.CameraList.TabIndex = 0;
            // 
            // PhotoCapture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 724);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PhotoCapture";
            this.Text = "PhotoCapture";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CameraStreamBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CapturedPhotoBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button RightATDBtn;
        private System.Windows.Forms.Button LeftATDBtn;
        private System.Windows.Forms.Button FacePhotoBtn;
        private System.Windows.Forms.Button GrabPhotoBtn;
        private System.Windows.Forms.ComboBox CameraList;
        private System.Windows.Forms.PictureBox CameraStreamBox;
        private System.Windows.Forms.PictureBox CapturedPhotoBox;
    }
}