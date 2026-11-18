namespace SNGMaker
{
    partial class NumberInputBox
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
            NumericUpDown1 = new NumericUpDown();
            TableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumericUpDown1).BeginInit();
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
            // NumericUpDown1
            // 
            NumericUpDown1.Location = new Point(14, 14);
            NumericUpDown1.Margin = new Padding(4, 3, 4, 3);
            NumericUpDown1.Name = "NumericUpDown1";
            NumericUpDown1.Size = new Size(245, 23);
            NumericUpDown1.TabIndex = 1;
            NumericUpDown1.ThousandsSeparator = true;
            // 
            // NumberInputBox
            // 
            AcceptButton = BtnOk;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = BtnCancel;
            ClientSize = new Size(273, 102);
            Controls.Add(NumericUpDown1);
            Controls.Add(TableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "NumberInputBox";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Nummer auswählen";
            TableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)NumericUpDown1).EndInit();
            ResumeLayout(false);
        }

        private TableLayoutPanel TableLayoutPanel1;
        private Button BtnOk;
        private Button BtnCancel;
        private NumericUpDown NumericUpDown1;
        #endregion
    }
}
