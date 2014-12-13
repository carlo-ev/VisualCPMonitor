Imports System.Xml
Imports System.IO
Imports System.Text

Public Class mainMenu

    Private Sub mainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblOs.Text = My.Computer.Info.OSFullName
        lblPlatform.Text = My.Computer.Info.OSPlatform
        lblVersion.Text = My.Computer.Info.OSVersion
        lblPhysical.Text = My.Computer.Info.TotalPhysicalMemory & " Bytes"
        lblPhysicalGB.Text = My.Computer.Info.TotalPhysicalMemory / 1000000000 & " GB"
        lblVirtual.Text = My.Computer.Info.TotalVirtualMemory & " Bytes"
        lblVirtualGB.Text = My.Computer.Info.TotalVirtualMemory / 1000000000 & " GB"
        lblPhysicalAvailable.Text = My.Computer.Info.AvailablePhysicalMemory & " Bytes"
        lblPhysicalAvailableGB.Text = My.Computer.Info.AvailablePhysicalMemory / 1000000000 & " GB"
        lblVirtualAvailable.Text = My.Computer.Info.AvailableVirtualMemory & " Bytes"
        lblVirtualAvailableGB.Text = My.Computer.Info.AvailableVirtualMemory / 1000000000 & " GB"
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        My.Forms.mainWindow.Controls.Remove(Me)
        My.Forms.mainWindow.Controls.Add(New loginScreen)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Forms.mainWindow.Controls.Remove(Me)
        My.Forms.mainWindow.Controls.Add(New detailedInfo)
    End Sub

    Private Sub btnDeviceSummary_Click(sender As Object, e As EventArgs) Handles btnDeviceSummary.Click
        My.Forms.mainWindow.Controls.Remove(Me)
        My.Forms.mainWindow.Controls.Add(New deviceSummary)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim writer As XmlTextWriter = New XmlTextWriter("specs.xml", Encoding.UTF8)

            writer.WriteStartDocument()

            writer.WriteStartElement("pc")

            writer.WriteStartElement("summary")
            writer.WriteStartElement("os")
            writer.WriteString(My.Computer.Info.OSFullName)
            writer.WriteEndElement()
            writer.WriteStartElement("version")
            writer.WriteString(My.Computer.Info.OSVersion)
            writer.WriteEndElement()
            writer.WriteStartElement("platform")
            writer.WriteString(My.Computer.Info.OSPlatform)
            writer.WriteEndElement()
            writer.WriteStartElement("virtualmemory")
            writer.WriteString(My.Computer.Info.TotalVirtualMemory / 1000000000 & "GB")
            writer.WriteEndElement()
            writer.WriteStartElement("physicalmemory")
            writer.WriteString(My.Computer.Info.TotalPhysicalMemory / 1000000000 & "GB")
            writer.WriteEndElement()
            writer.WriteEndElement()

            writer.WriteStartElement("devices")
            writer.WriteStartElement("audio")
            writer.WriteString(My.Computer.Audio.GetType.Module.Name)
            writer.WriteEndElement()
            writer.WriteStartElement("drives")
            For counter As Integer = 0 To My.Computer.FileSystem.Drives.Count() - 1
                writer.WriteStartElement("drive")
                writer.WriteString(My.Computer.FileSystem.Drives(counter).Name)
                writer.WriteEndElement()
            Next counter
            writer.WriteEndElement()
            writer.WriteStartElement("keyboard")
            writer.WriteString(My.Computer.Keyboard.GetType.AssemblyQualifiedName)
            writer.WriteEndElement()
            writer.WriteStartElement("mouse")
            writer.WriteString(My.Computer.Mouse.GetType.Module.FullyQualifiedName)
            writer.WriteEndElement()
            writer.WriteStartElement("network")
            writer.WriteString(My.Computer.Mouse.GetType.Module.FullyQualifiedName)
            writer.WriteEndElement()
            writer.WriteStartElement("screen")
            writer.WriteString(My.Computer.Screen.DeviceName)
            writer.WriteEndElement()
            writer.WriteEndElement()

            writer.WriteStartElement("cpu")
            writer.WriteStartElement("activeprocesses")
            Dim allProcess = Process.GetProcesses()
            For counter As Integer = 0 To allProcess.Count() - 1
                writer.WriteStartElement("process")
                writer.WriteString(allProcess(counter).ProcessName & "  " & allProcess(counter).NonpagedSystemMemorySize64 / 1000000000 & "GB")
                writer.WriteEndElement()
            Next counter
            writer.WriteEndElement()
            writer.WriteEndElement()

            writer.WriteStartElement("hardrives")
            For counter As Integer = 0 To My.Computer.FileSystem.Drives.Count() - 1
                If My.Computer.FileSystem.Drives(counter).IsReady Then
                    writer.WriteStartElement(My.Computer.FileSystem.Drives(counter).Name)
                    writer.WriteStartElement("totalspace")
                    writer.WriteString((My.Computer.FileSystem.Drives(counter).TotalSize / 1000000000) & "GB")
                    writer.WriteEndElement()
                    writer.WriteStartElement("freespace")
                    writer.WriteString((My.Computer.FileSystem.Drives(counter).TotalFreeSpace / 1000000000) & "GB")
                    writer.WriteEndElement()
                    writer.WriteStartElement("format")
                    writer.WriteString(My.Computer.FileSystem.Drives(counter).DriveFormat)
                    writer.WriteEndElement()
                    writer.WriteEndElement()
                End If
            Next counter
            writer.WriteEndElement()

            writer.WriteEndElement()

            writer.WriteEndDocument()
            writer.Flush()
            writer.Close()
            ToolStripStatusLabel1.Text = "XML File 'specs.xml' created successfully!"
        Catch exep As Exception
            ToolStripStatusLabel1.Text = "Failed to Create 'specs.xml' file!!"
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim clsRequest As System.Net.FtpWebRequest = DirectCast(System.Net.WebRequest.Create("ftp://01a4348.netsolhost.com/specs.xml"), System.Net.FtpWebRequest)
            clsRequest.Credentials = New System.Net.NetworkCredential("publico%01a4348", "Ceutec2013")
            clsRequest.Method = System.Net.WebRequestMethods.Ftp.UploadFile

            System.Console.WriteLine(Directory.GetCurrentDirectory() + "specs.xml")
            Dim bFile() As Byte = System.IO.File.ReadAllBytes(Directory.GetCurrentDirectory() + "\specs.xml")

            Dim clsStream As System.IO.Stream = clsRequest.GetRequestStream()
            clsStream.Write(bFile, 0, bFile.Length)
            clsStream.Close()
            clsStream.Dispose()
            ToolStripStatusLabel1.Text = "File Uploaded Successfully!!"
        Catch exep As Exception
            ToolStripStatusLabel1.Text = "Failed to Upload File!!"
        End Try
    End Sub
End Class
