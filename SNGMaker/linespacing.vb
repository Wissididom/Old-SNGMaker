Imports System.Windows.Forms
Public Class linespacing
    Public nud1Value As String = ""
    Public nud2Value As String = ""

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        nud1Value = CStr(nud1.Value)
        nud2Value = CStr(nud2.Value)
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub linespacing_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub linespacing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nud1Value = ""
        nud2Value = ""
    End Sub
End Class
