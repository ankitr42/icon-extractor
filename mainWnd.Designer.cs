namespace Icon_Extractor
{
    partial class mainWnd
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
            this.dlgFileBrowser = new System.Windows.Forms.OpenFileDialog();
            this.txtSrcFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.comboView = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExportSelected = new System.Windows.Forms.Button();
            this.btnExportAll = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboColorDepth = new System.Windows.Forms.ComboBox();
            this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.chkChildWindows = new System.Windows.Forms.CheckBox();
            this.sliderOpacityMeter = new System.Windows.Forms.TrackBar();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnDonate = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.grpImageSettings = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lstIcons = new System.Windows.Forms.ListView();
            this.toolStripContainer.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer.ContentPanel.SuspendLayout();
            this.toolStripContainer.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.grpInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sliderOpacityMeter)).BeginInit();
            this.grpImageSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // dlgFileBrowser
            // 
            this.dlgFileBrowser.Filter = "Executables|*.exe|DLLs|*.dll|All Files|*.*";
            this.dlgFileBrowser.RestoreDirectory = true;
            this.dlgFileBrowser.Title = "Select File";
            // 
            // txtSrcFile
            // 
            this.txtSrcFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSrcFile.BackColor = System.Drawing.SystemColors.Window;
            this.txtSrcFile.Location = new System.Drawing.Point(6, 21);
            this.txtSrcFile.Name = "txtSrcFile";
            this.txtSrcFile.ReadOnly = true;
            this.txtSrcFile.Size = new System.Drawing.Size(679, 20);
            this.txtSrcFile.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a file.";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Location = new System.Drawing.Point(691, 17);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 26);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // comboView
            // 
            this.comboView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboView.Enabled = false;
            this.comboView.FormattingEnabled = true;
            this.comboView.Items.AddRange(new object[] {
            "16x16",
            "24x24",
            "32x32",
            "48x48"});
            this.comboView.Location = new System.Drawing.Point(65, 22);
            this.comboView.Name = "comboView";
            this.comboView.Size = new System.Drawing.Size(125, 21);
            this.comboView.TabIndex = 2;
            this.comboView.SelectedIndexChanged += new System.EventHandler(this.comboView_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "View";
            // 
            // btnExportSelected
            // 
            this.btnExportSelected.Enabled = false;
            this.btnExportSelected.Location = new System.Drawing.Point(126, 154);
            this.btnExportSelected.Name = "btnExportSelected";
            this.btnExportSelected.Size = new System.Drawing.Size(119, 26);
            this.btnExportSelected.TabIndex = 5;
            this.btnExportSelected.Text = "Export selected icons";
            this.btnExportSelected.UseVisualStyleBackColor = true;
            this.btnExportSelected.Click += new System.EventHandler(this.btnExportSelected_Click);
            // 
            // btnExportAll
            // 
            this.btnExportAll.Enabled = false;
            this.btnExportAll.Location = new System.Drawing.Point(6, 154);
            this.btnExportAll.Name = "btnExportAll";
            this.btnExportAll.Size = new System.Drawing.Size(107, 26);
            this.btnExportAll.TabIndex = 4;
            this.btnExportAll.Text = "Export all icons";
            this.btnExportAll.UseVisualStyleBackColor = true;
            this.btnExportAll.Click += new System.EventHandler(this.btnExportAll_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Colordepth";
            // 
            // comboColorDepth
            // 
            this.comboColorDepth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboColorDepth.Enabled = false;
            this.comboColorDepth.FormattingEnabled = true;
            this.comboColorDepth.Items.AddRange(new object[] {
            "4",
            "8",
            "16",
            "24",
            "32"});
            this.comboColorDepth.Location = new System.Drawing.Point(65, 66);
            this.comboColorDepth.Name = "comboColorDepth";
            this.comboColorDepth.Size = new System.Drawing.Size(52, 21);
            this.comboColorDepth.TabIndex = 4;
            this.comboColorDepth.SelectedIndexChanged += new System.EventHandler(this.comboColorDepth_SelectedIndexChanged);
            // 
            // toolStripContainer
            // 
            // 
            // toolStripContainer.BottomToolStripPanel
            // 
            this.toolStripContainer.BottomToolStripPanel.Controls.Add(this.statusStrip);
            // 
            // toolStripContainer.ContentPanel
            // 
            this.toolStripContainer.ContentPanel.AutoScroll = true;
            this.toolStripContainer.ContentPanel.Controls.Add(this.grpInfo);
            this.toolStripContainer.ContentPanel.Controls.Add(this.grpImageSettings);
            this.toolStripContainer.ContentPanel.Controls.Add(this.lstIcons);
            this.toolStripContainer.ContentPanel.Controls.Add(this.label1);
            this.toolStripContainer.ContentPanel.Controls.Add(this.txtSrcFile);
            this.toolStripContainer.ContentPanel.Controls.Add(this.btnBrowse);
            this.toolStripContainer.ContentPanel.Controls.Add(this.btnExportSelected);
            this.toolStripContainer.ContentPanel.Controls.Add(this.btnExportAll);
            this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(771, 446);
            this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer.Name = "toolStripContainer";
            this.toolStripContainer.Size = new System.Drawing.Size(771, 468);
            this.toolStripContainer.TabIndex = 0;
            this.toolStripContainer.Text = "toolStripContainer1";
            // 
            // statusStrip
            // 
            this.statusStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 0);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(771, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 0;
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(38, 17);
            this.lblStatus.Text = "Ready";
            // 
            // grpInfo
            // 
            this.grpInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpInfo.Controls.Add(this.chkChildWindows);
            this.grpInfo.Controls.Add(this.sliderOpacityMeter);
            this.grpInfo.Controls.Add(this.lblInfo);
            this.grpInfo.Controls.Add(this.btnDonate);
            this.grpInfo.Controls.Add(this.btnAbout);
            this.grpInfo.Location = new System.Drawing.Point(270, 47);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(496, 133);
            this.grpInfo.TabIndex = 6;
            this.grpInfo.TabStop = false;
            // 
            // chkChildWindows
            // 
            this.chkChildWindows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkChildWindows.AutoSize = true;
            this.chkChildWindows.Location = new System.Drawing.Point(415, 43);
            this.chkChildWindows.Name = "chkChildWindows";
            this.chkChildWindows.Size = new System.Drawing.Size(76, 17);
            this.chkChildWindows.TabIndex = 1;
            this.chkChildWindows.Text = "&Childs Too";
            this.chkChildWindows.UseVisualStyleBackColor = true;
            // 
            // sliderOpacityMeter
            // 
            this.sliderOpacityMeter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sliderOpacityMeter.LargeChange = 10;
            this.sliderOpacityMeter.Location = new System.Drawing.Point(415, 7);
            this.sliderOpacityMeter.Maximum = 100;
            this.sliderOpacityMeter.Name = "sliderOpacityMeter";
            this.sliderOpacityMeter.Size = new System.Drawing.Size(75, 42);
            this.sliderOpacityMeter.SmallChange = 10;
            this.sliderOpacityMeter.TabIndex = 0;
            this.sliderOpacityMeter.TickFrequency = 10;
            this.sliderOpacityMeter.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.sliderOpacityMeter.Scroll += new System.EventHandler(this.sliderOpacityMeter_Scroll);
            // 
            // lblInfo
            // 
            this.lblInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfo.Location = new System.Drawing.Point(6, 13);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(403, 114);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "This program is freeware.";
            // 
            // btnDonate
            // 
            this.btnDonate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDonate.Location = new System.Drawing.Point(415, 66);
            this.btnDonate.Name = "btnDonate";
            this.btnDonate.Size = new System.Drawing.Size(75, 26);
            this.btnDonate.TabIndex = 2;
            this.btnDonate.Text = "Donate";
            this.btnDonate.UseVisualStyleBackColor = true;
            this.btnDonate.Click += new System.EventHandler(this.btnDonate_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbout.Location = new System.Drawing.Point(415, 101);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(75, 26);
            this.btnAbout.TabIndex = 3;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // grpImageSettings
            // 
            this.grpImageSettings.Controls.Add(this.label2);
            this.grpImageSettings.Controls.Add(this.comboView);
            this.grpImageSettings.Controls.Add(this.comboColorDepth);
            this.grpImageSettings.Controls.Add(this.label3);
            this.grpImageSettings.Controls.Add(this.label4);
            this.grpImageSettings.Location = new System.Drawing.Point(6, 47);
            this.grpImageSettings.Name = "grpImageSettings";
            this.grpImageSettings.Size = new System.Drawing.Size(239, 101);
            this.grpImageSettings.TabIndex = 3;
            this.grpImageSettings.TabStop = false;
            this.grpImageSettings.Text = "Icon Settings";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "bits";
            // 
            // lstIcons
            // 
            this.lstIcons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lstIcons.HideSelection = false;
            this.lstIcons.Location = new System.Drawing.Point(6, 186);
            this.lstIcons.Name = "lstIcons";
            this.lstIcons.Size = new System.Drawing.Size(760, 260);
            this.lstIcons.TabIndex = 7;
            this.lstIcons.UseCompatibleStateImageBehavior = false;
            // 
            // mainWnd
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 468);
            this.Controls.Add(this.toolStripContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "mainWnd";
            this.Text = "Icon Extractor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainWnd_FormClosed);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.mainWnd_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.mainWnd_DragEnter);
            this.toolStripContainer.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer.ContentPanel.ResumeLayout(false);
            this.toolStripContainer.ContentPanel.PerformLayout();
            this.toolStripContainer.ResumeLayout(false);
            this.toolStripContainer.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sliderOpacityMeter)).EndInit();
            this.grpImageSettings.ResumeLayout(false);
            this.grpImageSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog dlgFileBrowser;
        private System.Windows.Forms.TextBox txtSrcFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.ComboBox comboView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExportSelected;
        private System.Windows.Forms.Button btnExportAll;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboColorDepth;
        private System.Windows.Forms.ToolStripContainer toolStripContainer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lstIcons;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.GroupBox grpImageSettings;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnDonate;
        private System.Windows.Forms.TrackBar sliderOpacityMeter;
        private System.Windows.Forms.CheckBox chkChildWindows;

    }
}

