namespace SNGMaker
{
    public class PropertiesControl : UserControl
    {
        public PropertiesControl()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.AutoScaleDimensions = new SizeF(6.0F, 13.0F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Name = "PropertiesControl";
            this.ResumeLayout(false);
        }

        public List<PropertiesControlEntry> Items
        {
            get
            {
                var list = new List<PropertiesControlEntry>();
                var enumerator = this.Controls.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    var control = enumerator.Current as PropertiesControlEntry;
                    if (control is PropertiesControlEntry entry)
                    {
                        list.Add(entry);
                    }
                }
                return list;
            }
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        public void RemoveItemFromList(PropertiesControlEntry sender)
        {
            this.Controls.Remove(sender);
        }

        public PropertiesControlEntry InsertItem(PropertiesControlEntry item)
        {
            item.Dock = DockStyle.Top;
            this.Controls.Add(item);
            return item;
        }

        public void CleanUp()
        {
            //var items = this.Items;
            var enumerator = this.Items.GetEnumerator();
            while (enumerator.MoveNext())
            {
                this.Controls.Remove(enumerator.Current);
            }
        }

        public PropertiesControlEntry GetByProperty(string property)
        {
            //var items = this.Items;
            var enumerator = this.Items.GetEnumerator();
            while (enumerator.MoveNext())
            {
                if (enumerator.Current.Property == property)
                {
                    return enumerator.Current;
                }
            }
            throw new ArgumentException("Die angegebene Eigenschaft ist nicht verfügbar.");
        }
    }
}
