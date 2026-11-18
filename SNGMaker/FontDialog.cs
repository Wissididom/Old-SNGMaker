namespace SNGMaker
{
    public partial class FontDialog : Form
    {
        public string Values { get; private set; } = string.Empty;
        public bool HasSize { get; private set; } = false;
        public bool HasHeight { get; private set; } = false;

        public FontDialog()
        {
            InitializeComponent();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            var valueSize = (int)NudFontSize.Value;
            var valueHeight = (int)NudFontHeight.Value;
            Values = $"Size:{valueSize};Height:{valueHeight}";
            HasSize = CbFontSize.Checked;
            HasHeight = CbFontHeight.Checked;
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void CheckedChangedEvents(object sender, EventArgs e)
        {
            if (CbFontSize.Checked)
            {
                LblFontSize.Enabled = true;
                NudFontSize.Enabled = true;
            }
            else
            {
                LblFontSize.Enabled = false;
                NudFontSize.Enabled = false;
            }
            if (CbFontHeight.Checked)
            {
                LblFontHeight.Enabled = true;
                NudFontHeight.Enabled = true;
            }
            else
            {
                LblFontHeight.Enabled = false;
                NudFontHeight.Enabled = false;
            }
        }

        private void FontDialog_Load(object sender, EventArgs e)
        {
            CbFontSize.Checked = true;
            CbFontHeight.Checked = true;
        }
    }
}
