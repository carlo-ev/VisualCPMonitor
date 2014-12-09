Public Class detailedInfo

    Private Sub graphsTimer_Tick(sender As Object, e As EventArgs) Handles graphsTimer.Tick

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles graphsTimer.Tick
        cpuBar.Value = cpuCounter.NextValue.ToString
        lbl_cpuUsage.Text = "CPU Usage: " + cpuBar.Value.ToString + "%"
        Chart1.Series("CPU").Points.AddY(cpuBar.Value)


        Dim diskValue = diskCounter.NextValue
        diskBar.Value = If(diskValue <= 100, diskValue.ToString, "100")
        lbl_diskUsage.Text = "Disk Usage: " + diskBar.Value.ToString + "%"
        diskChart.Series("DISK").Points.AddY(diskBar.Value)

        ramBar.Value = ramCounter.NextValue.ToString
        lbl_ramUsage.Text = "RAM Usage: " + ramBar.Value.ToString + "%"
        memoryChart.Series("MEMORY").Points.AddY(ramBar.Value)
    End Sub

    Private Sub tablesTimer_Tick(sender As Object, e As EventArgs) Handles tablesTimer.Tick
        Dim allProcess = Process.GetProcesses()

        Dim processCount = allProcess.Count - 1

        cpuList.Items.Clear()
        diskList.Items.Clear()
        For counter As Integer = 0 To processCount Step 1
            Dim process = allProcess(counter)
            cpuList.Items.Add((counter + 1).ToString & "     " & process.ProcessName.ToString)
            If allProcess(counter).PagedMemorySize64 > 0 Then
                diskList.Items.Add((counter + 1).ToString & "     " & process.ProcessName.ToString & "     " & process.PagedSystemMemorySize64.ToString & "KB")
            End If
            If process.NonpagedSystemMemorySize64 > 0 Then
                memoryList.Items.Add((counter + 1).ToString & "     " & process.ProcessName.ToString & "     " & process.NonpagedSystemMemorySize64.ToString & "KB")
            End If
        Next counter

    End Sub

    Private Sub chartDiskUsage_Click(sender As Object, e As EventArgs) Handles chartDiskUsage.Click

    End Sub

    Private Sub detailedInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim total = (My.Computer.FileSystem.Drives.First.TotalSize / 1000000000)
        Dim free = My.Computer.FileSystem.Drives.First.TotalFreeSpace / 1000000000
        Dim used = total - free
        Dim label = My.Computer.FileSystem.Drives.First.Name
        Dim format = My.Computer.FileSystem.Drives.First.DriveFormat
        Dim type = My.Computer.FileSystem.Drives.First.DriveType
        chartDiskUsage.Series("Usage").Points.Add(My.Computer.FileSystem.Drives.First.TotalFreeSpace).Label = "Free"
        chartDiskUsage.Series("Usage").Points.Add(My.Computer.FileSystem.Drives.First.TotalSize - My.Computer.FileSystem.Drives.First.TotalFreeSpace).Label = "Used"

        lblTotal.Text = total & "GB"
        lblFree.Text = free & "GB"
        lblUsed.Text = used & "GB"
        lblLabel.Text = label
        lblFormat.Text = format
        lblType.Text = type

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Forms.mainWindow.Controls.Remove(Me)
        My.Forms.mainWindow.Controls.Add(New mainMenu)
    End Sub
End Class
