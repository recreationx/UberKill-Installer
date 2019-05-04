Imports System.IO
Imports Ionic.Zip
Imports ZipFile = Ionic.Zip.ZipFile
Public Class Form1

    'Find Steam path from registry
    Public autostrSteamInstallPath As String = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Valve\Steam", "InstallPath", Nothing)
    'Set Uberstrike folder path
    Public ubzpath As String = autostrSteamInstallPath + "\steamapps\common\UberStrike\"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        installpath.Text = ubzpath

        Try
            Dim readuberstrok As String
            readuberstrok = My.Computer.FileSystem.ReadAllText(ubzpath + "\Uberstrike_Data\.uberstrok")
            customHost.Text = readuberstrok
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Install_Click(sender As Object, e As EventArgs) Handles install.Click

        Try
            Dim ubzinstallpath As String = installpath.Text
            If Not Directory.Exists("C:\Temp") Then
                Directory.CreateDirectory("C:\Temp")
            End If
            Dim dir_Temp As String = "C:\Temp\beta.zip"
            Dim dir_installpath As String = ubzinstallpath & "\Uberstrike_Data"
            File.WriteAllBytes(dir_Temp, My.Resources.beta)
            Dim betazip As ZipEntry
            Using Zip As ZipFile = ZipFile.Read(dir_Temp)
                For Each betazip In Zip
                    betazip.Extract(dir_installpath, ExtractExistingFileAction.OverwriteSilently) 'Replace original DLLs
                Next
                log.AppendText(Environment.NewLine + Environment.NewLine + "Patched the following: ""Assembly-CSharp.dll, Assembly - CSharp - firstpass.dll, UnityEngine.dll, .uberstrok"" ")
            End Using
            Directory.Delete("C:\Temp", True)
            log.AppendText(Environment.NewLine + Environment.NewLine + "Installed UberKill successfully!")
            MsgBox("UberKill is installed!")

        Catch ex As Exception
            log.AppendText(Environment.NewLine + Environment.NewLine + "UberKill installation failed. Please check if installation path is correct.") 'If unknown error
            MsgBox("UberKill installation failed!")
        End Try

    End Sub

    Private Sub restore_Click(sender As Object, e As EventArgs) Handles restore.Click 'Send information on restoring files
        MsgBox("1. Navigate to Steam library" + vbNewLine + "2. Right click on Uberstrike and select Properties" + vbNewLine + "3. Select local files" + vbNewLine + "4. Select Verify Integrity of Game Files")
    End Sub

    Private Sub Autopath_CheckedChanged(sender As Object, e As EventArgs) Handles autopath.CheckedChanged
        If autopath.Checked = False Then
            installpath.Enabled = True
            FolderBrowserDialog1.Description = "Select Steam installation folder. Please ensure that correct folder is selected or else installation will fail."
            If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
                Dim result As String = FolderBrowserDialog1.SelectedPath
                Dim manualpath As String = result + "\steamapps\common\UberStrike\"
                installpath.Text = manualpath
                log.AppendText(Environment.NewLine + Environment.NewLine + "Path is set to: " + manualpath)
            End If
        Else
            installpath.Enabled = False
            installpath.Text = ubzpath
            log.AppendText(Environment.NewLine + Environment.NewLine + "Path is set to: " + ubzpath)
        End If
    End Sub

    Private Sub SetCustomHost_Click(sender As Object, e As EventArgs) Handles setCustomHost.Click
        Dim uberstrokpath As String = installpath.Text + "\Uberstrike_Data\.uberstrok\"
        File.WriteAllText(uberstrokpath, customHost.Text & vbCrLf)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim proc = Process.GetProcessesByName("Uberstrike")
        For i As Integer = 0 To proc.Count - 1
            proc(i).CloseMainWindow()
        Next i
    End Sub

#Region "Not Implemented"
    Public Function Ping(ByVal server As String) As String
        Dim ElapseTime As New Stopwatch
        Try
            If server.Contains("2.0") Then
                Dim server1 As String = server.Replace("https", "").Replace("http", "").Replace("2.0", "").Replace("/", "")
                ElapseTime.Start()
                My.Computer.Network.Ping(server1)
                ElapseTime.Stop()
            Else
                MsgBox("Not a valid Uberstrike server.")
            End If
        Catch ex As Exception
        End Try
        Return ElapseTime.Elapsed.TotalMilliseconds.ToString("N")
    End Function
#End Region
End Class
