using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formhide20190415
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (splitContainer1.Panel2Collapsed)
            {
                splitContainer1.Panel2Collapsed = false;

                button1.Left = splitContainer1.SplitterDistance - button1.Width;
                button2.Left = splitContainer1.SplitterDistance - button2.Width;
                button1.Text = "》";
            }
            else
            {
                splitContainer1.Panel2Collapsed = true;
                button1.Left = splitContainer1.Width - button1.Width;
                button2.Left = splitContainer1.Width - button2.Width;
                button1.Text = "《";
            }   
        }
    }
}
