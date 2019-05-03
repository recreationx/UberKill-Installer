<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.installpath = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.install = New System.Windows.Forms.Button()
        Me.selpath = New System.Windows.Forms.FolderBrowserDialog()
        Me.SuspendLayout()
        '
        'installpath
        '
        Me.installpath.Location = New System.Drawing.Point(12, 23)
        Me.installpath.Name = "installpath"
        Me.installpath.Size = New System.Drawing.Size(360, 20)
        Me.installpath.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Installing to:"
        '
        'install
        '
        Me.install.Location = New System.Drawing.Point(12, 47)
        Me.install.Name = "install"
        Me.install.Size = New System.Drawing.Size(75, 23)
        Me.install.TabIndex = 4
        Me.install.Text = "Install"
        Me.install.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(381, 73)
        Me.Controls.Add(Me.install)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.installpath)
        Me.Name = "Form1"
        Me.Text = "UberKill Installer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents installpath As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents install As Button
    Friend WithEvents selpath As FolderBrowserDialog
End Class
