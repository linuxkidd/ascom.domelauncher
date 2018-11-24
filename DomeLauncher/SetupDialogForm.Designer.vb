<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SetupDialogForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.EnterURLsLabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ShutterOpenLabel = New System.Windows.Forms.Label()
        Me.chkTrace = New System.Windows.Forms.CheckBox()
        Me.txtShutterOpenURL = New System.Windows.Forms.TextBox()
        Me.txtShutterCloseURL = New System.Windows.Forms.TextBox()
        Me.ShutterCloseLabel = New System.Windows.Forms.Label()
        Me.AuthRequired = New System.Windows.Forms.CheckBox()
        Me.Username = New System.Windows.Forms.TextBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(696, 458)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(6)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(292, 56)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(6, 6)
        Me.OK_Button.Margin = New System.Windows.Forms.Padding(6)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(134, 44)
        Me.OK_Button.TabIndex = 7
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(152, 6)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(6)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(134, 44)
        Me.Cancel_Button.TabIndex = 8
        Me.Cancel_Button.Text = "Cancel"
        '
        'EnterURLsLabel
        '
        Me.EnterURLsLabel.AutoSize = True
        Me.EnterURLsLabel.Location = New System.Drawing.Point(24, 106)
        Me.EnterURLsLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.EnterURLsLabel.Name = "EnterURLsLabel"
        Me.EnterURLsLabel.Size = New System.Drawing.Size(370, 25)
        Me.EnterURLsLabel.TabIndex = 1
        Me.EnterURLsLabel.Text = "Enter the URLs to call for each event."
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.ASCOM.DomeLauncher.My.Resources.Resources.ASCOM
        Me.PictureBox1.Location = New System.Drawing.Point(890, 23)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 56)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'ShutterOpenLabel
        '
        Me.ShutterOpenLabel.AutoSize = True
        Me.ShutterOpenLabel.Location = New System.Drawing.Point(24, 190)
        Me.ShutterOpenLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.ShutterOpenLabel.Name = "ShutterOpenLabel"
        Me.ShutterOpenLabel.Size = New System.Drawing.Size(139, 25)
        Me.ShutterOpenLabel.TabIndex = 7
        Me.ShutterOpenLabel.Text = "Shutter Open"
        '
        'chkTrace
        '
        Me.chkTrace.AutoSize = True
        Me.chkTrace.Location = New System.Drawing.Point(534, 473)
        Me.chkTrace.Margin = New System.Windows.Forms.Padding(6)
        Me.chkTrace.Name = "chkTrace"
        Me.chkTrace.Size = New System.Drawing.Size(129, 29)
        Me.chkTrace.TabIndex = 6
        Me.chkTrace.Text = "Trace on"
        Me.chkTrace.UseVisualStyleBackColor = True
        '
        'txtShutterOpenURL
        '
        Me.txtShutterOpenURL.Location = New System.Drawing.Point(218, 183)
        Me.txtShutterOpenURL.Name = "txtShutterOpenURL"
        Me.txtShutterOpenURL.Size = New System.Drawing.Size(769, 31)
        Me.txtShutterOpenURL.TabIndex = 1
        Me.txtShutterOpenURL.WordWrap = False
        '
        'txtShutterCloseURL
        '
        Me.txtShutterCloseURL.Location = New System.Drawing.Point(218, 237)
        Me.txtShutterCloseURL.Name = "txtShutterCloseURL"
        Me.txtShutterCloseURL.Size = New System.Drawing.Size(769, 31)
        Me.txtShutterCloseURL.TabIndex = 2
        '
        'ShutterCloseLabel
        '
        Me.ShutterCloseLabel.AutoSize = True
        Me.ShutterCloseLabel.Location = New System.Drawing.Point(24, 244)
        Me.ShutterCloseLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.ShutterCloseLabel.Name = "ShutterCloseLabel"
        Me.ShutterCloseLabel.Size = New System.Drawing.Size(142, 25)
        Me.ShutterCloseLabel.TabIndex = 10
        Me.ShutterCloseLabel.Text = "Shutter Close"
        '
        'AuthRequired
        '
        Me.AuthRequired.AutoSize = True
        Me.AuthRequired.Location = New System.Drawing.Point(37, 305)
        Me.AuthRequired.Margin = New System.Windows.Forms.Padding(6)
        Me.AuthRequired.Name = "AuthRequired"
        Me.AuthRequired.Size = New System.Drawing.Size(286, 29)
        Me.AuthRequired.TabIndex = 3
        Me.AuthRequired.Text = "Authentication Required?"
        Me.AuthRequired.UseVisualStyleBackColor = True
        '
        'Username
        '
        Me.Username.Enabled = False
        Me.Username.Location = New System.Drawing.Point(218, 343)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(260, 31)
        Me.Username.TabIndex = 4
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(24, 350)
        Me.lblUsername.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(110, 25)
        Me.lblUsername.TabIndex = 13
        Me.lblUsername.Text = "Username"
        '
        'Password
        '
        Me.Password.Enabled = False
        Me.Password.Location = New System.Drawing.Point(218, 395)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(260, 31)
        Me.Password.TabIndex = 5
        Me.Password.UseSystemPasswordChar = True
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(24, 402)
        Me.lblPassword.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(106, 25)
        Me.lblPassword.TabIndex = 15
        Me.lblPassword.Text = "Password"
        '
        'SetupDialogForm
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(1012, 536)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.Username)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.AuthRequired)
        Me.Controls.Add(Me.txtShutterCloseURL)
        Me.Controls.Add(Me.ShutterCloseLabel)
        Me.Controls.Add(Me.txtShutterOpenURL)
        Me.Controls.Add(Me.chkTrace)
        Me.Controls.Add(Me.ShutterOpenLabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.EnterURLsLabel)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SetupDialogForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DomeLauncher Setup"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents EnterURLsLabel As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Private WithEvents ShutterOpenLabel As System.Windows.Forms.Label
    Friend WithEvents chkTrace As System.Windows.Forms.CheckBox
    Friend WithEvents txtShutterOpenURL As TextBox
    Friend WithEvents txtShutterCloseURL As TextBox
    Private WithEvents ShutterCloseLabel As Label
    Friend WithEvents AuthRequired As CheckBox
    Friend WithEvents Username As TextBox
    Private WithEvents lblUsername As Label
    Friend WithEvents Password As TextBox
    Private WithEvents lblPassword As Label
End Class
