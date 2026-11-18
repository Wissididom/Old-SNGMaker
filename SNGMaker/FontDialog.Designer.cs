namespace SNGMaker
{
    partial class FontDialog
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
            TableLayoutPanel1 = new TableLayoutPanel();
            BtnOk = new Button();
            BtnCancel = new Button();
            LblFontSize = new Label();
            NudFontSize = new NumericUpDown();
            LblFontHeight = new Label();
            NudFontHeight = new NumericUpDown();
            CbFontSize = new CheckBox();
            CbFontHeight = new CheckBox();
            TableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NudFontSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudFontHeight).BeginInit();
            SuspendLayout();
            // 
            // TableLayoutPanel1
            // 
            TableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            TableLayoutPanel1.ColumnCount = 2;
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TableLayoutPanel1.Controls.Add(BtnOk, 0, 0);
            TableLayoutPanel1.Controls.Add(BtnCancel, 1, 0);
            TableLayoutPanel1.Location = new Point(57, 149);
            TableLayoutPanel1.Margin = new Padding(4, 3, 4, 3);
            TableLayoutPanel1.Name = "TableLayoutPanel1";
            TableLayoutPanel1.RowCount = 1;
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TableLayoutPanel1.Size = new Size(170, 33);
            TableLayoutPanel1.TabIndex = 0;
            // 
            // BtnOk
            // 
            BtnOk.Anchor = AnchorStyles.None;
            BtnOk.Location = new Point(4, 3);
            BtnOk.Margin = new Padding(4, 3, 4, 3);
            BtnOk.Name = "BtnOk";
            BtnOk.Size = new Size(77, 27);
            BtnOk.TabIndex = 0;
            BtnOk.Text = "OK";
            BtnOk.Click += BtnOk_Click;
            // 
            // BtnCancel
            // 
            BtnCancel.Anchor = AnchorStyles.None;
            BtnCancel.DialogResult = DialogResult.Cancel;
            BtnCancel.Location = new Point(89, 3);
            BtnCancel.Margin = new Padding(4, 3, 4, 3);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(77, 27);
            BtnCancel.TabIndex = 1;
            BtnCancel.Text = "Abbrechen";
            BtnCancel.Click += BtnCancel_Click;
            // 
            // LblFontSize
            // 
            LblFontSize.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            LblFontSize.AutoSize = true;
            LblFontSize.Location = new Point(14, 87);
            LblFontSize.Margin = new Padding(4, 0, 4, 0);
            LblFontSize.Name = "LblFontSize";
            LblFontSize.Size = new Size(75, 15);
            LblFontSize.TabIndex = 2;
            LblFontSize.Text = "Schriftgröße:";
            // 
            // NudFontSize
            // 
            NudFontSize.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            NudFontSize.Location = new Point(146, 83);
            NudFontSize.Margin = new Padding(4, 3, 4, 3);
            NudFontSize.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NudFontSize.Name = "NudFontSize";
            NudFontSize.Size = new Size(82, 23);
            NudFontSize.TabIndex = 3;
            NudFontSize.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // LblFontHeight
            // 
            LblFontHeight.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            LblFontHeight.AutoSize = true;
            LblFontHeight.Location = new Point(14, 117);
            LblFontHeight.Margin = new Padding(4, 0, 4, 0);
            LblFontHeight.Name = "LblFontHeight";
            LblFontHeight.Size = new Size(119, 15);
            LblFontHeight.TabIndex = 5;
            LblFontHeight.Text = "Schrifthöhe (in Pixel):";
            // 
            // NudFontHeight
            // 
            NudFontHeight.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            NudFontHeight.Location = new Point(146, 114);
            NudFontHeight.Margin = new Padding(4, 3, 4, 3);
            NudFontHeight.Maximum = new decimal(new int[] { 1024, 0, 0, 0 });
            NudFontHeight.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NudFontHeight.Name = "NudFontHeight";
            NudFontHeight.Size = new Size(82, 23);
            NudFontHeight.TabIndex = 6;
            NudFontHeight.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // CbFontSize
            // 
            CbFontSize.AutoSize = true;
            CbFontSize.Location = new Point(14, 14);
            CbFontSize.Margin = new Padding(4, 3, 4, 3);
            CbFontSize.Name = "CbFontSize";
            CbFontSize.Size = new Size(141, 19);
            CbFontSize.TabIndex = 7;
            CbFontSize.Text = "Schriftgröße einfügen";
            CbFontSize.UseVisualStyleBackColor = true;
            CbFontSize.CheckedChanged += CheckedChangedEvents;
            // 
            // CbFontHeight
            // 
            CbFontHeight.AutoSize = true;
            CbFontHeight.Location = new Point(14, 40);
            CbFontHeight.Margin = new Padding(4, 3, 4, 3);
            CbFontHeight.Name = "CbFontHeight";
            CbFontHeight.Size = new Size(137, 19);
            CbFontHeight.TabIndex = 8;
            CbFontHeight.Text = "Schrifthöhe einfügen";
            CbFontHeight.UseVisualStyleBackColor = true;
            CbFontHeight.CheckedChanged += CheckedChangedEvents;
            // 
            // FontDialog
            // 
            AcceptButton = BtnOk;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = BtnCancel;
            ClientSize = new Size(241, 196);
            Controls.Add(CbFontHeight);
            Controls.Add(CbFontSize);
            Controls.Add(NudFontHeight);
            Controls.Add(LblFontHeight);
            Controls.Add(NudFontSize);
            Controls.Add(LblFontSize);
            Controls.Add(TableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FontDialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Schrift auswählen";
            Load += FontDialog_Load;
            TableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)NudFontSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudFontHeight).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel TableLayoutPanel1;
        private Button BtnOk;
        private Button BtnCancel;
        private Label LblFontSize;
        private NumericUpDown NudFontSize;
        private Label LblFontHeight;
        private NumericUpDown NudFontHeight;
        private CheckBox CbFontSize;
        private CheckBox CbFontHeight;
    }
}
