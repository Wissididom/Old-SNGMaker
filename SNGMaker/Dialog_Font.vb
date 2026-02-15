Imports System.Windows.Forms
Public Class Dialog_Font
    Friend Values As String = ""
    Friend hasSize As Boolean = Nothing
    Friend hasHeight As Boolean = Nothing

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Dim ValueSize As Integer = nud_font_size.Value
        Dim ValueHeight As Integer = nud_font_height.Value
        Values = "Size:" & ValueSize & ";Height:" & ValueHeight
        hasSize = cb_font_size.Checked
        hasHeight = cb_font_height.Checked
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub CheckedChangedEvents(sender As Object, e As EventArgs) Handles cb_font_size.CheckedChanged, cb_font_height.CheckedChanged
        If cb_font_size.Checked = True Then
            lbl_font_size.Enabled = True
            nud_font_size.Enabled = True
        Else
            lbl_font_size.Enabled = False
            nud_font_size.Enabled = False
        End If
        If cb_font_height.Checked = True Then
            lbl_font_height.Enabled = True
            nud_font_height.Enabled = True
        Else
            lbl_font_height.Enabled = False
            nud_font_height.Enabled = False
        End If
    End Sub

    Private Sub Dialog_Font_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cb_font_size.Checked = True
        cb_font_height.Checked = True
    End Sub
End Class