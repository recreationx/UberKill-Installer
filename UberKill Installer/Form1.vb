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

        Catch ex As Exception
            log.AppendText(Environment.NewLine + Environment.NewLine + "UberKill installation failed. Please check if installation path is correct.") 'If unknown error
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles restore.Click
        MsgBox("1. Navigate to Steam library" + vbNewLine + "2. Right click on Uberstrike and select Properties" + vbNewLine + "3. Select local files" + vbNewLine + "4. Select Verify Integrity of Game Files")
    End Sub

End Class
