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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // 시작하기 버튼 클릭
        {
            //SetForm 실행
            SetForm setForm = new SetForm(this);
            setForm.Show();

            //MainForm 숨김
            //this.Hide();
            this.Visible = false;
        }

        public void WhenClosed()
        {
            this.Visible = true;
        }
    }
}
