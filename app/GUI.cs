using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace HomeImager
{
    public partial class GUI : Form
    {
        private int cor_x = 0;
        private int cor_y = 0;
        private int point_x = 0;
        private int point_y = 0;
        private int draw_flag = 0;
        private int open_flag = 0;
        private int lines = 48;
        private int rows = 64;

        private List<Color> colors = new List<Color>();
        private readonly SerialPortController portController;
        private readonly ImageController imgController;
        private int width;
        private int heigh;


        public GUI()
        {
            InitializeComponent();
            portController = new SerialPortController();
            imgController = new ImageController();
            var webCam = new Webcam();
            webCam.GetVideoDevices(ref comboBox1);
            comboBox2.Items.AddRange(portController.GetPortNames());
            comboBox2.SelectedIndex = 0;


        }

        private void mUp_Click(object sender, EventArgs e)
        {
            try
            {
                portController.Send('e');
            }
            catch (Exception exp)
            {

                MessageBox.Show(exp.Message);
            }

        }

        private void mDown_Click(object sender, EventArgs e)
        {
            try
            {
                portController.Send('d');
            }
            catch (Exception exp)
            {

                MessageBox.Show(exp.Message);
            }
        }

        private void mLeft_Click(object sender, EventArgs e)
        {
            try
            {
                portController.Send('b');
            }
            catch (Exception exp)
            {

                MessageBox.Show(exp.Message);
            }
        }

        private void mRight_Click(object sender, EventArgs e)
        {
            try
            {
                portController.Send('c');
            }
            catch (Exception exp)
            {

                MessageBox.Show(exp.Message);
            }
        }

        private void bUp_Click(object sender, EventArgs e)
        {
            try
            {
                portController.Send('j');
            }
            catch (Exception exp)
            {

                MessageBox.Show(exp.Message);
            }
        }

        private void bDown_Click(object sender, EventArgs e)
        {
            try
            {
                portController.Send('i');
            }
            catch (Exception exp)
            {

                MessageBox.Show(exp.Message);
            }
        }

        private void bLeft_Click(object sender, EventArgs e)
        {
            try
            {
                portController.Send('g');
            }
            catch (Exception exp)
            {

                MessageBox.Show(exp.Message);
            }
        }

        private void bRight_Click(object sender, EventArgs e)
        {
            try
            {
                portController.Send('h');
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                portController.Open(comboBox2.SelectedText);
                open_flag = 1;
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            try
            {
                if (open_flag == 1)
                    portController.Close();
                Application.Exit();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void scan_Click(object sender, EventArgs e)
        {
            try
            {
                portController.GetTemperature().Clear();
                colors.Clear();
                portController.Send('a');
                var thread = new Thread(() =>
                {
                    while (portController.GetTemperature().Count != 3072)
                    {
                        try
                        {
                            Thread.Sleep(100);
                        }
                        catch (Exception exp)
                        {

                            MessageBox.Show(exp.Message);
                        }
                        textBox1.Text = (double) portController.GetTemperature().Count/3072*100 + " %";
                        if (portController.GetTemperature().Count > 0)
                        {
                            colors = imgController.TemperatureToColor(portController.GetTemperature(), rows, lines);
                        }
                        textBox1.Text = @"Data recived";
                    }
                });
                thread.Start();
            }
            catch (Exception exp)
            {

                MessageBox.Show(exp.Message);
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image.Save(saveFileDialog1.FileName + ".png");
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
        }

        //public void paintComponent(Graphics h)
        //{
        //    for (var i = 0; i < 16; i++)
        //    {
        //        switch (i)
        //        {
        //            case 0:
        //                var h1 = CreateGraphics();
        //                Color.FromArgb()
        //                h = Color.FromArgb(255, 0, 0);
        //                break;
        //            case 1:
        //                h.setColor(new Color(255, 64, 0));
        //                break;
        //            case 2:
        //                h.setColor(new Color(255, 128, 0));
        //                break;
        //            case 3:
        //                h.setColor(new Color(255, 192, 0));
        //                break;
        //            case 4:
        //                h.setColor(new Color(255, 255, 0));
        //                break;
        //            case 5:
        //                h.setColor(new Color(192, 255, 0));
        //                break;
        //            case 6:
        //                h.setColor(new Color(128, 255, 0));
        //                break;
        //            case 7:
        //                h.setColor(new Color(64, 255, 0));
        //                break;
        //            case 8:
        //                h.setColor(new Color(0, 255, 0));
        //                break;
        //            case 9:
        //                h.setColor(new Color(0, 255, 64));
        //                break;
        //            case 10:
        //                h.setColor(new Color(0, 255, 128));
        //                break;
        //            case 11:
        //                h.setColor(new Color(0, 255, 192));
        //                break;
        //            case 12:
        //                h.setColor(new Color(0, 255, 255));
        //                break;
        //            case 13:
        //                h.setColor(new Color(0, 192, 255));
        //                break;
        //            case 14:
        //                h.setColor(new Color(0, 128, 255));
        //                break;
        //            case 15:
        //                h.setColor(new Color(0, 64, 255));
        //                break;
        //            case 16:
        //                h.setColor(new Color(0, 0, 255));
        //                break;
        //        }
        //        h.fillRect(20*i, 10, 20, 20);

        //    }
        //}



        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (!colors.Any())
            {
                draw_flag = 0;
                return;
            }
            point_x = e.X;
            point_y = e.Y;
            cor_x = point_x/9;
            cor_y = point_y/(460/48);
            draw_flag = 1;
        }
    }
}
