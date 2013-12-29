using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileMd5Gen
{
    public partial class Form1 : Form
    {
        private FolderBrowserDialog folderBrowser;
        private StringBuilder fileInfoes;

        public Form1()
        {
            InitializeComponent();
            folderBrowser = new FolderBrowserDialog();
            fileInfoes = new StringBuilder();
        }

        //Generate
        private void btnGen_Click(object sender, EventArgs e)
        {

            if (choosePath.Text.Length == 0)
            {
                MessageBox.Show("Please choose the direction.");
                return;
            }
            //Clear data
            fileInfoes.Clear();
            info.Items.Clear();

            //Generate md5 for each file
            String[] fileNames = Directory.GetFiles(choosePath.Text, "*", SearchOption.AllDirectories);
            foreach (String fileName in fileNames)
            {
                string fileNameShort = fileName.Substring(choosePath.Text.Length+1);
                string md5 = GetMD5HashFromFile(fileName);

                fileInfoes.Append(fileNameShort).Append(",").Append(md5).Append("\n");
                info.Items.Add(fileNameShort+","+md5);
            }
            //save file
            saveFile();
        }

        //Save file
        private void saveFile()
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.FileName = "version.txt";
            dlg.Filter = "txt文件|*.txt";
            dlg.AddExtension = true;
            dlg.Title = "保存文件";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(dlg.FileName, FileMode.Create);
                byte[] data = new UTF8Encoding().GetBytes(fileInfoes.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }
        }

        //Choose Directory
        private void btnChoose_Click(object sender, EventArgs e)
        {
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                choosePath.Text = folderBrowser.SelectedPath;
            }
        }

        //Generate file's md5 value
        private static string GetMD5HashFromFile(string fileName)
        {
            using(FileStream file = new FileStream(fileName, FileMode.Open)){
                System.Security.Cryptography.MD5 md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
                byte[] hash = md5.ComputeHash(file);
   
                StringBuilder result = new StringBuilder();
                for (int i = 0; i < hash.Length; i++)
                {
                    result.Append(hash[i].ToString("x2"));
                }
                return result.ToString();
            }
        }
    }
}
