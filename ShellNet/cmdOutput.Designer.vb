<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cmdOutput
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
        Me.ClsControlMenu1 = New ShellNet.clsControlMenu()
        Me.BonfireLabelHeader1 = New ShellNet.BonfireLabelHeader()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ClsControlMenu1
        '
        Me.ClsControlMenu1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClsControlMenu1.Customization = "8u/v/////wD///8A"
        Me.ClsControlMenu1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.ClsControlMenu1.Image = Nothing
        Me.ClsControlMenu1.Location = New System.Drawing.Point(380, 0)
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
        Me.BonfireLabelHeader1.Location = New System.Drawing.Point(0, 2)
        Me.BonfireLabelHeader1.Name = "BonfireLabelHeader1"
        Me.BonfireLabelHeader1.Size = New System.Drawing.Size(121, 17)
        Me.BonfireLabelHeader1.TabIndex = 1
        Me.BonfireLabelHeader1.Text = "Output - DDoS"
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Location = New System.Drawing.Point(12, 22)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox1.Size = New System.Drawing.Size(426, 214)
        Me.TextBox1.TabIndex = 2
        '
        'cmdOutput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 248)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.BonfireLabelHeader1)
        Me.Controls.Add(Me.ClsControlMenu1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "cmdOutput"
        Me.Text = "cmdOutput"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ClsControlMenu1 As clsControlMenu
    Friend WithEvents BonfireLabelHeader1 As BonfireLabelHeader
    Friend WithEvents TextBox1 As TextBox
End Class
