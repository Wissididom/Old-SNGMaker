Imports System.Text.RegularExpressions
Module RTBLayout

    Public Sub TextChangedSubs(ByVal rtb As RichTextBox)
        Dim pos As Integer = rtb.SelectionStart
        Dim cat1 As String = "([Pp][Rr][Ee]-([Bb][Rr][Ii][Dd][Gg][Ee]|[Rr][Ee][Ff][Rr][Aa][Ii][Nn]|[Cc][Hh][Oo][Rr][Uu][Ss]|[Cc][Oo][Dd][Aa]))"
        Dim cat2 As String = "([Uu][Nn][Bb][Ee]([Kk]|[Nn])[Aa][Nn][Nn][Tt]|[Uu][Nn][Kk][Nn][Oo][Ww][Nn])"
        Dim cat3 As String = "([Ii][Nn][Tt][Rr][Oo]|[Cc][Oo][Dd][Aa]|[Ee][Nn][Dd][Ii][Nn][Gg])"
        Dim cat4 As String = "([Vv][Ee][Rr][Ss][Ee]?|[Ss][Tt][Rr][Oo][Pp][Hh][Ee]|[Tt][Ee][Ii][Ll]|[Pp][Aa][Rr][Tt])"
        Dim cat5 As String = "([Bb][Rr][Ii][Dd][Gg][Ee]|[Mm][Ii][Ss][Cc]|[Zz][Ww][Ii][Ss][Cc][Hh][Ee][Nn][Ss][Pp][Ii][Ee][Ll]|[Ii][Nn][Tt][Ee][Rr][Ll][Uu][Dd][Ee])"
        Dim cat6 As String = "([Rr][Ee][Ff][Rr][Aa][Ii][Nn]|[Cc][Hh][Oo][Rr][Uu][Ss])"
        Dim cat7 As String = "([Cc][Hh][Oo][Rr])"
        rtb.SelectAll()
        rtb.SelectionBackColor = Color.White
        rtb.SelectionColor = Color.Black
        Call MarkWord(rtb, cat1, Color.FromArgb(170, 85, 255))
        Call MarkWord(rtb, cat2, Color.FromArgb(98, 176, 255))
        Call MarkWord(rtb, cat3, Color.FromArgb(0, 128, 64))
        Call MarkWord(rtb, cat4, Color.FromArgb(0, 128, 255))
        Call MarkWord(rtb, cat5, Color.FromArgb(204, 0, 0))
        Call MarkWord(rtb, cat6, Color.FromArgb(128, 0, 255))
        Call MarkWord(rtb, cat7, Color.FromArgb(170, 176, 255))
        Call MarkLine(rtb, Color.FromArgb(255, 0, 0))
        rtb.SelectionStart = pos
        rtb.SelectionLength = 0
    End Sub

    Public Sub MarkWord(rtb As RichTextBox, word As String, bColor As Color)
        Call Mark(rtb, "^(" & word & "|" & word & " \d*|" & word & " [A-Z])$", bColor, Color.White) 'Vorlage: Call Mark(rtb, "^(" & word & "|" & word & " \d*)$", bColor, Color.White)
    End Sub

    Public Sub MarkLine(rtb As RichTextBox, fColor As Color)
        Call Mark(rtb, "^---$", Color.White, fColor)
    End Sub

    Public Sub Mark(ByVal rtb As RichTextBox, ByVal pattern As String, bColor As Color, fColor As Color)
        Dim rOptions As RegexOptions = RegexOptions.Multiline
        Dim regex As New Regex(pattern, rOptions)
        For Each m As Match In regex.Matches(rtb.Text)
            rtb.SelectionStart = m.Index
            rtb.SelectionLength = m.Length
            rtb.SelectionColor = fColor
            rtb.SelectionBackColor = bColor
        Next
    End Sub

    Public Sub ChangeFormatOfSong(Type As SongFormatChanger, rtb As RichTextBox)
        Select Case Type
            Case SongFormatChanger.Align
                Dim fciocl As Integer = rtb.GetFirstCharIndexOfCurrentLine
                Dim str As String = InputBox("Geben Sie die horizontale Ausrichtung ein (l|left|e|c|center|r|right|k|keep):", "Eingabe erforderlich")
                If Not str = "" Then
                    If str = "l" Or str = "left" Or str = "e" Or str = "c" Or str = "center" Or str = "r" Or str = "right" Or str = "k" Or str = "keep" Then
                        'rtb_folien.Text.Insert(fciocl, "<align:" & str & ">") 'ss
                        Dim left As String = Strings.Left(rtb.Text, fciocl)
                        Dim right As String = Strings.Right(rtb.Text, Len(rtb.Text) - Len(left))
                        rtb.Text = left & "<align:" & str & ">" & right
                    End If
                End If
            Case SongFormatChanger.VAlign
                Dim fciocl As Integer = rtb.GetFirstCharIndexOfCurrentLine
                Dim str As String = InputBox("Geben Sie die vertikale Ausrichtung ein (t|top|m|middle|b|bottom):", "Eingabe erforderlich")
                If Not str = "" Then
                    If str = "t" Or str = "top" Or str = "m" Or str = "middle" Or str = "b" Or str = "bottom" Then
                        Dim left As String = Strings.Left(rtb.Text, fciocl)
                        Dim right As String = Strings.Right(rtb.Text, Len(rtb.Text) - Len(left))
                        rtb.Text = left & "<valign:" & str & ">" & right
                    End If
                End If
            Case SongFormatChanger.Bold
                Dim tempSelectedText As String = rtb.SelectedText
                tempSelectedText = "<b>" & tempSelectedText & "</b>"
                rtb.SelectedText = tempSelectedText
            Case SongFormatChanger.Italic
                Dim tempSelectedText As String = rtb.SelectedText
                tempSelectedText = "<i>" & tempSelectedText & "</i>"
                rtb.SelectedText = tempSelectedText
            Case SongFormatChanger.Underline
                Dim tempSelectedText As String = rtb.SelectedText
                tempSelectedText = "<u>" & tempSelectedText & "</u>"
                rtb.SelectedText = tempSelectedText
            Case SongFormatChanger.ColoredText
                Dim tempSelectionStart As Integer = rtb.SelectionStart
                Dim tempSelectionLength As Integer = rtb.SelectionLength
                Dim cd As New ColorDialog
                Dim dlgResult As DialogResult = cd.ShowDialog()
                If dlgResult = DialogResult.OK Then
                    'MsgBox(cd.Color.ToArgb.ToString("X").Substring(2))
                    'lesen: System.Drawing.ColorTranslator.FromHtml("#" & cd.Color.ToArgb().ToString("X").Substring(2))
                    rtb.SelectedText = "<c:$" & cd.Color.ToArgb().ToString("X").Substring(2) & ">" & rtb.SelectedText & "</c>"
                End If
            Case SongFormatChanger.Font
                Dim hasSize As Boolean = False
                Dim hasHeight As Boolean = False
                Dim tempSize As Integer = -1
                Dim tempHeight As Integer = -1
                Dim tempSelectionStart As Integer = rtb.SelectionStart
                Dim tempSelectionLength As Integer = rtb.SelectionLength
                Dim tempSelectedText As String = rtb.SelectedText
                If Dialog_Font.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    If Not Dialog_Font.Values = "" Then
                        If Dialog_Font.cb_font_size.Checked = True Then
                            tempSize = CInt(Dialog_Font.Values.Substring(5, Dialog_Font.Values.IndexOf(";") - 5))
                        End If
                        If Dialog_Font.cb_font_height.Checked = True Then
                            tempHeight = CInt(Dialog_Font.Values.Substring(Dialog_Font.Values.IndexOf(";") + 8))
                        End If
                    End If
                End If
                If tempSize > -1 Then
                    tempSelectedText = "<s:" & CStr(tempSize) & ">" & tempSelectedText & "</s>"
                    'hasSize = True
                End If
                If tempHeight > -1 Then
                    tempSelectedText = "<h:" & CStr(tempHeight) & ">" & tempSelectedText & "</h>"
                    'hasHeight = True
                End If
                rtb.SelectedText = tempSelectedText
            Case SongFormatChanger.WordWrap
                Dim tempSelectedText As String = rtb.SelectedText
                tempSelectedText = "<wordwrap>" & tempSelectedText & "</wordwrap>"
                rtb.SelectedText = tempSelectedText
            Case SongFormatChanger.NewLine
                Dim left As String = Strings.Left(rtb.Text, rtb.SelectionStart)
                Dim right As String = Strings.Right(rtb.Text, rtb.Text.Length - (rtb.SelectionStart + rtb.SelectionLength))
                rtb.Text = left & "<br>" & right
            Case SongFormatChanger.NewParagraph
                Dim left As String = Strings.Left(rtb.Text, rtb.SelectionStart)
                Dim right As String = Strings.Right(rtb.Text, rtb.Text.Length - (rtb.SelectionStart + rtb.SelectionLength))
                rtb.Text = left & "<p>" & right
            Case SongFormatChanger.StrikeOut
                Dim tempSelectedText As String = rtb.SelectedText
                tempSelectedText = "<strike>" & tempSelectedText & "</strike>"
                rtb.SelectedText = tempSelectedText
            Case SongFormatChanger.Subscript
                Dim tempSelectedText As String = rtb.SelectedText
                tempSelectedText = "<sub>" & tempSelectedText & "</sub>"
                rtb.SelectedText = tempSelectedText
            Case SongFormatChanger.Superscript
                Dim tempSelectedText As String = rtb.SelectedText
                tempSelectedText = "<super>" & tempSelectedText & "</super>"
                rtb.SelectedText = tempSelectedText
            Case SongFormatChanger.Linespacing
                Dim fciocl As Integer = rtb.GetFirstCharIndexOfCurrentLine
                Dim str As String = InputBox("Geben Sie den Zeilenabstand ein:", "Eingabe erforderlich", "1.0")
                If Not str = "" Then
                    If CheckInputMask(str, "#.#") Then
                        Dim left As String = Strings.Left(rtb.Text, fciocl)
                        Dim right As String = Strings.Right(rtb.Text, Len(rtb.Text) - Len(left))
                        rtb.Text = left & "<linespacing:" & str & ">" & right
                    ElseIf CheckInputMask(str, "#") Then
                        Dim left As String = Strings.Left(rtb.Text, fciocl)
                        Dim right As String = Strings.Right(rtb.Text, Len(rtb.Text) - Len(left))
                        rtb.Text = left & "<linespacing:" & str & ".0>" & right
                    Else
                        MessageBox.Show("Sie haben ein falsches Format angegeben. Bitte nur Zahl - Punkt - Zahl", "Falsches Format", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            Case SongFormatChanger.MoveLinesBetween
                Dim separated() As String = rtb.Text.Split({"---"}, StringSplitOptions.None)
                Dim aboveLine() As String = separated(0).TrimEnd.Split(vbLf)
                Dim underLine() As String = separated(1).TrimStart.Split(vbLf)
                Dim useAbove As Boolean = True
                If separated.Length > 2 Then
                    For i = 2 To separated.Length - 1
                        If useAbove Then
                            Dim tempList As List(Of String) = aboveLine.ToList()
                            tempList.AddRange(separated(i).TrimEnd.Split(vbLf))
                            aboveLine = tempList.ToArray()
                        Else
                            Dim tempList As List(Of String) = underLine.ToList()
                            tempList.AddRange(separated(i).TrimStart.Split(vbLf))
                            underLine = tempList.ToArray()
                        End If
                        useAbove = Not useAbove
                    Next
                End If
                Dim newString As New System.Text.StringBuilder
                For i As Integer = 0 To aboveLine.Length - 1
                    If i = aboveLine.Length - 1 Then
                        newString.Append(aboveLine(i) & vbNewLine & underLine(i))
                    Else
                        newString.Append(aboveLine(i) & vbNewLine & underLine(i) & vbNewLine)
                    End If
                Next
                rtb.Text = newString.ToString()
                rtb.Text = rtb.Text.Replace(vbLf & vbLf, vbLf & "---")
            Case SongFormatChanger.MoveLinesOnTwoFoils
                Dim separated() As String = rtb.Text.Split({vbLf}, StringSplitOptions.None)
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
                        newString.Append(aboveLine(i) & vbNewLine & "---" & vbNewLine)
                    Else
                        newString.Append(aboveLine(i) & vbNewLine)
                    End If
                Next
                For i As Integer = 0 To underLine.Length - 1
                    If i = underLine.Length - 1 Then
                        newString.Append(underLine(i))
                    Else
                        newString.Append(underLine(i) & vbNewLine)
                    End If
                Next
                rtb.Text = newString.ToString()
        End Select
    End Sub

    Public Function IstGerade(ByVal zahl As Long) As Boolean
        Dim temp As String = CStr(zahl)
        If temp.EndsWith("0") Or temp.EndsWith("2") Or temp.EndsWith("4") Or temp.EndsWith("6") Or temp.EndsWith("8") Then
            Return True
        ElseIf temp.EndsWith("1") Or temp.EndsWith("3") Or temp.EndsWith("5") Or temp.EndsWith("7") Or temp.EndsWith("9") Then
            Return False
        Else
            Throw New FormatException("keine Zahl übergeben")
        End If
    End Function

    ''' <summary>
    ''' Prüft ob ein String ein bestimmtes Format aufweist
    ''' </summary>
    ''' <param name="sInput">Der String, der das Format aufweisen soll</param>
    ''' <param name="sMask">Der String der das Format angibt (# = numerisches Zeichen, &amp; = alphanumerisches Zeichen)</param>
    ''' <returns></returns>
    Public Function CheckInputMask(ByVal sInput As String, ByVal sMask As String) As Boolean
        Dim bResult As Boolean
        Dim i As Integer
        'Eingabe auf bestimmtes Format hin prüfen
        bResult = False
        If Len(sInput) = Len(sMask) Then
            'Länge passt schon einmal
            For i = 1 To Len(sMask)
                Select Case Mid$(sMask, i, 1)
                    Case "#"
                        'numerisches Zeichen erwartet
                        bResult = IsNumeric(Mid$(sInput, i, 1))
                    Case "&"
                        'alphanumerisches Zeichen
                        bResult = True
                    Case Else
                        'sonst. Zeichen
                        bResult = (Mid$(sInput, i, 1) = Mid$(sMask, i, 1))
                End Select
                'Unstimmigkeit gefunden?
                If Not bResult Then Exit For
            Next i
        End If
        CheckInputMask = bResult
    End Function
End Module