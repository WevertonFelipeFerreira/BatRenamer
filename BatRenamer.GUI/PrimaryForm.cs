using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using BatRenamer.Models.Exceptions;
using BatRenamer.Models.Entities;
using BatRenamer.Models;
using BatRenamer.Models.Services;

namespace BatRenamer.GUI
{
    public partial class PrimaryForm : Form
    {
        private string path;
        private string pathWithArchive;
        private List<NameInfo> list;
        public PrimaryForm()
        {
            InitializeComponent();
            list = new List<NameInfo>();
            ToolTip toolTiper = new ToolTip();
            toolTiper.SetToolTip(this.btnDialogFile, "Will open a box for you to select a folder.");
            toolTiper.SetToolTip(this.btnRename, "When pressed will start the batch rename process.");
        }

        private void btnDialogFile_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                path = @GetPath();
                GBNameList.Enabled = true;
                txtDirectory.Text = path;
                pathWithArchive = @path + @"\Renamer.bat";
            }
            catch (IncorrectFolderException x)
            {
                MessageBox.Show(x.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (StringStructureException x)
            {
                MessageBox.Show(x.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (IOException x)
            {
                MessageBox.Show(x.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
        private string GetPath()
        {
            string path;
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                path = @fbd.SelectedPath;
                return path;
            }
            throw new IncorrectFolderException("The folder is not correct!");
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNamesInfo.Text))
            {
                MessageBox.Show("Empty Text.", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            foreach (var item in txtNamesInfo.Lines)
            {
                string c = item.Trim().Replace("\t", "");

                if (!c.Contains(";") && !c.Contains("."))
                {
                    throw new StringStructureException($"INVALID FORMAT! Format must be like: {Messages.formatExample}");
                }


                string[] fullString = c.Split(";");
                list.Add(new NameInfo(fullString[0], fullString[1]));
            }
            FormatTxtNamesInfo();
            BatBuilder b = new BatBuilder(list);
            progressBar.Value = 2;
            b.CreateAndWriteFile(pathWithArchive);
            b.Execute(pathWithArchive, path);

            // ProgressBar
            int maximun = list.Count;
            progressBar.Maximum = maximun;
            for (int i = 0; i <= maximun; i++)
            {
                progressBar.Value = i;
            }
            b.RemoveBat(pathWithArchive);
            MessageBox.Show("All file(s) renamed.", "Success!");
            Reset();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void FormatTxtNamesInfo()
        {
            txtNamesInfo.Clear();
            foreach (var item in list)
            {
                txtNamesInfo.Text += $"{item.OriginalName};{item.ToRename}\n";
            }
        }

        private void Reset()
        {
            if (!GBNameList.Enabled) 
            {
                return;
            }
            progressBar.Value = 0;
            txtNamesInfo.Clear();
            GBNameList.Enabled = false;
            path = "";
            pathWithArchive = "";
            list.RemoveAll(x => x.OriginalName != null && x.ToRename != null);
        }

    }
}
