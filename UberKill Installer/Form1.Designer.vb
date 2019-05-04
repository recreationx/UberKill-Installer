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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.installtab = New System.Windows.Forms.TabPage()
        Me.misctab = New System.Windows.Forms.TabPage()
        Me.setCustomHost = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.customHost = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.installtab.SuspendLayout()
        Me.misctab.SuspendLayout()
        Me.SuspendLayout()
        '
        'installpath
        '
        Me.installpath.Enabled = False
        Me.installpath.Location = New System.Drawing.Point(73, 6)
        Me.installpath.Name = "installpath"
        Me.installpath.Size = New System.Drawing.Size(284, 20)
        Me.installpath.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Installing to:"
        '
        'install
        '
        Me.install.Location = New System.Drawing.Point(181, 81)
        Me.install.Name = "install"
        Me.install.Size = New System.Drawing.Size(176, 23)
        Me.install.TabIndex = 4
        Me.install.Text = "Install"
        Me.install.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Patching:"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(72, 32)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(284, 20)
        Me.TextBox1.TabIndex = 6
        Me.TextBox1.Text = "Assembly-CSharp.dll, Assembly-CSharp-firstpass.dll, UnityEngine.dll"
        '
        'log
        '
        Me.log.Location = New System.Drawing.Point(7, 110)
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
        Me.restore.Location = New System.Drawing.Point(7, 81)
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
        Me.autopath.Location = New System.Drawing.Point(309, 58)
        Me.autopath.Name = "autopath"
        Me.autopath.Size = New System.Drawing.Size(48, 17)
        Me.autopath.TabIndex = 9
        Me.autopath.Text = "Auto"
        Me.autopath.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.installtab)
        Me.TabControl1.Controls.Add(Me.misctab)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(371, 233)
        Me.TabControl1.TabIndex = 10
        '
        'installtab
        '
        Me.installtab.Controls.Add(Me.installpath)
        Me.installtab.Controls.Add(Me.autopath)
        Me.installtab.Controls.Add(Me.Label1)
        Me.installtab.Controls.Add(Me.restore)
        Me.installtab.Controls.Add(Me.install)
        Me.installtab.Controls.Add(Me.log)
        Me.installtab.Controls.Add(Me.Label2)
        Me.installtab.Controls.Add(Me.TextBox1)
        Me.installtab.Location = New System.Drawing.Point(4, 22)
        Me.installtab.Name = "installtab"
        Me.installtab.Padding = New System.Windows.Forms.Padding(3)
        Me.installtab.Size = New System.Drawing.Size(363, 207)
        Me.installtab.TabIndex = 0
        Me.installtab.Text = "Install"
        Me.installtab.UseVisualStyleBackColor = True
        '
        'misctab
        '
        Me.misctab.Controls.Add(Me.Label5)
        Me.misctab.Controls.Add(Me.Button1)
        Me.misctab.Controls.Add(Me.Label4)
        Me.misctab.Controls.Add(Me.setCustomHost)
        Me.misctab.Controls.Add(Me.Label3)
        Me.misctab.Controls.Add(Me.customHost)
        Me.misctab.Location = New System.Drawing.Point(4, 22)
        Me.misctab.Name = "misctab"
        Me.misctab.Padding = New System.Windows.Forms.Padding(3)
        Me.misctab.Size = New System.Drawing.Size(363, 207)
        Me.misctab.TabIndex = 1
        Me.misctab.Text = "Misc"
        Me.misctab.UseVisualStyleBackColor = True
        '
        'setCustomHost
        '
        Me.setCustomHost.Location = New System.Drawing.Point(235, 18)
        Me.setCustomHost.Name = "setCustomHost"
        Me.setCustomHost.Size = New System.Drawing.Size(65, 23)
        Me.setCustomHost.TabIndex = 2
        Me.setCustomHost.Text = "Set"
        Me.setCustomHost.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(178, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Host: (Syntax: http://hostname/2.0/"
        '
        'customHost
        '
        Me.customHost.Location = New System.Drawing.Point(11, 20)
        Me.customHost.Name = "customHost"
        Me.customHost.Size = New System.Drawing.Size(218, 20)
        Me.customHost.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(145, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Be sure to install UberKill first."
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(11, 86)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Kill Uberstrike"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Others:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 233)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UberKill Installer"
        Me.TabControl1.ResumeLayout(False)
        Me.installtab.ResumeLayout(False)
        Me.installtab.PerformLayout()
        Me.misctab.ResumeLayout(False)
        Me.misctab.PerformLayout()
        Me.ResumeLayout(False)

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
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents installtab As TabPage
    Friend WithEvents misctab As TabPage
    Friend WithEvents setCustomHost As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents customHost As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
End Class
