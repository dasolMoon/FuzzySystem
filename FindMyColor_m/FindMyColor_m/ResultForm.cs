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

        //색상 
        Color skinColor = Color.Empty;
        double[] skinColor_cmyk = null; // cyon magenta yellow black
        double[] skinColor_hsv = null;
        double[] skinColor_hsl = null;
        string skinColor_hex = null;

        //퍼스널 컬러
        Color personalColor = Color.Empty;
        string tempType = null;
        string seasonType = null;

        //추천



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

            //여러 색상 표기기법으로 피부 색상을 표시 
            SetMySkinColor();

            SetMyPersonalColor();
        }


        private void SetMySkinColor() //여러 색상 표기기법으로 피부 색상을 표시 
        {
            //RGB
            labelR.Text = "" + skinColor.R;
            labelG.Text = "" + skinColor.G;
            labelB.Text = "" + skinColor.B;

            //CMYK
            skinColor_cmyk = RgbToCmyk(skinColor);
            labelC.Text = "" + (skinColor_cmyk[0] * 100).ToString("F0") + "%"; //cyan *100
            labelM.Text = "" + (skinColor_cmyk[1] * 100).ToString("F0") + "%"; //magenta *100
            labelY.Text = "" + (skinColor_cmyk[2] * 100).ToString("F0") + "%"; //yellow *100
            labelK.Text = "" + (skinColor_cmyk[3] * 100).ToString("F0") + "%"; //black *100

            //HSV
            skinColor_hsv = RgbToHsv(skinColor);
            labelH.Text = "" + skinColor_hsv[0].ToString("F0") + "º"; //H 색조
            labelS.Text = "" + (skinColor_hsv[1] * 100).ToString("F0") + "%"; //S *100 채도 
            labelV.Text = "" + (skinColor_hsv[2] * 100).ToString("F0") + "%"; //V *100 값 

            //HLS
            skinColor_hsl = RgbToHsl(skinColor);
            labelHu.Text = "" + skinColor_hsl[0].ToString("F0") + "º"; //H 색조
            labelSa.Text = "" + (skinColor_hsl[1] * 100).ToString("F0") + "%"; //S *100 채도 
            labelLu.Text = "" + (skinColor_hsl[2] * 100).ToString("F0") + "%"; //ㅣ *100 


            //HEX
            skinColor_hex = RgbToHex(skinColor);
            labelHex.Text = "#" + skinColor_hex;

        }

        private void ResultForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            setForm.WhenResultFormClosed();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private double[] RgbToCmyk(Color color) // RGB TO CMYK
        {
            byte red = color.R;
            byte green = color.G;
            byte blue = color.B;

            double black = Math.Min(1.0 - red / 255.0, Math.Min(1.0 - green / 255.0, 1.0 - blue / 255.0));
            double cyan = (1.0 - (red / 255.0) - black) / (1.0 - black);
            double magenta = (1.0 - (green / 255.0) - black) / (1.0 - black);
            double yellow = (1.0 - (blue / 255.0) - black) / (1.0 - black);

            double[] temp = new double[] { cyan, magenta, yellow, black };

            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i] < 0)
                {
                    temp[i] = 0;
                }
                else if (temp[i] > 1)
                {
                    temp[i] = 1;
                }
            }

            return temp;
        }

        private double[] RgbToHsv(Color color) // RGB TO HSV
        {
            double hue = color.GetHue();
            //double saturation = color.GetSaturation();
            int max = Math.Max(color.R, Math.Max(color.G, color.B));
            int min = Math.Min(color.R, Math.Min(color.G, color.B));

            double saturation = (max == 0) ? 0 : 1d - (1d * min / max);
            double value = max / 255d;

            double[] temp = new double[] { hue, saturation, value };

            for (int i = 1; i < temp.Length; i++)
            {
                if (temp[i] < 0)
                {
                    temp[i] = 0;
                }
                else if (temp[i] > 1)
                {
                    temp[i] = 1;
                }
            }

            return temp;
        }

        private string RgbToHex(Color color)
        {
            return color.R.ToString("X2") + color.G.ToString("X2") + color.B.ToString("X2");
        }

        private double[] RgbToHsl(Color color) // RGB TO HSL
        {
            double hue = color.GetHue(), saturation, luminance;

            // Convert RGB to a 0.0 to 1.0 range.
            double tempR = color.R / 255.0;
            double tempG = color.G / 255.0;
            double tempB = color.B / 255.0;

            // Get the maximum and minimum RGB components.
            double max = tempR;
            if (max < tempG) max = tempG;
            if (max < tempB) max = tempB;

            double min = tempR;
            if (min > tempG) min = tempG;
            if (min > tempB) min = tempB;

            double diff = max - min;
            luminance = (max + min) / 2;
            if (Math.Abs(diff) < 0.00001) saturation = 0;
            else
            {
                if (luminance <= 0.5) saturation = diff / (max + min);
                else saturation = (max == 0) ? 0 : 1d - (1d * min / max);

            }
            double[] temp = new double[] { hue, saturation, luminance };

            for (int i = 1; i < temp.Length; i++)
            {
                if (temp[i] < 0)
                {
                    temp[i] = 0;
                }
                else if (temp[i] > 1)
                {
                    temp[i] = 1;
                }
            }

            return temp;
        }

        private Color ColorFromHSV(double hue, double saturation, double value) // HSV TO RGB
        {
            int hi = Convert.ToInt32(Math.Floor(hue / 60)) % 6;
            double f = hue / 60 - Math.Floor(hue / 60);

            value = value * 255;
            int v = Convert.ToInt32(value);
            int p = Convert.ToInt32(value * (1 - saturation));
            int q = Convert.ToInt32(value * (1 - f * saturation));
            int t = Convert.ToInt32(value * (1 - (1 - f) * saturation));

            if (hi == 0)
                return Color.FromArgb(v, t, p);
            else if (hi == 1)
                return Color.FromArgb(q, v, p);
            else if (hi == 2)
                return Color.FromArgb(p, v, t);
            else if (hi == 3)
                return Color.FromArgb(p, q, v);
            else if (hi == 4)
                return Color.FromArgb(t, p, v);
            else
                return Color.FromArgb(v, p, q);
        }
        private Color colorFromCmyk(double cyan, double magenta, double yellow, double black) // CMYK TO RGB
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

        private void SetMyPersonalColor()
        {
            /* 1. 
                saturation ≥ 0.2
               2.
                hue ≤ 28° ||hue ≥ 330°
               3.
                0.5 ≤ luminance/saturation ≤ 3.0*/

            // santuration.min == 0.2 ; 
            // 0<=hue<=28  ||  330<=hue<=359

            //톤 구분
            double magenta = skinColor_cmyk[1];
            double yellow = skinColor_cmyk[2];

            double deep = Math.Abs(magenta - yellow);  //ㅇ 가중치값 ?

            if (magenta < yellow) tempType = "웜톤(WarmTone)";
            else if (magenta > yellow) tempType = "쿨톤(CoolTone)";
            else tempType = "중성톤(NeutralTone)";

            labelTemp.Text = tempType;
            labelDeep.Text = (deep * 100).ToString("F0");

        }
    }
}
