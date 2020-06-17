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
        string lightType = null;
        string seasonType = null;
        int deep = 0;

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
            skinColor_cmyk = setForm.RgbToCmyk(skinColor);
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
            skinColor_hsl = setForm.RgbToHsl(skinColor);
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

        /*

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
            

            return Color.FromArgb(red, green, blue);
        }
        */
        private void SetMyPersonalColor()
        {
            /* 1. 
                saturation ≥ 0.2
               2.
                hue ≤ 28° ||hue ≥ 330°
               3.
                0.5 ≤ luminance/saturation ≤ 3.0
             
               santuration.min == 0.2 ; 
               0<=hue<=28  ||  330<=hue<=359
             */

            /*
             <웜톤>
            High Y	High L	High S	Spring warm bright
            High Y	High L	Low S	Spring warm light
            Low Y	High L	Low S	Autumn warm mute
            Low Y	High L	High S	Autumn warm deep
            <쿨톤>
            High Y	Low L	Low S	Summer cool light
            Low Y	Low L	Low S	Summer cool mute
            Low Y	Low L	High S	Winter cool deep
            High Y	Low L	High S	Winter cool bright
             */

        
            //깊이 표현
            labelDeep.Text = (deep * 100).ToString("F0");

            //계절 깊이 구분
            double toneY = skinColor_cmyk[2];
            double toneS = skinColor_hsl[1];
            double toneL = skinColor_hsl[2];

            /*
            HIGH YELLOW 
            0.5 ~ 1

            HIGH SATURATION
            0.6 ~ 1

            HIGH LUMINANCE 
            1.75 ~ 3

            LOW YELLOW
            0 ~ 0.5

            LOW SATURATION
            0.2 ~ 0.6

            LOW LUMINANCE 
            0.5 ~ 1.75
             */

            // 웜톤, 쿨톤 구분
            if (toneL >= 1.75) 
            {
                tempType = "웜톤(WarmTone)";
                if(toneY >= 0.5)
                {
                    seasonType = "봄(Spring)";
                }
                else
                {
                    seasonType = "가을(Autumn)";
                }
            }
            else 
            {
                tempType = "쿨톤(CoolTone)";
                if(toneS >=0.6)
                {
                    seasonType = "겨울(Winter)";
                }
                else
                {
                    seasonType = "여름(Summer)";
                }
            }

            //bright 구분
            if (toneY >= 0.5) {
                if(toneS >= 0.6)
                {
                    lightType = "브라이트(Bright)";
                }
                else
                {
                    lightType= "라이트(Light)"; 
                }
            }else {
                if (toneS >= 0.6)
                {
                    lightType = "딥(Deep)";
                }
                else
                {
                    lightType = "뮤트(Mute)";
                }
            }

            //깊이 정도
            deep = (int)Math.Abs(skinColor_cmyk[1] - skinColor_cmyk[2]);
            //라벨브라이트


        }


    }
}
