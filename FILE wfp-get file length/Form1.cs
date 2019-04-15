using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FILE_wfp_get_file_length
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //DIALOG SHOW GetInvalidFileNameChars
        private void btn_Get_Click_Click_Click(object sender, EventArgs e)
        {
            foreach (char c in Path.GetInvalidFileNameChars()) {
                richTextBox1.Text += c + "\r\n";
            }
        }

        //File size + extension + time 
        private void Btn_file_extension_Click(object sender, EventArgs e)
        {
            OpenFileDialog P_OpenFileDialog = new OpenFileDialog();// creat open file dialog Obj 

            
            if (P_OpenFileDialog.ShowDialog() == DialogResult.OK)   //judge select file
            {
                FileInfo f = new FileInfo(P_OpenFileDialog.FileName); //file creat time / LastWriteTime

                MessageBox.Show("File length：" +
                    File.Open(P_OpenFileDialog.FileName, FileMode.Open).Length.ToString() +
                    "Byte"
                    + "\n"+
                    "File extension：" + 
                    P_OpenFileDialog.FileName.Substring(
                        P_OpenFileDialog.FileName.LastIndexOf(".") + 1,
                        P_OpenFileDialog.FileName.Length-
                        P_OpenFileDialog.FileName.LastIndexOf(".") - 1)
                        + "\n" +
                        "File Creat Time:" + f.CreationTime.ToString() 
                        + "\n" + 
                        "File Last Write Time:" + f.LastWriteTime.ToString() 
                        , "warn!");
            }
        }


        //Dialog  CreatFile
        private void btn_creatfile_Click(object sender, EventArgs e)
        {
            SaveFileDialog P_saveFileDialog = new SaveFileDialog();  //CREAT SAVE FILE DIALOG OBJ
            if (P_saveFileDialog.ShowDialog() == DialogResult.OK) {
                File.Create(P_saveFileDialog.FileName);
            }

        }
        //Dialog deletefile
        private void btn_deletfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog P_OpenFileDialog = new OpenFileDialog();   //DELETE FILE DIALOG OBJ
            if (P_OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.Delete(P_OpenFileDialog.FileName);
            }
        }


        //随机名称创建文件和文件夹
        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog P_FolderBrowserDialog = new FolderBrowserDialog();  //文件夹对话框
            if (P_FolderBrowserDialog.ShowDialog() == DialogResult.OK )   
            {
                File.Create(P_FolderBrowserDialog.SelectedPath +
                    "\\"  + 
                    Guid.NewGuid().ToString() + ".txt");      //根据Guid生成文件名
            }
        }
          private void btn_filecreatf_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog P_FolderBrowserDialog = new FolderBrowserDialog();  //文件夹对话框
            if (P_FolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                Directory.CreateDirectory(P_FolderBrowserDialog.SelectedPath + "\\" +
                    Guid.NewGuid().ToString() );      //根据Guid生成文件名
            }
        }

        private void btn_append_Click(object sender, EventArgs e)
        {
            textBox1.Text = Path.GetTempFileName(); //临时文件夹名称
            FileInfo file1 = new FileInfo(textBox1.Text);  //创建文件夹对象
            file1.AppendText();  //追加文本
        }

        private void Btn_FileDate_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK) {
                File.Create( folderBrowserDialog.SelectedPath + "" +
                    "\\" + DateTime.Now.ToString("yyyymmhhmmss") + ".txt" );
            }
        }
    }
}
