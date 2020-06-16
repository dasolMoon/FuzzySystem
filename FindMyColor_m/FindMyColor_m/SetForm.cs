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
    public partial class SetForm : Form
    {
        MainForm mainForm = null;
        Color skinColor = Color.Empty;
        public SetForm(MainForm mainForm)
        {
            InitializeComponent();

            this.mainForm = mainForm;
            Init();
        }
        void Init() //초기 설정
        {

        }
        private void SetForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Mainform을 Visible = false로 설정했기 때문에 
            //현재 창이 꺼지면 MainForm이 Visible  = true로 설정
            mainForm.WhenSetFormClosed();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "이미지 파일(*.jpg)|*.jpg|이미지파일(*.png)|*.png|모든파일|*.*";
            openFileDialog1.Title = "이미지 열기";
            openFileDialog1.FileName = "";
            openFileDialog1.InitialDirectory = @"C\"; //초기 위치를 C드라이브로 설정 
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            {
                //MessageBox.Show(openFileDialog1.FileName);
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);


                //버튼 관리
                btnPicture.Visible = false;
                btnRe.Visible = true;
                btnSkin.Enabled = true;
            }
        }

        private void btnRe_Click(object sender, EventArgs e)
        {
            skinColor = Color.Empty;
            pictureBox1.Image = null;
            pictureBox2.BackColor = Color.Empty;
            btnPicture.Visible = true;
            btnRe.Visible = false;
            btnSkin.Enabled = false;
            btnResult.Enabled = false;
        }

        private void btnSkin_Click(object sender, EventArgs e) // 자동 피부색 선택 ㅇ버튼작업
        {
            FindMySkin();
            //int temp = MessageBox.Show("클러스터의 갯수를 입력해주세요","클러스터 갯수 입력 ")

            InputData input = new InputData(this);
            double[,] inputData = input.Run();

            FCM fcm = new FCM();
            fcm.Run(inputData);
            //fcm.GetResult();
        }

        private void btnSkinSelf_Click(object sender, EventArgs e) // 직접 피부색 선택
        {
            btnResult.Enabled = true;
            //btnSkin.Enabled = false;

            SkinPickerForm skinPickerForm = new SkinPickerForm(this);
            skinPickerForm.Show();
            this.Visible = false;
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            if (skinColor == Color.Empty)
            {
                MessageBox.Show("피부색 선택 후 진행해주세요 ! ", "피부색 값이 비어있습니다.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ResultForm resultForm = new ResultForm(this);
                resultForm.Show();
                this.Visible = false;
            }
        }

        private void FindMySkin() //피부색 찾기
        {
            /* 1. 
                saturation ≥ 0.2
               2.
                hue ≤ 28° || hue ≥ 330°
               3.
                0.5 ≤ luminance/saturation ≤ 3.0*/

            Bitmap originImage = new Bitmap(pictureBox1.Image);
            Bitmap skinBitmap = new Bitmap(originImage.Width, originImage.Height);
            // Bitmap[,] temp = new Bitmap[originImage.Height,originImage.Width];
            for (int y = 0; y < originImage.Height; y++)
            {
                for (int x = 0; x < originImage.Width; x++)
                {
                    Color color = originImage.GetPixel(x, y);
                    double[] tempHsl = RgbToHsl(color);//{ HUE, SATURATION,luminance} 


                    if (tempHsl[1] >= 0.2) // 1. saturation ≥ 0.2
                    {
                        if (tempHsl[0] <= 28 || tempHsl[0] >= 330) // 2.  hue ≤ 28° || hue ≥ 330°
                        {
                            if (0.5 <= tempHsl[2] / tempHsl[1] && tempHsl[2] / tempHsl[1] <= 3.0) // 3. 0.5 ≤ luminance/saturation ≤ 3.0*/
                            {
                                skinBitmap.SetPixel(x, y, color);
                            }
                        }
                    }

                }
            }//피부 검출 완료

            pictureBox1.Image = skinBitmap;
        }
        public void SetSkinColor(Color color)
        {
            skinColor = color;
            pictureBox2.BackColor = color;
            this.Visible = true;
        }

        public void WhenResultFormClosed()
        {
            this.Close();
        }

        public double[] RgbToHsl(Color color) // RGB TO HSL
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

        public double[] RgbToCmyk(Color color) // RGB TO CMYK
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
    }
}
