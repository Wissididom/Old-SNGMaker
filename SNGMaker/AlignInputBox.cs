namespace SNGMaker
{
    public partial class AlignInputBox : Form
    {
        public AlignInputBox()
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

        private void AlignInputBox_Load(object sender, EventArgs e)
        {
            this.ComboBox1.SelectedIndex = 0;
        }

        public string? Value => this.ComboBox1.SelectedItem?.ToString();
    }
}
