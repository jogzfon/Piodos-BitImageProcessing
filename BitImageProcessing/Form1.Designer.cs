namespace BitImageProcessing
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reverseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mirrorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blackAndWhiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infraredToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sepiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadImageToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadBackgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subtractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pict01 = new System.Windows.Forms.PictureBox();
            this.pict02 = new System.Windows.Forms.PictureBox();
            this.greenScreenTimer = new System.Windows.Forms.Timer(this.components);
            this.greenScreenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pict01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pict02)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.imageToolStripMenuItem,
            this.greenScreenToolStripMenuItem,
            this.cameraToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1381, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uploadImageToolStripMenuItem,
            this.saveImageToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // uploadImageToolStripMenuItem
            // 
            this.uploadImageToolStripMenuItem.Name = "uploadImageToolStripMenuItem";
            this.uploadImageToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.uploadImageToolStripMenuItem.Text = "Upload Image";
            this.uploadImageToolStripMenuItem.Click += new System.EventHandler(this.Upload);
            // 
            // saveImageToolStripMenuItem
            // 
            this.saveImageToolStripMenuItem.Name = "saveImageToolStripMenuItem";
            this.saveImageToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.saveImageToolStripMenuItem.Text = "Save Image";
            this.saveImageToolStripMenuItem.Click += new System.EventHandler(this.SaveImage);
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reverseToolStripMenuItem,
            this.mirrorToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.blackAndWhiteToolStripMenuItem,
            this.infraredToolStripMenuItem,
            this.histogramToolStripMenuItem,
            this.sepiaToolStripMenuItem});
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.imageToolStripMenuItem.Text = "Image";
            // 
            // reverseToolStripMenuItem
            // 
            this.reverseToolStripMenuItem.Name = "reverseToolStripMenuItem";
            this.reverseToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.reverseToolStripMenuItem.Text = "Rotate";
            this.reverseToolStripMenuItem.Click += new System.EventHandler(this.Rotate);
            // 
            // mirrorToolStripMenuItem
            // 
            this.mirrorToolStripMenuItem.Name = "mirrorToolStripMenuItem";
            this.mirrorToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.mirrorToolStripMenuItem.Text = "Mirror";
            this.mirrorToolStripMenuItem.Click += new System.EventHandler(this.Mirror);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.copyToolStripMenuItem.Text = "Basic Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.Duplicate);
            // 
            // blackAndWhiteToolStripMenuItem
            // 
            this.blackAndWhiteToolStripMenuItem.Name = "blackAndWhiteToolStripMenuItem";
            this.blackAndWhiteToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.blackAndWhiteToolStripMenuItem.Text = "Greyscale";
            this.blackAndWhiteToolStripMenuItem.Click += new System.EventHandler(this.Greyscale);
            // 
            // infraredToolStripMenuItem
            // 
            this.infraredToolStripMenuItem.Name = "infraredToolStripMenuItem";
            this.infraredToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.infraredToolStripMenuItem.Text = "Color Inversion";
            this.infraredToolStripMenuItem.Click += new System.EventHandler(this.Infrared);
            // 
            // histogramToolStripMenuItem
            // 
            this.histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            this.histogramToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.histogramToolStripMenuItem.Text = "Histogram";
            this.histogramToolStripMenuItem.Click += new System.EventHandler(this.Histogram);
            // 
            // sepiaToolStripMenuItem
            // 
            this.sepiaToolStripMenuItem.Name = "sepiaToolStripMenuItem";
            this.sepiaToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.sepiaToolStripMenuItem.Text = "Sepia";
            this.sepiaToolStripMenuItem.Click += new System.EventHandler(this.Sepia);
            // 
            // greenScreenToolStripMenuItem
            // 
            this.greenScreenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uploadImageToolStripMenuItem1,
            this.uploadBackgroundToolStripMenuItem,
            this.subtractToolStripMenuItem});
            this.greenScreenToolStripMenuItem.Name = "greenScreenToolStripMenuItem";
            this.greenScreenToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.greenScreenToolStripMenuItem.Text = "GreenScreen";
            // 
            // uploadImageToolStripMenuItem1
            // 
            this.uploadImageToolStripMenuItem1.Name = "uploadImageToolStripMenuItem1";
            this.uploadImageToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.uploadImageToolStripMenuItem1.Text = "Upload Image";
            this.uploadImageToolStripMenuItem1.Click += new System.EventHandler(this.Upload);
            // 
            // uploadBackgroundToolStripMenuItem
            // 
            this.uploadBackgroundToolStripMenuItem.Name = "uploadBackgroundToolStripMenuItem";
            this.uploadBackgroundToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.uploadBackgroundToolStripMenuItem.Text = "Upload Background";
            this.uploadBackgroundToolStripMenuItem.Click += new System.EventHandler(this.UploadBg);
            // 
            // subtractToolStripMenuItem
            // 
            this.subtractToolStripMenuItem.Name = "subtractToolStripMenuItem";
            this.subtractToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.subtractToolStripMenuItem.Text = "Subtract";
            this.subtractToolStripMenuItem.Click += new System.EventHandler(this.Subtract_Pressed);
            // 
            // cameraToolStripMenuItem
            // 
            this.cameraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.greenScreenToolStripMenuItem1,
            this.closeToolStripMenuItem});
            this.cameraToolStripMenuItem.Name = "cameraToolStripMenuItem";
            this.cameraToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.cameraToolStripMenuItem.Text = "Camera";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.Open_Camera);
            // 
            // pict01
            // 
            this.pict01.Location = new System.Drawing.Point(31, 63);
            this.pict01.Name = "pict01";
            this.pict01.Size = new System.Drawing.Size(493, 553);
            this.pict01.TabIndex = 1;
            this.pict01.TabStop = false;
            // 
            // pict02
            // 
            this.pict02.Location = new System.Drawing.Point(544, 63);
            this.pict02.Name = "pict02";
            this.pict02.Size = new System.Drawing.Size(493, 553);
            this.pict02.TabIndex = 2;
            this.pict02.TabStop = false;
            // 
            // greenScreenTimer
            // 
            this.greenScreenTimer.Interval = 5000;
            this.greenScreenTimer.Tick += new System.EventHandler(this.greenScreen_Tick);
            // 
            // greenScreenToolStripMenuItem1
            // 
            this.greenScreenToolStripMenuItem1.Name = "greenScreenToolStripMenuItem1";
            this.greenScreenToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.greenScreenToolStripMenuItem1.Text = "GreenScreen";
            this.greenScreenToolStripMenuItem1.Click += new System.EventHandler(this.GreenScreenStart);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.Close_Camera);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1381, 673);
            this.Controls.Add(this.pict02);
            this.Controls.Add(this.pict01);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pict01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pict02)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reverseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blackAndWhiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uploadImageToolStripMenuItem;
        private System.Windows.Forms.PictureBox pict01;
        private System.Windows.Forms.PictureBox pict02;
        private System.Windows.Forms.ToolStripMenuItem mirrorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infraredToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sepiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenScreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uploadImageToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem uploadBackgroundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subtractToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cameraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.Timer greenScreenTimer;
        private System.Windows.Forms.ToolStripMenuItem greenScreenToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}

