﻿Imports System.Windows.Forms

Public Class AboutBox

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Button1OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1OK.Click
        Me.Close()
    End Sub

    Private Sub AboutBox_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = String.Format("Info {0}", ApplicationTitle)
        ' Initialisieren Sie den gesamten Text, der im Infofeld angezeigt wird.
        ' TODO: Passen Sie die Assemblyinformationen der Anwendung im Bereich "Anwendung" des Dialogfelds für die 
        '    Projekteigenschaften (im Menü "Projekt") an.
        Me.LabelProductName.Text = My.Application.Info.ProductName
        Me.LabelVersion.Text = String.Format("Version {0}", My.Application.Info.Version.ToString)
        Me.LabelCopyright.Text = My.Application.Info.Copyright
        Me.LabelCompanyName.Text = My.Application.Info.CompanyName
    End Sub

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click

    End Sub
End Class
