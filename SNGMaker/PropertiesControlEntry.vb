Public Class PropertiesControlEntry
    Inherits UserControl

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As NumericCheckTextBox

    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New SNGMaker.NumericCheckTextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New Font("Courier New", Me.Label1.Font.SizeInPoints)
        Me.Label1.Location = New System.Drawing.Point(3, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Font = New Font("Courier New", Me.TextBox1.Font.SizeInPoints)
        Me.TextBox1.Location = New System.Drawing.Point(138, 8)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(548, 20)
        Me.TextBox1.TabIndex = 1
        '
        'PropertiesControlEntry
        '
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "PropertiesControlEntry"
        Me.Size = New System.Drawing.Size(689, 34)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public Sub New(ByVal [Property] As String)
        InitializeComponent()
        Label1.Text = [Property] & ":"
    End Sub

    Public Sub New(ByVal [Property] As String, ByVal Value As String)
        InitializeComponent()
        Label1.Text = [Property] & ":"
        TextBox1.Text = Value
    End Sub

    Public Sub New(ByVal [Property] As String, ByVal numeric As Boolean)
        InitializeComponent()
        Label1.Text = [Property] & ":"
        TextBox1.IsNumeric = numeric
    End Sub

    Public Sub New(ByVal [Property] As String, ByVal Value As String, ByVal numeric As Boolean)
        InitializeComponent()
        Label1.Text = [Property] & ":"
        TextBox1.Text = Value
        TextBox1.IsNumeric = numeric
    End Sub

    Public Property [Property] As String
        Get
            Return Label1.Text.Split(":"c)(Label1.Text.Split(":"c).Count - 2)
        End Get
        Set
            Label1.Text = Value & ":"
        End Set
    End Property

    Public Property Value As String
        Get
            Return TextBox1.Text
        End Get
        Set
            TextBox1.Text = Value
        End Set
    End Property

    Public Property IsNumeric As Boolean
        Get
            Return TextBox1.IsNumeric
        End Get
        Set
            TextBox1.IsNumeric = Value
        End Set
    End Property
End Class
