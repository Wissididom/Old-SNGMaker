Public Class NumericCheckTextBox
    Inherits TextBox

    Public Sub New()
        MyBase.New
        IsNumeric = False
    End Sub

    Public Sub New(ByVal numeric As Boolean)
        MyBase.New
        IsNumeric = numeric
    End Sub

    Private Sub NumericCheckTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If IsNumeric Then
            If e.KeyCode = Keys.D0 Or e.KeyCode = Keys.D1 Or e.KeyCode = Keys.D2 Or e.KeyCode = Keys.D3 Or e.KeyCode = Keys.D4 _
                        Or e.KeyCode = Keys.D5 Or e.KeyCode = Keys.D6 Or e.KeyCode = Keys.D7 Or e.KeyCode = Keys.D8 Or e.KeyCode = Keys.D9 _
                        Or e.KeyCode = Keys.NumPad0 Or e.KeyCode = Keys.NumPad1 Or e.KeyCode = Keys.NumPad2 Or e.KeyCode = Keys.NumPad3 _
                        Or e.KeyCode = Keys.NumPad4 Or e.KeyCode = Keys.NumPad5 Or e.KeyCode = Keys.NumPad6 Or e.KeyCode = Keys.NumPad7 _
                        Or e.KeyCode = Keys.NumPad8 Or e.KeyCode = Keys.NumPad9 Or e.KeyCode = Keys.Back Or e.KeyCode = Keys.Delete _
                        Or e.KeyCode = Keys.Home Or e.KeyCode = Keys.End Or e.KeyCode = Keys.Insert Or e.KeyCode = Keys.Left _
                        Or e.KeyCode = Keys.Right Or e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down Then
                Me.ReadOnly = False
            Else
                Me.ReadOnly = True
            End If
        Else
            Me.ReadOnly = False
        End If
    End Sub

    Private Sub NumericCheckTextBox_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Me.ReadOnly = False
    End Sub

    Public Property IsNumeric As Boolean = Nothing
End Class
