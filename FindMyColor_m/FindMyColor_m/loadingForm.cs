using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindMyColor_m
{
    public partial class loadingForm : Form
    {
        public loadingForm()
        {
            InitializeComponent();

            this.BackgroundImage = Properties.Resources.Loading2;
            
        }

        
    }
}
