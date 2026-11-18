using System.Resources;

namespace SNGMaker
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Tc = new TabControl();
            Tp1 = new TabPage();
            Tp2 = new TabPage();
            Tp3 = new TabPage();
            BtnClearAll = new Button();
            BtnCopy = new Button();
            BtnSave = new Button();
            Tp4 = new TabPage();
            PropertiesControl1 = new PropertiesControl();
            FctbSlides = new FastColoredTextBoxNS.FastColoredTextBox();
            FctbFinishedSngFile = new FastColoredTextBoxNS.FastColoredTextBox();
            Ts = new ToolStrip();
            CutToolStripButton = new ToolStripButton();
            CopyToolStripButton = new ToolStripButton();
            PasteToolStripButton = new ToolStripButton();
            UndoToolStripButton = new ToolStripButton();
            RedoToolStripButton = new ToolStripButton();
            BoldToolStripButton = new ToolStripButton();
            ItalicsToolStripButton = new ToolStripButton();
            UnderlineToolStripButton = new ToolStripButton();
            StrikeOutToolStripButton = new ToolStripButton();
            AlignToolStripButton = new ToolStripButton();
            VAlignToolStripButton = new ToolStripButton();
            ColoredTextToolStripButton = new ToolStripButton();
            WordWrapToolStripButton = new ToolStripButton();
            SubscriptToolStripButton = new ToolStripButton();
            SuperscriptToolStripButton = new ToolStripButton();
            LinespacingToolStripButton = new ToolStripButton();
            FontToolStripButton = new ToolStripButton();
            ZeilenZwischenDieOberenZeilenToolStripButton = new ToolStripButton();
            NewLineToolStripButton = new ToolStripButton();
            NewParagraphToolStripButton = new ToolStripButton();
            SprachenAufZweiFolienAufteilenToolStripButton = new ToolStripButton();
            Tc.SuspendLayout();
            Tp3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)FctbSlides).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FctbFinishedSngFile).BeginInit();
            Ts.SuspendLayout();
            SuspendLayout();
            // 
            // Tc
            // 
            Tc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Tc.Controls.Add(Tp1);
            Tc.Controls.Add(Tp2);
            Tc.Controls.Add(Tp3);
            Tc.Controls.Add(Tp4);
            Tc.Location = new Point(0, 30);
            Tc.Margin = new Padding(4, 3, 4, 3);
            Tc.Name = "Tc";
            Tc.SelectedIndex = 0;
            Tc.Size = new Size(950, 633);
            Tc.TabIndex = 0;
            Tc.SelectedIndexChanged += Tc_SelectedIndexChanged;
            // 
            // Tp1
            // 
            Tp1.AutoScroll = true;
            Tp1.Controls.Add(PropertiesControl1);
            Tp1.Location = new Point(4, 24);
            Tp1.Margin = new Padding(4, 3, 4, 3);
            Tp1.Name = "Tp1";
            Tp1.Padding = new Padding(4, 3, 4, 3);
            Tp1.Size = new Size(942, 605);
            Tp1.TabIndex = 0;
            Tp1.Text = "Eigenschaften";
            Tp1.UseVisualStyleBackColor = true;
            // 
            // Tp2
            // 
            Tp2.Controls.Add(FctbSlides);
            Tp2.Location = new Point(4, 24);
            Tp2.Margin = new Padding(4, 3, 4, 3);
            Tp2.Name = "Tp2";
            Tp2.Padding = new Padding(4, 3, 4, 3);
            Tp2.Size = new Size(942, 605);
            Tp2.TabIndex = 1;
            Tp2.Text = "Folien";
            Tp2.UseVisualStyleBackColor = true;
            // 
            // Tp3
            // 
            Tp3.Controls.Add(BtnClearAll);
            Tp3.Controls.Add(BtnCopy);
            Tp3.Controls.Add(BtnSave);
            Tp3.Controls.Add(FctbFinishedSngFile);
            Tp3.Location = new Point(4, 24);
            Tp3.Margin = new Padding(4, 3, 4, 3);
            Tp3.Name = "Tp3";
            Tp3.Size = new Size(942, 605);
            Tp3.TabIndex = 2;
            Tp3.Text = "fertige SNG-Datei";
            Tp3.UseVisualStyleBackColor = true;
            // 
            // Tp4
            // 
            Tp4.Location = new Point(4, 24);
            Tp4.Margin = new Padding(4, 3, 4, 3);
            Tp4.Name = "Tp4";
            Tp4.Size = new Size(942, 605);
            Tp4.TabIndex = 3;
            Tp4.Text = "SNG-Datei öffnen";
            Tp4.UseVisualStyleBackColor = true;
            // 
            // BtnClearAll
            // 
            BtnClearAll.Location = new Point(612, 573);
            BtnClearAll.Margin = new Padding(4, 3, 4, 3);
            BtnClearAll.Name = "BtnClearAll";
            BtnClearAll.Size = new Size(88, 27);
            BtnClearAll.TabIndex = 3;
            BtnClearAll.Text = "alles leeren";
            BtnClearAll.UseVisualStyleBackColor = true;
            BtnClearAll.Click += BtnClearAll_Click;
            // 
            // BtnCopy
            // 
            BtnCopy.Location = new Point(707, 573);
            BtnCopy.Margin = new Padding(4, 3, 4, 3);
            BtnCopy.Name = "BtnCopy";
            BtnCopy.Size = new Size(88, 27);
            BtnCopy.TabIndex = 2;
            BtnCopy.Text = "kopieren";
            BtnCopy.UseVisualStyleBackColor = true;
            BtnCopy.Click += BtnCopy_Click;
            // 
            // BtnSave
            // 
            BtnSave.Location = new Point(811, 573);
            BtnSave.Margin = new Padding(4, 3, 4, 3);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(88, 27);
            BtnSave.TabIndex = 1;
            BtnSave.Text = "speichern";
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click;
            // 
            // PropertiesControl1
            // 
            PropertiesControl1.AutoScroll = true;
            PropertiesControl1.Dock = DockStyle.Fill;
            PropertiesControl1.Location = new Point(4, 3);
            PropertiesControl1.Margin = new Padding(5, 3, 5, 3);
            PropertiesControl1.Name = "PropertiesControl1";
            PropertiesControl1.Size = new Size(934, 599);
            PropertiesControl1.TabIndex = 0;
            // 
            // FctbSlides
            // 
            FctbSlides.AllowMacroRecording = false;
            FctbSlides.AutoCompleteBrackets = true;
            FctbSlides.AutoIndentChars = false;
            FctbSlides.AutoIndentCharsPatterns = "^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;=]+);\n^\\s*(case|default)\\s*[^:]*(?<range>:)\\s*(?<range>[^;]+);";
            FctbSlides.Cursor = Cursors.IBeam;
            FctbSlides.DefaultMarkerSize = 8;
            FctbSlides.DisabledColor = Color.FromArgb(100, 180, 180, 180);
            FctbSlides.Dock = DockStyle.Fill;
            FctbSlides.Font = new Font("Courier New", 9.75F);
            FctbSlides.Hotkeys = resources.GetString("FctbSlides.Hotkeys");
            FctbSlides.Location = new Point(4, 3);
            FctbSlides.Margin = new Padding(4, 3, 4, 3);
            FctbSlides.Name = "FctbSlides";
            FctbSlides.SelectionColor = Color.FromArgb(60, 0, 0, 255);
            FctbSlides.Size = new Size(934, 599);
            FctbSlides.TabIndex = 0;
            FctbSlides.TextChangedDelayed += TextChangedDelayed;
            // 
            // FctbFinishedSngFile
            // 
            FctbFinishedSngFile.AllowMacroRecording = false;
            FctbFinishedSngFile.AllowSeveralTextStyleDrawing = true;
            FctbFinishedSngFile.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            FctbFinishedSngFile.AutoCompleteBrackets = true;
            FctbFinishedSngFile.AutoIndent = false;
            FctbFinishedSngFile.AutoIndentChars = false;
            FctbFinishedSngFile.AutoIndentCharsPatterns = "^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;=]+);\n^\\s*(case|default)\\s*[^:]*(?<range>:)\\s*(?<range>[^;]+);";
            FctbFinishedSngFile.CommentPrefix = "";
            FctbFinishedSngFile.Cursor = Cursors.IBeam;
            FctbFinishedSngFile.DefaultMarkerSize = 8;
            FctbFinishedSngFile.DisabledColor = Color.FromArgb(100, 180, 180, 180);
            FctbFinishedSngFile.Font = new Font("Courier New", 9.75F);
            FctbFinishedSngFile.HighlightFoldingIndicator = false;
            FctbFinishedSngFile.Hotkeys = resources.GetString("FctbFinishedSngFile.Hotkeys");
            FctbFinishedSngFile.Location = new Point(0, 0);
            FctbFinishedSngFile.Margin = new Padding(4, 3, 4, 3);
            FctbFinishedSngFile.Name = "FctbFinishedSngFile";
            FctbFinishedSngFile.SelectionColor = Color.FromArgb(60, 0, 0, 255);
            FctbFinishedSngFile.ShowFoldingLines = true;
            FctbFinishedSngFile.Size = new Size(940, 550);
            FctbFinishedSngFile.TabIndex = 0;
            FctbFinishedSngFile.WordWrapAutoIndent = false;
            FctbFinishedSngFile.TextChangedDelayed += TextChangedDelayed;
            // 
            // Ts
            // 
            Ts.GripStyle = ToolStripGripStyle.Hidden;
            Ts.Items.AddRange(new ToolStripItem[] { CutToolStripButton, CopyToolStripButton, PasteToolStripButton, UndoToolStripButton, RedoToolStripButton, BoldToolStripButton, ItalicsToolStripButton, UnderlineToolStripButton, StrikeOutToolStripButton, AlignToolStripButton, VAlignToolStripButton, ColoredTextToolStripButton, WordWrapToolStripButton, SubscriptToolStripButton, SuperscriptToolStripButton, LinespacingToolStripButton, FontToolStripButton, ZeilenZwischenDieOberenZeilenToolStripButton, NewLineToolStripButton, NewParagraphToolStripButton, SprachenAufZweiFolienAufteilenToolStripButton });
            Ts.Location = new Point(0, 0);
            Ts.Name = "Ts";
            Ts.Size = new Size(950, 29);
            Ts.TabIndex = 1;
            Ts.Text = "Ts";
            Ts.Visible = false;
            // 
            // CutToolStripButton
            // 
            CutToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            CutToolStripButton.ImageTransparentColor = Color.Magenta;
            CutToolStripButton.Name = "CutToolStripButton";
            CutToolStripButton.Size = new Size(23, 26);
            CutToolStripButton.Text = "Ausschneiden";
            CutToolStripButton.Click += CutToolStripButton_Click;
            // 
            // CopyToolStripButton
            // 
            CopyToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            CopyToolStripButton.ImageTransparentColor = Color.Magenta;
            CopyToolStripButton.Name = "CopyToolStripButton";
            CopyToolStripButton.Size = new Size(23, 26);
            CopyToolStripButton.Text = "Kopieren";
            CopyToolStripButton.Click += CopyToolStripButton_Click;
            // 
            // PasteToolStripButton
            // 
            PasteToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            PasteToolStripButton.ImageTransparentColor = Color.Magenta;
            PasteToolStripButton.Name = "PasteToolStripButton";
            PasteToolStripButton.Size = new Size(23, 26);
            PasteToolStripButton.Text = "Inhalt der Zwischenablage einfügen";
            PasteToolStripButton.Click += PasteToolStripButton_Click;
            // 
            // UndoToolStripButton
            // 
            UndoToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            UndoToolStripButton.Enabled = false;
            UndoToolStripButton.ImageTransparentColor = Color.Magenta;
            UndoToolStripButton.Name = "UndoToolStripButton";
            UndoToolStripButton.Size = new Size(23, 26);
            UndoToolStripButton.Text = "Rückgängig";
            UndoToolStripButton.Click += UndoToolStripButton_Click;
            // 
            // RedoToolStripButton
            // 
            RedoToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            RedoToolStripButton.Enabled = false;
            RedoToolStripButton.ImageTransparentColor = Color.Magenta;
            RedoToolStripButton.Name = "RedoToolStripButton";
            RedoToolStripButton.Size = new Size(23, 26);
            RedoToolStripButton.Text = "Wiederherstellen";
            RedoToolStripButton.Click += RedoToolStripButton_Click;
            // 
            // BoldToolStripButton
            // 
            BoldToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            BoldToolStripButton.ImageTransparentColor = Color.Magenta;
            BoldToolStripButton.Name = "BoldToolStripButton";
            BoldToolStripButton.Size = new Size(23, 26);
            BoldToolStripButton.Text = "Fett";
            BoldToolStripButton.Click += BoldToolStripButton_Click;
            // 
            // ItalicsToolStripButton
            // 
            ItalicsToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ItalicsToolStripButton.ImageTransparentColor = Color.Magenta;
            ItalicsToolStripButton.Name = "ItalicsToolStripButton";
            ItalicsToolStripButton.Size = new Size(23, 26);
            ItalicsToolStripButton.Text = "Kursiv";
            ItalicsToolStripButton.Click += ItalicsToolStripButton_Click;
            // 
            // UnderlineToolStripButton
            // 
            UnderlineToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            UnderlineToolStripButton.ImageTransparentColor = Color.Magenta;
            UnderlineToolStripButton.Name = "UnderlineToolStripButton";
            UnderlineToolStripButton.Size = new Size(23, 26);
            UnderlineToolStripButton.Text = "Unterstrichen";
            UnderlineToolStripButton.Click += UnderlineToolStripButton_Click;
            // 
            // StrikeOutToolStripButton
            // 
            StrikeOutToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            StrikeOutToolStripButton.ImageTransparentColor = Color.Magenta;
            StrikeOutToolStripButton.Name = "StrikeOutToolStripButton";
            StrikeOutToolStripButton.Size = new Size(23, 26);
            StrikeOutToolStripButton.Text = "Durchgestrichen";
            StrikeOutToolStripButton.Click += StrikeOutToolStripButton_Click;
            // 
            // AlignToolStripButton
            // 
            AlignToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            AlignToolStripButton.Name = "AlignToolStripButton";
            AlignToolStripButton.Size = new Size(23, 26);
            AlignToolStripButton.Text = "horizontale Ausrichtung";
            AlignToolStripButton.Click += AlignToolStripButton_Click;
            // 
            // VAlignToolStripButton
            // 
            VAlignToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            VAlignToolStripButton.Name = "VAlignToolStripButton";
            VAlignToolStripButton.Size = new Size(23, 26);
            VAlignToolStripButton.Text = "vertikale Ausrichtung";
            VAlignToolStripButton.Click += VAlignToolStripButton_Click;
            // 
            // ColoredTextToolStripButton
            // 
            ColoredTextToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ColoredTextToolStripButton.Name = "ColoredTextToolStripButton";
            ColoredTextToolStripButton.Size = new Size(23, 26);
            ColoredTextToolStripButton.Text = "farblich markieren";
            ColoredTextToolStripButton.Click += ColoredTextToolStripButton_Click;
            // 
            // WordWrapToolStripButton
            // 
            WordWrapToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            WordWrapToolStripButton.Name = "WordWrapToolStripButton";
            WordWrapToolStripButton.Size = new Size(23, 26);
            WordWrapToolStripButton.Text = "automatischer Zeilenumbruch";
            WordWrapToolStripButton.Click += WordWrapToolStripButton_Click;
            // 
            // SubscriptToolStripButton
            // 
            SubscriptToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            SubscriptToolStripButton.Name = "SubscriptToolStripButton";
            SubscriptToolStripButton.Size = new Size(23, 26);
            SubscriptToolStripButton.Text = "tiefgestellt";
            SubscriptToolStripButton.Click += SubscriptToolStripButton_Click;
            // 
            // SuperscriptToolStripButton
            // 
            SuperscriptToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            SuperscriptToolStripButton.Name = "SuperscriptToolStripButton";
            SuperscriptToolStripButton.Size = new Size(23, 26);
            SuperscriptToolStripButton.Text = "hochgestellt";
            SuperscriptToolStripButton.Click += SuperscriptToolStripButton_Click;
            // 
            // LinespacingToolStripButton
            // 
            LinespacingToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            LinespacingToolStripButton.Name = "LinespacingToolStripButton";
            LinespacingToolStripButton.Size = new Size(23, 26);
            LinespacingToolStripButton.Text = "Zeilenabstand (Standard = 1.0)";
            LinespacingToolStripButton.Click += LinespacingToolStripButton_Click;
            // 
            // FontToolStripButton
            // 
            FontToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            FontToolStripButton.ImageTransparentColor = Color.Magenta;
            FontToolStripButton.Name = "FontToolStripButton";
            FontToolStripButton.Size = new Size(59, 26);
            FontToolStripButton.Text = "Schriftart";
            FontToolStripButton.Click += FontToolStripButton_Click;
            // 
            // ZeilenZwischenDieOberenZeilenToolStripButton
            // 
            ZeilenZwischenDieOberenZeilenToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ZeilenZwischenDieOberenZeilenToolStripButton.ImageTransparentColor = Color.Magenta;
            ZeilenZwischenDieOberenZeilenToolStripButton.Name = "ZeilenZwischenDieOberenZeilenToolStripButton";
            ZeilenZwischenDieOberenZeilenToolStripButton.Size = new Size(23, 26);
            ZeilenZwischenDieOberenZeilenToolStripButton.Text = "Zeilen zwischen die oberen Zeilen";
            ZeilenZwischenDieOberenZeilenToolStripButton.Click += ZeilenZwischenDieOberenZeilenToolStripButton_Click;
            // 
            // NewLineToolStripButton
            // 
            NewLineToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            NewLineToolStripButton.ImageTransparentColor = Color.Magenta;
            NewLineToolStripButton.Name = "NewLineToolStripButton";
            NewLineToolStripButton.Size = new Size(23, 26);
            NewLineToolStripButton.Text = "neue Zeile";
            NewLineToolStripButton.Click += NewLineToolStripButton_Click;
            // 
            // NewParagraphToolStripButton
            // 
            NewParagraphToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            NewParagraphToolStripButton.ImageTransparentColor = Color.Magenta;
            NewParagraphToolStripButton.Name = "NewParagraphToolStripButton";
            NewParagraphToolStripButton.Size = new Size(23, 26);
            NewParagraphToolStripButton.Text = "neuer Absatz";
            NewParagraphToolStripButton.Click += NewParagraphToolStripButton_Click;
            // 
            // SprachenAufZweiFolienAufteilenToolStripButton
            // 
            SprachenAufZweiFolienAufteilenToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            SprachenAufZweiFolienAufteilenToolStripButton.ImageTransparentColor = Color.Magenta;
            SprachenAufZweiFolienAufteilenToolStripButton.Name = "SprachenAufZweiFolienAufteilenToolStripButton";
            SprachenAufZweiFolienAufteilenToolStripButton.Size = new Size(23, 26);
            SprachenAufZweiFolienAufteilenToolStripButton.Text = "Sprachen auf zwei Folien aufteilen";
            SprachenAufZweiFolienAufteilenToolStripButton.Click += SprachenAufZweiFolienAufteilenToolStripButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 662);
            Controls.Add(Ts);
            Controls.Add(Tc);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SNGMaker";
            Load += MainForm_Load;
            Tc.ResumeLayout(false);
            Tp3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)FctbSlides).EndInit();
            ((System.ComponentModel.ISupportInitialize)FctbFinishedSngFile).EndInit();
            Ts.ResumeLayout(false);
            Ts.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private TabControl Tc;
        private TabPage Tp1;
        private TabPage Tp2;
        private TabPage Tp3;
        private TabPage Tp4;
        private FastColoredTextBoxNS.FastColoredTextBox FctbSlides;
        private FastColoredTextBoxNS.FastColoredTextBox FctbFinishedSngFile;
        private ToolStrip Ts;
        private ToolStripButton CutToolStripButton;
        private ToolStripButton CopyToolStripButton;
        private ToolStripButton PasteToolStripButton;
        private ToolStripButton UndoToolStripButton;
        private ToolStripButton RedoToolStripButton;
        private ToolStripButton BoldToolStripButton;
        private ToolStripButton ItalicsToolStripButton;
        private ToolStripButton UnderlineToolStripButton;
        private ToolStripButton StrikeOutToolStripButton;
        private ToolStripButton AlignToolStripButton;
        private ToolStripButton VAlignToolStripButton;
        private ToolStripButton ColoredTextToolStripButton;
        private ToolStripButton WordWrapToolStripButton;
        private ToolStripButton SubscriptToolStripButton;
        private ToolStripButton SuperscriptToolStripButton;
        private ToolStripButton LinespacingToolStripButton;
        private ToolStripButton FontToolStripButton;
        private ToolStripButton ZeilenZwischenDieOberenZeilenToolStripButton;
        private ToolStripButton NewLineToolStripButton;
        private ToolStripButton SprachenAufZweiFolienAufteilenToolStripButton;
        private ToolStripButton NewParagraphToolStripButton;
        private Button BtnClearAll;
        private Button BtnCopy;
        private Button BtnSave;
        private PropertiesControl PropertiesControl1;
        #endregion
    }
}
