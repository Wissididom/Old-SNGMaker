namespace SNGMaker
{
    public partial class NumberInputBox : Form
    {
        public NumberInputBox()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialog(decimal minVal, decimal increment, decimal maxVal)
        {
            this.NumericUpDown1.Minimum = minVal;
            this.NumericUpDown1.Increment = increment;
            this.NumericUpDown1.DecimalPlaces = increment.ToString().Replace(",", ".").Split('.').Last().Length;
            this.NumericUpDown1.Maximum = maxVal;
            return base.ShowDialog();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
            this.Close();
        }

        public decimal MinVal => this.NumericUpDown1.Minimum;
        public decimal Increment => this.NumericUpDown1.Increment;
        public decimal MaxVal => this.NumericUpDown1.Maximum;
        public decimal Value => this.NumericUpDown1.Value;
    }
}
