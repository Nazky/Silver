Public Class cmd
    Shared Sub RunCommandCom(command As String, arguments As String, permanent As Boolean, Hide As Boolean)
        Dim p As Process = New Process()
        Dim pi As ProcessStartInfo = New ProcessStartInfo()
        pi.Arguments = " " + If(permanent = True, "/K", "/C") + " " + command + " " + arguments
        pi.FileName = "cmd.exe"
        pi.WindowStyle = If(Hide = True, ProcessWindowStyle.Hidden, ProcessWindowStyle.Normal)
        p.StartInfo = pi
        p.Start()
    End Sub
End Class