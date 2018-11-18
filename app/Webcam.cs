using System.Windows.Forms;
using AForge.Video.DirectShow;
using AForge.Video;

namespace HomeImager
{
    public class Webcam
    {
        private FilterInfoCollection webcamList;
        private VideoCaptureDevice webcamDevice;

        public Webcam()
        {
            webcamList = new FilterInfoCollection(FilterCategory.VideoInputDevice);
        }

        public ComboBox GetVideoDevices(ref ComboBox comboBox)
        {
            foreach (FilterInfo videoCaptureDevice in webcamList)
            {
                comboBox.Items.Add(videoCaptureDevice.Name);
            }
            comboBox.SelectedIndex = 0;

            return comboBox;
        }
    }
}
