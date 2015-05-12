namespace Clipeity
{
    partial class ItemInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemInfoForm));
            this.lblButtonLabel = new System.Windows.Forms.Label();
            this.tbButtonLabel = new System.Windows.Forms.TextBox();
            this.lblCopyThistoClipBoard = new System.Windows.Forms.Label();
            this.tpLevel0 = new System.Windows.Forms.TableLayoutPanel();
            this.tbCopyThistoClipBoard = new System.Windows.Forms.TextBox();
            this.tpLevel10 = new System.Windows.Forms.TableLayoutPanel();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tpLevel0.SuspendLayout();
            this.tpLevel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblButtonLabel
            // 
            this.lblButtonLabel.AutoSize = true;
            this.lblButtonLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblButtonLabel.Location = new System.Drawing.Point(3, 0);
            this.lblButtonLabel.Name = "lblButtonLabel";
            this.lblButtonLabel.Size = new System.Drawing.Size(164, 30);
            this.lblButtonLabel.TabIndex = 0;
            this.lblButtonLabel.Text = "Button Label (20 chars)";
            this.lblButtonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbButtonLabel
            // 
            this.tbButtonLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbButtonLabel.Location = new System.Drawing.Point(173, 4);
            this.tbButtonLabel.MaxLength = 20;
            this.tbButtonLabel.Name = "tbButtonLabel";
            this.tbButtonLabel.Size = new System.Drawing.Size(273, 22);
            this.tbButtonLabel.TabIndex = 1;
            // 
            // lblCopyThistoClipBoard
            // 
            this.lblCopyThistoClipBoard.AutoSize = true;
            this.lblCopyThistoClipBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCopyThistoClipBoard.Location = new System.Drawing.Point(3, 30);
            this.lblCopyThistoClipBoard.Name = "lblCopyThistoClipBoard";
            this.lblCopyThistoClipBoard.Size = new System.Drawing.Size(164, 30);
            this.lblCopyThistoClipBoard.TabIndex = 2;
            this.lblCopyThistoClipBoard.Text = "Copy This to ClipBoard";
            this.lblCopyThistoClipBoard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tpLevel0
            // 
            this.tpLevel0.ColumnCount = 2;
            this.tpLevel0.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38F));
            this.tpLevel0.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62F));
            this.tpLevel0.Controls.Add(this.lblButtonLabel, 0, 0);
            this.tpLevel0.Controls.Add(this.lblCopyThistoClipBoard, 0, 1);
            this.tpLevel0.Controls.Add(this.tbButtonLabel, 1, 0);
            this.tpLevel0.Controls.Add(this.tbCopyThistoClipBoard, 1, 1);
            this.tpLevel0.Controls.Add(this.tpLevel10, 0, 2);
            this.tpLevel0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpLevel0.Location = new System.Drawing.Point(0, 0);
            this.tpLevel0.Name = "tpLevel0";
            this.tpLevel0.RowCount = 3;
            this.tpLevel0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tpLevel0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tpLevel0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpLevel0.Size = new System.Drawing.Size(449, 110);
            this.tpLevel0.TabIndex = 3;
            // 
            // tbCopyThistoClipBoard
            // 
            this.tbCopyThistoClipBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCopyThistoClipBoard.Location = new System.Drawing.Point(173, 34);
            this.tbCopyThistoClipBoard.Name = "tbCopyThistoClipBoard";
            this.tbCopyThistoClipBoard.Size = new System.Drawing.Size(273, 22);
            this.tbCopyThistoClipBoard.TabIndex = 3;
            // 
            // tpLevel10
            // 
            this.tpLevel10.ColumnCount = 2;
            this.tpLevel0.SetColumnSpan(this.tpLevel10, 2);
            this.tpLevel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tpLevel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tpLevel10.Controls.Add(this.btnOK, 0, 0);
            this.tpLevel10.Controls.Add(this.btnCancel, 1, 0);
            this.tpLevel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpLevel10.Location = new System.Drawing.Point(3, 63);
            this.tpLevel10.Name = "tpLevel10";
            this.tpLevel10.RowCount = 1;
            this.tpLevel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpLevel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpLevel10.Size = new System.Drawing.Size(443, 44);
            this.tpLevel10.TabIndex = 4;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOK.Location = new System.Drawing.Point(73, 5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 34);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(294, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 34);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // ItemInfoForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(449, 110);
            this.Controls.Add(this.tpLevel0);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ItemInfoForm";
            this.Text = "ItemInfoForm";
            this.Load += new System.EventHandler(this.ItemInfoForm_Load);
            this.tpLevel0.ResumeLayout(false);
            this.tpLevel0.PerformLayout();
            this.tpLevel10.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblButtonLabel;
        private System.Windows.Forms.TextBox tbButtonLabel;
        private System.Windows.Forms.Label lblCopyThistoClipBoard;
        private System.Windows.Forms.TableLayoutPanel tpLevel0;
        private System.Windows.Forms.TextBox tbCopyThistoClipBoard;
        private System.Windows.Forms.TableLayoutPanel tpLevel10;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}