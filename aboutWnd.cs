using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Icon_Extractor
{
    public partial class AboutWnd : Form
    {
        public AboutWnd()
        {
            InitializeComponent();

            lblAbout.Text = "Icon Extractor" + Environment.NewLine;
            lblAbout.Text += "Version: " + Application.ProductVersion + Environment.NewLine;
            lblAbout.Text += "Requires Microsoft® .Net framework v2.0 or later to run";

            lblContact.Text = "Developed by: Ankit Rajpoot" + Environment.NewLine;
            lblContact.Text += "Email: ankitr.42@gmail.com" + Environment.NewLine;
            lblContact.Text += "Visit me on the web at:" + Environment.NewLine;
            lblContact.Text += "http://ankitr.heliohost.org" + Environment.NewLine;
            lblContact.Links.Add(36, 19, "mailto:ankitr.42@gmail.com?subject=Icon Extractor " + Application.ProductVersion);
            lblContact.Links.Add(82, 27, "http://ankitr.heliohost.org");
            lblContact.Text += "If you've used this software, and found it useful for any purpose," +
                               " please send me a mail with your comments and suggestions. Your" +
                               " response is what will fuel my passion for programming." +
                               " Let your valuable comments or suggestions flow to my email address.";

            lblLegal.Text = "This software is freeware." + Environment.NewLine;
            lblLegal.Text += "Please feel free to use and distribute this software as long as you" +
                             " owe proper credit to the author." + Environment.NewLine + Environment.NewLine;
            lblLegal.Text += "Please note that, although this software has been thoroughly tested and debugged," +
                             " yet there MAY be errors or bugs in this program that MAY" +
                             " result in unintentional damage(s) to you or your property. Also note that" +
                             " if you're using this software for any purpose, you're using it at your" +
                             " own risk and the developer can't be held responsible for any unintentional" + 
                             " damage(s) that this software inflicts on you or your property." + Environment.NewLine + Environment.NewLine;
            lblLegal.Text += "Microsoft is a registered trademark of Microsoft corporation.";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblContact_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start((string)e.Link.LinkData);
        }
    }        
 }