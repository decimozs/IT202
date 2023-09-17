<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        userId = New TextBox()
        loginBtn = New Button()
        exitBtn = New Button()
        password = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' userId
        ' 
        userId.Location = New Point(235, 101)
        userId.Name = "userId"
        userId.Size = New Size(125, 27)
        userId.TabIndex = 0
        ' 
        ' loginBtn
        ' 
        loginBtn.BackColor = SystemColors.Info
        loginBtn.Location = New Point(253, 186)
        loginBtn.Name = "loginBtn"
        loginBtn.Size = New Size(94, 29)
        loginBtn.TabIndex = 1
        loginBtn.Text = "LOGIN"
        loginBtn.UseVisualStyleBackColor = False
        ' 
        ' exitBtn
        ' 
        exitBtn.BackColor = SystemColors.Info
        exitBtn.Location = New Point(253, 221)
        exitBtn.Name = "exitBtn"
        exitBtn.Size = New Size(94, 29)
        exitBtn.TabIndex = 2
        exitBtn.Text = "Exit"
        exitBtn.UseVisualStyleBackColor = False
        ' 
        ' password
        ' 
        password.Location = New Point(235, 134)
        password.Name = "password"
        password.PasswordChar = "*"c
        password.Size = New Size(125, 27)
        password.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(151, 108)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 20)
        Label1.TabIndex = 4
        Label1.Text = "USERID" & vbCrLf
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(151, 137)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 20)
        Label2.TabIndex = 5
        Label2.Text = "Password"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Info
        ClientSize = New Size(800, 450)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(password)
        Controls.Add(exitBtn)
        Controls.Add(loginBtn)
        Controls.Add(userId)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents userId As TextBox
    Friend WithEvents loginBtn As Button
    Friend WithEvents exitBtn As Button
    Friend WithEvents password As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
