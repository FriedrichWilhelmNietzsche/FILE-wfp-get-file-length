using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace getfilename_wfa
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }



        private void Btn_Select_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)    //open file dialog 
            {
                textBox1.Text = folderBrowserDialog1.SelectedPath;      //show file path
                tempstr = folderBrowserDialog1.SelectedPath;     //store selected file path
                thdAddFile = new Thread(new ThreadStart(SetAddFile));  //creat a threads
                thdAddFile.Start();   //run present threads
            }

        public delegate void AddFile();         //self definition delegate threads
        public void SetAddFile() {
            this.Invoke(new AddFile( RunAddFile));   //manage threads
        }

        public void RunAddFile()    //self definition, traversal file
        {
            TreeNode TNode = new TreeNode();   //creat threads
            Files_Copy(treeView1, tempstr, TNode, 0);
            Thread.Sleep(0);               //
            .

        }

        }
    }
}
