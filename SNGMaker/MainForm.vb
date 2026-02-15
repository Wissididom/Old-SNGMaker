Public Class MainForm

    Public DescriptionFile As String = Application.StartupPath & "\sngDesc.xml"

    Private Sub tc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tc.SelectedIndexChanged
        If tc.SelectedIndex > 0 AndAlso tc.SelectedTab IsNot tp4 Then
            UndoToolStripButton.Enabled = getActiveFastColoredTextBox().UndoEnabled
            RedoToolStripButton.Enabled = getActiveFastColoredTextBox().RedoEnabled
            ts.Visible = True
        Else
            ts.Visible = False
        End If
        If tc.SelectedIndex = 2 Then
            Dim ccli As Integer = -1
            If PropertiesControl1.getByProperty("CCLI-Nummer").Value <> "" Then
                If Not UInteger.TryParse(PropertiesControl1.getByProperty("CCLI-Nummer").Value, ccli) Then
                    ccli = -1
                End If
            End If
            Dim churchsongid As Integer = -1
            If PropertiesControl1.getByProperty("interne ID").Value <> "" Then
                If Not UInteger.TryParse(PropertiesControl1.getByProperty("interne ID").Value, churchsongid) Then
                    churchsongid = -1
                End If
            End If
            Dim langcount As Integer = -1
            If PropertiesControl1.getByProperty("Übersetzungsanzahl").Value <> "" Then
                If Not UInteger.TryParse(PropertiesControl1.getByProperty("Übersetzungsanzahl").Value, langcount) Then
                    langcount = -1
                End If
            End If
            Dim tempo As Integer = -1
            If PropertiesControl1.getByProperty("Tempo").Value <> "" Then
                If Not UInteger.TryParse(PropertiesControl1.getByProperty("Tempo").Value, tempo) Then
                    tempo = -1
                End If
            End If
            Dim fontsize As Integer = -1
            If PropertiesControl1.getByProperty("Schriftgröße").Value <> "" Then
                If Not UInteger.TryParse(PropertiesControl1.getByProperty("Schriftgröße").Value, fontsize) Then
                    fontsize = -1
                End If
            End If
            fctb_finished_sng_file.Text = gen.gen(PropertiesControl1.getByProperty("Titel").Value,
                    PropertiesControl1.getByProperty("Autor").Value,
                    PropertiesControl1.getByProperty("Melodie").Value,
                    PropertiesControl1.getByProperty("Übersetzung").Value,
                    PropertiesControl1.getByProperty("©").Value,
                    PropertiesControl1.getByProperty("National-©").Value,
                    PropertiesControl1.getByProperty("Zusatz-Rechte").Value,
                    PropertiesControl1.getByProperty("Zusatz-©").Value,
                    ccli,
                    PropertiesControl1.getByProperty("Editor").Value,
                    PropertiesControl1.getByProperty("Bibel").Value,
                    PropertiesControl1.getByProperty("Kategorieen").Value,
                    PropertiesControl1.getByProperty("Stichworte").Value,
                    PropertiesControl1.getByProperty("Schnellsuche").Value,
                    churchsongid,
                    PropertiesControl1.getByProperty("Kommentar").Value,
                    System.Convert.ToBase64String(System.Text.Encoding.Default.GetBytes(PropertiesControl1.getByProperty("Kommentare").Value)),
                    PropertiesControl1.getByProperty("Schlüssel").Value,
                    PropertiesControl1.getByProperty("Reihenfolge").Value,
                    PropertiesControl1.getByProperty("Songbuch").Value,
                    langcount,
                    PropertiesControl1.getByProperty("Sprache").Value,
                    tempo,
                    PropertiesControl1.getByProperty("Titel - Sprache-N").Value.Split("|"c),
                    PropertiesControl1.getByProperty("Originaltitel").Value,
                    PropertiesControl1.getByProperty("Hintergrundbild").Value,
                    PropertiesControl1.getByProperty("Schrift").Value,
                    PropertiesControl1.getByProperty("Schrift - Sprache-N").Value.Split("|"c),
                    fontsize,
                    PropertiesControl1.getByProperty("Textausrichtung").Value,
                    PropertiesControl1.getByProperty("Titelausrichtung").Value,
                    fctb_slides.Text)
        End If
        If tc.SelectedTab Is tp4 Then
            tc.SelectedIndex = 0
            MessageBox.Show("Achtung, diese Funktion ist noch fehlerhaft.", "Fehlerhaft", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim OFD As New OpenFileDialog()
            With OFD
                .Title = "öffnen..."
                .Multiselect = False
                .InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
                .FileName = "nichts gewählt"
                .Filter = "SNG-Dateien|*.sng|Textdokumente|*.txt|Alle Dateien|*.*"
                If .ShowDialog() = DialogResult.OK Then
                    Dim dic As Dictionary(Of String, String) = gen.Parse(.FileName, False)
                    For Each p As PropertiesControlEntry In PropertiesControl1.Controls
                        Try
                            p.Value = dic.Item(gen.GetEnglishWord(p.Property).ToLower())
                        Catch ex As Exception
                            'do nothing
                        End Try
                    Next
                    fctb_slides.Text = dic.Item("slides")
                    TextChangedDelayed(fctb_slides, New FastColoredTextBoxNS.TextChangedEventArgs(fctb_slides.Range))
                End If
            End With
        End If
    End Sub

    Public Function getActiveFastColoredTextBox() As FastColoredTextBoxNS.FastColoredTextBox
        If tc.SelectedTab Is tp2 Then
            Return fctb_slides
        ElseIf tc.SelectedTab Is tp3 Then
            Return fctb_finished_sng_file
        Else
            Throw New ArgumentException("Der aktuelle Tab hat keine FastColoredTextBox.")
        End If
    End Function

    Private Sub CutToolStripButton_Click(sender As Object, e As EventArgs) Handles CutToolStripButton.Click
        getActiveFastColoredTextBox().Cut()
    End Sub

    Private Sub CopyToolStripButton_Click(sender As Object, e As EventArgs) Handles CopyToolStripButton.Click
        getActiveFastColoredTextBox.Copy()
    End Sub

    Private Sub PasteToolStripButton_Click(sender As Object, e As EventArgs) Handles PasteToolStripButton.Click
        getActiveFastColoredTextBox.Paste()
    End Sub

    Private Sub UndoToolStripButton_Click(sender As Object, e As EventArgs) Handles UndoToolStripButton.Click
        UndoToolStripButton.Enabled = getActiveFastColoredTextBox.UndoEnabled
        If getActiveFastColoredTextBox.UndoEnabled Then
            getActiveFastColoredTextBox.Undo()
        End If
    End Sub

    Private Sub RedoToolStripButton_Click(sender As Object, e As EventArgs) Handles RedoToolStripButton.Click
        RedoToolStripButton.Enabled = getActiveFastColoredTextBox.RedoEnabled
        If getActiveFastColoredTextBox.RedoEnabled Then
            getActiveFastColoredTextBox.Redo()
        End If
    End Sub

    Private Sub BoldToolStripButton_Click(sender As Object, e As EventArgs) Handles BoldToolStripButton.Click
        getActiveFastColoredTextBox().SelectedText = "<b>" & getActiveFastColoredTextBox().SelectedText & "</b>"
    End Sub

    Private Sub ItalicsToolStripButton_Click(sender As Object, e As EventArgs) Handles ItalicsToolStripButton.Click
        getActiveFastColoredTextBox().SelectedText = "<i>" & getActiveFastColoredTextBox().SelectedText & "</i>"
    End Sub

    Private Sub UnderlineToolStripButton_Click(sender As Object, e As EventArgs) Handles UnderlineToolStripButton.Click
        getActiveFastColoredTextBox().SelectedText = "<u>" & getActiveFastColoredTextBox().SelectedText & "</u>"
    End Sub

    Private Sub StrikeOutToolStripButton_Click(sender As Object, e As EventArgs) Handles StrikeOutToolStripButton.Click
        getActiveFastColoredTextBox().SelectedText = "<strike>" & getActiveFastColoredTextBox().SelectedText & "</strike>"
    End Sub

    Private Sub AlignToolStripButton_Click(sender As Object, e As EventArgs) Handles AlignToolStripButton.Click
        Dim aib As New AlignInputBox()
        If aib.ShowDialog() = DialogResult.OK Then
            getActiveFastColoredTextBox().InsertLinePrefix("<align:" & aib.Value & ">")
        End If
    End Sub

    Private Sub VAlignToolStripButton_Click(sender As Object, e As EventArgs) Handles VAlignToolStripButton.Click
        Dim vaib As New VAlignInputBox()
        If vaib.ShowDialog() = DialogResult.OK Then
            getActiveFastColoredTextBox().InsertLinePrefix("<valign:" & vaib.Value & ">")
        End If
    End Sub

    Private Sub ColoredTextToolStripButton_Click(sender As Object, e As EventArgs) Handles ColoredTextToolStripButton.Click
        Dim cd As New ColorDialog
        If cd.ShowDialog() = DialogResult.OK Then
            getActiveFastColoredTextBox().SelectedText = "<c:$" & cd.Color.ToArgb().ToString("x").Substring(2) & ">" & getActiveFastColoredTextBox().SelectedText & "</c>"
        End If
    End Sub

    Private Sub WordWrapToolStripButton_Click(sender As Object, e As EventArgs) Handles WordWrapToolStripButton.Click
        getActiveFastColoredTextBox().SelectedText = "<wordwrap>" & getActiveFastColoredTextBox().SelectedText & "</wordwrap>"
    End Sub

    Private Sub SubscriptToolStripButton_Click(sender As Object, e As EventArgs) Handles SubscriptToolStripButton.Click
        getActiveFastColoredTextBox().SelectedText = "<sub>" & getActiveFastColoredTextBox().SelectedText & "</sub>"
    End Sub

    Private Sub SuperscriptToolStripButton_Click(sender As Object, e As EventArgs) Handles SuperscriptToolStripButton.Click
        getActiveFastColoredTextBox().SelectedText = "<super>" & getActiveFastColoredTextBox().SelectedText & "</super>"
    End Sub

    Private Sub LinespacingToolStripButton_Click(sender As Object, e As EventArgs) Handles LinespacingToolStripButton.Click
        Dim nib As New NumberInputBox
        If nib.ShowDialog(0, 0.1, 100) = DialogResult.OK Then
            getActiveFastColoredTextBox().InsertLinePrefix("<linespacing:" & Strings.FormatNumber(nib.Value, 1, TriState.False, TriState.False, TriState.False).Replace(",", ".") & ">")
        End If
    End Sub

    Private Sub FontToolStripButton_Click(sender As Object, e As EventArgs) Handles FontToolStripButton.Click
        Dim df As New Dialog_Font
        If df.ShowDialog() = DialogResult.OK Then
            Dim size As String = df.Values.Split(";"c)(0).Split(":"c)(1)
            Dim height As String = df.Values.Split(";"c)(1).Split(":"c)(1)
            Dim tempString As String = getActiveFastColoredTextBox().SelectedText
            If df.hasSize Then tempString = "<s:" & size & ">" & tempString & "</s>"
            If df.hasHeight Then tempString = "<h:" & height & ">" & tempString & "</h>"
            getActiveFastColoredTextBox().SelectedText = tempString
        End If
    End Sub

    Private Sub ZeilenZwischenDieOberenZeilenToolStripButton_Click(sender As Object, e As EventArgs) Handles ZeilenZwischenDieOberenZeilenToolStripButton.Click
        Dim separated() As String = getActiveFastColoredTextBox.Text.Split({"---"}, StringSplitOptions.None)
        Dim aboveLine() As String = separated(0).TrimEnd.Split({vbCrLf}, StringSplitOptions.None)
        Dim underLine() As String = separated(1).TrimStart.Split({vbCrLf}, StringSplitOptions.None)
        Dim useAbove As Boolean = True
        If separated.Length > 2 Then
            For i = 2 To separated.Length - 1
                If useAbove Then
                    Dim tempList As List(Of String) = aboveLine.ToList()
                    tempList.AddRange(separated(i).TrimEnd.Split({vbCrLf}, StringSplitOptions.None))
                    aboveLine = tempList.ToArray()
                Else
                    Dim tempList As List(Of String) = underLine.ToList()
                    tempList.AddRange(separated(i).TrimStart.Split({vbCrLf}, StringSplitOptions.None))
                    underLine = tempList.ToArray()
                End If
                useAbove = Not useAbove
            Next
        End If
        Dim newString As New System.Text.StringBuilder
        For i As Integer = 0 To aboveLine.Length - 1
            If i = aboveLine.Length - 1 Then
                newString.Append(aboveLine(i) & vbCrLf & underLine(i))
            Else
                newString.Append(aboveLine(i) & vbCrLf & underLine(i) & vbCrLf)
            End If
        Next
        getActiveFastColoredTextBox.Text = newString.ToString()
        getActiveFastColoredTextBox.Text = getActiveFastColoredTextBox.Text.Replace(vbCrLf & vbCrLf, vbCrLf & "---")
    End Sub

    Private Sub NewLineToolStripButton_Click(sender As Object, e As EventArgs) Handles NewLineToolStripButton.Click
        getActiveFastColoredTextBox().InsertText("<br>")
    End Sub

    Private Sub NewParagraphToolStripButton_Click(sender As Object, e As EventArgs) Handles NewParagraphToolStripButton.Click
        getActiveFastColoredTextBox().InsertText("<p>")
    End Sub

    Private Sub SprachenAufZweiFolienAufteilenToolStripButton_Click(sender As Object, e As EventArgs) Handles SprachenAufZweiFolienAufteilenToolStripButton.Click
        Dim separated() As String = getActiveFastColoredTextBox.Text.Split({vbCrLf}, StringSplitOptions.None)
        Dim aboveList As New List(Of String)
        Dim underList As New List(Of String)
        For i As Integer = 0 To separated.Length - 1
            If IstGerade(CLng(i)) Then
                aboveList.Add(separated(i))
            Else
                underList.Add(separated(i))
            End If
        Next
        Dim aboveLine() As String = aboveList.ToArray()
        Dim underLine() As String = underList.ToArray()
        Dim newString As New System.Text.StringBuilder
        For i As Integer = 0 To aboveLine.Length - 1
            If i = aboveLine.Length - 1 Then
                newString.Append(aboveLine(i) & vbCrLf & "---" & vbCrLf)
            Else
                newString.Append(aboveLine(i) & vbCrLf)
            End If
        Next
        For i As Integer = 0 To underLine.Length - 1
            If i = underLine.Length - 1 Then
                newString.Append(underLine(i))
            Else
                newString.Append(underLine(i) & vbCrLf)
            End If
        Next
        getActiveFastColoredTextBox.Text = newString.ToString()
    End Sub

    Private Sub TextChangedDelayed(sender As Object, e As FastColoredTextBoxNS.TextChangedEventArgs) Handles fctb_slides.TextChangedDelayed, fctb_finished_sng_file.TextChangedDelayed
        On Error GoTo OnError
        If IO.File.Exists(DescriptionFile) Then
            sender.DescriptionFile = DescriptionFile
            sender.SyntaxHighlighter.HighlightSyntax(FastColoredTextBoxNS.Language.Custom, sender.Range)
        End If
        If fctb_slides.Text = "" Then
            If tc.TabPages.Contains(tp3) Then
                tc.TabPages.Remove(tp3)
            End If
        Else
            If Not tc.TabPages.Contains(tp3) Then
                tc.TabPages.Add(tp3)
            End If
        End If
        Return
OnError:
        MessageBox.Show("Fehler aufgetreten." & vbCrLf & vbCrLf & "Die Beschreibung des SyntaxHighlighters ist fehlerhaft oder wurde nicht gefunden.", "Fehler aufgetreten")
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not IO.File.Exists(DescriptionFile) Then
            If MessageBox.Show("Die Beschreibung des SyntaxHighlighters wurde nicht gefunden." & vbCrLf & "Wollen Sie die Datei selbst suchen?", "Beschreibung nicht gefunden", MessageBoxButtons.YesNo, MessageBoxIcon.Error) = DialogResult.Yes Then
                Dim OFD As New OpenFileDialog
                With OFD
                    .Title = "Beschreibung suchen"
                    .InitialDirectory = Application.StartupPath
                    .FileName = "sngDesc.xml"
                    .Filter = "XML-Datei|*.xml|XML-Datei als *.txt|*.txt|XML-Datei mit anderer Dateierweiterung|*.*"
                    If .ShowDialog() = DialogResult.OK Then
                        DescriptionFile = .FileName
                    End If
                End With
            End If
        End If
        tc.TabPages.Remove(tp3)
        Dim properties As String() =
            {"Titel", "Autor", "Melodie", "Übersetzung", "©", "National-©", "Zusatz-Rechte", "Zusatz-©", "CCLI-Nummer", "Editor",
            "Bibel", "Kategorieen", "Stichworte", "Schnellsuche", "interne ID", "Kommentar", "Kommentare", "Schlüssel",
            "Reihenfolge", "Songbuch", "Übersetzungsanzahl", "Sprache", "Tempo", "Titel - Sprache-N", "Originaltitel",
            "Hintergrundbild", "Schrift", "Schrift - Sprache-N", "Schriftgröße", "Textausrichtung", "Titelausrichtung"}
        Dim tindex As Integer = properties.Length - 1
        For Each [property] As String In properties.Reverse
            PropertiesControl1.InsertItem(getPropertiesControlEntry([property], tindex))
            tindex -= 1
        Next
    End Sub

    Private Function getPropertiesControlEntry(ByVal [property] As String, ByVal tindex As Integer) As PropertiesControlEntry
        If [property] = "CCLI-Nummer" Or [property] = "interne ID" Or [property] = "Übersetzungsanzahl" Or [property] = "Tempo" Or [property] = "Schriftgröße" Then
            Return New PropertiesControlEntry([property], True) With {.TabIndex = tindex}
        Else
            Return New PropertiesControlEntry([property], False) With {.TabIndex = tindex}
        End If
    End Function

    Private Sub btn_clear_all_Click(sender As Object, e As EventArgs) Handles btn_clear_all.Click
        For Each [Property] As PropertiesControlEntry In PropertiesControl1.Controls
            [Property].Value = ""
        Next
        fctb_slides.Clear()
        fctb_finished_sng_file.Clear()
    End Sub

    Private Sub btn_copy_Click(sender As Object, e As EventArgs) Handles btn_copy.Click
        Dim selection As FastColoredTextBoxNS.Range = fctb_finished_sng_file.Selection
        fctb_finished_sng_file.SelectAll()
        fctb_finished_sng_file.Copy()
        fctb_finished_sng_file.Selection = selection
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Dim SFD As New SaveFileDialog()
        With SFD
            .Title = "speichern..."
            .InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            .FileName = PropertiesControl1.getByProperty("Titel").TextBox1.Text.Replace(" ", "_")
            Dim lst As New List(Of Char)
            lst.AddRange(IO.Path.GetInvalidFileNameChars())
            lst.AddRange(IO.Path.GetInvalidPathChars())
            For Each InvalidChar As Char In lst.ToArray()
                .FileName = .FileName.Replace(InvalidChar, "_"c)
            Next
            .Filter = "SNG-Dateien|*.sng|Textdokumente|*.txt|Alle Dateien|*.*"
            If .ShowDialog() = DialogResult.OK Then
                'fctb_finished_sng_file.SaveToFile(.FileName, System.Text.Encoding.Default)
                My.Computer.FileSystem.WriteAllText(.FileName, fctb_finished_sng_file.Text, False)
            End If
        End With
    End Sub
End Class
