<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dialog_Font
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.lbl_font_size = New System.Windows.Forms.Label()
        Me.nud_font_size = New System.Windows.Forms.NumericUpDown()
        Me.lbl_font_height = New System.Windows.Forms.Label()
        Me.nud_font_height = New System.Windows.Forms.NumericUpDown()
        Me.cb_font_size = New System.Windows.Forms.CheckBox()
        Me.cb_font_height = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.nud_font_size, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_font_height, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(49, 129)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Abbrechen"
        '
        'lbl_font_size
        '
        Me.lbl_font_size.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_font_size.AutoSize = True
        Me.lbl_font_size.Location = New System.Drawing.Point(12, 75)
        Me.lbl_font_size.Name = "lbl_font_size"
        Me.lbl_font_size.Size = New System.Drawing.Size(67, 13)
        Me.lbl_font_size.TabIndex = 2
        Me.lbl_font_size.Text = "Schriftgröße:"
        '
        'nud_font_size
        '
        Me.nud_font_size.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nud_font_size.Location = New System.Drawing.Point(125, 72)
        Me.nud_font_size.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nud_font_size.Name = "nud_font_size"
        Me.nud_font_size.Size = New System.Drawing.Size(70, 20)
        Me.nud_font_size.TabIndex = 3
        Me.nud_font_size.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lbl_font_height
        '
        Me.lbl_font_height.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_font_height.AutoSize = True
        Me.lbl_font_height.Location = New System.Drawing.Point(12, 101)
        Me.lbl_font_height.Name = "lbl_font_height"
        Me.lbl_font_height.Size = New System.Drawing.Size(106, 13)
        Me.lbl_font_height.TabIndex = 5
        Me.lbl_font_height.Text = "Schrifthöhe (in Pixel):"
        '
        'nud_font_height
        '
        Me.nud_font_height.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nud_font_height.Location = New System.Drawing.Point(125, 99)
        Me.nud_font_height.Maximum = New Decimal(New Integer() {1024, 0, 0, 0})
        Me.nud_font_height.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nud_font_height.Name = "nud_font_height"
        Me.nud_font_height.Size = New System.Drawing.Size(70, 20)
        Me.nud_font_height.TabIndex = 6
        Me.nud_font_height.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'cb_font_size
        '
        Me.cb_font_size.AutoSize = True
        Me.cb_font_size.Location = New System.Drawing.Point(12, 12)
        Me.cb_font_size.Name = "cb_font_size"
        Me.cb_font_size.Size = New System.Drawing.Size(127, 17)
        Me.cb_font_size.TabIndex = 7
        Me.cb_font_size.Text = "Schriftgröße einfügen"
        Me.cb_font_size.UseVisualStyleBackColor = True
        '
        'cb_font_height
        '
        Me.cb_font_height.AutoSize = True
        Me.cb_font_height.Location = New System.Drawing.Point(12, 35)
        Me.cb_font_height.Name = "cb_font_height"
        Me.cb_font_height.Size = New System.Drawing.Size(124, 17)
        Me.cb_font_height.TabIndex = 8
        Me.cb_font_height.Text = "Schrifthöhe einfügen"
        Me.cb_font_height.UseVisualStyleBackColor = True
        '
        'Dialog_Font
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(207, 170)
        Me.Controls.Add(Me.cb_font_height)
        Me.Controls.Add(Me.cb_font_size)
        Me.Controls.Add(Me.nud_font_height)
        Me.Controls.Add(Me.lbl_font_height)
        Me.Controls.Add(Me.nud_font_size)
        Me.Controls.Add(Me.lbl_font_size)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Dialog_Font"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Schrift auswählen"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.nud_font_size, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_font_height, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents lbl_font_size As System.Windows.Forms.Label
    Friend WithEvents nud_font_size As System.Windows.Forms.NumericUpDown
    Friend WithEvents lbl_font_height As Label
    Friend WithEvents nud_font_height As NumericUpDown
    Friend WithEvents cb_font_size As CheckBox
    Friend WithEvents cb_font_height As CheckBox
End Class
