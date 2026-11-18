namespace SNGMaker
{
    public partial class Linespacing : Form
    {
        public string Nud1Value => Nud1.Value.ToString();
        public string Nud2Value => Nud2.Value.ToString();

        public Linespacing()
        {
            InitializeComponent();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Linespacing_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
