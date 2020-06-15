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
        Color skinColor = Color.Black;

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
            this.Size = skinImage.Size;
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
