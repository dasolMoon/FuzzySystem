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
        Color skinColor = Color.Black;
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
            mainForm.WhenClosed();
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
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            btnPicture.Visible = true;
            btnRe.Visible = false;
            btnSkin.Enabled = false;
            btnResult.Enabled = false;
        }

        private void btnSkin_Click(object sender, EventArgs e)
        {
            btnResult.Enabled = true;
            //btnSkin.Enabled = false;

            SkinPickerForm skinPickerForm = new SkinPickerForm(this);
            skinPickerForm.Show();
            this.Visible = false;
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            ResultForm resultForm = new ResultForm();

        }


        public void SetSkinColor(Color color)
        {
            skinColor = color;
            pictureBox2.BackColor = color;
            this.Visible = true;
        }
    }
}
