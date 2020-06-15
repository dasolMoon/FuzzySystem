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
    public partial class SkinPickerForm : Form
    {
        Image skinImage= null;
        Color skinColor = Color.Empty;

        SetForm setForm = null;
        public SkinPickerForm(SetForm setForm)
        {
            InitializeComponent();
            this.skinImage = setForm.pictureBox1.Image;
            init();
            this.setForm = setForm;
        }

        private void init()
        {
            //만약 사진 크기가 현재 해상도보다 클 경우
            if(skinImage.Width >= Screen.PrimaryScreen.Bounds.Width || 
                skinImage.Height >= Screen.PrimaryScreen.Bounds.Height)
            {
                //현재 해상도의 최대값-100px한 것을 Maximumsize로 설정함
                this.MaximumSize = new System.Drawing.Size(Screen.PrimaryScreen.Bounds.Width-100, Screen.PrimaryScreen.Bounds.Height-100);
                this.Size = MaximumSize;
            }
            else
            {
                this.Size = skinImage.Size;
            }
            pictureBox1.Size = skinImage.Size;
            pictureBox1.Image = skinImage;
        }

        private void ImageMouseClick(object sender, MouseEventArgs e)
        {
            DialogResult choose = DialogResult.None;
            choose = MessageBox.Show("피부 색을 결정하시겠습니까?", "피부색 결정", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (choose == DialogResult.OK)
            {
                Bitmap temp = new Bitmap(pictureBox1.Image);
                skinColor = temp.GetPixel(e.X, e.Y);
                setForm.SetSkinColor(skinColor);
                this.Close();
            }
        }

    }
}
