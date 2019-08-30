namespace Icon_Extractor
{
    partial class AboutWnd
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
            this.btnOk = new System.Windows.Forms.Button();
            this.lblAbout = new System.Windows.Forms.LinkLabel();
            this.lblContact = new System.Windows.Forms.LinkLabel();
            this.lblLegal = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(289, 363);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblAbout
            // 
            this.lblAbout.LinkArea = new System.Windows.Forms.LinkArea(0, 0);
            this.lblAbout.Location = new System.Drawing.Point(3, 9);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(296, 48);
            this.lblAbout.TabIndex = 1;
            this.lblAbout.Text = "Icon Extractor";
            // 
            // lblContact
            // 
            this.lblContact.LinkArea = new System.Windows.Forms.LinkArea(0, 0);
            this.lblContact.Location = new System.Drawing.Point(6, 65);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(358, 117);
            this.lblContact.TabIndex = 1;
            this.lblContact.Text = "Icon Extractor";
            this.lblContact.UseCompatibleTextRendering = true;
            this.lblContact.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblContact_LinkClicked);
            // 
            // lblLegal
            // 
            this.lblLegal.LinkArea = new System.Windows.Forms.LinkArea(0, 0);
            this.lblLegal.Location = new System.Drawing.Point(3, 182);
            this.lblLegal.Name = "lblLegal";
            this.lblLegal.Size = new System.Drawing.Size(361, 160);
            this.lblLegal.TabIndex = 1;
            this.lblLegal.Text = "Icon Extractor";
            // 
            // AboutWnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 388);
            this.Controls.Add(this.lblLegal);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.lblAbout);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AboutWnd";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About Icon Extractor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.LinkLabel lblAbout;
        private System.Windows.Forms.LinkLabel lblContact;
        private System.Windows.Forms.LinkLabel lblLegal;
    }
}