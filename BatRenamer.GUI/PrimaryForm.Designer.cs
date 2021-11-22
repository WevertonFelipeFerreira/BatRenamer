
namespace BatRenamer.GUI
{
    partial class PrimaryForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnDialogFile = new System.Windows.Forms.Button();
            this.txtDirectory = new System.Windows.Forms.TextBox();
            this.GBNameList = new System.Windows.Forms.GroupBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnRename = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNamesInfo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.GBNameList.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select folder (with your files to be renamed)";
            // 
            // btnDialogFile
            // 
            this.btnDialogFile.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDialogFile.Location = new System.Drawing.Point(9, 51);
            this.btnDialogFile.Name = "btnDialogFile";
            this.btnDialogFile.Size = new System.Drawing.Size(58, 28);
            this.btnDialogFile.TabIndex = 1;
            this.btnDialogFile.Text = "Open";
            this.btnDialogFile.UseVisualStyleBackColor = true;
            this.btnDialogFile.Click += new System.EventHandler(this.btnDialogFile_Click);
            // 
            // txtDirectory
            // 
            this.txtDirectory.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDirectory.Location = new System.Drawing.Point(73, 52);
            this.txtDirectory.Name = "txtDirectory";
            this.txtDirectory.ReadOnly = true;
            this.txtDirectory.Size = new System.Drawing.Size(212, 27);
            this.txtDirectory.TabIndex = 2;
            // 
            // GBNameList
            // 
            this.GBNameList.Controls.Add(this.progressBar);
            this.GBNameList.Controls.Add(this.btnRename);
            this.GBNameList.Controls.Add(this.label4);
            this.GBNameList.Controls.Add(this.label3);
            this.GBNameList.Controls.Add(this.label2);
            this.GBNameList.Controls.Add(this.txtNamesInfo);
            this.GBNameList.Enabled = false;
            this.GBNameList.Location = new System.Drawing.Point(12, 113);
            this.GBNameList.Name = "GBNameList";
            this.GBNameList.Size = new System.Drawing.Size(488, 348);
            this.GBNameList.TabIndex = 3;
            this.GBNameList.TabStop = false;
            this.GBNameList.Text = "Names list";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(59, 263);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(367, 35);
            this.progressBar.TabIndex = 5;
            // 
            // btnRename
            // 
            this.btnRename.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRename.Location = new System.Drawing.Point(195, 304);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(98, 38);
            this.btnRename.TabIndex = 4;
            this.btnRename.Text = "RENAME";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(213, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "OriginalName.jpg;Renamed.jpg";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(4, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = " separated by a semicolon. EX: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(474, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter the original file names, then enter the name you want to rename,";
            // 
            // txtNamesInfo
            // 
            this.txtNamesInfo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNamesInfo.Location = new System.Drawing.Point(59, 80);
            this.txtNamesInfo.Multiline = true;
            this.txtNamesInfo.Name = "txtNamesInfo";
            this.txtNamesInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNamesInfo.Size = new System.Drawing.Size(367, 173);
            this.txtNamesInfo.TabIndex = 0;
            this.txtNamesInfo.Text = "OriginalName.jpg;Renamed.jpg\r\nOriginalName2.jpg;Renamed2.jpg\r\nOriginalName3.jpg;R" +
    "enamed3.jpg\r\nOriginalName4.jpg;Renamed4.jpg";
            this.txtNamesInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnDialogFile);
            this.groupBox1.Controls.Add(this.txtDirectory);
            this.groupBox1.Location = new System.Drawing.Point(14, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 87);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Folder area";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(425, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "button2";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // PrimaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 473);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GBNameList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "PrimaryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrimaryForm";
            this.GBNameList.ResumeLayout(false);
            this.GBNameList.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDialogFile;
        private System.Windows.Forms.TextBox txtDirectory;
        private System.Windows.Forms.GroupBox GBNameList;
        private System.Windows.Forms.TextBox txtNamesInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}