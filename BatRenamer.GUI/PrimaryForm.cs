using System;
using System.IO;
using System.Windows.Forms;
using BatRenamer.Models.Exceptions;

namespace BatRenamer.GUI
{
    public partial class PrimaryForm : Form
    {
        public PrimaryForm()
        {
            InitializeComponent();
            ToolTip TTbtnDialogFile = new ToolTip();
            TTbtnDialogFile.SetToolTip(this.btnDialogFile, "Will open a box for you to select a folder.");
        }

        private void btnDialogFile_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                string path = @GetPath();
                GBNameList.Enabled = true;
                txtDirectory.Text = path;
                string pathWithArchive = @path + @"\Renamer.bat";
            }
            catch (IncorrectFolderException x) 
            {
                MessageBox.Show(x.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
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

      
    }
}
