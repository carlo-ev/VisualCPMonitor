<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LoginScreen1 = New VisualCPMonitor.loginScreen()
        Me.SuspendLayout()
        '
        'LoginScreen1
        '
        Me.LoginScreen1.BackColor = System.Drawing.SystemColors.Highlight
        Me.LoginScreen1.Location = New System.Drawing.Point(12, 12)
        Me.LoginScreen1.Name = "LoginScreen1"
        Me.LoginScreen1.Size = New System.Drawing.Size(443, 306)
        Me.LoginScreen1.TabIndex = 0
        '
        'mainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(468, 324)
        Me.Controls.Add(Me.LoginScreen1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "mainWindow"
        Me.Text = "Performance Manager"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LoginScreen1 As VisualCPMonitor.loginScreen

End Class
