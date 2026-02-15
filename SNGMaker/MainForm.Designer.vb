<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.tc = New System.Windows.Forms.TabControl()
        Me.tp1 = New System.Windows.Forms.TabPage()
        Me.PropertiesControl1 = New SNGMaker.PropertiesControl()
        Me.tp2 = New System.Windows.Forms.TabPage()
        Me.fctb_slides = New FastColoredTextBoxNS.FastColoredTextBox()
        Me.tp3 = New System.Windows.Forms.TabPage()
        Me.btn_clear_all = New System.Windows.Forms.Button()
        Me.btn_copy = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.fctb_finished_sng_file = New FastColoredTextBoxNS.FastColoredTextBox()
        Me.ts = New System.Windows.Forms.ToolStrip()
        Me.CutToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.CopyToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PasteToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.UndoToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.RedoToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.BoldToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ItalicsToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.UnderlineToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.StrikeOutToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.AlignToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.VAlignToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ColoredTextToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.WordWrapToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.SubscriptToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.SuperscriptToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.LinespacingToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.FontToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ZeilenZwischenDieOberenZeilenToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.NewLineToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.NewParagraphToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.SprachenAufZweiFolienAufteilenToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.tp4 = New System.Windows.Forms.TabPage()
        Me.tc.SuspendLayout()
        Me.tp1.SuspendLayout()
        Me.tp2.SuspendLayout()
        CType(Me.fctb_slides, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tp3.SuspendLayout()
        CType(Me.fctb_finished_sng_file, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ts.SuspendLayout()
        Me.SuspendLayout()
        '
        'tc
        '
        Me.tc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tc.Controls.Add(Me.tp1)
        Me.tc.Controls.Add(Me.tp2)
        Me.tc.Controls.Add(Me.tp3)
        Me.tc.Controls.Add(Me.tp4)
        Me.tc.Location = New System.Drawing.Point(0, 26)
        Me.tc.Name = "tc"
        Me.tc.SelectedIndex = 0
        Me.tc.Size = New System.Drawing.Size(814, 549)
        Me.tc.TabIndex = 0
        '
        'tp1
        '
        Me.tp1.AutoScroll = True
        Me.tp1.Controls.Add(Me.PropertiesControl1)
        Me.tp1.Location = New System.Drawing.Point(4, 22)
        Me.tp1.Name = "tp1"
        Me.tp1.Padding = New System.Windows.Forms.Padding(3)
        Me.tp1.Size = New System.Drawing.Size(806, 523)
        Me.tp1.TabIndex = 0
        Me.tp1.Text = "Eigenschaften"
        Me.tp1.UseVisualStyleBackColor = True
        '
        'PropertiesControl1
        '
        Me.PropertiesControl1.AutoScroll = True
        Me.PropertiesControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PropertiesControl1.Location = New System.Drawing.Point(3, 3)
        Me.PropertiesControl1.Name = "PropertiesControl1"
        Me.PropertiesControl1.Size = New System.Drawing.Size(800, 517)
        Me.PropertiesControl1.TabIndex = 0
        '
        'tp2
        '
        Me.tp2.Controls.Add(Me.fctb_slides)
        Me.tp2.Location = New System.Drawing.Point(4, 22)
        Me.tp2.Name = "tp2"
        Me.tp2.Padding = New System.Windows.Forms.Padding(3)
        Me.tp2.Size = New System.Drawing.Size(806, 523)
        Me.tp2.TabIndex = 1
        Me.tp2.Text = "Folien"
        Me.tp2.UseVisualStyleBackColor = True
        '
        'fctb_slides
        '
        Me.fctb_slides.AllowMacroRecording = False
        Me.fctb_slides.AutoCompleteBrackets = True
        Me.fctb_slides.AutoCompleteBracketsList = New Char() {Global.Microsoft.VisualBasic.ChrW(40), Global.Microsoft.VisualBasic.ChrW(41), Global.Microsoft.VisualBasic.ChrW(123), Global.Microsoft.VisualBasic.ChrW(125), Global.Microsoft.VisualBasic.ChrW(91), Global.Microsoft.VisualBasic.ChrW(93), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(39), Global.Microsoft.VisualBasic.ChrW(39)}
        Me.fctb_slides.AutoIndentChars = False
        Me.fctb_slides.AutoScrollMinSize = New System.Drawing.Size(2, 14)
        Me.fctb_slides.BackBrush = Nothing
        Me.fctb_slides.CharHeight = 14
        Me.fctb_slides.CharWidth = 8
        Me.fctb_slides.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.fctb_slides.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.fctb_slides.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fctb_slides.Font = New System.Drawing.Font("Courier New", 9.75!)
        Me.fctb_slides.IsReplaceMode = False
        Me.fctb_slides.Location = New System.Drawing.Point(3, 3)
        Me.fctb_slides.Name = "fctb_slides"
        Me.fctb_slides.Paddings = New System.Windows.Forms.Padding(0)
        Me.fctb_slides.SelectionColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.fctb_slides.ServiceColors = CType(resources.GetObject("fctb_slides.ServiceColors"), FastColoredTextBoxNS.ServiceColors)
        Me.fctb_slides.Size = New System.Drawing.Size(800, 517)
        Me.fctb_slides.TabIndex = 0
        Me.fctb_slides.Zoom = 100
        '
        'tp3
        '
        Me.tp3.Controls.Add(Me.btn_clear_all)
        Me.tp3.Controls.Add(Me.btn_copy)
        Me.tp3.Controls.Add(Me.btn_save)
        Me.tp3.Controls.Add(Me.fctb_finished_sng_file)
        Me.tp3.Location = New System.Drawing.Point(4, 22)
        Me.tp3.Name = "tp3"
        Me.tp3.Size = New System.Drawing.Size(806, 523)
        Me.tp3.TabIndex = 2
        Me.tp3.Text = "fertige SNG-Datei"
        Me.tp3.UseVisualStyleBackColor = True
        '
        'btn_clear_all
        '
        Me.btn_clear_all.Location = New System.Drawing.Point(525, 497)
        Me.btn_clear_all.Name = "btn_clear_all"
        Me.btn_clear_all.Size = New System.Drawing.Size(75, 23)
        Me.btn_clear_all.TabIndex = 3
        Me.btn_clear_all.Text = "alles leeren"
        Me.btn_clear_all.UseVisualStyleBackColor = True
        '
        'btn_copy
        '
        Me.btn_copy.Location = New System.Drawing.Point(606, 497)
        Me.btn_copy.Name = "btn_copy"
        Me.btn_copy.Size = New System.Drawing.Size(75, 23)
        Me.btn_copy.TabIndex = 2
        Me.btn_copy.Text = "kopieren"
        Me.btn_copy.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(695, 497)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(75, 23)
        Me.btn_save.TabIndex = 1
        Me.btn_save.Text = "speichern"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'fctb_finished_sng_file
        '
        Me.fctb_finished_sng_file.AllowMacroRecording = False
        Me.fctb_finished_sng_file.AllowSeveralTextStyleDrawing = True
        Me.fctb_finished_sng_file.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fctb_finished_sng_file.AutoCompleteBrackets = True
        Me.fctb_finished_sng_file.AutoCompleteBracketsList = New Char() {Global.Microsoft.VisualBasic.ChrW(40), Global.Microsoft.VisualBasic.ChrW(41), Global.Microsoft.VisualBasic.ChrW(123), Global.Microsoft.VisualBasic.ChrW(125), Global.Microsoft.VisualBasic.ChrW(91), Global.Microsoft.VisualBasic.ChrW(93), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(39), Global.Microsoft.VisualBasic.ChrW(39)}
        Me.fctb_finished_sng_file.AutoIndent = False
        Me.fctb_finished_sng_file.AutoIndentChars = False
        Me.fctb_finished_sng_file.AutoScrollMinSize = New System.Drawing.Size(2, 14)
        Me.fctb_finished_sng_file.BackBrush = Nothing
        Me.fctb_finished_sng_file.CharHeight = 14
        Me.fctb_finished_sng_file.CharWidth = 8
        Me.fctb_finished_sng_file.CommentPrefix = ""
        Me.fctb_finished_sng_file.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.fctb_finished_sng_file.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.fctb_finished_sng_file.Font = New System.Drawing.Font("Courier New", 9.75!)
        Me.fctb_finished_sng_file.HighlightFoldingIndicator = False
        Me.fctb_finished_sng_file.IsReplaceMode = False
        Me.fctb_finished_sng_file.Location = New System.Drawing.Point(0, 0)
        Me.fctb_finished_sng_file.Name = "fctb_finished_sng_file"
        Me.fctb_finished_sng_file.Paddings = New System.Windows.Forms.Padding(0)
        Me.fctb_finished_sng_file.SelectionColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.fctb_finished_sng_file.ServiceColors = CType(resources.GetObject("fctb_finished_sng_file.ServiceColors"), FastColoredTextBoxNS.ServiceColors)
        Me.fctb_finished_sng_file.ShowFoldingLines = True
        Me.fctb_finished_sng_file.Size = New System.Drawing.Size(806, 477)
        Me.fctb_finished_sng_file.TabIndex = 0
        Me.fctb_finished_sng_file.WordWrapAutoIndent = False
        Me.fctb_finished_sng_file.Zoom = 100
        '
        'ts
        '
        Me.ts.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ts.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CutToolStripButton, Me.CopyToolStripButton, Me.PasteToolStripButton, Me.UndoToolStripButton, Me.RedoToolStripButton, Me.BoldToolStripButton, Me.ItalicsToolStripButton, Me.UnderlineToolStripButton, Me.StrikeOutToolStripButton, Me.AlignToolStripButton, Me.VAlignToolStripButton, Me.ColoredTextToolStripButton, Me.WordWrapToolStripButton, Me.SubscriptToolStripButton, Me.SuperscriptToolStripButton, Me.LinespacingToolStripButton, Me.FontToolStripButton, Me.ZeilenZwischenDieOberenZeilenToolStripButton, Me.NewLineToolStripButton, Me.NewParagraphToolStripButton, Me.SprachenAufZweiFolienAufteilenToolStripButton})
        Me.ts.Location = New System.Drawing.Point(0, 0)
        Me.ts.Name = "ts"
        Me.ts.Size = New System.Drawing.Size(814, 25)
        Me.ts.TabIndex = 1
        Me.ts.Text = "ts"
        Me.ts.Visible = False
        '
        'CutToolStripButton
        '
        Me.CutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CutToolStripButton.Image = CType(resources.GetObject("CutToolStripButton.Image"), System.Drawing.Image)
        Me.CutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CutToolStripButton.Name = "CutToolStripButton"
        Me.CutToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.CutToolStripButton.Text = "Ausschneiden"
        '
        'CopyToolStripButton
        '
        Me.CopyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CopyToolStripButton.Image = CType(resources.GetObject("CopyToolStripButton.Image"), System.Drawing.Image)
        Me.CopyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopyToolStripButton.Name = "CopyToolStripButton"
        Me.CopyToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.CopyToolStripButton.Text = "Kopieren"
        '
        'PasteToolStripButton
        '
        Me.PasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PasteToolStripButton.Image = CType(resources.GetObject("PasteToolStripButton.Image"), System.Drawing.Image)
        Me.PasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PasteToolStripButton.Name = "PasteToolStripButton"
        Me.PasteToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.PasteToolStripButton.Text = "Inhalt der Zwischenablage einfügen"
        '
        'UndoToolStripButton
        '
        Me.UndoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.UndoToolStripButton.Enabled = False
        Me.UndoToolStripButton.Image = Global.SNGMaker.My.Resources.Resources.undo_24
        Me.UndoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.UndoToolStripButton.Name = "UndoToolStripButton"
        Me.UndoToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.UndoToolStripButton.Text = "Rückgängig"
        '
        'RedoToolStripButton
        '
        Me.RedoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RedoToolStripButton.Enabled = False
        Me.RedoToolStripButton.Image = Global.SNGMaker.My.Resources.Resources.redo_24
        Me.RedoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RedoToolStripButton.Name = "RedoToolStripButton"
        Me.RedoToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.RedoToolStripButton.Text = "Wiederherstellen"
        '
        'BoldToolStripButton
        '
        Me.BoldToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BoldToolStripButton.Image = Global.SNGMaker.My.Resources.Resources.Fett
        Me.BoldToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BoldToolStripButton.Name = "BoldToolStripButton"
        Me.BoldToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.BoldToolStripButton.Text = "Fett"
        '
        'ItalicsToolStripButton
        '
        Me.ItalicsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ItalicsToolStripButton.Image = Global.SNGMaker.My.Resources.Resources.Kursiv
        Me.ItalicsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ItalicsToolStripButton.Name = "ItalicsToolStripButton"
        Me.ItalicsToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.ItalicsToolStripButton.Text = "Kursiv"
        '
        'UnderlineToolStripButton
        '
        Me.UnderlineToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.UnderlineToolStripButton.Image = Global.SNGMaker.My.Resources.Resources.Unterstrichen
        Me.UnderlineToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.UnderlineToolStripButton.Name = "UnderlineToolStripButton"
        Me.UnderlineToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.UnderlineToolStripButton.Text = "Unterstrichen"
        '
        'StrikeOutToolStripButton
        '
        Me.StrikeOutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.StrikeOutToolStripButton.Image = Global.SNGMaker.My.Resources.Resources.Durchgestrichen
        Me.StrikeOutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.StrikeOutToolStripButton.Name = "StrikeOutToolStripButton"
        Me.StrikeOutToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.StrikeOutToolStripButton.Text = "Durchgestrichen"
        '
        'AlignToolStripButton
        '
        Me.AlignToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AlignToolStripButton.Image = Global.SNGMaker.My.Resources.Resources.halign_24
        Me.AlignToolStripButton.Name = "AlignToolStripButton"
        Me.AlignToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.AlignToolStripButton.Text = "horizontale Ausrichtung"
        '
        'VAlignToolStripButton
        '
        Me.VAlignToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.VAlignToolStripButton.Image = Global.SNGMaker.My.Resources.Resources.valign
        Me.VAlignToolStripButton.Name = "VAlignToolStripButton"
        Me.VAlignToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.VAlignToolStripButton.Text = "vertikale Ausrichtung"
        '
        'ColoredTextToolStripButton
        '
        Me.ColoredTextToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ColoredTextToolStripButton.Image = Global.SNGMaker.My.Resources.Resources.ColoredText
        Me.ColoredTextToolStripButton.Name = "ColoredTextToolStripButton"
        Me.ColoredTextToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.ColoredTextToolStripButton.Text = "farblich markieren"
        '
        'WordWrapToolStripButton
        '
        Me.WordWrapToolStripButton.Name = "WordWrapToolStripButton"
        Me.WordWrapToolStripButton.Size = New System.Drawing.Size(171, 22)
        Me.WordWrapToolStripButton.Text = "automatischer Zeilenumbruch"
        '
        'SubscriptToolStripButton
        '
        Me.SubscriptToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SubscriptToolStripButton.Image = Global.SNGMaker.My.Resources.Resources.Subscript
        Me.SubscriptToolStripButton.Name = "SubscriptToolStripButton"
        Me.SubscriptToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.SubscriptToolStripButton.Text = "tiefgestellt"
        '
        'SuperscriptToolStripButton
        '
        Me.SuperscriptToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SuperscriptToolStripButton.Image = Global.SNGMaker.My.Resources.Resources.Superscript
        Me.SuperscriptToolStripButton.Name = "SuperscriptToolStripButton"
        Me.SuperscriptToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.SuperscriptToolStripButton.Text = "hochgestellt"
        '
        'LinespacingToolStripButton
        '
        Me.LinespacingToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.LinespacingToolStripButton.Name = "LinespacingToolStripButton"
        Me.LinespacingToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.LinespacingToolStripButton.Text = "Zeilenabstand (Standard = 1.0)"
        '
        'FontToolStripButton
        '
        Me.FontToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FontToolStripButton.Image = CType(resources.GetObject("FontToolStripButton.Image"), System.Drawing.Image)
        Me.FontToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.FontToolStripButton.Name = "FontToolStripButton"
        Me.FontToolStripButton.Size = New System.Drawing.Size(59, 22)
        Me.FontToolStripButton.Text = "Schriftart"
        '
        'ZeilenZwischenDieOberenZeilenToolStripButton
        '
        Me.ZeilenZwischenDieOberenZeilenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ZeilenZwischenDieOberenZeilenToolStripButton.Image = Global.SNGMaker.My.Resources.Resources.ZwischenZeilen
        Me.ZeilenZwischenDieOberenZeilenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ZeilenZwischenDieOberenZeilenToolStripButton.Name = "ZeilenZwischenDieOberenZeilenToolStripButton"
        Me.ZeilenZwischenDieOberenZeilenToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.ZeilenZwischenDieOberenZeilenToolStripButton.Text = "Zeilen zwischen die oberen Zeilen"
        '
        'NewLineToolStripButton
        '
        Me.NewLineToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NewLineToolStripButton.Image = Global.SNGMaker.My.Resources.Resources.Zeilenumbruch
        Me.NewLineToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewLineToolStripButton.Name = "NewLineToolStripButton"
        Me.NewLineToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.NewLineToolStripButton.Text = "neue Zeile"
        '
        'NewParagraphToolStripButton
        '
        Me.NewParagraphToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NewParagraphToolStripButton.Image = Global.SNGMaker.My.Resources.Resources.Paragraph
        Me.NewParagraphToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewParagraphToolStripButton.Name = "NewParagraphToolStripButton"
        Me.NewParagraphToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.NewParagraphToolStripButton.Text = "neuer Absatz"
        '
        'SprachenAufZweiFolienAufteilenToolStripButton
        '
        Me.SprachenAufZweiFolienAufteilenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SprachenAufZweiFolienAufteilenToolStripButton.Image = CType(resources.GetObject("SprachenAufZweiFolienAufteilenToolStripButton.Image"), System.Drawing.Image)
        Me.SprachenAufZweiFolienAufteilenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SprachenAufZweiFolienAufteilenToolStripButton.Name = "SprachenAufZweiFolienAufteilenToolStripButton"
        Me.SprachenAufZweiFolienAufteilenToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.SprachenAufZweiFolienAufteilenToolStripButton.Text = "Sprachen auf zwei Folien aufteilen"
        '
        'tp4
        '
        Me.tp4.Location = New System.Drawing.Point(4, 22)
        Me.tp4.Name = "tp4"
        Me.tp4.Size = New System.Drawing.Size(806, 523)
        Me.tp4.TabIndex = 3
        Me.tp4.Text = "SNG-Datei öffnen"
        Me.tp4.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(814, 574)
        Me.Controls.Add(Me.ts)
        Me.Controls.Add(Me.tc)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SNGMaker"
        Me.tc.ResumeLayout(False)
        Me.tp1.ResumeLayout(False)
        Me.tp2.ResumeLayout(False)
        CType(Me.fctb_slides, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tp3.ResumeLayout(False)
        CType(Me.fctb_finished_sng_file, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ts.ResumeLayout(False)
        Me.ts.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tc As TabControl
    Friend WithEvents tp2 As TabPage
    Friend WithEvents tp3 As TabPage
    Friend WithEvents fctb_slides As FastColoredTextBoxNS.FastColoredTextBox
    Friend WithEvents fctb_finished_sng_file As FastColoredTextBoxNS.FastColoredTextBox
    Friend WithEvents ts As ToolStrip
    Friend WithEvents CutToolStripButton As ToolStripButton
    Friend WithEvents CopyToolStripButton As ToolStripButton
    Friend WithEvents PasteToolStripButton As ToolStripButton
    Friend WithEvents UndoToolStripButton As ToolStripButton
    Friend WithEvents RedoToolStripButton As ToolStripButton
    Friend WithEvents BoldToolStripButton As ToolStripButton
    Friend WithEvents ItalicsToolStripButton As ToolStripButton
    Friend WithEvents UnderlineToolStripButton As ToolStripButton
    Friend WithEvents StrikeOutToolStripButton As ToolStripButton
    Friend WithEvents AlignToolStripButton As ToolStripButton
    Friend WithEvents VAlignToolStripButton As ToolStripButton
    Friend WithEvents ColoredTextToolStripButton As ToolStripButton
    Friend WithEvents WordWrapToolStripButton As ToolStripButton
    Friend WithEvents SubscriptToolStripButton As ToolStripButton
    Friend WithEvents SuperscriptToolStripButton As ToolStripButton
    Friend WithEvents LinespacingToolStripButton As ToolStripButton
    Friend WithEvents FontToolStripButton As ToolStripButton
    Friend WithEvents ZeilenZwischenDieOberenZeilenToolStripButton As ToolStripButton
    Friend WithEvents NewLineToolStripButton As ToolStripButton
    Friend WithEvents SprachenAufZweiFolienAufteilenToolStripButton As ToolStripButton
    Friend WithEvents NewParagraphToolStripButton As ToolStripButton
    Friend WithEvents btn_clear_all As Button
    Friend WithEvents btn_copy As Button
    Friend WithEvents btn_save As Button
    Friend WithEvents tp1 As TabPage
    Friend WithEvents PropertiesControl1 As PropertiesControl
    Friend WithEvents tp4 As TabPage
End Class
