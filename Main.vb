Public Class Main
    Private SSIDStr As String = ""
    Private PwdStr As String = ""
    Function RunCMD(ByVal Commands As String, Optional ByVal TimeOutMS As Integer = 1000) As String
        Dim myProcess As New Process()
        Dim myProcessStartInfo As New ProcessStartInfo("cmd.exe")
        myProcessStartInfo.UseShellExecute = False
        myProcessStartInfo.RedirectStandardOutput = True
        myProcessStartInfo.CreateNoWindow = True
        myProcessStartInfo.Arguments = "/c " & Commands
        myProcess.StartInfo = myProcessStartInfo
        myProcess.Start()
        myProcess.WaitForExit(TimeOutMS)
        Dim myStreamReader As IO.StreamReader = myProcess.StandardOutput
        Dim myString As String = myStreamReader.ReadToEnd()
        myProcess.Close()
        Return myString
    End Function
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim TmpStr As String = RunCMD("netsh wlan show hostednetwork", 100)
        CmdOut.Text = TmpStr
        If TmpStr.Contains("模式                   : 已启用") Then
            ModeON.Checked = True
        Else
            ModeOFF.Checked = True
        End If

        For i = 0 To TmpStr.Length - 1 Step 1
            If TmpStr.Chars(i) = Chr(&HA1B0) Then
                While Not TmpStr.Chars(i + 1) = Chr(&HA1B1)
                    SSIDStr = SSIDStr + TmpStr.Chars(i + 1)
                    i = i + 1
                End While
                Exit For
            End If
        Next i
        SSID.Text = SSIDStr

        If TmpStr.Contains("未启动") Then
            SwitchHosted.Text = "Start"
        Else
            SwitchHosted.Text = "Stop"
        End If
    End Sub

    Private Sub SetHosted_Click(sender As Object, e As EventArgs) Handles SetHosted.Click
        If ModeOFF.Checked Then CmdOut.Text = RunCMD("netsh wlan set hostednetwork mode=disallow", 100)
        If SSID.Text.Any And ModeON.Checked Then
            CmdOut.Text = RunCMD("netsh wlan set hostednetwork mode=allow ssid=" & SSID.Text & " key=" & Passwd.Text, 100)
            SwitchHosted.Enabled = True
        End If
    End Sub

    Private Sub SwitchHosted_Click(sender As Object, e As EventArgs) Handles SwitchHosted.Click
        If SwitchHosted.Text = "Start" Then
            CmdOut.Text = RunCMD("netsh wlan start hostednetwork")
            SwitchHosted.Text = "Stop"
        Else
            CmdOut.Text = RunCMD("netsh wlan stop hostednetwork")
            SwitchHosted.Text = "Start"
        End If
    End Sub

    Private Sub ModeON_CheckedChanged(sender As Object, e As EventArgs) Handles ModeON.CheckedChanged
        SwitchHosted.Enabled = False
    End Sub

    Private Sub ModeOFF_CheckedChanged(sender As Object, e As EventArgs) Handles ModeOFF.CheckedChanged
        SwitchHosted.Enabled = False
    End Sub
End Class
