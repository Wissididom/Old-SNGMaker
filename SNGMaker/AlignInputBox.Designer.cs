namespace SNGMaker
{
    partial class AlignInputBox
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
            ComboBox1 = new ComboBox();
            TableLayoutPanel1.SuspendLayout();
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
            TableLayoutPanel1.Location = new Point(89, 54);
            TableLayoutPanel1.Margin = new Padding(4, 3, 4, 3);
            TableLayoutPanel1.Name = "TableLayoutPanel1";
            TableLayoutPanel1.RowCount = 1;
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
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
            // ComboBox1
            // 
            ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBox1.FormattingEnabled = true;
            ComboBox1.Items.AddRange(new object[] { "l", "left", "e", "c", "center", "r", "right", "k", "keep" });
            ComboBox1.Location = new Point(14, 14);
            ComboBox1.Margin = new Padding(4, 3, 4, 3);
            ComboBox1.Name = "ComboBox1";
            ComboBox1.Size = new Size(244, 23);
            ComboBox1.TabIndex = 1;
            // 
            // AlignInputBox
            // 
            AcceptButton = BtnOk;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = BtnCancel;
            ClientSize = new Size(273, 102);
            Controls.Add(ComboBox1);
            Controls.Add(TableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AlignInputBox";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "horizontale Ausrichtung auswählen";
            Load += AlignInputBox_Load;
            TableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TableLayoutPanel1;
        private Button BtnOk;
        private Button BtnCancel;
        private ComboBox ComboBox1;
    }
}
