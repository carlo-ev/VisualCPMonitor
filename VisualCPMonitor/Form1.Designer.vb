<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.cpuUsageText = New System.Windows.Forms.Label()
        Me.cpuCounter = New System.Diagnostics.PerformanceCounter()
        Me.cpuBar = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_cpuUsage = New System.Windows.Forms.Label()
        Me.diskUsageText = New System.Windows.Forms.Label()
        Me.diskBar = New System.Windows.Forms.ProgressBar()
        Me.lbl_diskUsage = New System.Windows.Forms.Label()
        Me.diskCounter = New System.Diagnostics.PerformanceCounter()
        Me.ramUsageText = New System.Windows.Forms.Label()
        Me.ramBar = New System.Windows.Forms.ProgressBar()
        Me.lbl_ramUsage = New System.Windows.Forms.Label()
        Me.ramCounter = New System.Diagnostics.PerformanceCounter()
        CType(Me.cpuCounter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.diskCounter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ramCounter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cpuUsageText
        '
        Me.cpuUsageText.AutoSize = True
        Me.cpuUsageText.Location = New System.Drawing.Point(12, 41)
        Me.cpuUsageText.Name = "cpuUsageText"
        Me.cpuUsageText.Size = New System.Drawing.Size(66, 13)
        Me.cpuUsageText.TabIndex = 1
        Me.cpuUsageText.Text = "CPU Usage:"
        '
        'cpuCounter
        '
        Me.cpuCounter.CategoryName = "Processor"
        Me.cpuCounter.CounterName = "% Processor Time"
        Me.cpuCounter.InstanceName = "_Total"
        '
        'cpuBar
        '
        Me.cpuBar.Location = New System.Drawing.Point(84, 35)
        Me.cpuBar.Name = "cpuBar"
        Me.cpuBar.Size = New System.Drawing.Size(194, 23)
        Me.cpuBar.TabIndex = 2
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'lbl_cpuUsage
        '
        Me.lbl_cpuUsage.AutoSize = True
        Me.lbl_cpuUsage.Location = New System.Drawing.Point(180, 61)
        Me.lbl_cpuUsage.Name = "lbl_cpuUsage"
        Me.lbl_cpuUsage.Size = New System.Drawing.Size(77, 13)
        Me.lbl_cpuUsage.TabIndex = 3
        Me.lbl_cpuUsage.Text = "CPU Usage: %"
        '
        'diskUsageText
        '
        Me.diskUsageText.AutoSize = True
        Me.diskUsageText.Location = New System.Drawing.Point(12, 89)
        Me.diskUsageText.Name = "diskUsageText"
        Me.diskUsageText.Size = New System.Drawing.Size(65, 13)
        Me.diskUsageText.TabIndex = 4
        Me.diskUsageText.Text = "Disk Usage:"
        '
        'diskBar
        '
        Me.diskBar.Location = New System.Drawing.Point(84, 84)
        Me.diskBar.Name = "diskBar"
        Me.diskBar.Size = New System.Drawing.Size(194, 23)
        Me.diskBar.TabIndex = 5
        '
        'lbl_diskUsage
        '
        Me.lbl_diskUsage.AutoSize = True
        Me.lbl_diskUsage.Location = New System.Drawing.Point(183, 114)
        Me.lbl_diskUsage.Name = "lbl_diskUsage"
        Me.lbl_diskUsage.Size = New System.Drawing.Size(76, 13)
        Me.lbl_diskUsage.TabIndex = 6
        Me.lbl_diskUsage.Text = "Disk Usage: %"
        '
        'diskCounter
        '
        Me.diskCounter.CategoryName = "PhysicalDisk"
        Me.diskCounter.CounterName = "% Disk Time"
        Me.diskCounter.InstanceName = "_Total"
        '
        'ramUsageText
        '
        Me.ramUsageText.AutoSize = True
        Me.ramUsageText.Location = New System.Drawing.Point(15, 143)
        Me.ramUsageText.Name = "ramUsageText"
        Me.ramUsageText.Size = New System.Drawing.Size(68, 13)
        Me.ramUsageText.TabIndex = 7
        Me.ramUsageText.Text = "RAM Usage:"
        '
        'ramBar
        '
        Me.ramBar.Location = New System.Drawing.Point(84, 138)
        Me.ramBar.Name = "ramBar"
        Me.ramBar.Size = New System.Drawing.Size(194, 23)
        Me.ramBar.TabIndex = 8
        '
        'lbl_ramUsage
        '
        Me.lbl_ramUsage.AutoSize = True
        Me.lbl_ramUsage.Location = New System.Drawing.Point(183, 168)
        Me.lbl_ramUsage.Name = "lbl_ramUsage"
        Me.lbl_ramUsage.Size = New System.Drawing.Size(79, 13)
        Me.lbl_ramUsage.TabIndex = 9
        Me.lbl_ramUsage.Text = "RAM Usage: %"
        '
        'ramCounter
        '
        Me.ramCounter.CategoryName = "Memory"
        Me.ramCounter.CounterName = "% Committed Bytes In Use"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 269)
        Me.Controls.Add(Me.lbl_ramUsage)
        Me.Controls.Add(Me.ramBar)
        Me.Controls.Add(Me.ramUsageText)
        Me.Controls.Add(Me.lbl_diskUsage)
        Me.Controls.Add(Me.diskBar)
        Me.Controls.Add(Me.diskUsageText)
        Me.Controls.Add(Me.lbl_cpuUsage)
        Me.Controls.Add(Me.cpuBar)
        Me.Controls.Add(Me.cpuUsageText)
        Me.Name = "Form1"
        Me.Text = "Performance Manager"
        CType(Me.cpuCounter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.diskCounter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ramCounter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cpuUsageText As System.Windows.Forms.Label
    Friend WithEvents cpuCounter As System.Diagnostics.PerformanceCounter
    Friend WithEvents cpuBar As System.Windows.Forms.ProgressBar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lbl_cpuUsage As System.Windows.Forms.Label
    Friend WithEvents diskUsageText As System.Windows.Forms.Label
    Friend WithEvents diskBar As System.Windows.Forms.ProgressBar
    Friend WithEvents lbl_diskUsage As System.Windows.Forms.Label
    Friend WithEvents diskCounter As System.Diagnostics.PerformanceCounter
    Friend WithEvents ramUsageText As System.Windows.Forms.Label
    Friend WithEvents ramBar As System.Windows.Forms.ProgressBar
    Friend WithEvents lbl_ramUsage As System.Windows.Forms.Label
    Friend WithEvents ramCounter As System.Diagnostics.PerformanceCounter

End Class
