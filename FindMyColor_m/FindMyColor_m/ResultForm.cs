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
        double[] skinColor_hsl = null;
        double[] skinColor_hsv = null;
        string skinColor_hex = null;

        //퍼스널 컬러
        Color personalColor = Color.Empty;
        string tempType = null;
        string lightType = null;
        string seasonType = null;
        int deep = 0;

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

            
            //HSL
            skinColor_hsl = setForm.RgbToHsl(skinColor);
            labelHu.Text = "" + skinColor_hsl[0].ToString("F0") + "º"; //H 색조
            labelSa.Text = "" + (skinColor_hsl[1] * 100).ToString("F0") + "%"; //S *100 채도 
            labelL.Text = "" + (skinColor_hsl[2] * 100).ToString("F0") + "%"; //ㅣ *100 
            
            //HSV
            skinColor_hsv = setForm.RgbToHsv(skinColor);
            //labelHu.Text = "" + skinColor_hsv[0].ToString("F0") + "º"; //H 색조
            //labelSa.Text = "" + (skinColor_hsv[1] * 100).ToString("F0") + "%"; //S *100 채도 
            labelV.Text = "" + (skinColor_hsv[2] * 100).ToString("F0") + "%"; //ㅣ *100 


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

        private string RgbToHex(Color color)
        {
            return color.R.ToString("X2") + color.G.ToString("X2") + color.B.ToString("X2");
        }

        private void SetMyPersonalColor()
        {
            // 쿨 - 웜톤 깊이 표현
            labelDeep.Text = (deep * 100).ToString("F0");

            //계절 깊이 구분
            double toneY = skinColor_cmyk[2];
            double toneS = skinColor_hsl[1];
            double toneV = skinColor_hsl[2];

            //double toneV = skinColor_hsv[1];
            //double toneV = skinColor_hsv[2];



            // 웜톤, 쿨톤 구분
            if (toneY*100 >= 18.5) 
            {
                tempType = "웜(Warm)";
                picTemp.Image = Properties.Resources.웜;
                if (toneV >= 0.652)
                {
                    seasonType = "봄(Spring)";
                    picSeason.Image = Properties.Resources.봄;
                    if (toneS >= 0.33)
                    {
                        lightType = "브라이트(Bright)";
                        picLight.Image = Properties.Resources.브라이트;
                        pictureBox2.Image = Properties.Resources.봄웜브라이트;
                        pictureBoxPeople.Image = Properties.Resources.아이유;
                        labelName.Text = "아이유";
                        this.BackColor = Color.FromArgb(255, 202, 56);
                    }
                    else
                    {
                        lightType = "라이트(Light)";
                        pictureBox2.Image = Properties.Resources.봄웜라이트;
                        picLight.Image = Properties.Resources.라이트;
                        pictureBoxPeople.Image = Properties.Resources.설리;
                        labelName.Text = "설리"; 
                        this.BackColor = Color.Pink;
                    }
                }
                else
                {
                    seasonType = "가을(Autumn)";
                    picSeason.Image = Properties.Resources.가을;
                    if (toneS >= 0.33)
                    {
                        lightType = "딥(Deep)";
                        pictureBox2.Image = Properties.Resources.가을웜딥;
                        picLight.Image = Properties.Resources.딥;
                        pictureBoxPeople.Image = Properties.Resources.이효리;
                        labelName.Text = "이효리";
                        this.BackColor = Color.FromArgb(47, 16, 24);
                        this.ForeColor = Color.White;
                    }
                    else
                    {
                        lightType = "뮤트(Mute)";

                        picLight.Image = Properties.Resources.뮤트;
                        pictureBox2.Image = Properties.Resources.가을웜뮤트;
                        pictureBoxPeople.Image = Properties.Resources.이성경;
                        labelName.Text = "이성경"; 
                        this.BackColor = Color.FromArgb(152, 121, 92);
                    }
                }
            }
            else 
            {
                tempType = "쿨(Cool)";
                picTemp.Image = Properties.Resources.쿨;
                if(toneS >= 0.25)
                {
                    seasonType = "겨울(Winter)";
                    picSeason.Image = Properties.Resources.겨울;
                    if (toneV >= 0.70)
                    {
                        lightType = "브라이트(Bright)";
                        pictureBox2.Image = Properties.Resources.겨울쿨브라이트;
                        picLight.Image = Properties.Resources.브라이트;
                        pictureBoxPeople.Image = Properties.Resources.이다희;
                        labelName.Text = "이다희";
                        this.BackColor = Color.FromArgb(0, 29, 113);
                        this.ForeColor = Color.White;
                    }
                    else
                    {
                        lightType = "딥(Deep)";
                        pictureBox2.Image = Properties.Resources.겨울쿨딥;
                        picLight.Image = Properties.Resources.딥;
                        pictureBoxPeople.Image = Properties.Resources.문근영;
                        labelName.Text = "문근영";
                        this.BackColor = Color.FromArgb(54, 61, 78);
                        this.ForeColor = Color.White;
                    }
                }
                else
                {
                    seasonType = "여름(Summer)";
                    picSeason.Image = Properties.Resources.여름;
                    if (toneV >= 0.652)
                    {
                        lightType = "라이트(Light)";
                        pictureBox2.Image = Properties.Resources.여름쿨라이트;
                        picLight.Image = Properties.Resources.라이트;
                        pictureBoxPeople.Image = Properties.Resources.아이린;
                        labelName.Text = "아이린";
                        this.BackColor = Color.FromArgb(155, 197, 255);
                    }
                    else
                    {
                        lightType = "뮤트(Mute)";
                        pictureBox2.Image = Properties.Resources.여름쿨뮤트;
                        picLight.Image = Properties.Resources.뮤트;
                        pictureBoxPeople.Image = Properties.Resources.김고은;
                        labelName.Text = "김고은";
                        this.BackColor = Color.FromArgb(177, 122, 141);
                    }
                }
            }

            //깊이 정도
            deep = (int)Math.Abs(skinColor_cmyk[1] - skinColor_cmyk[2]);

            //라벨 설정
            labelseason.Text = seasonType;
            labelTemp.Text = tempType;
            labelLight.Text = lightType;

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            using (Bitmap bitmap = new Bitmap(this.Width, this.Height))
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string strFilename = saveFileDialog.FileName + ".jpg";
                    this.DrawToBitmap(bitmap, new Rectangle(0, 0, this.Width, this.Height));
                    bitmap.Save(@strFilename);

                    MessageBox.Show("파일이 "+ strFilename+"으로 저장되었습니다.", "저장 완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

       
        }
    }
}
