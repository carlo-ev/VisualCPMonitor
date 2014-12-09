<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class detailedInfo
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend4 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.cpuTab = New System.Windows.Forms.TabControl()
        Me.cpuTabContent = New System.Windows.Forms.TabPage()
        Me.cpuList = New System.Windows.Forms.ListBox()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.cpuUsageText = New System.Windows.Forms.Label()
        Me.cpuBar = New System.Windows.Forms.ProgressBar()
        Me.lbl_cpuUsage = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.memoryList = New System.Windows.Forms.ListBox()
        Me.memoryChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.ramUsageText = New System.Windows.Forms.Label()
        Me.lbl_ramUsage = New System.Windows.Forms.Label()
        Me.ramBar = New System.Windows.Forms.ProgressBar()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.diskList = New System.Windows.Forms.ListBox()
        Me.diskChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.diskUsageText = New System.Windows.Forms.Label()
        Me.lbl_diskUsage = New System.Windows.Forms.Label()
        Me.diskBar = New System.Windows.Forms.ProgressBar()
        Me.cpuCounter = New System.Diagnostics.PerformanceCounter()
        Me.graphsTimer = New System.Windows.Forms.Timer(Me.components)
        Me.diskCounter = New System.Diagnostics.PerformanceCounter()
        Me.ramCounter = New System.Diagnostics.PerformanceCounter()
        Me.tablesTimer = New System.Windows.Forms.Timer(Me.components)
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.chartDiskUsage = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblUsed = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblFree = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblFormat = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblType = New System.Windows.Forms.Label()
        Me.lblLabel = New System.Windows.Forms.Label()
        Me.cpuTab.SuspendLayout()
        Me.cpuTabContent.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.memoryChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.diskChart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cpuCounter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.diskCounter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ramCounter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.chartDiskUsage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cpuTab
        '
        Me.cpuTab.AccessibleName = ""
        Me.cpuTab.Controls.Add(Me.cpuTabContent)
        Me.cpuTab.Controls.Add(Me.TabPage2)
        Me.cpuTab.Controls.Add(Me.TabPage3)
        Me.cpuTab.Controls.Add(Me.TabPage1)
        Me.cpuTab.Location = New System.Drawing.Point(0, 11)
        Me.cpuTab.Name = "cpuTab"
        Me.cpuTab.SelectedIndex = 0
        Me.cpuTab.Size = New System.Drawing.Size(575, 390)
        Me.cpuTab.TabIndex = 12
        '
        'cpuTabContent
        '
        Me.cpuTabContent.Controls.Add(Me.lbl_cpuUsage)
        Me.cpuTabContent.Controls.Add(Me.cpuList)
        Me.cpuTabContent.Controls.Add(Me.Chart1)
        Me.cpuTabContent.Controls.Add(Me.cpuUsageText)
        Me.cpuTabContent.Controls.Add(Me.cpuBar)
        Me.cpuTabContent.Location = New System.Drawing.Point(4, 22)
        Me.cpuTabContent.Name = "cpuTabContent"
        Me.cpuTabContent.Padding = New System.Windows.Forms.Padding(3)
        Me.cpuTabContent.Size = New System.Drawing.Size(567, 364)
        Me.cpuTabContent.TabIndex = 0
        Me.cpuTabContent.Text = "CPU"
        Me.cpuTabContent.UseVisualStyleBackColor = True
        '
        'cpuList
        '
        Me.cpuList.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cpuList.FormattingEnabled = True
        Me.cpuList.ItemHeight = 20
        Me.cpuList.Location = New System.Drawing.Point(11, 254)
        Me.cpuList.Name = "cpuList"
        Me.cpuList.Size = New System.Drawing.Size(550, 104)
        Me.cpuList.TabIndex = 11
        '
        'Chart1
        '
        Me.Chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight
        Me.Chart1.BorderSkin.BackColor = System.Drawing.SystemColors.GrayText
        Me.Chart1.BorderSkin.BorderColor = System.Drawing.Color.Transparent
        ChartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[False]
        ChartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Lime
        ChartArea1.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[False]
        ChartArea1.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[True]
        ChartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Lime
        ChartArea1.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[False]
        ChartArea1.BackColor = System.Drawing.Color.Black
        ChartArea1.BackSecondaryColor = System.Drawing.Color.White
        ChartArea1.BorderColor = System.Drawing.Color.White
        ChartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Enabled = False
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(-1, 31)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Light
        Me.Chart1.PaletteCustomColors = New System.Drawing.Color() {System.Drawing.Color.Lime}
        Series1.BorderColor = System.Drawing.Color.White
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series1.Color = System.Drawing.Color.White
        Series1.LabelForeColor = System.Drawing.Color.White
        Series1.Legend = "Legend1"
        Series1.MarkerColor = System.Drawing.Color.White
        Series1.Name = "CPU"
        Series1.XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary
        Series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[Single]
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(567, 197)
        Me.Chart1.TabIndex = 10
        Me.Chart1.Text = "cpuChart"
        '
        'cpuUsageText
        '
        Me.cpuUsageText.AutoSize = True
        Me.cpuUsageText.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cpuUsageText.Location = New System.Drawing.Point(6, 3)
        Me.cpuUsageText.Name = "cpuUsageText"
        Me.cpuUsageText.Size = New System.Drawing.Size(124, 25)
        Me.cpuUsageText.TabIndex = 1
        Me.cpuUsageText.Text = "CPU Usage"
        '
        'cpuBar
        '
        Me.cpuBar.Location = New System.Drawing.Point(3, 234)
        Me.cpuBar.Name = "cpuBar"
        Me.cpuBar.Size = New System.Drawing.Size(558, 10)
        Me.cpuBar.TabIndex = 2
        '
        'lbl_cpuUsage
        '
        Me.lbl_cpuUsage.AutoSize = True
        Me.lbl_cpuUsage.Location = New System.Drawing.Point(473, 218)
        Me.lbl_cpuUsage.Name = "lbl_cpuUsage"
        Me.lbl_cpuUsage.Size = New System.Drawing.Size(77, 13)
        Me.lbl_cpuUsage.TabIndex = 3
        Me.lbl_cpuUsage.Text = "CPU Usage: %"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ramUsageText)
        Me.TabPage2.Controls.Add(Me.lbl_ramUsage)
        Me.TabPage2.Controls.Add(Me.memoryList)
        Me.TabPage2.Controls.Add(Me.memoryChart)
        Me.TabPage2.Controls.Add(Me.ramBar)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(567, 359)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Memory"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'memoryList
        '
        Me.memoryList.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.memoryList.FormattingEnabled = True
        Me.memoryList.ItemHeight = 20
        Me.memoryList.Location = New System.Drawing.Point(6, 254)
        Me.memoryList.Name = "memoryList"
        Me.memoryList.Size = New System.Drawing.Size(555, 104)
        Me.memoryList.TabIndex = 11
        '
        'memoryChart
        '
        Me.memoryChart.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight
        ChartArea2.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[False]
        ChartArea2.AxisX.LineColor = System.Drawing.Color.Lime
        ChartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.Lime
        ChartArea2.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[False]
        ChartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.Lime
        ChartArea2.AxisY2.MajorGrid.LineColor = System.Drawing.Color.Lime
        ChartArea2.BackColor = System.Drawing.Color.Black
        ChartArea2.Name = "ChartArea1"
        Me.memoryChart.ChartAreas.Add(ChartArea2)
        Legend2.Enabled = False
        Legend2.Name = "Legend1"
        Me.memoryChart.Legends.Add(Legend2)
        Me.memoryChart.Location = New System.Drawing.Point(3, 26)
        Me.memoryChart.Name = "memoryChart"
        Me.memoryChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Light
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series2.Legend = "Legend1"
        Series2.Name = "MEMORY"
        Series2.XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary
        Series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[Single]
        Me.memoryChart.Series.Add(Series2)
        Me.memoryChart.Size = New System.Drawing.Size(561, 206)
        Me.memoryChart.TabIndex = 10
        Me.memoryChart.Text = "Chart2"
        '
        'ramUsageText
        '
        Me.ramUsageText.AutoSize = True
        Me.ramUsageText.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ramUsageText.Location = New System.Drawing.Point(6, 3)
        Me.ramUsageText.Name = "ramUsageText"
        Me.ramUsageText.Size = New System.Drawing.Size(157, 25)
        Me.ramUsageText.TabIndex = 7
        Me.ramUsageText.Text = "Memory Usage"
        '
        'lbl_ramUsage
        '
        Me.lbl_ramUsage.AutoSize = True
        Me.lbl_ramUsage.Location = New System.Drawing.Point(454, 221)
        Me.lbl_ramUsage.Name = "lbl_ramUsage"
        Me.lbl_ramUsage.Size = New System.Drawing.Size(92, 13)
        Me.lbl_ramUsage.TabIndex = 9
        Me.lbl_ramUsage.Text = "Memory Usage: %"
        '
        'ramBar
        '
        Me.ramBar.Location = New System.Drawing.Point(6, 238)
        Me.ramBar.Name = "ramBar"
        Me.ramBar.Size = New System.Drawing.Size(555, 10)
        Me.ramBar.TabIndex = 8
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.diskUsageText)
        Me.TabPage3.Controls.Add(Me.lbl_diskUsage)
        Me.TabPage3.Controls.Add(Me.diskList)
        Me.TabPage3.Controls.Add(Me.diskChart)
        Me.TabPage3.Controls.Add(Me.diskBar)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(567, 359)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Disk"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'diskList
        '
        Me.diskList.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.diskList.FormattingEnabled = True
        Me.diskList.ItemHeight = 20
        Me.diskList.Location = New System.Drawing.Point(7, 257)
        Me.diskList.Name = "diskList"
        Me.diskList.Size = New System.Drawing.Size(554, 104)
        Me.diskList.TabIndex = 9
        '
        'diskChart
        '
        Me.diskChart.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight
        ChartArea3.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[False]
        ChartArea3.AxisX.IsLabelAutoFit = False
        ChartArea3.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[False]
        ChartArea3.AxisX2.MajorGrid.LineColor = System.Drawing.Color.Lime
        ChartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.Lime
        ChartArea3.BackColor = System.Drawing.Color.Black
        ChartArea3.Name = "ChartArea1"
        Me.diskChart.ChartAreas.Add(ChartArea3)
        Legend3.Enabled = False
        Legend3.Name = "Legend1"
        Me.diskChart.Legends.Add(Legend3)
        Me.diskChart.Location = New System.Drawing.Point(7, 31)
        Me.diskChart.Name = "diskChart"
        Me.diskChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Light
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series3.Legend = "Legend1"
        Series3.Name = "DISK"
        Series3.XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary
        Me.diskChart.Series.Add(Series3)
        Me.diskChart.Size = New System.Drawing.Size(554, 204)
        Me.diskChart.TabIndex = 8
        Me.diskChart.Text = "Chart2"
        '
        'diskUsageText
        '
        Me.diskUsageText.AutoSize = True
        Me.diskUsageText.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.diskUsageText.Location = New System.Drawing.Point(6, 3)
        Me.diskUsageText.Name = "diskUsageText"
        Me.diskUsageText.Size = New System.Drawing.Size(122, 25)
        Me.diskUsageText.TabIndex = 4
        Me.diskUsageText.Text = "Disk Usage"
        '
        'lbl_diskUsage
        '
        Me.lbl_diskUsage.AutoSize = True
        Me.lbl_diskUsage.Location = New System.Drawing.Point(471, 225)
        Me.lbl_diskUsage.Name = "lbl_diskUsage"
        Me.lbl_diskUsage.Size = New System.Drawing.Size(76, 13)
        Me.lbl_diskUsage.TabIndex = 6
        Me.lbl_diskUsage.Text = "Disk Usage: %"
        '
        'diskBar
        '
        Me.diskBar.Location = New System.Drawing.Point(7, 241)
        Me.diskBar.Name = "diskBar"
        Me.diskBar.Size = New System.Drawing.Size(554, 10)
        Me.diskBar.TabIndex = 5
        '
        'cpuCounter
        '
        Me.cpuCounter.CategoryName = "Processor"
        Me.cpuCounter.CounterName = "% Processor Time"
        Me.cpuCounter.InstanceName = "_Total"
        '
        'graphsTimer
        '
        Me.graphsTimer.Enabled = True
        Me.graphsTimer.Interval = 1000
        '
        'diskCounter
        '
        Me.diskCounter.CategoryName = "PhysicalDisk"
        Me.diskCounter.CounterName = "% Disk Time"
        Me.diskCounter.InstanceName = "_Total"
        '
        'ramCounter
        '
        Me.ramCounter.CategoryName = "Memory"
        Me.ramCounter.CounterName = "% Committed Bytes In Use"
        '
        'tablesTimer
        '
        Me.tablesTimer.Enabled = True
        Me.tablesTimer.Interval = 5000
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lblLabel)
        Me.TabPage1.Controls.Add(Me.lblType)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.lblFormat)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.lblFree)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.lblUsed)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.lblTotal)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.chartDiskUsage)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(567, 364)
        Me.TabPage1.TabIndex = 3
        Me.TabPage1.Text = "Disk Storage"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'chartDiskUsage
        '
        ChartArea4.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal
        ChartArea4.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[True]
        ChartArea4.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[False]
        ChartArea4.Name = "ChartArea1"
        Me.chartDiskUsage.ChartAreas.Add(ChartArea4)
        Legend4.Name = "Legend1"
        Legend4.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Tall
        Me.chartDiskUsage.Legends.Add(Legend4)
        Me.chartDiskUsage.Location = New System.Drawing.Point(11, 31)
        Me.chartDiskUsage.Name = "chartDiskUsage"
        Series4.ChartArea = "ChartArea1"
        Series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series4.Legend = "Legend1"
        Series4.Name = "Usage"
        Me.chartDiskUsage.Series.Add(Series4)
        Me.chartDiskUsage.Size = New System.Drawing.Size(550, 201)
        Me.chartDiskUsage.TabIndex = 0
        Me.chartDiskUsage.Text = "Chart2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Disk Storage"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(476, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(160, 267)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Total Space"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(160, 291)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(51, 18)
        Me.lblTotal.TabIndex = 3
        Me.lblTotal.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(294, 267)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 24)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Used Space"
        '
        'lblUsed
        '
        Me.lblUsed.AutoSize = True
        Me.lblUsed.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsed.Location = New System.Drawing.Point(294, 291)
        Me.lblUsed.Name = "lblUsed"
        Me.lblUsed.Size = New System.Drawing.Size(51, 18)
        Me.lblUsed.TabIndex = 5
        Me.lblUsed.Text = "Label5"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(430, 267)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 24)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Free Space"
        '
        'lblFree
        '
        Me.lblFree.AutoSize = True
        Me.lblFree.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFree.Location = New System.Drawing.Point(430, 291)
        Me.lblFree.Name = "lblFree"
        Me.lblFree.Size = New System.Drawing.Size(51, 18)
        Me.lblFree.TabIndex = 7
        Me.lblFree.Text = "Label7"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 239)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 24)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Drive Format"
        '
        'lblFormat
        '
        Me.lblFormat.AutoSize = True
        Me.lblFormat.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormat.Location = New System.Drawing.Point(17, 267)
        Me.lblFormat.Name = "lblFormat"
        Me.lblFormat.Size = New System.Drawing.Size(66, 24)
        Me.lblFormat.TabIndex = 9
        Me.lblFormat.Text = "Label7"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(17, 295)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 24)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Drive Type"
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblType.Location = New System.Drawing.Point(17, 324)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(66, 24)
        Me.lblType.TabIndex = 11
        Me.lblType.Text = "Label7"
        '
        'lblLabel
        '
        Me.lblLabel.AutoSize = True
        Me.lblLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLabel.Location = New System.Drawing.Point(17, 208)
        Me.lblLabel.Name = "lblLabel"
        Me.lblLabel.Size = New System.Drawing.Size(66, 24)
        Me.lblLabel.TabIndex = 12
        Me.lblLabel.Text = "Label7"
        '
        'detailedInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cpuTab)
        Me.Name = "detailedInfo"
        Me.Size = New System.Drawing.Size(575, 401)
        Me.cpuTab.ResumeLayout(False)
        Me.cpuTabContent.ResumeLayout(False)
        Me.cpuTabContent.PerformLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.memoryChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.diskChart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cpuCounter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.diskCounter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ramCounter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.chartDiskUsage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cpuTab As System.Windows.Forms.TabControl
    Friend WithEvents cpuTabContent As System.Windows.Forms.TabPage
    Friend WithEvents lbl_cpuUsage As System.Windows.Forms.Label
    Friend WithEvents cpuList As System.Windows.Forms.ListBox
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents cpuUsageText As System.Windows.Forms.Label
    Friend WithEvents cpuBar As System.Windows.Forms.ProgressBar
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents ramUsageText As System.Windows.Forms.Label
    Friend WithEvents lbl_ramUsage As System.Windows.Forms.Label
    Friend WithEvents memoryList As System.Windows.Forms.ListBox
    Friend WithEvents memoryChart As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents ramBar As System.Windows.Forms.ProgressBar
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents diskUsageText As System.Windows.Forms.Label
    Friend WithEvents lbl_diskUsage As System.Windows.Forms.Label
    Friend WithEvents diskList As System.Windows.Forms.ListBox
    Friend WithEvents diskChart As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents diskBar As System.Windows.Forms.ProgressBar
    Friend WithEvents cpuCounter As System.Diagnostics.PerformanceCounter
    Friend WithEvents graphsTimer As System.Windows.Forms.Timer
    Friend WithEvents diskCounter As System.Diagnostics.PerformanceCounter
    Friend WithEvents ramCounter As System.Diagnostics.PerformanceCounter
    Friend WithEvents tablesTimer As System.Windows.Forms.Timer
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents chartDiskUsage As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lblFree As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblUsed As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblLabel As System.Windows.Forms.Label
    Friend WithEvents lblType As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblFormat As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
