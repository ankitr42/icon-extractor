using System;
using Win32API;
using System.Drawing;
using Microsoft.Win32;
using System.Diagnostics;
using System.Windows.Forms;

namespace Icon_Extractor
{
    public partial class mainWnd : Form
    {
        private string fileName;
        private uint totalIcons, counter;
        private IntPtr[] lIconHandles;

        public mainWnd()
        {
            InitializeComponent();
            lstIcons.LargeImageList = new ImageList();
            
            comboView.SelectedIndex = 2;
            comboColorDepth.SelectedIndex = 2;

            lblInfo.Text = "Icon Extractor - A freeware tool to extract icons from executables/DLLs." + Environment.NewLine + Environment.NewLine;
            lblInfo.Text += "Developed by: Ankit Rajpoot" + Environment.NewLine;
            lblInfo.Text += "If you found this program useful, please send me a mail. " + 
                            "For my email address and other information click the 'About' button." + Environment.NewLine + Environment.NewLine;
            lblInfo.Text += "Note: If the icons are having jagged edges or distorted colors, " +
                            "try lowering your desktop color depth to 24-bits or 16-bits.";

            try
            {
                sliderOpacityMeter.Value = (int)Registry.GetValue(@"HKEY_LOCAL_MACHINE\Software\Logicsoft\Icon Extractor\1.0", "Opacity", 0);
                sliderOpacityMeter_Scroll(new object(), EventArgs.Empty);
            }
            catch
            {
                sliderOpacityMeter.Value = 0;
            }

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (dlgFileBrowser.ShowDialog() == DialogResult.Cancel)
                return;

            fileName = dlgFileBrowser.FileName;

            if (fileName != txtSrcFile.Text)
            {
                txtSrcFile.Text = fileName;
                lstIcons.LargeImageList.Images.Clear();
                lstIcons.Items.Clear();
                Extract();
            }
        }

        private void EnableControls()
        {
            comboView.Enabled = true;
            comboColorDepth.Enabled = true;
            btnExportAll.Enabled = true;
            btnExportSelected.Enabled = true;
        }

        private void Extract()
        {
            uint temp = 1;
            lstIcons.Items.Clear();
            lstIcons.LargeImageList.ImageSize = new Size(GetIconSize(), GetIconSize());
            lstIcons.LargeImageList.ColorDepth = (ColorDepth)Convert.ToInt32(comboColorDepth.SelectedItem.ToString());
            totalIcons = (uint)WinIcons.ExtractIcon(IntPtr.Zero, txtSrcFile.Text, -1);

            if (totalIcons == 0)
            {
                MessageBox.Show("The selected file doesn't contain any icons.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            lblStatus.Text = "Drawing icons. Please wait...";
            Application.DoEvents();

            EnableControls();
                        
            lIconHandles = new IntPtr[totalIcons];

            for (counter = 0; counter < totalIcons; counter++)
                WinIcons.PrivateExtractIcons(txtSrcFile.Text, (int)counter, GetIconSize(),
                    GetIconSize(), ref lIconHandles[counter], ref temp, 1, 0);

            lstIcons.BeginUpdate();
            counter = 1;
            foreach (IntPtr ptr in lIconHandles)
            {
                lstIcons.Items.Add(new ListViewItem(counter.ToString(), (int)counter - 1));
                lstIcons.LargeImageList.Images.Add(Icon.FromHandle(ptr));
                //WinIcons.DestroyIcon(ptr);
                counter++;
            }

            lstIcons.EndUpdate();
            lblStatus.Text = "Ready";
        }

        private void comboView_SelectedIndexChanged(object sender, EventArgs e)
        {           
            if (txtSrcFile.Text != "")
                Extract();            
        }

        private void comboColorDepth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtSrcFile.Text != "")
                Extract();
        }

        private void btnExportAll_Click(object sender, EventArgs e)
        {
            saveIconsWnd exportWindow = new saveIconsWnd(lstIcons.Items, lIconHandles, GetIconSize());
            if (chkChildWindows.Checked)
                exportWindow.Opacity = this.Opacity;

            if (exportWindow.ShowDialog() == DialogResult.OK)
                MessageBox.Show("Export successful.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExportSelected_Click(object sender, EventArgs e)
        {
            saveIconsWnd exportWindow;

            if (lstIcons.SelectedItems.Count < 1)
            {
                MessageBox.Show("Please select one or more icons first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            exportWindow = new saveIconsWnd(lstIcons.SelectedItems, lIconHandles, GetIconSize());
            if (chkChildWindows.Checked)
                exportWindow.Opacity = this.Opacity;
            
            if (exportWindow.ShowDialog() == DialogResult.OK)
                MessageBox.Show("Export successful.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            AboutWnd aboutWindow = new AboutWnd();
            if (chkChildWindows.Checked)
                aboutWindow.Opacity = this.Opacity;
            aboutWindow.ShowDialog();
        }

        private int GetIconSize()
        {
            if (comboView.SelectedIndex == 0)
                return 16;
            
            if (comboView.SelectedIndex == 1)
                return 24;

            if (comboView.SelectedIndex == 2)
                return 32;

            if (comboView.SelectedIndex == 3)
                return 48;

            return 32;
        }

        private void btnDonate_Click(object sender, EventArgs e)
        {
            Process.Start("http://ankitr.heliohost.org");
        }

        private void mainWnd_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Registry.SetValue(@"HKEY_LOCAL_MACHINE\Software\Logicsoft\Icon Extractor\1.0\", "Opacity", sliderOpacityMeter.Value);
            }
            catch
            {
            }
        }

        private void sliderOpacityMeter_Scroll(object sender, EventArgs e)
        {
            this.Opacity = (1.00 - ((double)sliderOpacityMeter.Value / 100));
        }

        private void mainWnd_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
        }

        private void mainWnd_DragDrop(object sender, DragEventArgs e)
        {
            string[] fileName;
            
            fileName = (string[])e.Data.GetData(DataFormats.FileDrop);

            if (fileName[0] != txtSrcFile.Text)
            {
                txtSrcFile.Text = fileName[0];
                lstIcons.LargeImageList.Images.Clear();
                lstIcons.Items.Clear();
                Extract();
            }
        }
    }
}