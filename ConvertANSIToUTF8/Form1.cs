using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ConvertANSIToUTF8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectFiles_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.Filter = "Txt Files|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string[] fileNames = ofd.FileNames;
                for (int i = 0; i < fileNames.Length; i++)
                {
                    listBox1.Items.Add(fileNames[i]);
                }
            }
        }

        private void btnRemoveFile_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void btnConvertToUTF8_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                string path = listBox1.Items[i].ToString();
                string content = File.ReadAllText(path, Encoding.Default);
                File.WriteAllText(path, content, Encoding.UTF8);
            }
            MessageBox.Show("Finish");
        }
    }
}
