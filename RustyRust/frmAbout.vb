﻿Public NotInheritable Class frmAbout

    Private Sub frmAbout_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        Me.Close()

    End Sub

    Private Sub frmAbout_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LostFocus
        Me.Close()

    End Sub
End Class
