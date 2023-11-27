using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace BitImageProcessing
{
    public partial class Form1 : Form
    {
        Bitmap bitImage;
        Bitmap origImage;
        Bitmap backgroundImage;
        DeviceManager devicemanager;
        Device device;
        PictureBox pict03;
        bool isSubtract = false;
        public Form1()
        {
            InitializeComponent();
            devicemanager = new DeviceManager();
            device = new Device();
            this.DoubleBuffered = true;
        }

        private void Upload(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = openFileDialog.FileName;

                    if (File.Exists(selectedFilePath))
                    {
                        origImage = new Bitmap(selectedFilePath);
                        bitImage = origImage;

                        // Now you have the image in the 'bitImage' Bitmap object, and you can use it as needed.
                        pict01.Image = bitImage;
                        pict01.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                    else
                    {
                        MessageBox.Show("The selected file does not exist.");
                    }
                }
            }
        }
        private void Duplicate(object sender, EventArgs e)
        {
            int h, v;
            bitImage = origImage;
            Bitmap duplicateImage = new Bitmap(bitImage.Width, bitImage.Height);
            for (h = 0; h < bitImage.Width; h++)
            {
                for (v = 0; v < bitImage.Height; v++)
                {
                    Color color = bitImage.GetPixel(h, v);
                    duplicateImage.SetPixel(h, v, bitImage.GetPixel(h, v));
                }
            }
            pict02.Image = duplicateImage;
            pict02.SizeMode = PictureBoxSizeMode.Zoom;
            bitImage = duplicateImage;
        }

        private void Rotate(object sender, EventArgs e)
        {
            int newWidth = bitImage.Height;
            int newHeight = bitImage.Width;
            Bitmap rotateImage = new Bitmap(newWidth, newHeight);

            for (int h = 0; h < newWidth; h++)
            {
                for (int v = 0; v < newHeight; v++)
                {
                    Color color = bitImage.GetPixel(v, bitImage.Height - 1 - h);
                    rotateImage.SetPixel(h, v, color);
                }
            }

            bitImage = rotateImage;
            pict02.Image = bitImage;
            pict02.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void Mirror(object sender, EventArgs e)
        {
            int h, v;
            bitImage = origImage;
            Bitmap mirrorImage = new Bitmap(bitImage.Width, bitImage.Height);
            for (h = 0; h < bitImage.Width; h++)
            {
                for (v = 0; v < bitImage.Height; v++)
                {
                    Color color = bitImage.GetPixel(h, v);
                    mirrorImage.SetPixel(h, v, bitImage.GetPixel((bitImage.Width - 1) - h, v));
                }
            }
            bitImage = mirrorImage;
            pict02.Image = bitImage;
            pict02.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void Infrared(object sender, EventArgs e)
        {
            int h, v;
            bitImage = origImage;
            Bitmap infraredImage = new Bitmap(bitImage.Width, bitImage.Height);
            for (h = 0; h < bitImage.Width; h++)
            {
                for (v = 0; v < bitImage.Height; v++)
                {
                    Color color = bitImage.GetPixel(h, v);
                    Color reversedColor = Color.FromArgb(255 - color.R, 255 - color.G, 255 - color.B);
                    infraredImage.SetPixel(h, v, reversedColor);
                }
            }
            bitImage = infraredImage;
            pict02.Image = bitImage;
            pict02.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void Sepia(object sender, EventArgs e)
        {
            bitImage = origImage;
            Bitmap sepiaImage = new Bitmap(bitImage.Width, bitImage.Height);
            for (int h = 0; h < bitImage.Width; h++)
            {
                for (int v = 0; v < bitImage.Height; v++)
                {
                    Color p = bitImage.GetPixel(h, v);
                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;

                    int tr = (int)(0.393 * r + 0.769 * g + 0.189 * b);
                    int tg = (int)(0.349 * r + 0.686 * g + 0.168 * b);
                    int tb = (int)(0.272 * r + 0.534 * g + 0.131 * b);

                    r = Math.Min(255, tr);
                    g = Math.Min(255, tg);
                    b = Math.Min(255, tb);

                    sepiaImage.SetPixel(h, v, Color.FromArgb(a, r, g, b));
                }
            }
            bitImage = sepiaImage;
            pict02.Image = sepiaImage;
            pict02.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void SaveImage(object sender, EventArgs e)
        {
            if (bitImage != null)
            {
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|PNG Image|*.png";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = saveDialog.FileName;
                    bitImage.Save(fileName);

                    // Optionally, you can show a success message to the user
                    MessageBox.Show("File saved successfully!");
                }
            }
        }

        private void Histogram(object sender, EventArgs e)
        {
            //to greyscale
            bitImage = origImage;
            Bitmap histogram = new Bitmap(bitImage.Width, bitImage.Height);
            Color pixel;
            int grey;
            for (int i = 0; i < bitImage.Width; i++)
            {
                for (int j = 0; j < bitImage.Height; j++)
                {
                    pixel = bitImage.GetPixel(i, j);
                    grey = (pixel.R + pixel.G + pixel.B) / 3;
                    Color c = Color.FromArgb(grey, grey, grey);
                    histogram.SetPixel(i, j, c);
                }
            }

            //to data array
            int[] histData = new int[256];
            Color hist;
            for (int i = 0; i < bitImage.Width; i++)
            {
                for (int j = 0; j < bitImage.Height; j++)
                {
                    hist = histogram.GetPixel(i, j); // 0-255 either r,g,b
                    histData[hist.R]++;
                }
            }

            Bitmap mydata = new Bitmap(256, 800);
            for (int i = 0; i < 256; i++)
            {
                for (int j = 0; j < 800; j++)
                {
                    mydata.SetPixel(i, j, Color.White);
                }
            }

            //plot histdata
            for (int i = 0; i < 256; i++)
            {
                for (int j = 0; j < Math.Min(histData[i] / 5, 800); j++)
                {
                    mydata.SetPixel(i, 799 - j, Color.Black);
                }
            }
            pict02.Image = mydata;
            bitImage = mydata;
            pict02.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void Greyscale(object sender, EventArgs e)
        {
            int h, v;
            bitImage = origImage;
            Bitmap greyImage = new Bitmap(bitImage.Width, bitImage.Height);
            for (h = 0; h < bitImage.Width; h++)
            {
                for (v = 0; v < bitImage.Height; v++)
                {
                    Color color = bitImage.GetPixel(h, v);
                    int grayValue = (int)((color.R + color.G + color.B) / 3);
                    Color reversedColor = Color.FromArgb(grayValue, grayValue, grayValue);
                    greyImage.SetPixel(h, v, reversedColor);
                }
            }
            bitImage = greyImage;
            pict02.Image = bitImage;
            pict02.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void UploadBg(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = openFileDialog.FileName;

                    if (File.Exists(selectedFilePath))
                    {
                        backgroundImage = new Bitmap(selectedFilePath);

                        // Now you have the image in the 'bitImage' Bitmap object, and you can use it as needed.
                        pict02.Image = backgroundImage;
                        pict02.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                    else
                    {
                        MessageBox.Show("The selected file does not exist.");
                    }
                }
            }
        }

        private void Subtract_Pressed(object sender, EventArgs e)
        {
            if (!isSubtract)
            {
                this.Width += 200;
                isSubtract = true;
            }
            // Set the form width to 1300

            // Create a PictureBox if it doesn't exist
            if (pict03 == null)
            {
                pict03 = new PictureBox();
                pict03.Location = new Point(800, 50);
                pict03.Width = pict02.Width;
                pict03.Height = pict02.Height;
                pict03.SizeMode = PictureBoxSizeMode.Zoom;
                this.Controls.Add(pict03); // Add the PictureBox to the form's controls
            }
            if (origImage != null && backgroundImage != null)
            {
                Color greenScreen = Color.FromArgb(0, 255, 0); // Assuming green screen color is pure green
                int threshold = 100;

                Bitmap subtractedImage = new Bitmap(origImage.Width, origImage.Height);

                for (int x = 0; x < origImage.Width; x++)
                {
                    for (int y = 0; y < origImage.Height; y++)
                    {
                        Color pixel = origImage.GetPixel(x, y);

                        // Check if the pixel is close to the green screen color
                        if (IsSimilarColor(pixel, greenScreen, threshold))
                        {
                            // Make the pixel transparent
                            subtractedImage.SetPixel(x, y, Color.Transparent);
                        }
                        else
                        {
                            // Copy the pixel from the original image to the subtracted image
                            subtractedImage.SetPixel(x, y, pixel);
                        }
                    }
                }

                // Create a new bitmap to hold the result (backgroundImage + subtractedImage)
                Bitmap resultImage = new Bitmap(backgroundImage);

                // Draw the subtractedImage onto the resultImage at the same position
                using (Graphics g = Graphics.FromImage(resultImage))
                {
                    g.DrawImage(subtractedImage, new Point(0, 0));
                }

                // Update the image in the PictureBox
                bitImage = resultImage;
                pict03.Image = bitImage;
            }
        }
        private bool IsSimilarColor(Color color1, Color color2, int threshold)
        {
            // Check if the colors are similar within the specified threshold
            return Math.Abs(color1.R - color2.R) <= threshold &&
                   Math.Abs(color1.G - color2.G) <= threshold &&
                   Math.Abs(color1.B - color2.B) <= threshold;
        }

        private void Open_Camera(object sender, EventArgs e)
        {
            if (isSubtract)
            {
                this.Width -= 200;
                isSubtract = false;
            }
            if(pict03 == null)
            {
                pict01.Image = null; pict02.Image = null;
            }
            else
            {
                pict01.Image = null; pict02.Image = null; pict03.Image = null;
            }
            device.ShowWindow(pict01);
        }

        private void greenScreen_Tick(object sender, EventArgs e)
        {
            device.Sendmessage();
            // Capture the current frame from pictureBox1 and convert it to a Bitmap
            Bitmap currentFrame = PictureBoxToBitmap(pict01);

            // Display the converted Bitmap in pictureBox2
            pict02.Image = currentFrame;
        }
    
        private void GreenScreenStart(object sender, EventArgs e)
        {
            greenScreenTimer.Start();
        }
        private Bitmap PictureBoxToBitmap(PictureBox pictureBox)
        {
            // Get the size and location of pict01
            int pictureBoxWidth = pict01.Width;
            int pictureBoxHeight = pict01.Height;
            Point pictureBoxLocation = pict01.PointToScreen(Point.Empty);

            // Get the size of the screen
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;

            // Calculate the center position for pict01 on the screen
            int centerX = (screenWidth - pictureBoxWidth) / 2;
            int centerY = (screenHeight - pictureBoxHeight) / 2;

            // Capture the content of the area containing the centered pict01
            Bitmap screenCapture = new Bitmap(pictureBoxWidth, pictureBoxHeight);
            using (Graphics g = Graphics.FromImage(screenCapture))
            {
                g.CopyFromScreen(new Point(centerX, centerY), Point.Empty, new Size(pictureBoxWidth, pictureBoxHeight));
            }

            return screenCapture;
        }
        private void Close_Camera(object sender, EventArgs e)
        {
            greenScreenTimer.Stop();
            device.Stop();
        }
    }
}
