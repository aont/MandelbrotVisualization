using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Aont
{
    public enum CalcType { Argment, ConvergenceArgment }

    class MandelbrotCalculator
    {
        public MandelbrotCalculator() { }


        public CalcType calctype = CalcType.Argment;
        public int Width = 256, Height = 256;
        public double minX = -2, minY = -1.5, MaxX = 1, MaxY = 1.5;
        public int Loop = 128;
        double Infinity2 = 1e12;
        double Epsilon2 = 1e-10;
        public double n_exp = 2;
        public double epsilon
        {
            get { return Math.Sqrt(Epsilon2); }
            set { this.Epsilon2 = value*value; }
        }
        public double Infinity
        {
            get { return Math.Sqrt(Infinity2); }
            set { this.Infinity2 = value * value; }
        }

        public Bitmap getBitmap()
        {
            var Canvas = new Bitmap(Width, Height);
            for (int i = 0; i < Height; i++)
            {
                double Y = getY(i);
                for (int j = 0; j < Width; j++)
                {
                    double X = getX(j);

                    Canvas.SetPixel(j, i, getColor(X, Y));
                }
            }
            return Canvas;
        }

        public double getX(int Left)
        {
            return (minX * (Width - Left) + MaxX * Left) / Width;
        }
        public double getY(int Top)
        {
            return (minY * Top + MaxY * (Height - Top)) / Height;
        }


        Color getColor(double X, double Y)
        {
            switch (calctype)
            {
                case CalcType.ConvergenceArgment:
                    return getColorConvergence(X, Y);

                default:
                    return getColorNormal(X, Y);
            }

        }

        private Color getColorConvergence(double X, double Y)
        {
            var x = 1 - 4 * X; var y = -4 * Y;
            var root = Math.Pow(x * x + y * y, 0.25);
            var Theta = Math.Atan2(y, x) / 2;
            var x_n = (1 - root * Math.Cos(Theta)) / 2;
            var y_n = -root * Math.Sin(Theta) / 2;

            var RR = x_n*x_n+y_n*y_n;
            int h = (int)(Math.Atan2(y_n, x_n) * 180 / Math.PI + 360) % 360;
            const int s = 255;
            int i =  (int)Math.Max(0,Math.Min(255,256*Math.Exp(-2*RR)));
            int r, g, b;
            HSIToRGB(h, s, i, out r, out g, out b);
            return Color.FromArgb(r, g, b);
        }

        Color getColorNormal(double X, double Y)
        {
            double x_n = 0, y_n = 0;

            int n;
            for (n = Loop; n > 0; n--)
            {
                var Theta = Math.Atan2(y_n, x_n) * n_exp;
                var Rn = Math.Pow(x_n * x_n + y_n * y_n, n_exp / 2);
                var x = Rn * Math.Cos(Theta) + X;
                var y = Rn * Math.Sin(Theta) + Y;



                var deltaz2 = Math.Pow(x - x_n, 2) + Math.Pow(y - y_n, 2);
                if (deltaz2 < Epsilon2)
                {
                    break;
                }
                else if (deltaz2 > Infinity2)
                {
                    int h = (int)(Math.Atan2(y_n, x_n) * 180 / Math.PI + 360) % 360;
                    const int s = 32;
                    int i = 256 * n / Loop;
                    int r, g, b;
                    HSIToRGB(h, s, i, out r, out g, out b);
                    return Color.FromArgb(r, g, b);
                }
                else
                {
                    x_n = x;
                    y_n = y;
                }
            }
            {
                int h = (int)(Math.Atan2(y_n, x_n) * 180 / Math.PI ) % 360;
                while (h < 0)
                {
                    h += 360;
                }
                const int s = 255;
                const int i = 255;
                int r, g, b;
                HSIToRGB(h, s, i, out r, out g, out b);
                return Color.FromArgb(r, g, b);
            }
        }

        public static void HSIToRGB(int h, int s, int i, out int r, out int g, out int b)
        {
            if (0 > h && h > 359) throw new ArgumentOutOfRangeException("h", "色相Hは0～359の範囲でなければなりません。");
            if (0 > s && s > 255) throw new ArgumentOutOfRangeException("s", "彩度Sは0～255の範囲でなければなりません。");
            if (0 > i && i > 255) throw new ArgumentOutOfRangeException("i", "明度Iは0～255の範囲でなければなりません。");

            if (s == 0)
            {
                r = g = b = i;
            }
            else
            {
                int ht = h * 6;
                double d = (double)(ht % 360);
                int t1 = (int)(i * (255.0d - s) / 255.0d);
                int t2 = (int)(i * (255.0d - s * d / 360.0d) / 255.0d);
                int t3 = (int)(i * (255.0d - s * (360.0d - d) / 360.0d) / 255.0d);

                switch (ht / 360)
                {
                    case 0:
                        r = i; g = t3; b = t1; break;
                    case 1:
                        r = t2; g = i; b = t1; break;
                    case 2:
                        r = t1; g = i; b = t3; break;
                    case 3:
                        r = t1; g = t2; b = i; break;
                    case 4:
                        r = t3; g = t1; b = i; break;
                    default:
                        r = i; g = t1; b = t2; break;
                }
            }
        }



        public event EventHandler<ProgressingEventArgs> Progressing = delegate(object sender, ProgressingEventArgs e) { };
        public Bitmap setImage()
        {
            var Canvas = new Bitmap(Width, Height);
            var e = new ProgressingEventArgs();



            for (int i = 0; i < Height; i++)
            {
                double Y = getY(i);
                for (int j = 0; j < Width; j++)
                {
                    double X = getX(j);

                    Canvas.SetPixel(j, i, getColor(X, Y));

                    e.Percent = 100 * (i * Height + j) / (Height * Width);
                    Progressing(this, e);
                }





            }


            e.Percent = 100;
            Progressing(this, e);
            return Canvas;
        }
    }

    class ProgressingEventArgs : EventArgs
    {
        public int Percent;
    }
}
