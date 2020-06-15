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
    }
}
