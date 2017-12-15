using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Kinect
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }
        private void Form5_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == 'w' || e.KeyChar == 'W')
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }
    }
}
