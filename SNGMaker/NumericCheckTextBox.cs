using System.ComponentModel;

namespace SNGMaker
{
    public class NumericCheckTextBox : TextBox
    {
        public NumericCheckTextBox(bool numeric = false) : base()
        {
            IsNumeric = numeric;
            this.KeyDown += NumericCheckTextBox_KeyDown;
            this.KeyUp += NumericCheckTextBox_KeyUp;
        }

        private void NumericCheckTextBox_KeyDown(object? sender, KeyEventArgs e)
        {
            if (IsNumeric)
            {
                if (e.KeyCode == Keys.D0 || e.KeyCode == Keys.D1 || e.KeyCode == Keys.D2 || e.KeyCode == Keys.D3 || e.KeyCode == Keys.D4
                    || e.KeyCode == Keys.D5 || e.KeyCode == Keys.D6 || e.KeyCode == Keys.D7 || e.KeyCode == Keys.D8 || e.KeyCode == Keys.D9
                    || e.KeyCode == Keys.NumPad0 || e.KeyCode == Keys.NumPad1 || e.KeyCode == Keys.NumPad2 || e.KeyCode == Keys.NumPad3
                    || e.KeyCode == Keys.NumPad4 || e.KeyCode == Keys.NumPad5 || e.KeyCode == Keys.NumPad6 || e.KeyCode == Keys.NumPad7
                    || e.KeyCode == Keys.NumPad8 || e.KeyCode == Keys.NumPad9 || e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete
                    || e.KeyCode == Keys.Home || e.KeyCode == Keys.End || e.KeyCode == Keys.Insert || e.KeyCode == Keys.Left
                    || e.KeyCode == Keys.Right || e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
                {
                    this.ReadOnly = false;
                }
                else
                {
                    this.ReadOnly = true;
                }
            }
            else
            {
                this.ReadOnly = false;
            }
        }

        private void NumericCheckTextBox_KeyUp(object? sender, KeyEventArgs e)
        {
            this.ReadOnly = false;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsNumeric { get; internal set; } = false;
    }
}
