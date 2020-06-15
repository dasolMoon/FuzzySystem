using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FindMyColor_m
{
    public partial class ResultForm : Form
    {
        SetForm setForm = null;
        Color skinColor = Color.Empty;

        public ResultForm(SetForm setForm)
        {
            InitializeComponent();

            this.setForm = setForm;
            Init();
        }

        private void Init()
        {
            skinColor = setForm.pictureBox2.BackColor;
            pictureBox1.BackColor = skinColor;

            SetMyColor();
        }

        private void SetMyColor() //여러 색상 표기기법으로 피부 색상을 표시 
        {
            labelR.Text = "" + skinColor.R;
            labelG.Text = "" + skinColor.G;
            labelB.Text = "" + skinColor.B;

            double[] tempRgb = RgbToCmyk(skinColor);
            labelC.Text = "" + tempRgb[0] + "%"; //cyan
            labelM.Text = "" + tempRgb[1] + "%"; //magenta
            labelY.Text = "" + tempRgb[2] + "%"; //yellow
            labelK.Text = "" + tempRgb[3] + "%"; //black

        }

        private void ResultForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            setForm.WhenResultFormClosed();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private double[] RgbToCmyk(Color color)
        {
            byte red = color.R;
            byte green = color.G;
            byte blue = color.B;

            double black = Math.Min(1.0 - red / 255.0, Math.Min(1.0 - green / 255.0, 1.0 - blue / 255.0)) * 10;
            double cyan = (1.0 - (red / 255.0) - black) / (1.0 - black) * 10;
            double magenta = (1.0 - (green / 255.0) - black) / (1.0 - black) * 10;
            double yellow = (1.0 - (blue / 255.0) - black) / (1.0 - black) * 10;

            return new[] { cyan, magenta, yellow, black };
        }

        private Color CmykToRgb(double cyan, double magenta, double yellow, double black) //CMYK TO RGB
        {
            byte red = Convert.ToByte((1 - Math.Min(1, cyan * (1 - black) + black)) * 255);
            byte green = Convert.ToByte((1 - Math.Min(1, magenta * (1 - black) + black)) * 255);
            byte blue = Convert.ToByte((1 - Math.Min(1, yellow * (1 - black) + black)) * 255);
            /*
                        Color tempColor = Color.FromArgb(Convert.ToByte((1 - Math.Min(1, cyan * (1 - black) + black)) * 255),
                        Convert.ToByte((1 - Math.Min(1, magenta * (1 - black) + black)) * 255),
                        Convert.ToByte((1 - Math.Min(1, yellow * (1 - black) + black)) * 255));
            */

            return Color.FromArgb(red, green, blue);
        }
    }
}
