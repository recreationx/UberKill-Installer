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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.installpath = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.install = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.log = New System.Windows.Forms.TextBox()
        Me.restore = New System.Windows.Forms.Button()
        Me.autopath = New System.Windows.Forms.CheckBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.SuspendLayout()
        '
        'installpath
        '
        Me.installpath.Enabled = False
        Me.installpath.Location = New System.Drawing.Point(72, 12)
        Me.installpath.Name = "installpath"
        Me.installpath.Size = New System.Drawing.Size(284, 20)
        Me.installpath.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Installing to:"
        '
        'install
        '
        Me.install.Location = New System.Drawing.Point(180, 83)
        Me.install.Name = "install"
        Me.install.Size = New System.Drawing.Size(176, 23)
        Me.install.TabIndex = 4
        Me.install.Text = "Install"
        Me.install.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Patching:"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(71, 38)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(284, 20)
        Me.TextBox1.TabIndex = 6
        Me.TextBox1.Text = "Assembly-CSharp.dll, Assembly-CSharp-firstpass.dll, UnityEngine.dll"
        '
        'log
        '
        Me.log.Location = New System.Drawing.Point(6, 112)
        Me.log.Multiline = True
        Me.log.Name = "log"
        Me.log.ReadOnly = True
        Me.log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.log.Size = New System.Drawing.Size(349, 84)
        Me.log.TabIndex = 7
        Me.log.Text = "UberKill Installer v0.1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Press Install to install UberKill patch!"
        '
        'restore
        '
        Me.restore.Location = New System.Drawing.Point(6, 83)
        Me.restore.Name = "restore"
        Me.restore.Size = New System.Drawing.Size(168, 23)
        Me.restore.TabIndex = 8
        Me.restore.Text = "Restore"
        Me.restore.UseVisualStyleBackColor = True
        '
        'autopath
        '
        Me.autopath.AutoSize = True
        Me.autopath.Checked = True
        Me.autopath.CheckState = System.Windows.Forms.CheckState.Checked
        Me.autopath.Location = New System.Drawing.Point(308, 64)
        Me.autopath.Name = "autopath"
        Me.autopath.Size = New System.Drawing.Size(48, 17)
        Me.autopath.TabIndex = 9
        Me.autopath.Text = "Auto"
        Me.autopath.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(359, 199)
        Me.Controls.Add(Me.autopath)
        Me.Controls.Add(Me.restore)
        Me.Controls.Add(Me.log)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.install)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.installpath)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UberKill Installer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents installpath As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents install As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents log As TextBox
    Friend WithEvents restore As Button
    Friend WithEvents autopath As CheckBox
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
End Class
