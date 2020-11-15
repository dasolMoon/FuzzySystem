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

        public void WhenSetFormClosed()
        {
            this.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("임시로 막아두었습니다. For 선바 ", "임시 차단 항목", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //MessageBox.Show("Github주소 복사 완료 \nSNS로 Find My Color를 공유해보세요 ! ", "Github주소 복사", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //System.Windows.Forms.Clipboard.SetText("https://github.com/dasolMoon/FuzzySystem.git");
        }
    }
}
