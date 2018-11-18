using System;
using System.Collections.Generic;
using System.Drawing;

namespace HomeImager
{
    public class ImageController
    {
        public double max = 0;
        private double average;
        public double min = 0;
        private double tmin = 0;
        private double tmax = 0;
        private double step;
        private int redValue;
        private int greenValue;
        private int blueValue;

        public void Find_Limits(List<Double> temp, int rows, int lines)
        {
            var maxpos = 0;
            var minpos = 0;
            max = temp[0];
            min = temp[0];
            for (var i = 0; i < (rows * lines); i++)
            {
                for (var j = i + 1; j < (rows * lines); j++)
                {
                    if (max < temp[j] && maxpos != j)
                    {
                        max = temp[j];
                        maxpos = j;
                    }
                    if (min > temp[j] && minpos != j)
                    {
                        min = temp[j];
                        minpos = j;
                    }
                }
            }
        }

        public int CalculateRGB(int rgb1, int rgb2, double t1, double t2, double t)
        {
            var faktor = (((t - t1) * 100.0) / (t2 - t1)) / 100.0;
            var drgb = rgb1 + (faktor * (rgb2 - rgb1));
            var rgb = (int) drgb;
            return rgb;
        }

        public void IntToRGB(double temperatures)
        {
            step = (((max - min) * 100.0) / 10) / 100.0;

            if ((temperatures >= min) && (temperatures <= (min + step)))
            {
                redValue = CalculateRGB(28, 31, min, (min + step), temperatures);
                greenValue = CalculateRGB(1, 17, min, (min + step), temperatures);
                blueValue = CalculateRGB(108, 218, min, (min + step), temperatures);
            }
            if ((temperatures > (min + step)) && (temperatures <= (min + 2 * step)))
            {
                redValue = CalculateRGB(31, 50, (min + step), (min + 2 * step),
                        temperatures);
                greenValue = CalculateRGB(17, 111, (min + step), (min + 2 * step),
                        temperatures);
                blueValue = CalculateRGB(218, 238, (min + step), (min + 2 * step),
                        temperatures);
            }
            if ((temperatures > (min + 2 * step))
                    && (temperatures <= (min + 3 * step)))
            {
                redValue = CalculateRGB(50, 63, (min + 2 * step),
                        (min + 3 * step), temperatures);
                greenValue = CalculateRGB(111, 196, (min + 2 * step),
                        (min + 3 * step), temperatures);
                blueValue = CalculateRGB(238, 229, (min + 2 * step),
                        (min + 3 * step), temperatures);
            }
            if ((temperatures > (min + 3 * step))
                    && (temperatures <= (min + 4 * step)))
            {
                redValue = CalculateRGB(63, 64, (min + 3 * step),
                        (min + 4 * step), temperatures);
                greenValue = CalculateRGB(196, 222, (min + 3 * step),
                        (min + 4 * step), temperatures);
                blueValue = CalculateRGB(229, 135, (min + 3 * step),
                        (min + 4 * step), temperatures);
            }
            if ((temperatures > (min + 4 * step))
                    && (temperatures <= (min + 5 * step)))
            {
                redValue = CalculateRGB(64, 192, (min + 4 * step),
                        (min + 5 * step), temperatures);
                greenValue = CalculateRGB(222, 240, (min + 4 * step),
                        (min + 5 * step), temperatures);
                blueValue = CalculateRGB(135, 14, (min + 4 * step),
                        (min + 5 * step), temperatures);
            }
            if ((temperatures > (min + 5 * step))
                    && (temperatures <= (min + 6 * step)))
            {
                redValue = CalculateRGB(192, 223, (min + 5 * step),
                        (min + 6 * step), temperatures);
                greenValue = CalculateRGB(240, 172, (min + 5 * step),
                        (min + 6 * step), temperatures);
                blueValue = CalculateRGB(14, 18, (min + 5 * step),
                        (min + 6 * step), temperatures);
            }
            if ((temperatures > (min + 6 * step))
                    && (temperatures <= (min + 7 * step)))
            {
                redValue = CalculateRGB(223, 209, (min + 6 * step),
                        (min + 7 * step), temperatures);
                greenValue = CalculateRGB(172, 111, (min + 6 * step),
                        (min + 7 * step), temperatures);
                blueValue = CalculateRGB(18, 14, (min + 6 * step),
                        (min + 7 * step), temperatures);
            }
            if ((temperatures > (min + 7 * step))
                    && (temperatures <= (min + 8 * step)))
            {
                redValue = CalculateRGB(209, 210, (min + 7 * step),
                        (min + 8 * step), temperatures);
                greenValue = CalculateRGB(111, 50, (min + 7 * step),
                        (min + 8 * step), temperatures);
                blueValue = CalculateRGB(14, 28, (min + 7 * step),
                        (min + 8 * step), temperatures);
            }
            if ((temperatures > (min + 8 * step))
                    && (temperatures <= (min + 9 * step)))
            {
                redValue = CalculateRGB(210, 194, (min + 8 * step),
                        (min + 9 * step), temperatures);
                greenValue = CalculateRGB(50, 26, (min + 8 * step),
                        (min + 9 * step), temperatures);
                blueValue = CalculateRGB(28, 0, (min + 8 * step),
                        (min + 9 * step), temperatures);
            }
            if ((temperatures > (min + 9 * step)) && (temperatures <= max))
            {
                redValue = CalculateRGB(194, 132, (min + 9 * step), max,
                        temperatures);
                greenValue = CalculateRGB(26, 26, (min + 9 * step), max,
                        temperatures);
                blueValue = CalculateRGB(0, 0, (min + 9 * step), max, temperatures);
            }
            if (temperatures < min)
            {
                redValue = 28;
                greenValue = 1;
                blueValue = 108;
            }
            if (temperatures > max)
            {
                redValue = 132;
                greenValue = 26;
                blueValue = 0;
            }
        }

        public List<Color> TemperatureToColor(List<Double> temp, int rows, int lines)
        {
            var col = new List<Color>();
            Find_Limits(temp, rows, lines);
            for (var i = 0; i < rows * lines; i++)
            {
                IntToRGB(temp[i]);
                col.Add(Color.FromArgb(255, redValue, greenValue, blueValue));
            }
            return col;

        }
    }
}
