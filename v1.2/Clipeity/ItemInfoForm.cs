using System;
using System.Windows.Forms;

namespace Clipeity
{
    public enum ItemInfoFormMode
    {
        AddNew,
        Edit
    }

    public partial class ItemInfoForm : Form
    {
        public ItemInfoForm()
        {
            InitializeComponent();
            Mode = ItemInfoFormMode.AddNew;
            Data = new ItemInfo();
        }

        public ItemInfoForm(ItemInfo data)
        {
            InitializeComponent();
            Mode = ItemInfoFormMode.Edit;
            Data = data;
        }

        public ItemInfoFormMode Mode { get; set; }
        public ItemInfo Data { get; set; }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Data.ButtonLabel = tbButtonLabel.Text;
            Data.CopyThisToClipboard = tbCopyThistoClipBoard.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void ItemInfoForm_Load(object sender, EventArgs e)
        {
            switch (Mode)
            {
                case ItemInfoFormMode.AddNew:
                    Text = "Add new item";
                    tbButtonLabel.Text = string.Empty;
                    tbCopyThistoClipBoard.Text = string.Empty;
                    tbButtonLabel.Focus();
                    break;
                case ItemInfoFormMode.Edit:
                    Text = "Edit item";
                    tbButtonLabel.Text = Data.ButtonLabel;
                    tbCopyThistoClipBoard.Text = Data.CopyThisToClipboard;
                    tbButtonLabel.Focus();
                    break;
            }
        }
    }
}