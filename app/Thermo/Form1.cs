using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Thermo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Color> temperatureStretching = new List<Color>
            {
                Color.FromArgb(255, 0, 0),
                Color.FromArgb(255, 64, 0),
                Color.FromArgb(255, 128, 0),
                Color.FromArgb(255, 192, 0),
                Color.FromArgb(192, 255, 0),
                Color.FromArgb(128, 255, 0),
                Color.FromArgb(64, 255, 0),
                Color.FromArgb(0, 255, 0),
                Color.FromArgb(0, 255, 64),
                Color.FromArgb(0, 255, 128),
                Color.FromArgb(0, 255, 192),
                Color.FromArgb(0, 255, 255),
                Color.FromArgb(0, 192, 255),
                Color.FromArgb(0, 128, 255),
                Color.FromArgb(0, 64, 255),
                Color.FromArgb(0, 0, 255)
            };

        private void Form1_Load(object sender, EventArgs e)
        {
            var s = File.ReadAllText("matrix.txt").Replace('.', ',');
            var values = s.Split();

            var mas = new double[60, 45];

            var index = 0;
            for (var i = 59; i >=0; i--)
            {

                for (var j = 44; j >=0; j--)
                {
                    while (true)
                    {
                        if (double.TryParse(values[index], out mas[i, j]))
                            break;
                        index++;
                    }
                    index++;
                }
            }

            var thermoPicture = ConvertThermoMatrixToBitmap(mas, 60, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Image = thermoPicture;
        }

        Bitmap ConvertThermoMatrixToBitmap(double[,] thermoMatrix, int width, int height)
        {
            var result = new Bitmap(width, height);
            var minValue = double.MaxValue;
            var maxValue = double.MinValue;
            for (var x=0; x<width; x++)
            {
                for (var y=0; y<height; y++)
                {
                    minValue = Math.Min(minValue, thermoMatrix[x, y]);
                    maxValue = Math.Max(maxValue, thermoMatrix[x, y]);
                }
            }
            temperatureStretching.Reverse();
            for (var x=0; x<width; x++)
            {
                for (var y=0; y<height; y++)
                {
                    result.SetPixel(x, y, ConvertThermoToColor(thermoMatrix[x, y], minValue, maxValue, temperatureStretching));
                }
            }
            return result;
        }

        private Color ConvertThermoToColor(double value, double minValue, double maxValue, List<Color> palette)
        {
            var index = (int)Math.Round((value - minValue) * (palette.Count-1) / (maxValue - minValue));
            return palette[index];
        }
    }
}
