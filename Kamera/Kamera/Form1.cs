using System;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kamera
{
    public partial class Form1 : Form
    {
        private FilterInfoCollection capturedevice;
        private VideoCaptureDevice videoSource;

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            prBox2.Image = (Bitmap)prBox1.Image.Clone();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
                prBox1.Image = null;
                prBox1.Invalidate();
                prBox2.Image = null;
                prBox2.Invalidate();
            }
            Application.Exit(null);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            capturedevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo devicelist in capturedevice)
            {
                comboBoxWebcamlist.Items.Add(devicelist.Name);
            }
            comboBoxWebcamlist.SelectedIndex = 0;
            videoSource = new VideoCaptureDevice();
        }

        private void buttonsaveimage_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save Image As";
            saveFileDialog.Filter = "Image files (*.jpg, *.png) | *.jpg, *.png";
            ImageFormat imageFormat = ImageFormat.Png;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(saveFileDialog.FileName);
                switch (ext)
                {
                    case ".jpg":
                        imageFormat = ImageFormat.Jpeg;
                        break;
                    case ".png":
                        imageFormat = ImageFormat.Png;
                        break;
                }
                prBox2.Image.Save(saveFileDialog.FileName, imageFormat);
            }
        }

        private void buttonstart_Click(object sender, EventArgs e)
        {
            if (videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
                prBox1.Image = null;
                prBox1.Invalidate();
            }
            videoSource = new VideoCaptureDevice(capturedevice[comboBoxWebcamlist.SelectedIndex].MonikerString);
            videoSource.NewFrame += new NewFrameEventHandler(videoSource_NewFrame);
            videoSource.Start();
        }

        private void videoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            prBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void prBox1_Click(object sender, EventArgs e)
        {

        }

        private void prBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}