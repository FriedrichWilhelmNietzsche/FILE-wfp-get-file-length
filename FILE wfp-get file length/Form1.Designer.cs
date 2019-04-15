namespace FILE_wfp_get_file_length
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Get_Click_Click = new System.Windows.Forms.Button();
            this.Btn_file_extension = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btn_creatfile = new System.Windows.Forms.Button();
            this.btn_deletfile = new System.Windows.Forms.Button();
            this.btn_filecreatf = new System.Windows.Forms.Button();
            this.btn_filecreatp = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_append = new System.Windows.Forms.Button();
            this.Btn_FileDate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Get_Click_Click
            // 
            this.btn_Get_Click_Click.Location = new System.Drawing.Point(83, 8);
            this.btn_Get_Click_Click.Name = "btn_Get_Click_Click";
            this.btn_Get_Click_Click.Size = new System.Drawing.Size(75, 23);
            this.btn_Get_Click_Click.TabIndex = 0;
            this.btn_Get_Click_Click.Text = "file";
            this.btn_Get_Click_Click.UseVisualStyleBackColor = true;
            this.btn_Get_Click_Click.Click += new System.EventHandler(this.btn_Get_Click_Click_Click);
            // 
            // Btn_file_extension
            // 
            this.Btn_file_extension.Location = new System.Drawing.Point(206, 6);
            this.Btn_file_extension.Name = "Btn_file_extension";
            this.Btn_file_extension.Size = new System.Drawing.Size(169, 23);
            this.Btn_file_extension.TabIndex = 1;
            this.Btn_file_extension.Text = "file operate";
            this.Btn_file_extension.UseVisualStyleBackColor = true;
            this.Btn_file_extension.Click += new System.EventHandler(this.Btn_file_extension_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(9, 8);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(68, 161);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // btn_creatfile
            // 
            this.btn_creatfile.Location = new System.Drawing.Point(178, 56);
            this.btn_creatfile.Name = "btn_creatfile";
            this.btn_creatfile.Size = new System.Drawing.Size(91, 23);
            this.btn_creatfile.TabIndex = 3;
            this.btn_creatfile.Text = "file create";
            this.btn_creatfile.UseVisualStyleBackColor = true;
            this.btn_creatfile.Click += new System.EventHandler(this.btn_creatfile_Click);
            // 
            // btn_deletfile
            // 
            this.btn_deletfile.Location = new System.Drawing.Point(300, 56);
            this.btn_deletfile.Name = "btn_deletfile";
            this.btn_deletfile.Size = new System.Drawing.Size(89, 23);
            this.btn_deletfile.TabIndex = 4;
            this.btn_deletfile.Text = "file delete";
            this.btn_deletfile.UseVisualStyleBackColor = true;
            this.btn_deletfile.Click += new System.EventHandler(this.btn_deletfile_Click);
            // 
            // btn_filecreatf
            // 
            this.btn_filecreatf.Location = new System.Drawing.Point(178, 100);
            this.btn_filecreatf.Name = "btn_filecreatf";
            this.btn_filecreatf.Size = new System.Drawing.Size(91, 23);
            this.btn_filecreatf.TabIndex = 5;
            this.btn_filecreatf.Text = "files creat";
            this.btn_filecreatf.UseVisualStyleBackColor = true;
            this.btn_filecreatf.Click += new System.EventHandler(this.btn_filecreatf_Click);
            // 
            // btn_filecreatp
            // 
            this.btn_filecreatp.Location = new System.Drawing.Point(300, 100);
            this.btn_filecreatp.Name = "btn_filecreatp";
            this.btn_filecreatp.Size = new System.Drawing.Size(89, 23);
            this.btn_filecreatp.TabIndex = 6;
            this.btn_filecreatp.Text = "file creat+\r\n";
            this.btn_filecreatp.UseVisualStyleBackColor = true;
            this.btn_filecreatp.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(111, 142);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(277, 21);
            this.textBox1.TabIndex = 7;
            // 
            // btn_append
            // 
            this.btn_append.Location = new System.Drawing.Point(111, 169);
            this.btn_append.Name = "btn_append";
            this.btn_append.Size = new System.Drawing.Size(165, 23);
            this.btn_append.TabIndex = 8;
            this.btn_append.Text = "file append";
            this.btn_append.UseVisualStyleBackColor = true;
            this.btn_append.Click += new System.EventHandler(this.btn_append_Click);
            // 
            // Btn_FileDate
            // 
            this.Btn_FileDate.Location = new System.Drawing.Point(96, 238);
            this.Btn_FileDate.Name = "Btn_FileDate";
            this.Btn_FileDate.Size = new System.Drawing.Size(124, 23);
            this.Btn_FileDate.TabIndex = 9;
            this.Btn_FileDate.Text = "file date";
            this.Btn_FileDate.UseVisualStyleBackColor = true;
            this.Btn_FileDate.Click += new System.EventHandler(this.Btn_FileDate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_FileDate);
            this.Controls.Add(this.btn_append);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_filecreatp);
            this.Controls.Add(this.btn_filecreatf);
            this.Controls.Add(this.btn_deletfile);
            this.Controls.Add(this.btn_creatfile);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Btn_file_extension);
            this.Controls.Add(this.btn_Get_Click_Click);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Get_Click_Click;
        private System.Windows.Forms.Button Btn_file_extension;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btn_creatfile;
        private System.Windows.Forms.Button btn_deletfile;
        private System.Windows.Forms.Button btn_filecreatf;
        private System.Windows.Forms.Button btn_filecreatp;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_append;
        private System.Windows.Forms.Button Btn_FileDate;
    }
}

