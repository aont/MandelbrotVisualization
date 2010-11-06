using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Drawing.Imaging;

namespace Aont
{
    public partial class MandelbrotForm : Form
    {
        public MandelbrotForm()
        {
            InitializeComponent();



            mandelbrot.Progressing += new EventHandler<ProgressingEventArgs>(mandelbrot_Progressing);
        }


        void mandelbrot_Progressing(object sender, ProgressingEventArgs e)
        {

            this.progressBar1.Value = e.Percent;

        }

        
        MandelbrotCalculator mandelbrot = new MandelbrotCalculator();



        void Set()
        {
            mandelbrot.n_exp = double.Parse(n_settingControl8.Value);
            mandelbrot.minX = double.Parse(leftx_settingControl1.Value);
            mandelbrot.minY = double.Parse(bottomy_settingControl2.Value);
            mandelbrot.MaxX = double.Parse(rightx_settingControl3.Value);
            mandelbrot.MaxY = double.Parse(topy_settingControl4.Value);
            mandelbrot.Width = int.Parse(width_settingControl9.Value);
            mandelbrot.Height = int.Parse(height_settingControl10.Value);
            mandelbrot.Loop = int.Parse(loop_settingControl5.Value);
            mandelbrot.Infinity = double.Parse(infinity_settingControl6.Value);
            mandelbrot.epsilon = double.Parse(epsilon_settingControl7.Value);

            InvalidateImage();
        }
        void InvalidateImage()
        {
            this.progressBar1.Visible = true;


            var Canvas = mandelbrot.setImage();

            this.pictureBox1.Image = Canvas;


            this.progressBar1.Visible = false;
        }
        private void set_button_Click(object sender, EventArgs e)
        {
            Set();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    this.leftx_settingControl1.Value = mandelbrot.getX(e.X * mandelbrot.Width / this.pictureBox1.Width).ToString();
                    this.bottomy_settingControl2.Value = mandelbrot.getY(e.Y * mandelbrot.Height / this.pictureBox1.Height).ToString();
                    break;
                case MouseButtons.Right:
                    this.rightx_settingControl3.Value = mandelbrot.getX(e.X * mandelbrot.Width / this.pictureBox1.Width).ToString();
                    this.topy_settingControl4.Value = mandelbrot.getY(e.Y * mandelbrot.Height / this.pictureBox1.Height).ToString();
                    break;
                default:
                    break;
            }
        }
        void InvalidateParametersTextBox()
        {
            this.n_settingControl8.Value = mandelbrot.n_exp.ToString();
            this.leftx_settingControl1.Value = mandelbrot.minX.ToString();
            this.bottomy_settingControl2.Value = mandelbrot.minY.ToString();
            this.rightx_settingControl3.Value = mandelbrot.MaxX.ToString();
            this.topy_settingControl4.Value = mandelbrot.MaxY.ToString();
            this.width_settingControl9.Value = mandelbrot.Width.ToString();
            this.height_settingControl10.Value = mandelbrot.Height.ToString();
            this.loop_settingControl5.Value = mandelbrot.Loop.ToString();
            this.infinity_settingControl6.Value = mandelbrot.Infinity.ToString();
            this.epsilon_settingControl7.Value = mandelbrot.epsilon.ToString();
        }


        private void MandelbrotForm_Shown(object sender, EventArgs e)
        {
            InvalidateParametersTextBox();
            InvalidateImage();
        }


        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            this.saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            var fn = this.saveFileDialog1.FileName;
            ImageFormat format =ImageFormat.Bmp   ;
            if (fn.ToLower().EndsWith(".jpg") || fn.ToLower().EndsWith(".jpeg"))
                format = ImageFormat.Jpeg;
            else if (fn.ToLower().EndsWith(".png"))
                format = ImageFormat.Png;
            else if (fn.ToLower().EndsWith(".gif"))
                format = ImageFormat.Gif;

            this.pictureBox1.Image.Save(fn, format);
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mandelbrot.calctype = CalcType.Argment;
            InvalidateImage();

        }

        private void convergenceAssumptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mandelbrot.calctype = CalcType.ConvergenceArgment;
            InvalidateImage();
        }

        private void reset_button1_Click(object sender, EventArgs e)
        {
            this.InvalidateParametersTextBox();
        }

        private void initialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.mandelbrot = new MandelbrotCalculator();
            this.InvalidateParametersTextBox();
        }




    }
}
