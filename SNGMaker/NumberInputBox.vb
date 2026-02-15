Public Class NumberInputBox

    Public Overloads Function ShowDialog(ByVal MinVal As Decimal, ByVal Increment As Decimal, ByVal MaxVal As Decimal) As DialogResult
        Me.NumericUpDown1.Minimum = MinVal
        Me.NumericUpDown1.Increment = Increment
        Me.NumericUpDown1.DecimalPlaces = CStr(Increment).Replace(",", ".").Split("."c).Last().Length
        Me.NumericUpDown1.Maximum = MaxVal
        Return MyBase.ShowDialog()
    End Function

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Public ReadOnly Property MinVal As Decimal
        Get
            Return Me.NumericUpDown1.Minimum
        End Get
    End Property

    Public ReadOnly Property Increment As Decimal
        Get
            Return Me.NumericUpDown1.Increment
        End Get
    End Property

    Public ReadOnly Property MaxVal As Decimal
        Get
            Return Me.NumericUpDown1.Maximum
        End Get
    End Property

    Public ReadOnly Property Value As Decimal
        Get
            Return Me.NumericUpDown1.Value
        End Get
    End Property
End Class
