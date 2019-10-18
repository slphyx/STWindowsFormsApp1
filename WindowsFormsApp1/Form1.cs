using System;
using System.Drawing;
using System.Windows.Forms;
using Wolfram.NETLink;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private MathKernel mathKernel;
        private Bitmap bitmap;

        public Form1()
        {
            InitializeComponent();

            string[] mlArgs = { "-linkmode", "launch", "-linkname", "c:/program files/wolfram research/wolfram engine/12.0/wolfram.exe" };
            IKernelLink ml = MathLinkFactory.CreateKernelLink(mlArgs);

            mathKernel = new MathKernel(ml);


            mathKernel.GraphicsHeight = pictureBox1.Height;
            mathKernel.GraphicsWidth = pictureBox1.Width;

            mathKernel.CaptureGraphics = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (mathKernel.IsComputing)
            {
                mathKernel.Abort();
            }

            mathKernel.Compute(this.WLcommand_textBox.Text);
            this.Output_textBox.Text = (string)mathKernel.Result;

            if (mathKernel.Graphics.Length > 0)
            {
                if (bitmap != null)
                {
                    bitmap.Dispose();
                }


                bitmap = new Bitmap(mathKernel.Graphics[0]);

                this.pictureBox1.Image = bitmap;

            }
        }
    }
}
