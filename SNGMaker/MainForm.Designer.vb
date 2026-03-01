Imports System.Windows.Forms

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        tc = New TabControl()
        tp1 = New TabPage()
        PropertiesControl1 = New PropertiesControl()
        tp2 = New TabPage()
        fctb_slides = New FastColoredTextBoxNS.FastColoredTextBox()
        tp3 = New TabPage()
        btn_clear_all = New Button()
        btn_copy = New Button()
        btn_save = New Button()
        fctb_finished_sng_file = New FastColoredTextBoxNS.FastColoredTextBox()
        tp4 = New TabPage()
        ts = New ToolStrip()
        CutToolStripButton = New ToolStripButton()
        CopyToolStripButton = New ToolStripButton()
        PasteToolStripButton = New ToolStripButton()
        UndoToolStripButton = New ToolStripButton()
        RedoToolStripButton = New ToolStripButton()
        BoldToolStripButton = New ToolStripButton()
        ItalicsToolStripButton = New ToolStripButton()
        UnderlineToolStripButton = New ToolStripButton()
        StrikeOutToolStripButton = New ToolStripButton()
        AlignToolStripButton = New ToolStripButton()
        VAlignToolStripButton = New ToolStripButton()
        ColoredTextToolStripButton = New ToolStripButton()
        WordWrapToolStripButton = New ToolStripButton()
        SubscriptToolStripButton = New ToolStripButton()
        SuperscriptToolStripButton = New ToolStripButton()
        LinespacingToolStripButton = New ToolStripButton()
        FontToolStripButton = New ToolStripButton()
        ZeilenZwischenDieOberenZeilenToolStripButton = New ToolStripButton()
        NewLineToolStripButton = New ToolStripButton()
        NewParagraphToolStripButton = New ToolStripButton()
        SprachenAufZweiFolienAufteilenToolStripButton = New ToolStripButton()
        tc.SuspendLayout()
        tp1.SuspendLayout()
        tp2.SuspendLayout()
        CType(fctb_slides, System.ComponentModel.ISupportInitialize).BeginInit()
        tp3.SuspendLayout()
        CType(fctb_finished_sng_file, System.ComponentModel.ISupportInitialize).BeginInit()
        ts.SuspendLayout()
        SuspendLayout()
        ' 
        ' tc
        ' 
        tc.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        tc.Controls.Add(tp1)
        tc.Controls.Add(tp2)
        tc.Controls.Add(tp3)
        tc.Controls.Add(tp4)
        tc.Location = New System.Drawing.Point(0, 30)
        tc.Margin = New Padding(4, 3, 4, 3)
        tc.Name = "tc"
        tc.SelectedIndex = 0
        tc.Size = New System.Drawing.Size(950, 633)
        tc.TabIndex = 0
        ' 
        ' tp1
        ' 
        tp1.AutoScroll = True
        tp1.Controls.Add(PropertiesControl1)
        tp1.Location = New System.Drawing.Point(4, 24)
        tp1.Margin = New Padding(4, 3, 4, 3)
        tp1.Name = "tp1"
        tp1.Padding = New Padding(4, 3, 4, 3)
        tp1.Size = New System.Drawing.Size(942, 605)
        tp1.TabIndex = 0
        tp1.Text = "Eigenschaften"
        tp1.UseVisualStyleBackColor = True
        ' 
        ' PropertiesControl1
        ' 
        PropertiesControl1.AutoScroll = True
        PropertiesControl1.Dock = DockStyle.Fill
        PropertiesControl1.Location = New System.Drawing.Point(4, 3)
        PropertiesControl1.Margin = New Padding(5, 3, 5, 3)
        PropertiesControl1.Name = "PropertiesControl1"
        PropertiesControl1.Size = New System.Drawing.Size(934, 599)
        PropertiesControl1.TabIndex = 0
        ' 
        ' tp2
        ' 
        tp2.Controls.Add(fctb_slides)
        tp2.Location = New System.Drawing.Point(4, 24)
        tp2.Margin = New Padding(4, 3, 4, 3)
        tp2.Name = "tp2"
        tp2.Padding = New Padding(4, 3, 4, 3)
        tp2.Size = New System.Drawing.Size(942, 605)
        tp2.TabIndex = 1
        tp2.Text = "Folien"
        tp2.UseVisualStyleBackColor = True
        ' 
        ' fctb_slides
        ' 
        fctb_slides.AllowMacroRecording = False
        fctb_slides.AutoCompleteBrackets = True
        fctb_slides.AutoIndentChars = False
        fctb_slides.AutoIndentCharsPatterns = "^\s*[\w\.]+(\s\w+)?\s*(?<range>=)\s*(?<range>[^;=]+);" & vbLf & "^\s*(case|default)\s*[^:]*(?<range>:)\s*(?<range>[^;]+);"
        fctb_slides.Cursor = Cursors.IBeam
        fctb_slides.DefaultMarkerSize = 8
        fctb_slides.DisabledColor = Drawing.Color.FromArgb(CByte(100), CByte(180), CByte(180), CByte(180))
        fctb_slides.Dock = DockStyle.Fill
        fctb_slides.Hotkeys = resources.GetString("fctb_slides.Hotkeys")
        fctb_slides.Location = New System.Drawing.Point(4, 3)
        fctb_slides.Margin = New Padding(4, 3, 4, 3)
        fctb_slides.Name = "fctb_slides"
        fctb_slides.SelectionColor = Drawing.Color.FromArgb(CByte(60), CByte(0), CByte(0), CByte(255))
        fctb_slides.Size = New System.Drawing.Size(934, 599)
        fctb_slides.TabIndex = 0
        ' 
        ' tp3
        ' 
        tp3.Controls.Add(btn_clear_all)
        tp3.Controls.Add(btn_copy)
        tp3.Controls.Add(btn_save)
        tp3.Controls.Add(fctb_finished_sng_file)
        tp3.Location = New System.Drawing.Point(4, 24)
        tp3.Margin = New Padding(4, 3, 4, 3)
        tp3.Name = "tp3"
        tp3.Size = New System.Drawing.Size(942, 605)
        tp3.TabIndex = 2
        tp3.Text = "fertige SNG-Datei"
        tp3.UseVisualStyleBackColor = True
        ' 
        ' btn_clear_all
        ' 
        btn_clear_all.Location = New System.Drawing.Point(612, 573)
        btn_clear_all.Margin = New Padding(4, 3, 4, 3)
        btn_clear_all.Name = "btn_clear_all"
        btn_clear_all.Size = New System.Drawing.Size(88, 27)
        btn_clear_all.TabIndex = 3
        btn_clear_all.Text = "alles leeren"
        btn_clear_all.UseVisualStyleBackColor = True
        ' 
        ' btn_copy
        ' 
        btn_copy.Location = New System.Drawing.Point(707, 573)
        btn_copy.Margin = New Padding(4, 3, 4, 3)
        btn_copy.Name = "btn_copy"
        btn_copy.Size = New System.Drawing.Size(88, 27)
        btn_copy.TabIndex = 2
        btn_copy.Text = "kopieren"
        btn_copy.UseVisualStyleBackColor = True
        ' 
        ' btn_save
        ' 
        btn_save.Location = New System.Drawing.Point(811, 573)
        btn_save.Margin = New Padding(4, 3, 4, 3)
        btn_save.Name = "btn_save"
        btn_save.Size = New System.Drawing.Size(88, 27)
        btn_save.TabIndex = 1
        btn_save.Text = "speichern"
        btn_save.UseVisualStyleBackColor = True
        ' 
        ' fctb_finished_sng_file
        ' 
        fctb_finished_sng_file.AllowMacroRecording = False
        fctb_finished_sng_file.AllowSeveralTextStyleDrawing = True
        fctb_finished_sng_file.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        fctb_finished_sng_file.AutoCompleteBrackets = True
        fctb_finished_sng_file.AutoIndent = False
        fctb_finished_sng_file.AutoIndentChars = False
        fctb_finished_sng_file.AutoIndentCharsPatterns = "^\s*[\w\.]+(\s\w+)?\s*(?<range>=)\s*(?<range>[^;=]+);" & vbLf & "^\s*(case|default)\s*[^:]*(?<range>:)\s*(?<range>[^;]+);"
        fctb_finished_sng_file.CommentPrefix = ""
        fctb_finished_sng_file.Cursor = Cursors.IBeam
        fctb_finished_sng_file.DefaultMarkerSize = 8
        fctb_finished_sng_file.DisabledColor = Drawing.Color.FromArgb(CByte(100), CByte(180), CByte(180), CByte(180))
        fctb_finished_sng_file.HighlightFoldingIndicator = False
        fctb_finished_sng_file.Hotkeys = resources.GetString("fctb_finished_sng_file.Hotkeys")
        fctb_finished_sng_file.Location = New System.Drawing.Point(0, 0)
        fctb_finished_sng_file.Margin = New Padding(4, 3, 4, 3)
        fctb_finished_sng_file.Name = "fctb_finished_sng_file"
        fctb_finished_sng_file.SelectionColor = Drawing.Color.FromArgb(CByte(60), CByte(0), CByte(0), CByte(255))
        fctb_finished_sng_file.ShowFoldingLines = True
        fctb_finished_sng_file.Size = New System.Drawing.Size(940, 550)
        fctb_finished_sng_file.TabIndex = 0
        fctb_finished_sng_file.WordWrapAutoIndent = False
        ' 
        ' tp4
        ' 
        tp4.Location = New System.Drawing.Point(4, 24)
        tp4.Margin = New Padding(4, 3, 4, 3)
        tp4.Name = "tp4"
        tp4.Size = New System.Drawing.Size(942, 605)
        tp4.TabIndex = 3
        tp4.Text = "SNG-Datei öffnen"
        tp4.UseVisualStyleBackColor = True
        ' 
        ' ts
        ' 
        ts.GripStyle = ToolStripGripStyle.Hidden
        ts.Items.AddRange(New ToolStripItem() {CutToolStripButton, CopyToolStripButton, PasteToolStripButton, UndoToolStripButton, RedoToolStripButton, BoldToolStripButton, ItalicsToolStripButton, UnderlineToolStripButton, StrikeOutToolStripButton, AlignToolStripButton, VAlignToolStripButton, ColoredTextToolStripButton, WordWrapToolStripButton, SubscriptToolStripButton, SuperscriptToolStripButton, LinespacingToolStripButton, FontToolStripButton, ZeilenZwischenDieOberenZeilenToolStripButton, NewLineToolStripButton, NewParagraphToolStripButton, SprachenAufZweiFolienAufteilenToolStripButton})
        ts.Location = New System.Drawing.Point(0, 0)
        ts.Name = "ts"
        ts.Size = New System.Drawing.Size(950, 29)
        ts.TabIndex = 1
        ts.Text = "ts"
        ts.Visible = False
        ' 
        ' CutToolStripButton
        ' 
        CutToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        CutToolStripButton.Image = CType(resources.GetObject("CutToolStripButton.Image"), Drawing.Image)
        CutToolStripButton.ImageTransparentColor = Drawing.Color.Magenta
        CutToolStripButton.Name = "CutToolStripButton"
        CutToolStripButton.Size = New System.Drawing.Size(23, 26)
        CutToolStripButton.Text = "Ausschneiden"
        ' 
        ' CopyToolStripButton
        ' 
        CopyToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        CopyToolStripButton.Image = CType(resources.GetObject("CopyToolStripButton.Image"), Drawing.Image)
        CopyToolStripButton.ImageTransparentColor = Drawing.Color.Magenta
        CopyToolStripButton.Name = "CopyToolStripButton"
        CopyToolStripButton.Size = New System.Drawing.Size(23, 26)
        CopyToolStripButton.Text = "Kopieren"
        ' 
        ' PasteToolStripButton
        ' 
        PasteToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        PasteToolStripButton.Image = CType(resources.GetObject("PasteToolStripButton.Image"), Drawing.Image)
        PasteToolStripButton.ImageTransparentColor = Drawing.Color.Magenta
        PasteToolStripButton.Name = "PasteToolStripButton"
        PasteToolStripButton.Size = New System.Drawing.Size(23, 26)
        PasteToolStripButton.Text = "Inhalt der Zwischenablage einfügen"
        ' 
        ' UndoToolStripButton
        ' 
        UndoToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        UndoToolStripButton.Enabled = False
        UndoToolStripButton.Image = My.Resources.Resources.undo_24
        UndoToolStripButton.ImageTransparentColor = Drawing.Color.Magenta
        UndoToolStripButton.Name = "UndoToolStripButton"
        UndoToolStripButton.Size = New System.Drawing.Size(23, 26)
        UndoToolStripButton.Text = "Rückgängig"
        ' 
        ' RedoToolStripButton
        ' 
        RedoToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        RedoToolStripButton.Enabled = False
        RedoToolStripButton.Image = My.Resources.Resources.redo_24
        RedoToolStripButton.ImageTransparentColor = Drawing.Color.Magenta
        RedoToolStripButton.Name = "RedoToolStripButton"
        RedoToolStripButton.Size = New System.Drawing.Size(23, 26)
        RedoToolStripButton.Text = "Wiederherstellen"
        ' 
        ' BoldToolStripButton
        ' 
        BoldToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        BoldToolStripButton.Image = My.Resources.Resources.Fett
        BoldToolStripButton.ImageTransparentColor = Drawing.Color.Magenta
        BoldToolStripButton.Name = "BoldToolStripButton"
        BoldToolStripButton.Size = New System.Drawing.Size(23, 26)
        BoldToolStripButton.Text = "Fett"
        ' 
        ' ItalicsToolStripButton
        ' 
        ItalicsToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        ItalicsToolStripButton.Image = My.Resources.Resources.Kursiv
        ItalicsToolStripButton.ImageTransparentColor = Drawing.Color.Magenta
        ItalicsToolStripButton.Name = "ItalicsToolStripButton"
        ItalicsToolStripButton.Size = New System.Drawing.Size(23, 26)
        ItalicsToolStripButton.Text = "Kursiv"
        ' 
        ' UnderlineToolStripButton
        ' 
        UnderlineToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        UnderlineToolStripButton.Image = My.Resources.Resources.Unterstrichen
        UnderlineToolStripButton.ImageTransparentColor = Drawing.Color.Magenta
        UnderlineToolStripButton.Name = "UnderlineToolStripButton"
        UnderlineToolStripButton.Size = New System.Drawing.Size(23, 26)
        UnderlineToolStripButton.Text = "Unterstrichen"
        ' 
        ' StrikeOutToolStripButton
        ' 
        StrikeOutToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        StrikeOutToolStripButton.Image = My.Resources.Resources.Durchgestrichen
        StrikeOutToolStripButton.ImageTransparentColor = Drawing.Color.Magenta
        StrikeOutToolStripButton.Name = "StrikeOutToolStripButton"
        StrikeOutToolStripButton.Size = New System.Drawing.Size(23, 26)
        StrikeOutToolStripButton.Text = "Durchgestrichen"
        ' 
        ' AlignToolStripButton
        ' 
        AlignToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        AlignToolStripButton.Image = My.Resources.Resources.halign_24
        AlignToolStripButton.Name = "AlignToolStripButton"
        AlignToolStripButton.Size = New System.Drawing.Size(23, 26)
        AlignToolStripButton.Text = "horizontale Ausrichtung"
        ' 
        ' VAlignToolStripButton
        ' 
        VAlignToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        VAlignToolStripButton.Image = My.Resources.Resources.valign
        VAlignToolStripButton.Name = "VAlignToolStripButton"
        VAlignToolStripButton.Size = New System.Drawing.Size(23, 26)
        VAlignToolStripButton.Text = "vertikale Ausrichtung"
        ' 
        ' ColoredTextToolStripButton
        ' 
        ColoredTextToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        ColoredTextToolStripButton.Image = My.Resources.Resources.ColoredText
        ColoredTextToolStripButton.Name = "ColoredTextToolStripButton"
        ColoredTextToolStripButton.Size = New System.Drawing.Size(23, 26)
        ColoredTextToolStripButton.Text = "farblich markieren"
        ' 
        ' WordWrapToolStripButton
        ' 
        WordWrapToolStripButton.Image = My.Resources.Resources.Zeilenumbruch
        WordWrapToolStripButton.Name = "WordWrapToolStripButton"
        WordWrapToolStripButton.Size = New System.Drawing.Size(187, 26)
        WordWrapToolStripButton.Text = "automatischer Zeilenumbruch"
        ' 
        ' SubscriptToolStripButton
        ' 
        SubscriptToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        SubscriptToolStripButton.Image = My.Resources.Resources.Subscript
        SubscriptToolStripButton.Name = "SubscriptToolStripButton"
        SubscriptToolStripButton.Size = New System.Drawing.Size(23, 26)
        SubscriptToolStripButton.Text = "tiefgestellt"
        ' 
        ' SuperscriptToolStripButton
        ' 
        SuperscriptToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        SuperscriptToolStripButton.Image = My.Resources.Resources.Superscript
        SuperscriptToolStripButton.Name = "SuperscriptToolStripButton"
        SuperscriptToolStripButton.Size = New System.Drawing.Size(23, 26)
        SuperscriptToolStripButton.Text = "hochgestellt"
        ' 
        ' LinespacingToolStripButton
        ' 
        LinespacingToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        LinespacingToolStripButton.Image = My.Resources.Resources.ZwischenZeilen
        LinespacingToolStripButton.Name = "LinespacingToolStripButton"
        LinespacingToolStripButton.Size = New System.Drawing.Size(23, 26)
        LinespacingToolStripButton.Text = "Zeilenabstand (Standard = 1.0)"
        ' 
        ' FontToolStripButton
        ' 
        FontToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Text
        FontToolStripButton.Image = CType(resources.GetObject("FontToolStripButton.Image"), Drawing.Image)
        FontToolStripButton.ImageTransparentColor = Drawing.Color.Magenta
        FontToolStripButton.Name = "FontToolStripButton"
        FontToolStripButton.Size = New System.Drawing.Size(59, 26)
        FontToolStripButton.Text = "Schriftart"
        ' 
        ' ZeilenZwischenDieOberenZeilenToolStripButton
        ' 
        ZeilenZwischenDieOberenZeilenToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        ZeilenZwischenDieOberenZeilenToolStripButton.Image = My.Resources.Resources.ZwischenZeilen
        ZeilenZwischenDieOberenZeilenToolStripButton.ImageTransparentColor = Drawing.Color.Magenta
        ZeilenZwischenDieOberenZeilenToolStripButton.Name = "ZeilenZwischenDieOberenZeilenToolStripButton"
        ZeilenZwischenDieOberenZeilenToolStripButton.Size = New System.Drawing.Size(23, 26)
        ZeilenZwischenDieOberenZeilenToolStripButton.Text = "Zeilen zwischen die oberen Zeilen"
        ' 
        ' NewLineToolStripButton
        ' 
        NewLineToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        NewLineToolStripButton.Image = My.Resources.Resources.Paragraph
        NewLineToolStripButton.ImageTransparentColor = Drawing.Color.Magenta
        NewLineToolStripButton.Name = "NewLineToolStripButton"
        NewLineToolStripButton.Size = New System.Drawing.Size(23, 26)
        NewLineToolStripButton.Text = "neue Zeile"
        ' 
        ' NewParagraphToolStripButton
        ' 
        NewParagraphToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        NewParagraphToolStripButton.Image = My.Resources.Resources.Paragraph
        NewParagraphToolStripButton.ImageTransparentColor = Drawing.Color.Magenta
        NewParagraphToolStripButton.Name = "NewParagraphToolStripButton"
        NewParagraphToolStripButton.Size = New System.Drawing.Size(23, 26)
        NewParagraphToolStripButton.Text = "neuer Absatz"
        ' 
        ' SprachenAufZweiFolienAufteilenToolStripButton
        ' 
        SprachenAufZweiFolienAufteilenToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        SprachenAufZweiFolienAufteilenToolStripButton.Image = My.Resources.Resources.ZwischenZeilen
        SprachenAufZweiFolienAufteilenToolStripButton.ImageTransparentColor = Drawing.Color.Magenta
        SprachenAufZweiFolienAufteilenToolStripButton.Name = "SprachenAufZweiFolienAufteilenToolStripButton"
        SprachenAufZweiFolienAufteilenToolStripButton.Size = New System.Drawing.Size(23, 26)
        SprachenAufZweiFolienAufteilenToolStripButton.Text = "Sprachen auf zwei Folien aufteilen"
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New System.Drawing.SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New System.Drawing.Size(950, 662)
        Controls.Add(ts)
        Controls.Add(tc)
        Icon = CType(resources.GetObject("$this.Icon"), Drawing.Icon)
        Margin = New Padding(4, 3, 4, 3)
        Name = "MainForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "SNGMaker"
        tc.ResumeLayout(False)
        tp1.ResumeLayout(False)
        tp2.ResumeLayout(False)
        CType(fctb_slides, System.ComponentModel.ISupportInitialize).EndInit()
        tp3.ResumeLayout(False)
        CType(fctb_finished_sng_file, System.ComponentModel.ISupportInitialize).EndInit()
        ts.ResumeLayout(False)
        ts.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

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
