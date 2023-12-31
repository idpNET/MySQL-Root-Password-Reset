﻿Imports System.ComponentModel
Imports System.IO
Imports System.ServiceProcess

Public Class frmMain
    Inherits System.Windows.Forms.Form
    Private stopwatch As Stopwatch ' Declare the Stopwatch object
    Private once_announced As Boolean = False ' Flag to track operation result detection and announcement
    Private isCancellationRequested As Boolean ' Flag to track cancellation request

    ' mysqld.exe browsing logic
    Private Sub btnBrowse1_Click(sender As Object, e As EventArgs) Handles btnBrowse1.Click
        Dim openFileDialog1 As New OpenFileDialog()
        ' Set filter to only accept mysqld.exe
        openFileDialog1.Filter = "mysqld.exe|mysqld.exe"
        openFileDialog1.Title = "Select mysqld.exe"

        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            txtPathToMysqld.Text = openFileDialog1.FileName
            Dim mysqldPath As String = txtPathToMysqld.Text
            ' Check if the mysqld.exe path exists
            If File.Exists(mysqldPath) Then
                lblStatus1.Text = "OK"
                lblStatus1.ForeColor = Color.FromArgb(0, 64, 0)
                lblStatus1.BackColor = Color.DarkOliveGreen
            Else
                lblStatus1.Text = "Not set"
                lblStatus1.ForeColor = Color.Maroon
                lblStatus1.BackColor = Color.IndianRed
            End If
        End If
    End Sub

    ' my.ini browsing logic
    Private Sub btnBrowse2_Click(sender As Object, e As EventArgs) Handles btnBrowse2.Click
        Dim openFileDialog2 As New OpenFileDialog()
        ' Set filter to only accept my.ini
        openFileDialog2.Filter = "my.ini|my.ini"
        openFileDialog2.Title = "Select my.ini"

        If openFileDialog2.ShowDialog() = DialogResult.OK Then
            txtPathToMyIni.Text = openFileDialog2.FileName
            Dim myIniPath As String = txtPathToMyIni.Text
            ' Check if the my.ini path exists
            If File.Exists(myIniPath) Then
                lblStatus2.Text = "OK"
                lblStatus2.ForeColor = Color.FromArgb(0, 64, 0)
                lblStatus2.BackColor = Color.DarkOliveGreen
            Else
                lblStatus2.Text = "Not set"
                lblStatus2.ForeColor = Color.Maroon
                lblStatus2.BackColor = Color.IndianRed
            End If
        End If
    End Sub

    ' Start password change operation
    Private Sub btnSET_Click(sender As Object, e As EventArgs) Handles btnSET.Click
        DisableControls()
        rtbNotification.Text = "" ' Reset notification before new operations 
        stopwatch = Stopwatch.StartNew() ' Start tracking process time
        isCancellationRequested = False
        bwRun.RunWorkerAsync()
    End Sub

    ' MySQL service auto detection logic
    Private Sub btnDetect_Click(sender As Object, e As EventArgs) Handles btnDetect.Click
        ' Attempt to auto-detect the MySQL service name
        Dim serviceName As String = FindMySQLServiceName()
        If Not String.IsNullOrEmpty(serviceName) Then
            txtServiceName.Text = serviceName
            lblStatus4.Text = "OK"
            lblStatus4.ForeColor = Color.FromArgb(0, 64, 0)
            lblStatus4.BackColor = Color.DarkOliveGreen
        Else
            txtServiceName.Text = "Not found"
            lblStatus4.Text = "Not found"
            lblStatus4.ForeColor = Color.Maroon
            lblStatus4.BackColor = Color.IndianRed
        End If
    End Sub

    ' MySQL service auto detection logic
    Private Function FindMySQLServiceName() As String
        ' Find a service name starting with "mysql"
        Dim services As ServiceController() = ServiceController.GetServices()
        For Each service As ServiceController In services
            If service.ServiceName.StartsWith("mysql", StringComparison.OrdinalIgnoreCase) Then
                Return service.ServiceName
            End If
        Next

        Return Nothing
    End Function

    ' Stop MySQL service
    Private Sub StopMySQLService()
        Dim serviceName As String = txtServiceName.Text
        Try
            Dim service As ServiceController = New ServiceController(serviceName)
            If service.Status = ServiceControllerStatus.Running Then
                service.Stop()
                service.WaitForStatus(ServiceControllerStatus.Stopped)
            End If
        Catch ex As Exception
            Throw New Exception("Failed to stop MySQL service: " & ex.Message & Environment.NewLine)
        End Try
    End Sub

    ' Start MySQL service
    Private Sub StartMySQLService()
        Dim serviceName As String = txtServiceName.Text
        Try
            Dim service As ServiceController = New ServiceController(serviceName)
            If service.Status = ServiceControllerStatus.Stopped Then
                service.Start()
                service.WaitForStatus(ServiceControllerStatus.Running)
            End If
        Catch ex As Exception
            Throw New Exception("Failed to start MySQL service: " & ex.Message & Environment.NewLine)
        End Try
    End Sub

    ' Terminate instances of mysqld.exe to release resource for further operations
    Private Sub KillMySQLDProcesses()
        Try
            Dim processes As Process() = Process.GetProcessesByName("mysqld")
            For Each process As Process In processes
                process.Kill()
                process.WaitForExit()
            Next
        Catch ex As Exception
            Throw New Exception("Failed to kill mysqld.exe process: " & ex.Message & Environment.NewLine)
        End Try
    End Sub

    ' Write text to notification 
    ' Write text to notification 
    Private Sub AppendTextToNotification(ByVal text As String)
        If rtbNotification.InvokeRequired Then
            rtbNotification.Invoke(Sub() AppendTextToNotification(text))
        Else
            Dim startIndex As Integer = rtbNotification.TextLength
            rtbNotification.AppendText(text & Environment.NewLine)
            rtbNotification.ScrollToCaret() ' Scroll to the end of the text

            ' Check for specific strings and apply formatting
            Dim searchString1 As String = "Operation completed in"
            Dim searchString2 As String = "Password change failed. Killing mysqld.exe processes ..."
            Dim searchString3 As String = "Password successfully changed. Killing mysqld.exe processes ..."

            If text.Contains(searchString1) Then
                rtbNotification.Select(startIndex, text.Length)
                rtbNotification.SelectionBackColor = Color.DimGray
            ElseIf text.Contains(searchString2) Then
                rtbNotification.Select(startIndex, text.Length)
                rtbNotification.SelectionColor = Color.Red
                rtbNotification.SelectionBackColor = Color.FromArgb(40, 40, 40)
            ElseIf text.Contains(searchString3) Then
                rtbNotification.Select(startIndex, text.Length)
                rtbNotification.SelectionColor = Color.LimeGreen
                rtbNotification.SelectionBackColor = Color.FromArgb(40, 40, 40)
            End If
        End If
    End Sub


    ' Password check logic
    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        If (txtPassword.TextLength >= 5) Then
            lblStatus3.Text = "OK"
            lblStatus3.ForeColor = Color.FromArgb(0, 64, 0)
            lblStatus3.BackColor = Color.DarkOliveGreen
            btnSET.Enabled = True
        Else
            lblStatus3.Text = "Not OK"
            lblStatus3.ForeColor = Color.Maroon
            lblStatus3.BackColor = Color.IndianRed
            btnSET.Enabled = False
        End If
    End Sub

    ' Service name manual input logic
    Private Sub txtServiceName_TextChanged(sender As Object, e As EventArgs) Handles txtServiceName.TextChanged
        lblStatus4.Text = "Manually set"
        lblStatus4.ForeColor = Color.SaddleBrown
        lblStatus4.BackColor = Color.Khaki
    End Sub

    ' Run mysqld.exe command to change password
    Sub RunCommandAsAdministrator(ByVal command As String, ByVal workingDirectory As String)
        Try
            Dim processInfo As New ProcessStartInfo("cmd.exe")
            processInfo.WindowStyle = ProcessWindowStyle.Hidden
            processInfo.Verb = "runas" ' Run as administrator
            processInfo.WorkingDirectory = workingDirectory ' Set the current working directory to the MySQL bin directory
            processInfo.Arguments = $"/C {command}"
            processInfo.UseShellExecute = False
            processInfo.RedirectStandardOutput = True
            processInfo.RedirectStandardError = True
            processInfo.CreateNoWindow = True ' Prevent the command prompt window from showing up

            Dim process As Process = New Process()
            process.StartInfo = processInfo
            process.EnableRaisingEvents = True
            process.Start()

            ' Event handler for capturing the output
            AddHandler process.OutputDataReceived, AddressOf Process_OutputDataReceived
            AddHandler process.ErrorDataReceived, AddressOf Process_ErrorDataReceived

            process.BeginOutputReadLine()
            process.BeginErrorReadLine()

            process.WaitForExit()
        Catch ex As Exception
            Throw New Exception("Failed to run command: " & ex.Message)
        End Try
    End Sub

    ' Write mysqld.exe outputs to notifications
    Private Sub Process_OutputDataReceived(sender As Object, e As DataReceivedEventArgs)
        If e.Data IsNot Nothing Then
            ' Append the output to the notification control
            AppendTextToNotification(e.Data & Environment.NewLine)
        End If
    End Sub

    ' Write mysqld.exe output errors to notifications
    Private Sub Process_ErrorDataReceived(sender As Object, e As DataReceivedEventArgs)
        If e.Data IsNot Nothing Then
            ' Append the error output to the notification control
            AppendTextToNotification(e.Data & Environment.NewLine)
        End If
    End Sub

    ' Operation status check logic
    Private Sub rtbNotification_TextChanged(sender As Object, e As EventArgs) Handles rtbNotification.TextChanged
        Dim text As String = rtbNotification.Text

        ' Check for success or failure strings
        If text.IndexOf("ready for connections. Version", StringComparison.OrdinalIgnoreCase) >= 0 Then
            If (Not once_announced) Then
                ' Operation is successful, release all cmd instances
                AppendTextToNotification("Password successfully changed. Killing mysqld.exe processes ...")
                KillMySQLDProcesses()
                once_announced = True
            End If
        ElseIf text.IndexOf("Shutdown", StringComparison.OrdinalIgnoreCase) >= 0 Or text.IndexOf("Program aborted", StringComparison.OrdinalIgnoreCase) >= 0 Then
            If (Not once_announced) Then
                ' Operation is unsuccessful
                AppendTextToNotification("Password change failed. Killing mysqld.exe processes ...")
                AppendTextToNotification("")
                KillMySQLDProcesses()
                once_announced = True
            End If
        End If
    End Sub

    ' BackgroundWorker reportage
    Private Sub bwRun_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bwRun.ProgressChanged
        ProgressBar.Value = e.ProgressPercentage
        AppendTextToNotification(e.UserState.ToString())
    End Sub

    ' BackgroundWorker completion
    Private Sub bwRun_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwRun.RunWorkerCompleted
        stopwatch.Stop()

        ' Get the elapsed time in milliseconds
        Dim elapsedMilliseconds As Long = stopwatch.ElapsedMilliseconds

        ' Display the elapsed time
        AppendTextToNotification($"Operation completed in {elapsedMilliseconds} ms.")

        ' Reset the stopwatch
        stopwatch.Reset()

        ' Enable the button
        EnableControls()
        ' Reset announcement flag
        once_announced = False
    End Sub

    ' Disable UI controls to prevent conflicts in process procedure
    Sub DisableControls()
        txtPassword.Enabled = False
        txtPathToMyIni.Enabled = False
        txtPathToMysqld.Enabled = False
        txtServiceName.Enabled = False
        btnBrowse1.Enabled = False
        btnBrowse2.Enabled = False
        btnDetect.Enabled = False
        btnSET.Enabled = False
    End Sub

    ' ReEnable UI controls after process completion
    Sub EnableControls()
        txtPassword.Enabled = True
        txtPathToMyIni.Enabled = True
        txtPathToMysqld.Enabled = True
        txtServiceName.Enabled = True
        btnBrowse1.Enabled = True
        btnBrowse2.Enabled = True
        btnDetect.Enabled = True
        btnSET.Enabled = True
    End Sub

    ' ' BackgroundWorker Work
    Private Sub bwRun_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwRun.DoWork
        ' Check if cancellation is requested before starting any operations
        If isCancellationRequested Then
            e.Cancel = True ' Set the cancellation flag in the event args
            Return ' Exit the method
        End If

        Try
            ' Variable decelerations for password change operation
            Dim mysqldPath As String = txtPathToMysqld.Text
            Dim myIniPath As String = txtPathToMyIni.Text
            Dim newPassword As String = txtPassword.Text
            Dim mysqlBinDirectory As String = Path.GetDirectoryName(mysqldPath) ' Dir to mysqld.exe file
            Dim tempFolderPath As String = Path.GetTempPath() ' Get windows temp folder
            Dim tempFileName As String = Path.GetRandomFileName() ' Get a random file name
            Dim tempFilePath As String = Path.Combine(tempFolderPath, tempFileName) ' Dir to temp file to be used in mysqld command
            Dim mysqlCommand As String = $"mysqld --defaults-file=""{myIniPath}"" --init-file=""{tempFilePath}"" --console""" ' mysqld command to change password

            ' Write the alter statement to the temp file
            File.WriteAllText(tempFilePath, $"alter user 'root'@'localhost' identified by '{newPassword}';")

            ' Check if cancellation is requested before starting any operations
            If isCancellationRequested Then
                e.Cancel = True ' Set the cancellation flag in the event args
                Return ' Exit the method
            End If



            ' Report progress to update the progress bar
            bwRun.ReportProgress(0, "Stopping MySQL service... (UI might look unresponsive for a while)")
            StopMySQLService()

            ' Check if cancellation is requested before starting any operations
            If isCancellationRequested Then
                e.Cancel = True ' Set the cancellation flag in the event args
                Return ' Exit the method
            End If

            bwRun.ReportProgress(10, "mysqld.exe processes killed.")
            KillMySQLDProcesses()

            ' Check if cancellation is requested before starting any operations
            If isCancellationRequested Then
                e.Cancel = True ' Set the cancellation flag in the event args
                Return ' Exit the method
            End If

            bwRun.ReportProgress(30, "Attempting to change root user password ...")
            RunCommandAsAdministrator(mysqlCommand, mysqlBinDirectory)

            ' Check if cancellation is requested before starting any operations
            If isCancellationRequested Then
                e.Cancel = True ' Set the cancellation flag in the event args
                Return ' Exit the method
            End If

            bwRun.ReportProgress(80, "Restarting MySQL service ... (UI might look unresponsive for a while)")
            StartMySQLService()

            ' Check if cancellation is requested before starting any operations
            If isCancellationRequested Then
                e.Cancel = True ' Set the cancellation flag in the event args
                Return ' Exit the method
            End If
            File.Delete(tempFilePath)
            bwRun.ReportProgress(100, "")
        Catch ex As Exception
            ' Handle the exception and request cancellation
            AppendTextToNotification(ex.Message)
            e.Cancel = True ' Set the cancellation flag in the event args
        End Try
    End Sub
    ' Set tool tip
    Private Sub lblTip1_MouseHover(sender As Object, e As EventArgs) Handles lblTip1.MouseHover
        ToolTip1.SetToolTip(lblTip1, "By default, file should be in : " &
                            Environment.NewLine &
                            "<windows installation drive>\Program Files\MySQL\MySQL Server <Version>\mysql.exe")

    End Sub

    ' Set tool tip
    Private Sub lblTip2_MouseHover(sender As Object, e As EventArgs) Handles lblTip2.MouseHover
        ToolTip1.SetToolTip(lblTip2, "By default, file should be in : " &
                          Environment.NewLine &
                          "<windows installation drive>\ProgramData\MySQL\MySQL Server <Version>\my.ini")
    End Sub
    ' Set tool tip
    Private Sub lblTip1_MouseClick(sender As Object, e As MouseEventArgs) Handles lblTip1.MouseClick
        ToolTip1.SetToolTip(lblTip1, "By default, file should be in : " &
                          Environment.NewLine &
                          "<windows installation drive>\Program Files\MySQL\MySQL Server <Version>\mysql.exe")
    End Sub
    ' Set tool tip
    Private Sub lblTip2_MouseClick(sender As Object, e As MouseEventArgs) Handles lblTip2.MouseClick
        ToolTip1.SetToolTip(lblTip2, "By default, file should be in : " &
                        Environment.NewLine &
                        "<windows installation drive>\ProgramData\MySQL\MySQL Server <Version>\my.ini")
    End Sub
End Class
