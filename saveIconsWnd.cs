using System;
using System.IO;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace Icon_Extractor
{
    public partial class saveIconsWnd : Form
    {
        private ListView.ListViewItemCollection items;
        private ImageFormat[] imgFormat;
        private IntPtr[] iHandles;
        private int dimensions;
        
        public saveIconsWnd(ListView.ListViewItemCollection itemList, IntPtr[] iconHandles, int size)
        {
            InitializeComponent();
            items = itemList;
            iHandles = iconHandles;
            dimensions = size;
            imgFormat = new ImageFormat[6];

            InitializeImageFormats();
        }

        public saveIconsWnd(ListView.SelectedListViewItemCollection itemList, IntPtr[] iconHandles, int size)
        {
            InitializeComponent();
            items = new ListView.ListViewItemCollection(new ListView());

            foreach (ListViewItem item in itemList)
                items.Add((ListViewItem)item.Clone());

            iHandles = iconHandles;
            dimensions = size;
            imgFormat = new ImageFormat[6];

            InitializeImageFormats();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            dlgFolderBrowser.Description = "Select a folder to put the icons into.";
            if (dlgFolderBrowser.ShowDialog() == DialogResult.Cancel)
                return;
            txtDestinationFolder.Text = dlgFolderBrowser.SelectedPath;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            FileStream temp;

            DisableAllControls();

            if (txtDestinationFolder.Text == "")
            {
                MessageBox.Show("Please select a destination folder.");
                EnableAllControls();
                return;
            }

            
            for (int i=0; i<items.Count; i++)
            {
                if (comboFormat.SelectedIndex == 2)
                {
                    temp = new FileStream(txtDestinationFolder.Text + "\\" + (items[i].Index+1).ToString() + ".ico", FileMode.CreateNew);
                    Icon.FromHandle(iHandles[Convert.ToInt32(items[i].Text) - 1]).Save(temp);
                }
                else
                {
                    temp = new FileStream(txtDestinationFolder.Text + "\\" + items[i].Index.ToString() + GetExtension(comboFormat.SelectedIndex), FileMode.CreateNew);
                    Icon.FromHandle(iHandles[Convert.ToInt32(items[i].Text)-1]).ToBitmap().Save(temp, imgFormat[comboFormat.SelectedIndex]);
                }
                temp.Close();
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private string GetExtension(int index)
        {
            string temp;

            if (index == 3)
                return ".jpeg";

            temp = (string)comboFormat.Items[index];
            temp = temp.Substring(temp.IndexOf("(") + 1, 4);

            return temp;
        }

        private void EnableAllControls()
        {
            txtDestinationFolder.Enabled = true;
            btnBrowse.Enabled = true;
            comboFormat.Enabled = true;
            btnExport.Enabled = true;
            btnCancel.Enabled = true;
        }

        private void DisableAllControls()
        {
            txtDestinationFolder.Enabled = false;
            btnBrowse.Enabled = false;
            comboFormat.Enabled = false;
            btnExport.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void InitializeImageFormats()
        {
            imgFormat[0] = ImageFormat.Bmp;
            imgFormat[1] = ImageFormat.Gif;
            imgFormat[2] = ImageFormat.Icon;
            imgFormat[3] = ImageFormat.Jpeg;
            imgFormat[4] = ImageFormat.Png;
            imgFormat[5] = ImageFormat.Tiff;

            comboFormat.Items.Add("Bitmap File Format (.bmp)");
            comboFormat.Items.Add("Graphics Interchange Format (.gif)");
            comboFormat.Items.Add("Windows Icon Format (.ico)");
            comboFormat.Items.Add("Joint Photographic Experts Group Format (.jpeg)");
            comboFormat.Items.Add("Portable Network Graphics Format (.png)");
            comboFormat.Items.Add("Tag Image File Format (.tiff)");
            comboFormat.SelectedIndex = 4;
        }
    }
}