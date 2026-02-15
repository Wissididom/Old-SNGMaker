Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices
Public Class PropertiesControl
    Inherits UserControl

    Private components As IContainer

    Public ReadOnly Property Items() As List(Of PropertiesControlEntry)
        Get
            Dim list As New List(Of PropertiesControlEntry)
            Dim enumerator As IEnumerator = Me.Controls.GetEnumerator
            While enumerator.MoveNext
                Dim control As Control = CType(enumerator.Current, Control)
                If TypeOf control Is PropertiesControlEntry Then
                    list.Add(CType(control, PropertiesControlEntry))
                End If
            End While
            Return list
        End Get
    End Property

    Protected Overrides Sub Dispose(disposing As Boolean)
        If disposing AndAlso Me.components IsNot Nothing Then
            Me.components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    Private Sub InitializeComponent()
        Me.SuspendLayout()
        Me.AutoScaleDimensions = New SizeF(6.0F, 13.0F)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.AutoScroll = True
        Me.Name = "PropertiesControl"
        Me.ResumeLayout(False)
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub RemoveItemFromList(sender As PropertiesControlEntry)
        Me.Controls.Remove(sender)
    End Sub

    Public Function InsertItem(item As PropertiesControlEntry) As PropertiesControlEntry
        item.Dock = DockStyle.Top
        Me.Controls.Add(item)
        Return item
    End Function

    Public Sub CleanUp()
        Dim items As List(Of PropertiesControlEntry) = Me.Items
        Dim enumerator As List(Of PropertiesControlEntry).Enumerator = Me.Items.GetEnumerator
        While enumerator.MoveNext
            Me.Controls.Remove(enumerator.Current)
        End While
    End Sub

    Public Function getByProperty(ByVal [Property] As String) As PropertiesControlEntry
        Dim items As List(Of PropertiesControlEntry) = Me.Items
        Dim enumerator As List(Of PropertiesControlEntry).Enumerator = Me.Items.GetEnumerator
        While enumerator.MoveNext
            If enumerator.Current.Property = [Property] Then
                Return enumerator.Current
            End If
        End While
        Throw New ArgumentException("Die angegebene Eigenschaft ist nicht verfügbar.")
    End Function
End Class
