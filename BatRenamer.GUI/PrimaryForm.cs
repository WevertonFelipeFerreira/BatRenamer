using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BatRenamer.Models.Exceptions;

namespace BatRenamer.GUI
{
    public partial class PrimaryForm : Form
    {
        public PrimaryForm()
        {
            InitializeComponent();
        }

        private void btnDialogFile_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                string path = @GetPath();
                txtDirectory.Text = path;
                string pathWithArchive = @path + @"\Renamer.bat";
            }
            catch (IncorrectFolderException x) 
            {
                MessageBox.Show(x.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
