using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using OpenCvSharp;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 元画像の表示
            Mat src = new Mat("Images/testimage.png", ImreadModes.Color);
            this.pictureBoxIpl1.ImageIpl = src;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 元画像の表示
            Mat src = new Mat("Images/testimage.png", ImreadModes.GrayScale);
            this.pictureBoxIpl1.ImageIpl = src;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // グレースケール
            Mat src = new Mat("Images/testimage.png", ImreadModes.Color);
            Mat gray = src.CvtColor(ColorConversionCodes.BGR2GRAY);

            this.pictureBoxIpl1.ImageIpl = gray;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // ２値化 大津式
            Mat src = new Mat("Images/testimage.png", ImreadModes.GrayScale);

            Mat binary = src.Threshold(0, 255, ThresholdTypes.Otsu | ThresholdTypes.Binary);
            this.pictureBoxIpl1.ImageIpl = binary;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // グレースケール
            Mat src = new Mat("Images/testimage.png", ImreadModes.Color);
            Mat gray = src.CvtColor(ColorConversionCodes.BGR2GRAY);
         
            // ２値化 大津式
            Mat binary = gray.Threshold(0, 255, ThresholdTypes.Otsu | ThresholdTypes.Binary);
            this.pictureBoxIpl1.ImageIpl = binary;
        }
    }
}
