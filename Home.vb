Imports System.IO
Imports Renci.SshNet
Imports System.Web
Imports System.Text

Public Class Home

    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer


    Private Sub Panel1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Panel1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Panel1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseUp
        drag = False
    End Sub
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'MsgBox("No Working for now sorry :(", MsgBoxStyle.Critical)
        MsgBox("PLEASE !!!! make sur you have install python 2.7.x and python 3.x", MsgBoxStyle.Information, "ATTENTNION")
        Dim logg As String = "Silver log | Software created by @NazkyYT and @appletech752"
        Dim sc As SshCommand
        cmd.RunCommandCom("py -2 bin\tcprelay\tcprelay.py", "-t 44:2222", True, True)
        System.Threading.Thread.Sleep(5000)
        logg = logg & Environment.NewLine & Environment.NewLine & "tcprelay launch"
        Dim sshClient = New SshClient("127.0.0.1", 2222, "root", "alpine")
        sshClient.Connect()
        sc = sshClient.CreateCommand("mount -o rw,union,update /")
        sc.Execute()
        sc = sshClient.CreateCommand("rm -rf /Applications/Setup.app")
        sc.Execute()
        sc = sshClient.CreateCommand("uicache -p /Applications/Setup.app")
        sc.Execute()
        sc = sshClient.CreateCommand("killall backboardd")
        sc.Execute()
        sshClient.Disconnect()
        MsgBox("Bypass done :)", MsgBoxStyle.Information)
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Process.Start("https://www.paypal.me/appletech752")
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Process.Start("https://www.paypal.me/NazkyOfficial")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox("No Working for now sorry :(", MsgBoxStyle.Critical)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MsgBox("PLEASE !!!! make sur you have install python 2.7.x and python 3.x", MsgBoxStyle.Information, "ATTENTNION")
        Dim logg As String = "Silver log | Software created by @NazkyYT and @appletech752"
        Dim sc As SshCommand
        Try
            cmd.RunCommandCom("py -2 bin\tcprelay\tcprelay.py", "-t 44:2222", True, True)
            System.Threading.Thread.Sleep(500)
            logg = logg & Environment.NewLine & Environment.NewLine & "tcprelay launch"
            Dim sshClient = New SshClient("172.0.0.1", 2222, "root", "alpine")
            sshClient.Connect()
            logg = logg & Environment.NewLine & "Connection sucess"
            sc = sshClient.CreateCommand("mount -o rw,union,update /")
            sc.Execute()
            logg = logg & Environment.NewLine & "mount sucess"
            sc = sshClient.CreateCommand("mv /usr/libexec/mobileactivationd /usr/libexec/mobileactivationdbak")
            sc.Execute()
            logg = logg & Environment.NewLine & "bak create sucess"
            Dim scpclient = New ScpClient("172.0.0.1", 2222, "root", "alpine")
            scpclient.Connect()
            scpclient.Upload(New FileInfo("bin\Bypass\13\I13B"), "/usr/libexec/")
            logg = logg & Environment.NewLine & "File upload sucess"
            sc = sshClient.CreateCommand("mv /usr/libexec/I13B /usr/libexec/mobileactivationd")
            sc.Execute()
            logg = logg & Environment.NewLine & "File rename sucess"
            sc = sshClient.CreateCommand("chmod 755 /usr/libexec/mobileactivationd")
            sc.Execute()
            sc = sshClient.CreateCommand("launchctl unload /System/Library/LaunchDaemons/com.apple.mobileactivationd.plist")
            sc.Execute()
            sc = sshClient.CreateCommand("launchctl load /System/Library/LaunchDaemons/com.apple.mobileactivationd.plist")
            sc.Execute()
            logg = logg & Environment.NewLine & "iDevice activate sucess"
            MsgBox("The bypass is normally done if you have any problem please contact me on twitter", MsgBoxStyle.Information)
            sshClient.Disconnect()
            scpclient.Disconnect()

            Dim proc = Process.GetProcessesByName("python")
            For i As Integer = 0 To proc.Count - 1
                proc(i).CloseMainWindow()
            Next i

            Dim proc1 = Process.GetProcessesByName("cmd")
            For i As Integer = 0 To proc.Count - 1
                proc(i).CloseMainWindow()
            Next i

        Catch ex As Exception
            Dim log As String = "Log.txt"
            Dim fs As FileStream = File.Create(log)

            Dim info As Byte() = New UTF8Encoding(True).GetBytes(logg & Environment.NewLine & ex.Message)
            fs.Write(info, 0, info.Length)
            fs.Close()
            MsgBox("error during process please read the log.txt file in the root of application", MsgBoxStyle.Critical)

            Dim proc = Process.GetProcessesByName("python")
            For i As Integer = 0 To proc.Count - 1
                proc(i).CloseMainWindow()
            Next i

            Dim proc1 = Process.GetProcessesByName("cmd")
            For i As Integer = 0 To proc.Count - 1
                proc(i).CloseMainWindow()
            Next i
        End Try



    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Directory.CreateDirectory("FileInfo\BypassPasscode\File\")
        Dim msg1 = MsgBox("This delete all previous files are you sur you want continue ?", MsgBoxStyle.YesNo + MsgBoxStyle.Information)
        If msg1 = MsgBoxResult.Yes Then
            Dim sc As SshCommand
            Dim directoryName As String = "FileInfo\BypassPasscode\File\"
            For Each deleteFile In Directory.GetFiles(directoryName, "*", SearchOption.TopDirectoryOnly)
                File.Delete(deleteFile)
            Next
            Dim logg As String = "Silver log | Software created by @NazkyYT and @appletech752"
            Try
                cmd.RunCommandCom("py -2 bin\tcprelay\tcprelay.py", "-t 44:2222", True, True)
                logg = logg & Environment.NewLine & "tcprelay launch"
                Dim scpclient = New ScpClient("172.0.0.1", 2222, "root", "alpine")
                Dim sshClient = New SshClient("127.0.0.1", 2222, "root", "alpine")
                System.Threading.Thread.Sleep(500)
                scpclient.Connect()
                scpclient.Upload(New FileInfo("bin\Ressource\getfiles.sh"), "/var/root")
                'cmd.RunCommandCom("bin\Ressource\pscp.exe", " -pw alpine -P 2222 bin\Ressource\getfiles.sh root@localhost:/", True, False)
                System.Threading.Thread.Sleep(500)
                sshClient.Connect()
                sc = sshClient.CreateCommand("chmod 755 /getfiles.sh")
                sc.Execute()
                sc = sshClient.CreateCommand("./getfiles.sh")
                sc.Execute()

                System.Threading.Thread.Sleep(500)
                scpclient.Download(New DirectoryInfo("/var/root/Ressource"), "FileInfo\BypassPasscode\File\")

                'cmd.RunCommandCom("bin\Ressource\pscp.exe", " -pw alpine -P 2222 -r root@localhost:/Ressource FileInfo\BypassPasscode\File\", False, True)

                MsgBox("File Download sucess", MsgBoxStyle.Information)

                logg = logg & Environment.NewLine & "File Download sucess"

                System.Threading.Thread.Sleep(500)

                Dim proc = Process.GetProcessesByName("python")
                For i As Integer = 0 To proc.Count - 1
                    proc(i).CloseMainWindow()
                Next i

                Dim proc1 = Process.GetProcessesByName("cmd")
                For i As Integer = 0 To proc.Count - 1
                    proc(i).CloseMainWindow()
                Next i

            Catch ex As Exception
                Dim log As String = "Log.txt"
                Dim fs As FileStream = File.Create(log)

                Dim info As Byte() = New UTF8Encoding(True).GetBytes(logg & Environment.NewLine & ex.Message)
                fs.Write(info, 0, info.Length)
                fs.Close()
                MsgBox("error during process please read the log.txt file in the root of application", MsgBoxStyle.Critical)

                Dim proc = Process.GetProcessesByName("python")
                For i As Integer = 0 To proc.Count - 1
                    proc(i).CloseMainWindow()
                Next i

                Dim proc1 = Process.GetProcessesByName("cmd")
                For i As Integer = 0 To proc.Count - 1
                    proc(i).CloseMainWindow()
                Next i

            End Try
        Else
            MsgBox("Make a backup of you'r file :)", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cmd.RunCommandCom("py -2 bin\tcprelay\tcprelay.py", "-t 44:2222", True, False)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        MsgBox("PLEASE !!!! make sur you have install python 2.7.x and python 3.x", MsgBoxStyle.Information, "ATTENTNION")
        Dim sc As SshCommand
        Dim logg As String = "Silver log | Software created by @NazkyYT and @appletech752"
        Try
            cmd.RunCommandCom("py -2 bin\tcprelay\tcprelay.py", "-t 44:2222", True, True)
            logg = logg & Environment.NewLine & "tcprelay launch"
            Dim sshClient = New SshClient("172.0.0.1", 2222, "root", "alpine")
            sshClient.Connect()

            cmd.RunCommandCom("bin\Ressource\pscp.exe", " -pw alpine -P 2222 -r FileInfo\BypassPasscode\File\Ressource\. root@localhost:/Ressource ", False, False)


            cmd.RunCommandCom("bin\Ressource\pscp.exe", " -pw alpine -P 2222 bin\Ressource\sendfile.sh root@localhost:/", False, False)

            sc = sshClient.CreateCommand("chmod 755 /sendfile.sh")
            sc.Execute()
            sc = sshClient.CreateCommand("./sendfile.sh")
            sc.Execute()

            System.Threading.Thread.Sleep(500)

            MsgBox("You'r iDevice is activate", MsgBoxStyle.Information)

            logg = logg & Environment.NewLine & "File Upload sucess"

            Dim proc = Process.GetProcessesByName("python")
            For i As Integer = 0 To proc.Count - 1
                proc(i).CloseMainWindow()
            Next i

            Dim proc1 = Process.GetProcessesByName("cmd")
            For i As Integer = 0 To proc.Count - 1
                proc(i).CloseMainWindow()
            Next i

        Catch ex As Exception
            Dim log As String = "Log.txt"
            Dim fs As FileStream = File.Create(log)

            Dim info As Byte() = New UTF8Encoding(True).GetBytes(logg & Environment.NewLine & ex.Message)
            fs.Write(info, 0, info.Length)
            fs.Close()
            MsgBox("error during process please read the log.txt file in the root of application", MsgBoxStyle.Critical)

            Dim proc = Process.GetProcessesByName("python")
            For i As Integer = 0 To proc.Count - 1
                proc(i).CloseMainWindow()
            Next i

            Dim proc1 = Process.GetProcessesByName("cmd")
            For i As Integer = 0 To proc.Count - 1
                proc(i).CloseMainWindow()
            Next i

        End Try
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim logg As String = "Silver log | Software created by @NazkyYT and @appletech752"
        Try
            Dim sc As SshCommand
            cmd.RunCommandCom("py -2 bin\tcprelay\tcprelay.py", "-t 44:2222", True, True)
            System.Threading.Thread.Sleep(500)
            logg = logg & Environment.NewLine & Environment.NewLine & "tcprelay launch"
            Dim sshClient = New SshClient("127.0.0.1", 2222, "root", "alpine")
            cmd.RunCommandCom("bin\Ressource\pscp.exe", "pw alpine -P 2222 bin\Ressource\com.apple.purplebuddy.plist root@localhost:/ ", False, False)
            System.Threading.Thread.Sleep(5000)
            sshClient.Connect()
            sc = sshClient.CreateCommand("mount -o rw,union,update /")
            sc.Execute()
            System.Threading.Thread.Sleep(500)
            sc = sshClient.CreateCommand("sudo apt update")
            sc.Execute()
            System.Threading.Thread.Sleep(5000)
            sc = sshClient.CreateCommand("sudo apt install file-cmds -y")
            sc.Execute()
            System.Threading.Thread.Sleep(500)
            sc = sshClient.CreateCommand("killall backboardd")
            sc.Execute()
            System.Threading.Thread.Sleep(500)
            sc = sshClient.CreateCommand("mv com.apple.purplebuddy.plist /var/mobile/library/preferences/")
            sc.Execute()
            System.Threading.Thread.Sleep(500)
            sc = sshClient.CreateCommand("chflags uchg /var/mobile/Library/Preferences/com.apple.purplebuddy.plist")
            sc.Execute()
            System.Threading.Thread.Sleep(500)
            MsgBox("AppStore fix PLEASE REBOOT before connect to appstore APPS !!!!", MsgBoxStyle.Information)
            sshClient.Disconnect()


            Dim proc = Process.GetProcessesByName("python")
            For i As Integer = 0 To proc.Count - 1
                proc(i).CloseMainWindow()
            Next i

            Dim proc1 = Process.GetProcessesByName("cmd")
            For i As Integer = 0 To proc.Count - 1
                proc(i).CloseMainWindow()
            Next i

        Catch ex As Exception
            Dim log As String = "Log.txt"
            Dim fs As FileStream = File.Create(log)

            Dim info As Byte() = New UTF8Encoding(True).GetBytes(logg & Environment.NewLine & ex.Message)
            fs.Write(info, 0, info.Length)
            fs.Close()
            MsgBox("error during process please read the log.txt file in the root of application", MsgBoxStyle.Critical)

            Dim proc = Process.GetProcessesByName("python")
            For i As Integer = 0 To proc.Count - 1
                proc(i).CloseMainWindow()
            Next i

            Dim proc1 = Process.GetProcessesByName("cmd")
            For i As Integer = 0 To proc.Count - 1
                proc(i).CloseMainWindow()
            Next i
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MsgBox("No Working for now sorry :(", MsgBoxStyle.Critical)

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        MsgBox("No Working for now sorry :(", MsgBoxStyle.Critical)

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        MsgBox("No Working for now sorry :(", MsgBoxStyle.Critical)

    End Sub
End Class
