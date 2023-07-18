<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.gbInputParameters = New System.Windows.Forms.GroupBox()
        Me.lblTip2 = New System.Windows.Forms.Label()
        Me.lblTip1 = New System.Windows.Forms.Label()
        Me.gbInfo = New System.Windows.Forms.GroupBox()
        Me.lblStatus4 = New System.Windows.Forms.Label()
        Me.lblStatus3 = New System.Windows.Forms.Label()
        Me.lblStatus2 = New System.Windows.Forms.Label()
        Me.lblStatus1 = New System.Windows.Forms.Label()
        Me.lblServiceName2 = New System.Windows.Forms.Label()
        Me.lblPassword2 = New System.Windows.Forms.Label()
        Me.lblPathToMyIni2 = New System.Windows.Forms.Label()
        Me.lblPathToMysqld2 = New System.Windows.Forms.Label()
        Me.btnDetect = New System.Windows.Forms.Button()
        Me.txtServiceName = New System.Windows.Forms.TextBox()
        Me.lblServiceName = New System.Windows.Forms.Label()
        Me.btnSET = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtPathToMyIni = New System.Windows.Forms.TextBox()
        Me.txtPathToMysqld = New System.Windows.Forms.TextBox()
        Me.btnBrowse1 = New System.Windows.Forms.Button()
        Me.btnBrowse2 = New System.Windows.Forms.Button()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblPathToMyIni = New System.Windows.Forms.Label()
        Me.lblPathToMysqld = New System.Windows.Forms.Label()
        Me.gbNotification = New System.Windows.Forms.GroupBox()
        Me.rtbNotification = New System.Windows.Forms.RichTextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.bwRun = New System.ComponentModel.BackgroundWorker()
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.gbInputParameters.SuspendLayout()
        Me.gbInfo.SuspendLayout()
        Me.gbNotification.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbInputParameters
        '
        Me.gbInputParameters.Controls.Add(Me.lblTip2)
        Me.gbInputParameters.Controls.Add(Me.lblTip1)
        Me.gbInputParameters.Controls.Add(Me.gbInfo)
        Me.gbInputParameters.Controls.Add(Me.btnDetect)
        Me.gbInputParameters.Controls.Add(Me.txtServiceName)
        Me.gbInputParameters.Controls.Add(Me.lblServiceName)
        Me.gbInputParameters.Controls.Add(Me.btnSET)
        Me.gbInputParameters.Controls.Add(Me.txtPassword)
        Me.gbInputParameters.Controls.Add(Me.txtPathToMyIni)
        Me.gbInputParameters.Controls.Add(Me.txtPathToMysqld)
        Me.gbInputParameters.Controls.Add(Me.btnBrowse1)
        Me.gbInputParameters.Controls.Add(Me.btnBrowse2)
        Me.gbInputParameters.Controls.Add(Me.lblPassword)
        Me.gbInputParameters.Controls.Add(Me.lblPathToMyIni)
        Me.gbInputParameters.Controls.Add(Me.lblPathToMysqld)
        Me.gbInputParameters.ForeColor = System.Drawing.Color.PapayaWhip
        Me.gbInputParameters.Location = New System.Drawing.Point(13, 12)
        Me.gbInputParameters.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.gbInputParameters.Name = "gbInputParameters"
        Me.gbInputParameters.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.gbInputParameters.Size = New System.Drawing.Size(861, 231)
        Me.gbInputParameters.TabIndex = 0
        Me.gbInputParameters.TabStop = False
        Me.gbInputParameters.Text = "Input Parameters"
        '
        'lblTip2
        '
        Me.lblTip2.AutoSize = True
        Me.lblTip2.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.lblTip2.Location = New System.Drawing.Point(535, 29)
        Me.lblTip2.Name = "lblTip2"
        Me.lblTip2.Size = New System.Drawing.Size(14, 14)
        Me.lblTip2.TabIndex = 13
        Me.lblTip2.Text = "?"
        '
        'lblTip1
        '
        Me.lblTip1.AutoSize = True
        Me.lblTip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.lblTip1.Location = New System.Drawing.Point(250, 29)
        Me.lblTip1.Name = "lblTip1"
        Me.lblTip1.Size = New System.Drawing.Size(14, 14)
        Me.lblTip1.TabIndex = 11
        Me.lblTip1.Text = "?"
        '
        'gbInfo
        '
        Me.gbInfo.Controls.Add(Me.lblStatus4)
        Me.gbInfo.Controls.Add(Me.lblStatus3)
        Me.gbInfo.Controls.Add(Me.lblStatus2)
        Me.gbInfo.Controls.Add(Me.lblStatus1)
        Me.gbInfo.Controls.Add(Me.lblServiceName2)
        Me.gbInfo.Controls.Add(Me.lblPassword2)
        Me.gbInfo.Controls.Add(Me.lblPathToMyIni2)
        Me.gbInfo.Controls.Add(Me.lblPathToMysqld2)
        Me.gbInfo.ForeColor = System.Drawing.Color.PapayaWhip
        Me.gbInfo.Location = New System.Drawing.Point(566, 29)
        Me.gbInfo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.gbInfo.Name = "gbInfo"
        Me.gbInfo.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.gbInfo.Size = New System.Drawing.Size(282, 185)
        Me.gbInfo.TabIndex = 3
        Me.gbInfo.TabStop = False
        Me.gbInfo.Text = "INFO"
        '
        'lblStatus4
        '
        Me.lblStatus4.BackColor = System.Drawing.Color.IndianRed
        Me.lblStatus4.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus4.ForeColor = System.Drawing.Color.Maroon
        Me.lblStatus4.Location = New System.Drawing.Point(159, 135)
        Me.lblStatus4.Name = "lblStatus4"
        Me.lblStatus4.Size = New System.Drawing.Size(108, 14)
        Me.lblStatus4.TabIndex = 8
        Me.lblStatus4.Text = "Not found"
        Me.lblStatus4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStatus3
        '
        Me.lblStatus3.BackColor = System.Drawing.Color.IndianRed
        Me.lblStatus3.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus3.ForeColor = System.Drawing.Color.Maroon
        Me.lblStatus3.Location = New System.Drawing.Point(159, 105)
        Me.lblStatus3.Name = "lblStatus3"
        Me.lblStatus3.Size = New System.Drawing.Size(108, 14)
        Me.lblStatus3.TabIndex = 7
        Me.lblStatus3.Text = "Not set"
        Me.lblStatus3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStatus2
        '
        Me.lblStatus2.BackColor = System.Drawing.Color.IndianRed
        Me.lblStatus2.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus2.ForeColor = System.Drawing.Color.Maroon
        Me.lblStatus2.Location = New System.Drawing.Point(159, 75)
        Me.lblStatus2.Name = "lblStatus2"
        Me.lblStatus2.Size = New System.Drawing.Size(108, 14)
        Me.lblStatus2.TabIndex = 6
        Me.lblStatus2.Text = "Not set"
        Me.lblStatus2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStatus1
        '
        Me.lblStatus1.BackColor = System.Drawing.Color.IndianRed
        Me.lblStatus1.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus1.ForeColor = System.Drawing.Color.Maroon
        Me.lblStatus1.Location = New System.Drawing.Point(159, 46)
        Me.lblStatus1.Name = "lblStatus1"
        Me.lblStatus1.Size = New System.Drawing.Size(108, 14)
        Me.lblStatus1.TabIndex = 5
        Me.lblStatus1.Text = "Not set"
        Me.lblStatus1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblServiceName2
        '
        Me.lblServiceName2.AutoSize = True
        Me.lblServiceName2.BackColor = System.Drawing.Color.Transparent
        Me.lblServiceName2.Location = New System.Drawing.Point(16, 135)
        Me.lblServiceName2.Name = "lblServiceName2"
        Me.lblServiceName2.Size = New System.Drawing.Size(98, 14)
        Me.lblServiceName2.TabIndex = 4
        Me.lblServiceName2.Text = "MySQL service"
        '
        'lblPassword2
        '
        Me.lblPassword2.AutoSize = True
        Me.lblPassword2.BackColor = System.Drawing.Color.Transparent
        Me.lblPassword2.Location = New System.Drawing.Point(16, 105)
        Me.lblPassword2.Name = "lblPassword2"
        Me.lblPassword2.Size = New System.Drawing.Size(63, 14)
        Me.lblPassword2.TabIndex = 3
        Me.lblPassword2.Text = "Password"
        '
        'lblPathToMyIni2
        '
        Me.lblPathToMyIni2.AutoSize = True
        Me.lblPathToMyIni2.BackColor = System.Drawing.Color.Transparent
        Me.lblPathToMyIni2.Location = New System.Drawing.Point(16, 75)
        Me.lblPathToMyIni2.Name = "lblPathToMyIni2"
        Me.lblPathToMyIni2.Size = New System.Drawing.Size(105, 14)
        Me.lblPathToMyIni2.TabIndex = 2
        Me.lblPathToMyIni2.Text = "Path to my.ini"
        '
        'lblPathToMysqld2
        '
        Me.lblPathToMysqld2.AutoSize = True
        Me.lblPathToMysqld2.BackColor = System.Drawing.Color.Transparent
        Me.lblPathToMysqld2.Location = New System.Drawing.Point(16, 45)
        Me.lblPathToMysqld2.Name = "lblPathToMysqld2"
        Me.lblPathToMysqld2.Size = New System.Drawing.Size(133, 14)
        Me.lblPathToMysqld2.TabIndex = 1
        Me.lblPathToMysqld2.Text = "Path to mysqld.exe"
        '
        'btnDetect
        '
        Me.btnDetect.Location = New System.Drawing.Point(14, 191)
        Me.btnDetect.Name = "btnDetect"
        Me.btnDetect.Size = New System.Drawing.Size(250, 23)
        Me.btnDetect.TabIndex = 4
        Me.btnDetect.Text = "Auto detect"
        Me.btnDetect.UseVisualStyleBackColor = True
        '
        'txtServiceName
        '
        Me.txtServiceName.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtServiceName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtServiceName.ForeColor = System.Drawing.Color.Black
        Me.txtServiceName.Location = New System.Drawing.Point(14, 161)
        Me.txtServiceName.Name = "txtServiceName"
        Me.txtServiceName.Size = New System.Drawing.Size(250, 15)
        Me.txtServiceName.TabIndex = 3
        Me.txtServiceName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblServiceName
        '
        Me.lblServiceName.AutoSize = True
        Me.lblServiceName.BackColor = System.Drawing.Color.Transparent
        Me.lblServiceName.Location = New System.Drawing.Point(11, 134)
        Me.lblServiceName.Name = "lblServiceName"
        Me.lblServiceName.Size = New System.Drawing.Size(133, 14)
        Me.lblServiceName.TabIndex = 10
        Me.lblServiceName.Text = "MySQL service name"
        '
        'btnSET
        '
        Me.btnSET.Enabled = False
        Me.btnSET.ForeColor = System.Drawing.Color.Firebrick
        Me.btnSET.Location = New System.Drawing.Point(299, 191)
        Me.btnSET.Name = "btnSET"
        Me.btnSET.Size = New System.Drawing.Size(250, 23)
        Me.btnSET.TabIndex = 6
        Me.btnSET.Text = "SET"
        Me.btnSET.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPassword.ForeColor = System.Drawing.Color.Black
        Me.txtPassword.Location = New System.Drawing.Point(299, 161)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(250, 15)
        Me.txtPassword.TabIndex = 5
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPathToMyIni
        '
        Me.txtPathToMyIni.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtPathToMyIni.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPathToMyIni.ForeColor = System.Drawing.Color.Black
        Me.txtPathToMyIni.Location = New System.Drawing.Point(299, 56)
        Me.txtPathToMyIni.Name = "txtPathToMyIni"
        Me.txtPathToMyIni.ReadOnly = True
        Me.txtPathToMyIni.Size = New System.Drawing.Size(250, 15)
        Me.txtPathToMyIni.TabIndex = 7
        Me.txtPathToMyIni.TabStop = False
        '
        'txtPathToMysqld
        '
        Me.txtPathToMysqld.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtPathToMysqld.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPathToMysqld.ForeColor = System.Drawing.Color.Black
        Me.txtPathToMysqld.Location = New System.Drawing.Point(14, 56)
        Me.txtPathToMysqld.Name = "txtPathToMysqld"
        Me.txtPathToMysqld.ReadOnly = True
        Me.txtPathToMysqld.Size = New System.Drawing.Size(250, 15)
        Me.txtPathToMysqld.TabIndex = 6
        Me.txtPathToMysqld.TabStop = False
        '
        'btnBrowse1
        '
        Me.btnBrowse1.Location = New System.Drawing.Point(14, 86)
        Me.btnBrowse1.Name = "btnBrowse1"
        Me.btnBrowse1.Size = New System.Drawing.Size(250, 23)
        Me.btnBrowse1.TabIndex = 1
        Me.btnBrowse1.Text = "Browse"
        Me.btnBrowse1.UseVisualStyleBackColor = True
        '
        'btnBrowse2
        '
        Me.btnBrowse2.Location = New System.Drawing.Point(299, 86)
        Me.btnBrowse2.Name = "btnBrowse2"
        Me.btnBrowse2.Size = New System.Drawing.Size(250, 23)
        Me.btnBrowse2.TabIndex = 2
        Me.btnBrowse2.Text = "Browse"
        Me.btnBrowse2.UseVisualStyleBackColor = True
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblPassword.ForeColor = System.Drawing.Color.Firebrick
        Me.lblPassword.Location = New System.Drawing.Point(296, 134)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(91, 14)
        Me.lblPassword.TabIndex = 2
        Me.lblPassword.Text = "New Password"
        '
        'lblPathToMyIni
        '
        Me.lblPathToMyIni.AutoSize = True
        Me.lblPathToMyIni.BackColor = System.Drawing.Color.Transparent
        Me.lblPathToMyIni.Location = New System.Drawing.Point(296, 29)
        Me.lblPathToMyIni.Name = "lblPathToMyIni"
        Me.lblPathToMyIni.Size = New System.Drawing.Size(140, 14)
        Me.lblPathToMyIni.TabIndex = 1
        Me.lblPathToMyIni.Text = "Path to my.ini file"
        '
        'lblPathToMysqld
        '
        Me.lblPathToMysqld.AutoSize = True
        Me.lblPathToMysqld.BackColor = System.Drawing.Color.Transparent
        Me.lblPathToMysqld.Location = New System.Drawing.Point(11, 29)
        Me.lblPathToMysqld.Name = "lblPathToMysqld"
        Me.lblPathToMysqld.Size = New System.Drawing.Size(133, 14)
        Me.lblPathToMysqld.TabIndex = 0
        Me.lblPathToMysqld.Text = "Path to mysqld.exe"
        '
        'gbNotification
        '
        Me.gbNotification.Controls.Add(Me.rtbNotification)
        Me.gbNotification.ForeColor = System.Drawing.Color.PapayaWhip
        Me.gbNotification.Location = New System.Drawing.Point(13, 261)
        Me.gbNotification.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.gbNotification.Name = "gbNotification"
        Me.gbNotification.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.gbNotification.Size = New System.Drawing.Size(861, 155)
        Me.gbNotification.TabIndex = 2
        Me.gbNotification.TabStop = False
        Me.gbNotification.Text = "Notification"
        '
        'rtbNotification
        '
        Me.rtbNotification.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.rtbNotification.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbNotification.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.rtbNotification.Location = New System.Drawing.Point(14, 23)
        Me.rtbNotification.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.rtbNotification.Name = "rtbNotification"
        Me.rtbNotification.ReadOnly = True
        Me.rtbNotification.Size = New System.Drawing.Size(834, 116)
        Me.rtbNotification.TabIndex = 1
        Me.rtbNotification.TabStop = False
        Me.rtbNotification.Text = ""
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.FileName = "OpenFileDialog1"
        '
        'bwRun
        '
        Me.bwRun.WorkerReportsProgress = True
        Me.bwRun.WorkerSupportsCancellation = True
        '
        'ProgressBar
        '
        Me.ProgressBar.Location = New System.Drawing.Point(14, 263)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(861, 11)
        Me.ProgressBar.TabIndex = 2
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 0
        Me.ToolTip1.BackColor = System.Drawing.SystemColors.HighlightText
        Me.ToolTip1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(889, 435)
        Me.Controls.Add(Me.ProgressBar)
        Me.Controls.Add(Me.gbNotification)
        Me.Controls.Add(Me.gbInputParameters)
        Me.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximumSize = New System.Drawing.Size(905, 470)
        Me.MinimumSize = New System.Drawing.Size(905, 470)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MySQL Root Password Reset [ https://github.com/idpNET]"
        Me.gbInputParameters.ResumeLayout(False)
        Me.gbInputParameters.PerformLayout()
        Me.gbInfo.ResumeLayout(False)
        Me.gbInfo.PerformLayout()
        Me.gbNotification.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbInputParameters As GroupBox
    Friend WithEvents gbNotification As GroupBox
    Friend WithEvents rtbNotification As RichTextBox
    Friend WithEvents txtPathToMyIni As TextBox
    Friend WithEvents txtPathToMysqld As TextBox
    Friend WithEvents btnBrowse1 As Button
    Friend WithEvents btnBrowse2 As Button
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblPathToMyIni As Label
    Friend WithEvents lblPathToMysqld As Label
    Friend WithEvents btnSET As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnDetect As Button
    Friend WithEvents txtServiceName As TextBox
    Friend WithEvents lblServiceName As Label
    Friend WithEvents gbInfo As GroupBox
    Friend WithEvents lblStatus4 As Label
    Friend WithEvents lblStatus3 As Label
    Friend WithEvents lblStatus2 As Label
    Friend WithEvents lblStatus1 As Label
    Friend WithEvents lblServiceName2 As Label
    Friend WithEvents lblPassword2 As Label
    Friend WithEvents lblPathToMyIni2 As Label
    Friend WithEvents lblPathToMysqld2 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents OpenFileDialog2 As OpenFileDialog
    Friend WithEvents bwRun As System.ComponentModel.BackgroundWorker
    Friend WithEvents ProgressBar As ProgressBar
    Friend WithEvents lblTip2 As Label
    Friend WithEvents lblTip1 As Label
    Friend WithEvents ToolTip1 As ToolTip
End Class
