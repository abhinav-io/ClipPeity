using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using Clipeity.Properties;

namespace Clipeity
{
    public partial class MainForm : Form
    {
        private const int CommonHeight = 30;
        private const string FilePath = "items.xml";
        private readonly ItemInfoCollection _iic;
        private int _currentIndex;

        public MainForm()
        {
            InitializeComponent();
            _iic = ItemInfoCollection.Load(FilePath);
        }

        private string ButtonName
        {
            get
            {
                string buttonName = Resources.MainFormButtonNamePrefix +
                                    _currentIndex.ToString(CultureInfo.InvariantCulture);
                _currentIndex++;
                return buttonName;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            flpLevel0.Location = new Point(0, 0);
            flpLevel0.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flpLevel0.Dock = DockStyle.None;
            flpLevel0.AutoSize = true;

            foreach (ItemInfo data in _iic)
            {
                AddButton(data);
            }
        }

        private void AddNewItem()
        {
            using (var iif = new ItemInfoForm())
            {
                iif.StartPosition = FormStartPosition.CenterParent;
                if (iif.ShowDialog(this) != DialogResult.Cancel)
                {
                    AddButton(iif.Data);
                    _iic.Add(iif.Data);
                }
            }
        }

        private void AddButton(ItemInfo data)
        {
            var btn = new Button
            {
                AutoSize = true,
                Name = ButtonName,
                Text = data.ButtonLabel,
                Tag = data,
                Height = CommonHeight,
                ContextMenuStrip = cmsForButton,
            };
            //_iic.AddOrUpdate(iif.Data);
            btn.Click += BtnOnClick;
            flpLevel0.Controls.Add(btn);
        }

        private void BtnOnClick(object sender, EventArgs eventArgs)
        {
            var sourceControl = sender as Button;
            if (sourceControl != null)
            {
                var data = sourceControl.Tag as ItemInfo;
                if (data != null)
                {
                    Clipboard.SetText(data.CopyThisToClipboard);
                    fadeOutTimer.EnqueueEffectedButton(sourceControl);
                }
            }
            //Console.WriteLine(sender);
        }

        private void EditItem(Button btn)
        {
            var data = btn.Tag as ItemInfo;
            if (data != null)
            {
                using (var iif = new ItemInfoForm(data))
                {
                    if (iif.ShowDialog(this) != DialogResult.Cancel)
                    {
                        btn.Text = iif.Data.ButtonLabel;
                        //_iic.AddOrUpdate(iif.Data);
                    }
                }
            }
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewItem();
        }

        private void cmsForButton_Opening(object sender, CancelEventArgs e)
        {
            var sourceControl = cmsForButton.SourceControl as Button;
            if (sourceControl != null)
            {
                editToolStripMenuItem.Enabled = true;
                deleteToolStripMenuItem.Enabled = true;
            }
            else
            {
                editToolStripMenuItem.Enabled = false;
                deleteToolStripMenuItem.Enabled = false;
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sourceControl = cmsForButton.SourceControl as Button;
            if (sourceControl != null)
            {
                EditItem(sourceControl);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sourceControl = cmsForButton.SourceControl as Button;
            if (sourceControl != null)
            {
                var data = sourceControl.Tag as ItemInfo;
                if (data != null)
                    _iic.RemoveItem(data);
                flpLevel0.Controls.Remove(sourceControl);
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (fadeOutTimer.Enabled)
                fadeOutTimer.Enabled = false;

            ItemInfoCollection.Save(_iic, FilePath);
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == NativeMethods.WM_SHOWME)
            {
                ShowMe();
            }
            base.WndProc(ref m);
        }

        private void ShowMe()
        {
            if (WindowState == FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Normal;
            }
            // get our current "TopMost" value (ours will always be false though)
            bool top = TopMost;
            // make our form jump to the top of everything
            TopMost = true;
            // set it back to whatever it was
            TopMost = top;
        }
    }
}