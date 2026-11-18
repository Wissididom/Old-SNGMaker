namespace SNGMaker
{
    partial class Linespacing
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
            Nud1 = new NumericUpDown();
            Label1 = new Label();
            Nud2 = new NumericUpDown();
            TableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Nud1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Nud2).BeginInit();
            SuspendLayout();
            // 
            // TableLayoutPanel1
            // 
            TableLayoutPanel1.Anchor = AnchorStyles.Bottom;
            TableLayoutPanel1.ColumnCount = 2;
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TableLayoutPanel1.Controls.Add(BtnOk, 0, 0);
            TableLayoutPanel1.Controls.Add(BtnCancel, 1, 0);
            TableLayoutPanel1.Location = new Point(18, 53);
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
            // Nud1
            // 
            Nud1.Location = new Point(14, 14);
            Nud1.Margin = new Padding(4, 3, 4, 3);
            Nud1.Maximum = new decimal(new int[] { 9, 0, 0, 0 });
            Nud1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            Nud1.Name = "Nud1";
            Nud1.Size = new Size(85, 23);
            Nud1.TabIndex = 1;
            Nud1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.BackColor = SystemColors.Control;
            Label1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            Label1.Location = new Point(97, 14);
            Label1.Margin = new Padding(4, 0, 4, 0);
            Label1.Name = "Label1";
            Label1.Size = new Size(13, 17);
            Label1.TabIndex = 2;
            Label1.Text = ".";
            // 
            // Nud2
            // 
            Nud2.Location = new Point(108, 14);
            Nud2.Margin = new Padding(4, 3, 4, 3);
            Nud2.Name = "Nud2";
            Nud2.Size = new Size(84, 23);
            Nud2.TabIndex = 3;
            // 
            // Linespacing
            // 
            AcceptButton = BtnOk;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = BtnCancel;
            ClientSize = new Size(206, 100);
            Controls.Add(Nud2);
            Controls.Add(Nud1);
            Controls.Add(TableLayoutPanel1);
            Controls.Add(Label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Linespacing";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Zeilenabstand";
            FormClosing += Linespacing_FormClosing;
            TableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Nud1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Nud2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel TableLayoutPanel1;
        private Button BtnOk;
        private Button BtnCancel;
        private NumericUpDown Nud1;
        private Label Label1;
        private NumericUpDown Nud2;
    }
}
