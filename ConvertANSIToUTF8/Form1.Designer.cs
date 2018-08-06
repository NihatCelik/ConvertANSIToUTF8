namespace ConvertANSIToUTF8
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnSelectFiles = new System.Windows.Forms.Button();
            this.btnConvertToUTF8 = new System.Windows.Forms.Button();
            this.btnRemoveFile = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRemoveFile);
            this.panel1.Controls.Add(this.btnConvertToUTF8);
            this.panel1.Controls.Add(this.btnSelectFiles);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 42);
            this.panel1.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 42);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(512, 287);
            this.listBox1.TabIndex = 1;
            // 
            // btnSelectFiles
            // 
            this.btnSelectFiles.Location = new System.Drawing.Point(12, 10);
            this.btnSelectFiles.Name = "btnSelectFiles";
            this.btnSelectFiles.Size = new System.Drawing.Size(113, 23);
            this.btnSelectFiles.TabIndex = 0;
            this.btnSelectFiles.Text = "Select Files";
            this.btnSelectFiles.UseVisualStyleBackColor = true;
            this.btnSelectFiles.Click += new System.EventHandler(this.btnSelectFiles_Click);
            // 
            // btnConvertToUTF8
            // 
            this.btnConvertToUTF8.Location = new System.Drawing.Point(223, 10);
            this.btnConvertToUTF8.Name = "btnConvertToUTF8";
            this.btnConvertToUTF8.Size = new System.Drawing.Size(113, 23);
            this.btnConvertToUTF8.TabIndex = 2;
            this.btnConvertToUTF8.Text = "Convert To UTF8";
            this.btnConvertToUTF8.UseVisualStyleBackColor = true;
            this.btnConvertToUTF8.Click += new System.EventHandler(this.btnConvertToUTF8_Click);
            // 
            // btnRemoveFile
            // 
            this.btnRemoveFile.Location = new System.Drawing.Point(131, 10);
            this.btnRemoveFile.Name = "btnRemoveFile";
            this.btnRemoveFile.Size = new System.Drawing.Size(86, 23);
            this.btnRemoveFile.TabIndex = 1;
            this.btnRemoveFile.Text = "Remove File";
            this.btnRemoveFile.UseVisualStyleBackColor = true;
            this.btnRemoveFile.Click += new System.EventHandler(this.btnRemoveFile_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnSelectFiles;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 329);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Convert ANSI To UTF8";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnSelectFiles;
        private System.Windows.Forms.Button btnConvertToUTF8;
        private System.Windows.Forms.Button btnRemoveFile;
    }
}

