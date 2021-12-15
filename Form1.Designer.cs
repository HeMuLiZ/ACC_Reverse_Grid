
namespace ACC_Reverse_Grid_App
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnReverse = new System.Windows.Forms.Button();
            this.btnQual = new System.Windows.Forms.Button();
            this.btnServerFile = new System.Windows.Forms.Button();
            this.btnResultsFile = new System.Windows.Forms.Button();
            this.lblServer = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblResultsFile = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.sessionMinSelector = new System.Windows.Forms.NumericUpDown();
            this.lblSessionMin = new System.Windows.Forms.Label();
            this.groupBoxSettings = new System.Windows.Forms.GroupBox();
            this.UseDNFSettingsCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DNFsBackChkbox = new System.Windows.Forms.CheckBox();
            this.numericHighDNF = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDNFHigh = new System.Windows.Forms.Label();
            this.lblLowDNF = new System.Windows.Forms.Label();
            this.numericLowDNF = new System.Windows.Forms.NumericUpDown();
            this.serverBtn = new System.Windows.Forms.Button();
            this.UpButton = new System.Windows.Forms.Button();
            this.DownButton = new System.Windows.Forms.Button();
            this.setGridBtn = new System.Windows.Forms.Button();
            this.driverlist = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sessionMinSelector)).BeginInit();
            this.groupBoxSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericHighDNF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLowDNF)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(18, 231);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(106, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Auto reverse grid";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnReverse
            // 
            this.btnReverse.Enabled = false;
            this.btnReverse.Location = new System.Drawing.Point(6, 19);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(105, 28);
            this.btnReverse.TabIndex = 1;
            this.btnReverse.Text = "Reverse Grid";
            this.btnReverse.UseVisualStyleBackColor = true;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            // 
            // btnQual
            // 
            this.btnQual.Enabled = false;
            this.btnQual.Location = new System.Drawing.Point(242, 19);
            this.btnQual.Name = "btnQual";
            this.btnQual.Size = new System.Drawing.Size(105, 28);
            this.btnQual.TabIndex = 2;
            this.btnQual.Text = "Qualifying";
            this.btnQual.UseVisualStyleBackColor = true;
            this.btnQual.Click += new System.EventHandler(this.btnQual_Click);
            // 
            // btnServerFile
            // 
            this.btnServerFile.Location = new System.Drawing.Point(6, 19);
            this.btnServerFile.Name = "btnServerFile";
            this.btnServerFile.Size = new System.Drawing.Size(105, 28);
            this.btnServerFile.TabIndex = 3;
            this.btnServerFile.Text = "Pick Server File";
            this.btnServerFile.UseVisualStyleBackColor = true;
            this.btnServerFile.Click += new System.EventHandler(this.btnServerFile_Click);
            // 
            // btnResultsFile
            // 
            this.btnResultsFile.Enabled = false;
            this.btnResultsFile.Location = new System.Drawing.Point(243, 19);
            this.btnResultsFile.Name = "btnResultsFile";
            this.btnResultsFile.Size = new System.Drawing.Size(105, 28);
            this.btnResultsFile.TabIndex = 4;
            this.btnResultsFile.Text = "Pick Results File";
            this.btnResultsFile.UseVisualStyleBackColor = true;
            this.btnResultsFile.Click += new System.EventHandler(this.btnResultsFile_Click);
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(10, 16);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(38, 13);
            this.lblServer.TabIndex = 5;
            this.lblServer.Text = "Server";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Controls.Add(this.lblResultsFile);
            this.groupBox1.Controls.Add(this.lblServer);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 94);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(10, 69);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Status";
            // 
            // lblResultsFile
            // 
            this.lblResultsFile.AutoSize = true;
            this.lblResultsFile.Location = new System.Drawing.Point(10, 43);
            this.lblResultsFile.Name = "lblResultsFile";
            this.lblResultsFile.Size = new System.Drawing.Size(114, 13);
            this.lblResultsFile.TabIndex = 6;
            this.lblResultsFile.Text = "No Results File Picked";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnQual);
            this.groupBox2.Controls.Add(this.btnReverse);
            this.groupBox2.Location = new System.Drawing.Point(13, 266);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(353, 57);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Grid Editors";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnResultsFile);
            this.groupBox3.Controls.Add(this.btnServerFile);
            this.groupBox3.Location = new System.Drawing.Point(12, 329);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(354, 59);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Change Files";
            // 
            // sessionMinSelector
            // 
            this.sessionMinSelector.Location = new System.Drawing.Point(291, 24);
            this.sessionMinSelector.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.sessionMinSelector.Name = "sessionMinSelector";
            this.sessionMinSelector.Size = new System.Drawing.Size(53, 20);
            this.sessionMinSelector.TabIndex = 9;
            this.sessionMinSelector.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.sessionMinSelector.ValueChanged += new System.EventHandler(this.sessionMinSelector_ValueChanged);
            // 
            // lblSessionMin
            // 
            this.lblSessionMin.AutoSize = true;
            this.lblSessionMin.Location = new System.Drawing.Point(10, 26);
            this.lblSessionMin.Name = "lblSessionMin";
            this.lblSessionMin.Size = new System.Drawing.Size(178, 13);
            this.lblSessionMin.TabIndex = 10;
            this.lblSessionMin.Text = "Practice minutes when reversed grid";
            // 
            // groupBoxSettings
            // 
            this.groupBoxSettings.Controls.Add(this.UseDNFSettingsCheckBox);
            this.groupBoxSettings.Controls.Add(this.label2);
            this.groupBoxSettings.Controls.Add(this.DNFsBackChkbox);
            this.groupBoxSettings.Controls.Add(this.numericHighDNF);
            this.groupBoxSettings.Controls.Add(this.label1);
            this.groupBoxSettings.Controls.Add(this.lblDNFHigh);
            this.groupBoxSettings.Controls.Add(this.lblLowDNF);
            this.groupBoxSettings.Controls.Add(this.numericLowDNF);
            this.groupBoxSettings.Controls.Add(this.lblSessionMin);
            this.groupBoxSettings.Controls.Add(this.sessionMinSelector);
            this.groupBoxSettings.Location = new System.Drawing.Point(13, 114);
            this.groupBoxSettings.Name = "groupBoxSettings";
            this.groupBoxSettings.Size = new System.Drawing.Size(353, 146);
            this.groupBoxSettings.TabIndex = 11;
            this.groupBoxSettings.TabStop = false;
            this.groupBoxSettings.Text = "Settings";
            // 
            // UseDNFSettingsCheckBox
            // 
            this.UseDNFSettingsCheckBox.AutoSize = true;
            this.UseDNFSettingsCheckBox.Location = new System.Drawing.Point(144, 118);
            this.UseDNFSettingsCheckBox.Name = "UseDNFSettingsCheckBox";
            this.UseDNFSettingsCheckBox.Size = new System.Drawing.Size(15, 14);
            this.UseDNFSettingsCheckBox.TabIndex = 20;
            this.UseDNFSettingsCheckBox.UseVisualStyleBackColor = true;
            this.UseDNFSettingsCheckBox.CheckedChanged += new System.EventHandler(this.UseDNFSettingsCheckBox_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Use DNF second settings";
            // 
            // DNFsBackChkbox
            // 
            this.DNFsBackChkbox.AutoSize = true;
            this.DNFsBackChkbox.Location = new System.Drawing.Point(329, 117);
            this.DNFsBackChkbox.Name = "DNFsBackChkbox";
            this.DNFsBackChkbox.Size = new System.Drawing.Size(15, 14);
            this.DNFsBackChkbox.TabIndex = 18;
            this.DNFsBackChkbox.UseVisualStyleBackColor = true;
            this.DNFsBackChkbox.CheckedChanged += new System.EventHandler(this.DNFsBackChkbox_CheckedChanged);
            // 
            // numericHighDNF
            // 
            this.numericHighDNF.Location = new System.Drawing.Point(291, 80);
            this.numericHighDNF.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericHighDNF.Name = "numericHighDNF";
            this.numericHighDNF.Size = new System.Drawing.Size(53, 20);
            this.numericHighDNF.TabIndex = 15;
            this.numericHighDNF.Value = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numericHighDNF.ValueChanged += new System.EventHandler(this.numericHighDNF_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Set DNF\'s back of the grid";
            // 
            // lblDNFHigh
            // 
            this.lblDNFHigh.AutoSize = true;
            this.lblDNFHigh.Location = new System.Drawing.Point(10, 82);
            this.lblDNFHigh.Name = "lblDNFHigh";
            this.lblDNFHigh.Size = new System.Drawing.Size(95, 13);
            this.lblDNFHigh.TabIndex = 14;
            this.lblDNFHigh.Text = "DNF high seconds";
            // 
            // lblLowDNF
            // 
            this.lblLowDNF.AutoSize = true;
            this.lblLowDNF.Location = new System.Drawing.Point(10, 53);
            this.lblLowDNF.Name = "lblLowDNF";
            this.lblLowDNF.Size = new System.Drawing.Size(91, 13);
            this.lblLowDNF.TabIndex = 12;
            this.lblLowDNF.Text = "DNF low seconds";
            // 
            // numericLowDNF
            // 
            this.numericLowDNF.Location = new System.Drawing.Point(291, 51);
            this.numericLowDNF.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericLowDNF.Name = "numericLowDNF";
            this.numericLowDNF.Size = new System.Drawing.Size(53, 20);
            this.numericLowDNF.TabIndex = 11;
            this.numericLowDNF.ValueChanged += new System.EventHandler(this.numericLowDNF_ValueChanged);
            // 
            // serverBtn
            // 
            this.serverBtn.Location = new System.Drawing.Point(372, 19);
            this.serverBtn.Name = "serverBtn";
            this.serverBtn.Size = new System.Drawing.Size(204, 88);
            this.serverBtn.TabIndex = 13;
            this.serverBtn.Text = "Restart Server";
            this.serverBtn.UseVisualStyleBackColor = true;
            this.serverBtn.Click += new System.EventHandler(this.serverBtn_Click);
            // 
            // UpButton
            // 
            this.UpButton.Enabled = false;
            this.UpButton.Location = new System.Drawing.Point(530, 124);
            this.UpButton.Name = "UpButton";
            this.UpButton.Size = new System.Drawing.Size(46, 46);
            this.UpButton.TabIndex = 14;
            this.UpButton.Text = "Up";
            this.UpButton.UseVisualStyleBackColor = true;
            this.UpButton.Click += new System.EventHandler(this.UpButton_Click);
            // 
            // DownButton
            // 
            this.DownButton.Enabled = false;
            this.DownButton.Location = new System.Drawing.Point(530, 176);
            this.DownButton.Name = "DownButton";
            this.DownButton.Size = new System.Drawing.Size(46, 46);
            this.DownButton.TabIndex = 15;
            this.DownButton.Text = "Down";
            this.DownButton.UseVisualStyleBackColor = true;
            this.DownButton.Click += new System.EventHandler(this.DownButton_Click);
            // 
            // setGridBtn
            // 
            this.setGridBtn.Enabled = false;
            this.setGridBtn.Location = new System.Drawing.Point(530, 342);
            this.setGridBtn.Name = "setGridBtn";
            this.setGridBtn.Size = new System.Drawing.Size(46, 46);
            this.setGridBtn.TabIndex = 16;
            this.setGridBtn.Text = "Set grid";
            this.setGridBtn.UseVisualStyleBackColor = true;
            this.setGridBtn.Click += new System.EventHandler(this.setGridBtn_Click);
            // 
            // driverlist
            // 
            this.driverlist.FormattingEnabled = true;
            this.driverlist.Location = new System.Drawing.Point(372, 124);
            this.driverlist.MultiColumn = true;
            this.driverlist.Name = "driverlist";
            this.driverlist.Size = new System.Drawing.Size(152, 264);
            this.driverlist.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 397);
            this.Controls.Add(this.setGridBtn);
            this.Controls.Add(this.DownButton);
            this.Controls.Add(this.UpButton);
            this.Controls.Add(this.serverBtn);
            this.Controls.Add(this.driverlist);
            this.Controls.Add(this.groupBoxSettings);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBox1);
            this.Name = "Form1";
            this.Text = "ACC Reverse Grip App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sessionMinSelector)).EndInit();
            this.groupBoxSettings.ResumeLayout(false);
            this.groupBoxSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericHighDNF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLowDNF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.Button btnQual;
        private System.Windows.Forms.Button btnServerFile;
        private System.Windows.Forms.Button btnResultsFile;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblResultsFile;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.NumericUpDown sessionMinSelector;
        private System.Windows.Forms.Label lblSessionMin;
        private System.Windows.Forms.GroupBox groupBoxSettings;
        private System.Windows.Forms.NumericUpDown numericHighDNF;
        private System.Windows.Forms.Label lblDNFHigh;
        private System.Windows.Forms.Label lblLowDNF;
        private System.Windows.Forms.NumericUpDown numericLowDNF;
        private System.Windows.Forms.CheckBox DNFsBackChkbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button serverBtn;
        private System.Windows.Forms.Button UpButton;
        private System.Windows.Forms.Button DownButton;
        private System.Windows.Forms.Button setGridBtn;
        private System.Windows.Forms.ListBox driverlist;
        private System.Windows.Forms.CheckBox UseDNFSettingsCheckBox;
        private System.Windows.Forms.Label label2;
    }
}

