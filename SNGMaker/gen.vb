Public Class gen

    ''' <summary>
    ''' A SNG file starts with the properties of the song. This Function generates the properties-part of the SNG file and appends three hyphens at the end of it. The properties-part of the SNG file will be returned.
    ''' </summary>
    ''' <param name="title">song title</param>
    ''' <param name="author">name of the lyrics author</param>
    ''' <param name="melody">name of componist</param>
    ''' <param name="translation">name of translation author</param>
    ''' <param name="c">copyright information</param>
    ''' <param name="natcopyright">national copyright information</param>
    ''' <param name="rights">additional rights (e.g. for translated lyrics)</param>
    ''' <param name="addcopyrightinfo">additional copyright information</param>
    ''' <param name="CCLI">CCLI number</param>
    ''' <param name="editor">name of editing program</param>
    ''' <param name="bible">bible passage the text is based on</param>
    ''' <param name="categories">categories the song is about</param>
    ''' <param name="keywords">search keywords</param>
    ''' <param name="quickfind">quick find string like STTN for "Shout to the North"</param>
    ''' <param name="churchsongid">internal ID</param>
    ''' <param name="comment">arbitrary comment</param>
    ''' <param name="comments">Comment encoded with base64</param>
    ''' <param name="key">mus. key of the song</param>
    ''' <param name="verseorder">order of the song parts</param>
    ''' <param name="songbook">also written: SongBook</param>
    ''' <param name="langcount">number of translations in song file</param>
    ''' <param name="lang">language of the song</param>
    ''' <param name="tempo">tempo of the song</param>
    ''' <param name="titlelang">song title in other language</param>
    ''' <param name="otitle">original title</param>
    ''' <param name="backgroundimage">Path to background relative to image folder. Observed file types: JPEG, PNG, BMP, WMV, AVI</param>
    ''' <param name="font">font for lyrics</param>
    ''' <param name="fontlang">font for other lyrics</param>
    ''' <param name="fontsize">font size for lyrics</param>
    ''' <param name="textalign">text alignment</param>
    ''' <param name="titlealign">title alignment</param>
    ''' <remarks>Quelle: http://wiki.openlp.org/Development:SongBeamer_-_Song_Data_Format#Properties</remarks>
    Public Shared Function genProperties(ByVal title As String, ByVal author As String, ByVal melody As String,
                        ByVal translation As String, ByVal c As String,
                        ByVal natcopyright As String, ByVal rights As String,
                        ByVal addcopyrightinfo As String, ByVal CCLI As Integer,
                        ByVal editor As String, ByVal bible As String, ByVal categories As String,
                        ByVal keywords As String, ByVal quickfind As String, ByVal churchsongid As Integer,
                        ByVal comment As String, ByVal comments As String, ByVal key As String, ByVal verseorder As String,
                        ByVal songbook As String, ByVal langcount As Integer, ByVal lang As String, ByVal tempo As Integer,
                        ByVal titlelang As String(), ByVal otitle As String, ByVal backgroundimage As String,
                        ByVal font As String, ByVal fontlang As String(), ByVal fontsize As Integer, ByVal textalign As String,
                        ByVal titlealign As String) As String
        Dim settings As String = ""
        If title <> "" AndAlso Not IsNothing(title) Then settings = settings & "#Title=" & title & vbCrLf
        If author <> "" AndAlso Not IsNothing(author) Then settings = settings & "#Author=" & author & vbCrLf
        If melody <> "" AndAlso Not IsNothing(melody) Then settings = settings & "#Melody=" & melody & vbCrLf
        If translation <> "" AndAlso Not IsNothing(translation) Then settings = settings & "#Translation=" & translation & vbCrLf
        If c <> "" AndAlso Not IsNothing(c) Then settings = settings & "#(c)=" & c & vbCrLf
        If natcopyright <> "" AndAlso Not IsNothing(natcopyright) Then settings = settings & "#NatCopyright=" & natcopyright & vbCrLf
        If rights <> "" AndAlso Not IsNothing(rights) Then settings = settings & "#Rights=" & rights & vbCrLf
        If addcopyrightinfo <> "" AndAlso Not IsNothing(addcopyrightinfo) Then settings = settings & "#AddCopyrightInfo=" & addcopyrightinfo & vbCrLf
        If CCLI >= 0 Then settings = settings & "#CCLI=" & CStr(CCLI) & vbCrLf
        If editor <> "" AndAlso Not IsNothing(editor) Then settings = settings & "#Editor=" & editor & vbCrLf
        If bible <> "" AndAlso Not IsNothing(bible) Then settings = settings & "#Bible=" & bible & vbCrLf
        If categories <> "" AndAlso Not IsNothing(categories) Then settings = settings & "#Categories=" & categories & vbCrLf
        If keywords <> "" AndAlso Not IsNothing(keywords) Then settings = settings & "#Keywords=" & keywords & vbCrLf
        If quickfind <> "" AndAlso Not IsNothing(quickfind) Then settings = settings & "#QuickFind=" & quickfind & vbCrLf
        If churchsongid >= 0 Then settings = settings & "#ChurchSongID=" & CStr(churchsongid) & vbCrLf
        If comment <> "" AndAlso Not IsNothing(comment) Then settings = settings & "#Comment=" & comment & vbCrLf
        If comments <> "" AndAlso Not IsNothing(comments) Then settings = settings & "#Comments=" & comments & vbCrLf
        If key <> "" AndAlso Not IsNothing(key) Then settings = settings & "#Key=" & key & vbCrLf
        If verseorder <> "" AndAlso Not IsNothing(verseorder) Then settings = settings & "#VerseOrder=" & verseorder & vbCrLf
        If songbook <> "" AndAlso Not IsNothing(songbook) Then settings = settings & "#Songbook=" & songbook & vbCrLf
        If langcount >= 0 Then settings = settings & "#LangCount=" & CStr(langcount) & vbCrLf
        If lang <> "" AndAlso Not IsNothing(lang) Then settings = settings & "#Lang=" & lang & vbCrLf
        If tempo >= 0 Then settings = settings & "#Tempo=" & CStr(tempo) & vbCrLf
        If Not IsNothing(titlelang) Then
            For i As Integer = 0 To titlelang.Count - 1
                If titlelang(i) <> "" Then
                    settings = settings & "#TitleLang" & (i + 2) & "=" & titlelang(i) & vbCrLf
                End If
            Next
        End If
        If otitle <> "" AndAlso Not IsNothing(otitle) Then settings = settings & "#OTitle=" & otitle & vbCrLf
        If backgroundimage <> "" AndAlso Not IsNothing(backgroundimage) Then settings = settings & "#BackgroundImage=" & backgroundimage & vbCrLf
        If font <> "" AndAlso Not IsNothing(font) Then settings = settings & "#Font=" & font & vbCrLf
        If Not IsNothing(fontlang) Then
            For i As Integer = 0 To fontlang.Count - 1
                If fontlang(i) <> "" Then
                    settings = settings & "#FontLang" & (i + 2) & "=" & fontlang(i) & vbCrLf
                End If
            Next
        End If
        If fontsize >= 0 Then settings = settings & "#FontSize=" & CStr(fontsize) & vbCrLf
        If textalign <> "" AndAlso Not IsNothing(textalign) Then settings = settings & "#TextAlign=" & textalign & vbCrLf
        If titlealign <> "" AndAlso Not IsNothing(titlealign) Then settings = settings & "#TitleAlign=" & titlealign & vbCrLf
        If settings <> "" Then settings = settings & "---"
        Return settings
    End Function

    ''' <summary>
    ''' generates and returns the complete SNG file
    ''' </summary>
    ''' <param name="properties">the properties of the song in the right Format (like getProperties is returning)</param>
    ''' <param name="slides">the slides of the song splitted by three hyphens</param>
    Public Shared Function gen(ByVal properties As String, ByVal slides As String)
        Return properties & vbCrLf & slides
    End Function

    ''' <summary>
    ''' generates and returns the complete SNG file
    ''' </summary>
    ''' <param name="title">song title</param>
    ''' <param name="author">name of the lyrics author</param>
    ''' <param name="melody">name of componist</param>
    ''' <param name="translation">name of translation author</param>
    ''' <param name="c">copyright information</param>
    ''' <param name="natcopyright">national copyright information</param>
    ''' <param name="rights">additional rights (e.g. for translated lyrics)</param>
    ''' <param name="addcopyrightinfo">additional copyright information</param>
    ''' <param name="CCLI">CCLI number</param>
    ''' <param name="editor">name of editing program</param>
    ''' <param name="bible">bible passage the text is based on</param>
    ''' <param name="categories">categories the song is about</param>
    ''' <param name="keywords">search keywords</param>
    ''' <param name="quickfind">quick find string like STTN for "Shout to the North"</param>
    ''' <param name="churchsongid">internal ID</param>
    ''' <param name="comment">arbitrary comment</param>
    ''' <param name="comments">Comment encoded with base64</param>
    ''' <param name="key">mus. key of the song</param>
    ''' <param name="verseorder">order of the song parts</param>
    ''' <param name="songbook">also written: SongBook</param>
    ''' <param name="langcount">number of translations in song file</param>
    ''' <param name="lang">language of the song</param>
    ''' <param name="tempo">tempo of the song</param>
    ''' <param name="titlelang">song title in other language</param>
    ''' <param name="otitle">original title</param>
    ''' <param name="backgroundimage">Path to background relative to image folder. Observed file types: JPEG, PNG, BMP, WMV, AVI</param>
    ''' <param name="font">font for lyrics</param>
    ''' <param name="fontlang">font for other lyrics</param>
    ''' <param name="fontsize">font size for lyrics</param>
    ''' <param name="textalign">text alignment</param>
    ''' <param name="titlealign">title alignment</param>
    ''' <param name="slides">the slides of the song splitted by three hyphens</param>
    ''' <remarks>Quelle: http://wiki.openlp.org/Development:SongBeamer_-_Song_Data_Format#Properties</remarks>
    Public Shared Function gen(ByVal title As String, ByVal author As String, ByVal melody As String,
                        ByVal translation As String, ByVal c As String,
                        ByVal natcopyright As String, ByVal rights As String,
                        ByVal addcopyrightinfo As String, ByVal CCLI As Integer,
                        ByVal editor As String, ByVal bible As String, ByVal categories As String,
                        ByVal keywords As String, ByVal quickfind As String, ByVal churchsongid As Integer,
                        ByVal comment As String, ByVal comments As String, ByVal key As String, ByVal verseorder As String,
                        ByVal songbook As String, ByVal langcount As Integer, ByVal lang As String, ByVal tempo As Integer,
                        ByVal titlelang As String(), ByVal otitle As String, ByVal backgroundimage As String,
                        ByVal font As String, ByVal fontlang As String(), ByVal fontsize As Integer, ByVal textalign As String,
                        ByVal titlealign As String, ByVal slides As String) As String
        Dim properties As String = genProperties(title, author, melody, translation, c, natcopyright, rights,
                                                 addcopyrightinfo, CCLI, editor, bible, categories, keywords,
                                                 quickfind, churchsongid, comment, comments, key, verseorder,
                                                 songbook, langcount, lang, tempo, titlelang, otitle, backgroundimage,
                                                 font, fontlang, fontsize, textalign, titlealign)
        If properties = "" Then
            Return slides
        Else
            Return gen(properties, slides)
        End If
    End Function

    Public Shared Function Parse(ByVal File As String, ByVal Optional content As Boolean = False) As Dictionary(Of String, String)
        Return Parse(File, System.Text.Encoding.Default, content)
    End Function

    Public Shared Function Parse(ByVal File As String, ByVal encoding As System.Text.Encoding, ByVal Optional content As Boolean = False) As Dictionary(Of String, String)
        If Not content Then
            File = My.Computer.FileSystem.ReadAllText(File, encoding)
        End If
        File = File.Replace(vbCrLf, vbLf).Replace(vbCr, vbLf)
        Dim dic As New Dictionary(Of String, String)
        Dim slides As String = ""
        For Each line As String In File.Split(vbLf.ToCharArray())
            If line.StartsWith("#") Then
                If line.ToLower().StartsWith("#Title=".ToLower()) Then
                    dic.Add("title", line.Substring(Len("#Title=")))
                End If
                If line.ToLower().StartsWith("#Author=".ToLower()) Then
                    dic.Add("author", line.Substring(Len("#Author=")))
                End If
                If line.ToLower().StartsWith("#Melody=".ToLower()) Then
                    dic.Add("melody", line.Substring(Len("#Melody=")))
                End If
                If line.ToLower().StartsWith("#Translation=".ToLower()) Then
                    dic.Add("translation", line.Substring(Len("#Translation=")))
                End If
                If line.ToLower().StartsWith("#(c)=".ToLower()) Then
                    dic.Add("c", line.Substring(Len("#(c)=")))
                End If
                If line.ToLower().StartsWith("#NatCopyright=".ToLower()) Then
                    dic.Add("natcopyright", line.Substring(Len("#NatCopyright=")))
                End If
                If line.ToLower().StartsWith("#Rights=".ToLower()) Then
                    dic.Add("rights", line.Substring(Len("#Rights=")))
                End If
                If line.ToLower().StartsWith("#AddCopyrightInfo=".ToLower()) Then
                    dic.Add("addcopyrightinfo", line.Substring(Len("#AddCopyrightInfo=")))
                End If
                If line.ToLower().StartsWith("#CCLI=".ToLower()) Then
                    dic.Add("ccli", line.Substring(Len("#CCLI=")))
                End If
                If line.ToLower().StartsWith("#Editor=".ToLower()) Then
                    dic.Add("editor", line.Substring(Len("#Editor=")))
                End If
                If line.ToLower().StartsWith("#Bible=".ToLower()) Then
                    dic.Add("bible", line.Substring(Len("#Bible=")))
                End If
                If line.ToLower().StartsWith("#Categories=".ToLower()) Then
                    dic.Add("categories", line.Substring(Len("#Categories=")))
                End If
                If line.ToLower().StartsWith("#Keywords=".ToLower()) Then
                    dic.Add("keywords", line.Substring(Len("#Keywords=")))
                End If
                If line.ToLower().StartsWith("#QuickFind=".ToLower()) Then
                    dic.Add("quickfind", line.Substring(Len("#QuickFind=")))
                End If
                If line.ToLower().StartsWith("#ChurchSongID=".ToLower()) Then
                    dic.Add("churchsongid", line.Substring(Len("#ChurchSongID=")))
                End If
                If line.ToLower().StartsWith("#Comment=".ToLower()) Then
                    dic.Add("comment", line.Substring(Len("#Comment=")))
                End If
                If line.ToLower().StartsWith("#Comments=".ToLower()) Then
                    dic.Add("comments", line.Substring(Len("#Comments=")))
                End If
                If line.ToLower().StartsWith("#Key=".ToLower()) Then
                    dic.Add("key", line.Substring(Len("#Key=")))
                End If
                If line.ToLower().StartsWith("#VerseOrder=".ToLower()) Then
                    dic.Add("verseorder", line.Substring(Len("#VerseOrder=")))
                End If
                If line.ToLower().StartsWith("#Songbook=".ToLower()) Then
                    dic.Add("songbook", line.Substring(Len("#Songbook=")))
                End If
                If line.ToLower().StartsWith("#LangCount=".ToLower()) Then
                    dic.Add("langcount", line.Substring(Len("#LangCount=")))
                End If
                If line.ToLower().StartsWith("#Lang=".ToLower()) Then
                    dic.Add("lang", line.Substring(Len("#Lang=")))
                End If
                If line.ToLower().StartsWith("#Tempo=".ToLower()) Then
                    dic.Add("tempo", line.Substring(Len("#Tempo=")))
                End If
                If line.ToLower().StartsWith("#TitleLang=".ToLower()) Then
                    dic.Add("titlelang", line.Substring(Len("#TitleLang=")))
                End If
                If line.ToLower().StartsWith("#OTitle=".ToLower()) Then
                    dic.Add("otitle", line.Substring(Len("#OTitle=")))
                End If
                If line.ToLower().StartsWith("#BackgroundImage=".ToLower()) Then
                    dic.Add("backgroundimage", line.Substring(Len("#BackgroundImage=")))
                End If
                If line.ToLower().StartsWith("#Font=".ToLower()) Then
                    dic.Add("font", line.Substring(Len("#Font=")))
                End If
                If line.ToLower().StartsWith("#FontLang=".ToLower()) Then
                    dic.Add("fontlang", line.Substring(Len("#FontLang=")))
                End If
                If line.ToLower().StartsWith("#FontSize=".ToLower()) Then
                    dic.Add("fontsize", line.Substring(Len("#FontSize=")))
                End If
                If line.ToLower().StartsWith("#TextAlign=".ToLower()) Then
                    dic.Add("textalign", line.Substring(Len("#TextAlign=")))
                End If
                If line.ToLower().StartsWith("#TitleAlign=".ToLower()) Then
                    dic.Add("titlealign", line.Substring(Len("#TitleAlign=")))
                End If
            Else
                If slides = "" Then
                    If line <> "---" Then
                        slides = line
                    End If
                Else
                    slides &= vbCrLf & line
                End If
            End If
        Next
        dic.Add("slides", slides)
        Return dic
    End Function

    Public Shared Function GetEnglishWord(ByVal GermanWord As String) As String
        Select Case GermanWord.ToLower()
            Case "Titel".ToLower()
                Return "Title"
            Case "Autor".ToLower()
                Return "Author"
            Case "Melodie".ToLower()
                Return "Melody"
            Case "Übersetzung".ToLower()
                Return "Translation"
            Case "©".ToLower()
                Return "c"
            Case "National-©".ToLower()
                Return "NatCopyright"
            Case "Zusatz-Rechte".ToLower()
                Return "Rights"
            Case "Zusatz-©".ToLower()
                Return "AddCopyrightInfo"
            Case "CCLI".ToLower()
                Return "CCLI"
            Case "Editor".ToLower()
                Return "Editor"
            Case "Bibel".ToLower()
                Return "Bible"
            Case "Kategorieen".ToLower()
                Return "Categories"
            Case "Stichworte".ToLower()
                Return "Keywords"
            Case "Schnellsuche".ToLower()
                Return "QuickFind"
            Case "interne ID".ToLower()
                Return "ChurchSongID"
            Case "Kommentar".ToLower()
                Return "Comment"
            Case "Kommentare".ToLower()
                Return "Comments"
            Case "Schlüssel".ToLower()
                Return "Key"
            Case "Reihenfolge".ToLower()
                Return "VerseOrder"
            Case "Songbook".ToLower()
                Return "Songbuch"
            Case "Übersetzungsanzahl".ToLower()
                Return "LangCount"
            Case "Sprache".ToLower()
                Return "Lang"
            Case "Tempo".ToLower()
                Return "Tempo"
            Case "Titel - Sprache-N".ToLower()
                Return "TitleLang"
            Case "Originaltitel".ToLower()
                Return "OTitle"
            Case "Hintergrundbild".ToLower()
                Return "BackgroundImage"
            Case "Schrift".ToLower()
                Return "Font"
            Case "Schrift - Sprache-N".ToLower()
                Return "FontLang"
            Case "Schriftgröße".ToLower()
                Return "FontSize"
            Case "Textausrichtung".ToLower()
                Return "TextAlign"
            Case "Titelausrichtung".ToLower()
                Return "TitleAlign"
            Case Else
                Return GermanWord
        End Select
    End Function
End Class
