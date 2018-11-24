Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Imports ASCOM.Utilities
Imports ASCOM.DomeLauncher

<ComVisible(False)> _
Public Class SetupDialogForm

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click ' OK button event handler
        ' Persist new values of user settings to the ASCOM profile
        ' Update the state variables with results from the dialogue
        Dome.ShutterOpenURL = txtShutterOpenURL.Text
        Dome.ShutterCloseURL = txtShutterCloseURL.Text
        Dome.traceState = chkTrace.Checked
        Dome.AuthRequired = AuthRequired.Checked
        If AuthRequired.Checked Then
            Dome.URLUsername = Username.Text
            Dome.URLPassword = Password.Text
        Else
            Dome.URLUsername = ""
            Dome.URLPassword = ""
        End If
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click 'Cancel button event handler
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub ShowAscomWebPage(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.DoubleClick, PictureBox1.Click
        ' Click on ASCOM logo event handler
        Try
            System.Diagnostics.Process.Start("http://ascom-standards.org/")
        Catch noBrowser As System.ComponentModel.Win32Exception
            If noBrowser.ErrorCode = -2147467259 Then
                MessageBox.Show(noBrowser.Message)
            End If
        Catch other As System.Exception
            MessageBox.Show(other.Message)
        End Try
    End Sub

    Private Sub SetupDialogForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load ' Form load event handler
        ' Retrieve current values of user settings from the ASCOM Profile
        InitUI()
    End Sub

    Private Sub InitUI()
        chkTrace.Checked = Dome.traceState
        txtShutterOpenURL.Text = Dome.ShutterOpenURL
        txtShutterCloseURL.Text = Dome.ShutterCloseURL
        AuthRequired.Checked = Dome.AuthRequired
        Username.Text = Dome.URLUsername
        Password.Text = Dome.URLPassword
    End Sub

    Private Sub AuthRequired_CheckedChanged(sender As Object, e As EventArgs) Handles AuthRequired.CheckedChanged
        lblUsername.Enabled = AuthRequired.Checked
        Username.Enabled = AuthRequired.Checked
        lblPassword.Enabled = AuthRequired.Checked
        Password.Enabled = AuthRequired.Checked
    End Sub
End Class
