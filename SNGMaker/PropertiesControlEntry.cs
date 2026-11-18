using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace SNGMaker
{
    public class PropertiesControlEntry : UserControl
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        private Label Label1;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        private NumericCheckTextBox TextBox1;

        public PropertiesControlEntry()
        {
            InitializeComponent();
        }

        public PropertiesControlEntry(string property)
        {
            InitializeComponent();
            Label1.Text = $"{property}:";
        }

        public PropertiesControlEntry(string property, string value)
        {
            InitializeComponent();
            Label1.Text = $"{property}:";
            TextBox1.Text = value;
        }

        public PropertiesControlEntry(string property, bool numeric)
        {
            InitializeComponent();
            Label1.Text = $"{property}:";
            TextBox1.IsNumeric = numeric;
        }

        public PropertiesControlEntry(string property, string value, bool numeric)
        {
            InitializeComponent();
            Label1.Text = $"{property}:";
            TextBox1.Text = value;
            TextBox1.IsNumeric = numeric;
        }

        [MemberNotNull(nameof(Label1), nameof(TextBox1))]
        private void InitializeComponent()
        {
            this.Label1 = new Label();
            this.TextBox1 = new NumericCheckTextBox();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new Font("Courier New", this.Label1.Font.SizeInPoints);
            this.Label1.Location = new System.Drawing.Point(3, 11);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(39, 13);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Label1";
            // 
            // TextBox1
            // 
            this.TextBox1.Anchor = (AnchorStyles)(AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.TextBox1.Font = new Font("Courier New", this.TextBox1.Font.SizeInPoints);
            this.TextBox1.Location = new System.Drawing.Point(138, 8);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(548, 20);
            this.TextBox1.TabIndex = 1;
            // 
            // PropertiesControlEntry
            // 
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.Label1);
            this.Name = "PropertiesControlEntry";
            this.Size = new System.Drawing.Size(689, 34);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Property
        {
            get
            {
                if (Label1.Text.Contains(':'))
                {
                    return Label1.Text.Split(':')[^2];
                }
                return Label1.Text;
            }
            set
            {
                Label1.Text = $"{value}:";
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Value
        {
            get
            {
                return TextBox1.Text;
            }
            set
            {
                TextBox1.Text = value;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsNumeric
        {
            get
            {
                return TextBox1.IsNumeric;
            }
            set
            {
                TextBox1.IsNumeric = value;
            }
        }
    }
}
