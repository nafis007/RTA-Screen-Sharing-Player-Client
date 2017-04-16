using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MjpegProcessor;

namespace testPlayer
{
    public partial class DisplayForm : Form
    {
        MjpegDecoder _mjpeg;
        public DisplayForm()
        {
            InitializeComponent();
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            playSharedScreen();
        }

        private void playSharedScreen()
        {
            _mjpeg = new MjpegDecoder();
            _mjpeg.ParseStream(new Uri(URLTextBox.Text));
            _mjpeg.FrameReady += mjpeg_FrameReady;
        }


        private void mjpeg_FrameReady(object sender, FrameReadyEventArgs e)
        {
            pictureBoxForDisplay.Image = e.Bitmap;
        }

        private void pictureBoxForDisplay_Click(object sender, EventArgs e)
        {

        }


    }
}
