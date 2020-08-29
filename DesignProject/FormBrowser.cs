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

namespace DesignProject
{
    public partial class FormBrowser : Form
    {
        public FormBrowser()
        {
            InitializeComponent();
        }

        private void BtnFolderBrowser_Click(object sender, EventArgs e)
        {
            FolderBrowser.Description = "Lütfen Klasörünüzü Seçiniz";
            FolderBrowser.ShowNewFolderButton = true;

            DialogResult folderResult = FolderBrowser.ShowDialog();

            if (folderResult == DialogResult.OK)
            {
                string folderPath = FolderBrowser.SelectedPath;
                MessageBox.Show(folderPath);
            }


        }

        private void BtnOpenFileDialog_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Dosyanızı Seçiniz";
            DialogResult fileResult = openFileDialog1.ShowDialog();

            if (fileResult == DialogResult.OK)
            {
                MessageBox.Show(openFileDialog1.FileName);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Dosyayı Kaydetçeğiniz Yeri Seçiniz";
            //saveFileDialog1.Filter = "|*.txt";
            DialogResult dialogResult = saveFileDialog1.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                string savePath = saveFileDialog1.FileName;
                //File.WriteAllText(savePath, RchSaveFile.Text);
                File.AppendAllText(savePath,"\n" + RchSaveFile.Text);

            }

        }
    }
}
