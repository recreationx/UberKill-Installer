Imports System.IO
Imports System.IO.Compression
Imports Ionic.Zip
Imports ZipFile = Ionic.Zip.ZipFile

Public Class Form1

    Public autostrSteamInstallPath As String = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Valve\Steam", "InstallPath", Nothing)
    Public ubzpath As String = autostrSteamInstallPath + "\steamapps\common\UberStrike\"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        installpath.Text = ubzpath

    End Sub

    Private Sub Install_Click(sender As Object, e As EventArgs) Handles install.Click
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
                    betazip.Extract(dir_installpath, ExtractExistingFileAction.OverwriteSilently)
                Next
            End Using
        Directory.Delete("C:\Temp", True)
    End Sub
End Class
