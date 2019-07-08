<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.tc_areas = New System.Windows.Forms.TabControl()
        Me.tp_hardware = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbl_hardware_networkswitchcount = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dg_hardware_nodes = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dcol_hardware_nodes_sw = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dg_hardware_ports = New System.Windows.Forms.DataGridView()
        Me.dg_hardware_comports_portname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dg_hardware_comports_hardware = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dg_hardware_comports_version = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_scanning = New System.Windows.Forms.Label()
        Me.btn_port_autoconfig = New System.Windows.Forms.Button()
        Me.tp_terminal = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btn_comm_sa = New System.Windows.Forms.Button()
        Me.btn_comm_cn = New System.Windows.Forms.Button()
        Me.btn_comm_id = New System.Windows.Forms.Button()
        Me.cb_terminal_includecr = New System.Windows.Forms.CheckBox()
        Me.lbl_Terminal_CPU = New System.Windows.Forms.Label()
        Me.cb_terminal_port = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_terminal_console = New System.Windows.Forms.TextBox()
        Me.btn_terminal_sendcustom = New System.Windows.Forms.Button()
        Me.lbl_Terminal_CMD = New System.Windows.Forms.Label()
        Me.txt_terminal_command = New System.Windows.Forms.TextBox()
        Me.tp_rgbleds = New System.Windows.Forms.TabPage()
        Me.btn_rgb_changecolor2 = New System.Windows.Forms.Button()
        Me.pnl_color2 = New System.Windows.Forms.Panel()
        Me.btn_SetLED = New System.Windows.Forms.Button()
        Me.num_LEDNumber = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btn_rgb_stopfadeall = New System.Windows.Forms.Button()
        Me.btn_rgb_fadeallleds = New System.Windows.Forms.Button()
        Me.btn_rgb_setallleds = New System.Windows.Forms.Button()
        Me.btn_rgb_changecolor = New System.Windows.Forms.Button()
        Me.pnl_color = New System.Windows.Forms.Panel()
        Me.tp_switches = New System.Windows.Forms.TabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.lbl_recent_switch = New System.Windows.Forms.Label()
        Me.chk_use_tts = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dg_switches_switchlist = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_switches_activity = New System.Windows.Forms.TextBox()
        Me.tp_drivers = New System.Windows.Forms.TabPage()
        Me.cb_pulse_pwm = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.num_pulse_ms = New System.Windows.Forms.NumericUpDown()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lv_DriverInformation = New System.Windows.Forms.ListView()
        Me.Attribute = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Value = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btn_ExecuteDriver = New System.Windows.Forms.Button()
        Me.lst_Drivers = New System.Windows.Forms.ListBox()
        Me.btn_comm_wd0 = New System.Windows.Forms.Button()
        Me.tc_areas.SuspendLayout()
        Me.tp_hardware.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dg_hardware_nodes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg_hardware_ports, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.tp_terminal.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.tp_rgbleds.SuspendLayout()
        CType(Me.num_LEDNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tp_switches.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.dg_switches_switchlist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tp_drivers.SuspendLayout()
        CType(Me.num_pulse_ms, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tc_areas
        '
        Me.tc_areas.Controls.Add(Me.tp_hardware)
        Me.tc_areas.Controls.Add(Me.tp_terminal)
        Me.tc_areas.Controls.Add(Me.tp_rgbleds)
        Me.tc_areas.Controls.Add(Me.tp_switches)
        Me.tc_areas.Controls.Add(Me.tp_drivers)
        Me.tc_areas.Location = New System.Drawing.Point(12, 12)
        Me.tc_areas.Name = "tc_areas"
        Me.tc_areas.SelectedIndex = 0
        Me.tc_areas.Size = New System.Drawing.Size(700, 551)
        Me.tc_areas.TabIndex = 0
        '
        'tp_hardware
        '
        Me.tp_hardware.Controls.Add(Me.GroupBox2)
        Me.tp_hardware.Controls.Add(Me.GroupBox1)
        Me.tp_hardware.Location = New System.Drawing.Point(4, 22)
        Me.tp_hardware.Name = "tp_hardware"
        Me.tp_hardware.Size = New System.Drawing.Size(692, 525)
        Me.tp_hardware.TabIndex = 1
        Me.tp_hardware.Text = "Hardware"
        Me.tp_hardware.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbl_hardware_networkswitchcount)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.dg_hardware_nodes)
        Me.GroupBox2.Controls.Add(Me.dg_hardware_ports)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 103)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(682, 394)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Step 2: Review Hardware"
        '
        'lbl_hardware_networkswitchcount
        '
        Me.lbl_hardware_networkswitchcount.AutoSize = True
        Me.lbl_hardware_networkswitchcount.Location = New System.Drawing.Point(116, 367)
        Me.lbl_hardware_networkswitchcount.Name = "lbl_hardware_networkswitchcount"
        Me.lbl_hardware_networkswitchcount.Size = New System.Drawing.Size(13, 13)
        Me.lbl_hardware_networkswitchcount.TabIndex = 10
        Me.lbl_hardware_networkswitchcount.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 367)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Network Switches:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "FAST Nodes:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "FAST Ports:"
        '
        'dg_hardware_nodes
        '
        Me.dg_hardware_nodes.AllowUserToAddRows = False
        Me.dg_hardware_nodes.AllowUserToDeleteRows = False
        Me.dg_hardware_nodes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_hardware_nodes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.dcol_hardware_nodes_sw, Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.dg_hardware_nodes.Location = New System.Drawing.Point(17, 175)
        Me.dg_hardware_nodes.MultiSelect = False
        Me.dg_hardware_nodes.Name = "dg_hardware_nodes"
        Me.dg_hardware_nodes.ReadOnly = True
        Me.dg_hardware_nodes.RowHeadersVisible = False
        Me.dg_hardware_nodes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_hardware_nodes.Size = New System.Drawing.Size(631, 165)
        Me.dg_hardware_nodes.TabIndex = 6
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Node"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Node"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 60
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NodeName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Node Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Version"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Version"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 60
        '
        'dcol_hardware_nodes_sw
        '
        Me.dcol_hardware_nodes_sw.DataPropertyName = "SW"
        Me.dcol_hardware_nodes_sw.HeaderText = "SW"
        Me.dcol_hardware_nodes_sw.Name = "dcol_hardware_nodes_sw"
        Me.dcol_hardware_nodes_sw.ReadOnly = True
        Me.dcol_hardware_nodes_sw.Width = 30
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "DR"
        Me.Column1.HeaderText = "DR"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 30
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "XI"
        Me.Column2.HeaderText = "XI"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 30
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "XO"
        Me.Column3.HeaderText = "XO"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 30
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.DataPropertyName = "SerialNumber"
        Me.Column4.HeaderText = "Serial Number"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'dg_hardware_ports
        '
        Me.dg_hardware_ports.AllowUserToAddRows = False
        Me.dg_hardware_ports.AllowUserToDeleteRows = False
        Me.dg_hardware_ports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_hardware_ports.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dg_hardware_comports_portname, Me.dg_hardware_comports_hardware, Me.dg_hardware_comports_version, Me.Column5})
        Me.dg_hardware_ports.Location = New System.Drawing.Point(17, 56)
        Me.dg_hardware_ports.MultiSelect = False
        Me.dg_hardware_ports.Name = "dg_hardware_ports"
        Me.dg_hardware_ports.ReadOnly = True
        Me.dg_hardware_ports.RowHeadersVisible = False
        Me.dg_hardware_ports.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_hardware_ports.Size = New System.Drawing.Size(631, 90)
        Me.dg_hardware_ports.TabIndex = 5
        '
        'dg_hardware_comports_portname
        '
        Me.dg_hardware_comports_portname.DataPropertyName = "PortName"
        Me.dg_hardware_comports_portname.HeaderText = "Port Name"
        Me.dg_hardware_comports_portname.Name = "dg_hardware_comports_portname"
        Me.dg_hardware_comports_portname.ReadOnly = True
        Me.dg_hardware_comports_portname.Width = 85
        '
        'dg_hardware_comports_hardware
        '
        Me.dg_hardware_comports_hardware.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.dg_hardware_comports_hardware.DataPropertyName = "HardwareName"
        Me.dg_hardware_comports_hardware.HeaderText = "Hardware Detected"
        Me.dg_hardware_comports_hardware.Name = "dg_hardware_comports_hardware"
        Me.dg_hardware_comports_hardware.ReadOnly = True
        '
        'dg_hardware_comports_version
        '
        Me.dg_hardware_comports_version.DataPropertyName = "HardwareVersion"
        Me.dg_hardware_comports_version.HeaderText = "Version"
        Me.dg_hardware_comports_version.Name = "dg_hardware_comports_version"
        Me.dg_hardware_comports_version.ReadOnly = True
        Me.dg_hardware_comports_version.Width = 70
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "RawIDString"
        Me.Column5.HeaderText = "ID"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 175
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl_scanning)
        Me.GroupBox1.Controls.Add(Me.btn_port_autoconfig)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(682, 82)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Step 1: Find FAST Hardware"
        '
        'lbl_scanning
        '
        Me.lbl_scanning.AutoSize = True
        Me.lbl_scanning.Location = New System.Drawing.Point(224, 37)
        Me.lbl_scanning.Name = "lbl_scanning"
        Me.lbl_scanning.Size = New System.Drawing.Size(127, 13)
        Me.lbl_scanning.TabIndex = 5
        Me.lbl_scanning.Text = "Please Wait, Scanning...."
        Me.lbl_scanning.Visible = False
        '
        'btn_port_autoconfig
        '
        Me.btn_port_autoconfig.Location = New System.Drawing.Point(24, 32)
        Me.btn_port_autoconfig.Name = "btn_port_autoconfig"
        Me.btn_port_autoconfig.Size = New System.Drawing.Size(194, 23)
        Me.btn_port_autoconfig.TabIndex = 4
        Me.btn_port_autoconfig.Text = "Click Here To Scan For Hardware"
        Me.btn_port_autoconfig.UseVisualStyleBackColor = True
        '
        'tp_terminal
        '
        Me.tp_terminal.Controls.Add(Me.GroupBox4)
        Me.tp_terminal.Location = New System.Drawing.Point(4, 22)
        Me.tp_terminal.Name = "tp_terminal"
        Me.tp_terminal.Size = New System.Drawing.Size(692, 525)
        Me.tp_terminal.TabIndex = 2
        Me.tp_terminal.Text = "Terminal"
        Me.tp_terminal.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.GroupBox3)
        Me.GroupBox4.Controls.Add(Me.cb_terminal_includecr)
        Me.GroupBox4.Controls.Add(Me.lbl_Terminal_CPU)
        Me.GroupBox4.Controls.Add(Me.cb_terminal_port)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.txt_terminal_console)
        Me.GroupBox4.Controls.Add(Me.btn_terminal_sendcustom)
        Me.GroupBox4.Controls.Add(Me.lbl_Terminal_CMD)
        Me.GroupBox4.Controls.Add(Me.txt_terminal_command)
        Me.GroupBox4.Location = New System.Drawing.Point(15, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(657, 510)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Step 2: Communicate"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btn_comm_wd0)
        Me.GroupBox3.Controls.Add(Me.btn_comm_sa)
        Me.GroupBox3.Controls.Add(Me.btn_comm_cn)
        Me.GroupBox3.Controls.Add(Me.btn_comm_id)
        Me.GroupBox3.Location = New System.Drawing.Point(24, 99)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(607, 84)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Common Commands"
        '
        'btn_comm_sa
        '
        Me.btn_comm_sa.Location = New System.Drawing.Point(162, 19)
        Me.btn_comm_sa.Name = "btn_comm_sa"
        Me.btn_comm_sa.Size = New System.Drawing.Size(140, 23)
        Me.btn_comm_sa.TabIndex = 2
        Me.btn_comm_sa.Text = "Switch Data (SA)"
        Me.btn_comm_sa.UseVisualStyleBackColor = True
        '
        'btn_comm_cn
        '
        Me.btn_comm_cn.Location = New System.Drawing.Point(16, 48)
        Me.btn_comm_cn.Name = "btn_comm_cn"
        Me.btn_comm_cn.Size = New System.Drawing.Size(140, 23)
        Me.btn_comm_cn.TabIndex = 1
        Me.btn_comm_cn.Text = "Configured Nodes (CN)"
        Me.btn_comm_cn.UseVisualStyleBackColor = True
        '
        'btn_comm_id
        '
        Me.btn_comm_id.Location = New System.Drawing.Point(16, 19)
        Me.btn_comm_id.Name = "btn_comm_id"
        Me.btn_comm_id.Size = New System.Drawing.Size(140, 23)
        Me.btn_comm_id.TabIndex = 0
        Me.btn_comm_id.Text = "Processor ID (ID)"
        Me.btn_comm_id.UseVisualStyleBackColor = True
        '
        'cb_terminal_includecr
        '
        Me.cb_terminal_includecr.AutoSize = True
        Me.cb_terminal_includecr.Checked = True
        Me.cb_terminal_includecr.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cb_terminal_includecr.Location = New System.Drawing.Point(384, 37)
        Me.cb_terminal_includecr.Name = "cb_terminal_includecr"
        Me.cb_terminal_includecr.Size = New System.Drawing.Size(79, 17)
        Me.cb_terminal_includecr.TabIndex = 6
        Me.cb_terminal_includecr.Text = "Include CR"
        Me.cb_terminal_includecr.UseVisualStyleBackColor = True
        '
        'lbl_Terminal_CPU
        '
        Me.lbl_Terminal_CPU.AutoSize = True
        Me.lbl_Terminal_CPU.Location = New System.Drawing.Point(21, 42)
        Me.lbl_Terminal_CPU.Name = "lbl_Terminal_CPU"
        Me.lbl_Terminal_CPU.Size = New System.Drawing.Size(32, 13)
        Me.lbl_Terminal_CPU.TabIndex = 5
        Me.lbl_Terminal_CPU.Text = "CPU:"
        '
        'cb_terminal_port
        '
        Me.cb_terminal_port.DisplayMember = "HardwareName"
        Me.cb_terminal_port.FormattingEnabled = True
        Me.cb_terminal_port.Location = New System.Drawing.Point(84, 39)
        Me.cb_terminal_port.Name = "cb_terminal_port"
        Me.cb_terminal_port.Size = New System.Drawing.Size(288, 21)
        Me.cb_terminal_port.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 186)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Terminal:"
        '
        'txt_terminal_console
        '
        Me.txt_terminal_console.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_terminal_console.Location = New System.Drawing.Point(24, 202)
        Me.txt_terminal_console.Multiline = True
        Me.txt_terminal_console.Name = "txt_terminal_console"
        Me.txt_terminal_console.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_terminal_console.Size = New System.Drawing.Size(607, 287)
        Me.txt_terminal_console.TabIndex = 3
        '
        'btn_terminal_sendcustom
        '
        Me.btn_terminal_sendcustom.Location = New System.Drawing.Point(384, 64)
        Me.btn_terminal_sendcustom.Name = "btn_terminal_sendcustom"
        Me.btn_terminal_sendcustom.Size = New System.Drawing.Size(194, 23)
        Me.btn_terminal_sendcustom.TabIndex = 2
        Me.btn_terminal_sendcustom.Text = "Send Custom Command"
        Me.btn_terminal_sendcustom.UseVisualStyleBackColor = True
        '
        'lbl_Terminal_CMD
        '
        Me.lbl_Terminal_CMD.AutoSize = True
        Me.lbl_Terminal_CMD.Location = New System.Drawing.Point(21, 69)
        Me.lbl_Terminal_CMD.Name = "lbl_Terminal_CMD"
        Me.lbl_Terminal_CMD.Size = New System.Drawing.Size(57, 13)
        Me.lbl_Terminal_CMD.TabIndex = 1
        Me.lbl_Terminal_CMD.Text = "Command:"
        '
        'txt_terminal_command
        '
        Me.txt_terminal_command.Location = New System.Drawing.Point(84, 67)
        Me.txt_terminal_command.Name = "txt_terminal_command"
        Me.txt_terminal_command.Size = New System.Drawing.Size(288, 20)
        Me.txt_terminal_command.TabIndex = 0
        '
        'tp_rgbleds
        '
        Me.tp_rgbleds.Controls.Add(Me.btn_rgb_changecolor2)
        Me.tp_rgbleds.Controls.Add(Me.pnl_color2)
        Me.tp_rgbleds.Controls.Add(Me.btn_SetLED)
        Me.tp_rgbleds.Controls.Add(Me.num_LEDNumber)
        Me.tp_rgbleds.Controls.Add(Me.Label8)
        Me.tp_rgbleds.Controls.Add(Me.btn_rgb_stopfadeall)
        Me.tp_rgbleds.Controls.Add(Me.btn_rgb_fadeallleds)
        Me.tp_rgbleds.Controls.Add(Me.btn_rgb_setallleds)
        Me.tp_rgbleds.Controls.Add(Me.btn_rgb_changecolor)
        Me.tp_rgbleds.Controls.Add(Me.pnl_color)
        Me.tp_rgbleds.Location = New System.Drawing.Point(4, 22)
        Me.tp_rgbleds.Name = "tp_rgbleds"
        Me.tp_rgbleds.Size = New System.Drawing.Size(692, 525)
        Me.tp_rgbleds.TabIndex = 0
        Me.tp_rgbleds.Text = "RGB LEDs"
        Me.tp_rgbleds.UseVisualStyleBackColor = True
        '
        'btn_rgb_changecolor2
        '
        Me.btn_rgb_changecolor2.Location = New System.Drawing.Point(463, 26)
        Me.btn_rgb_changecolor2.Name = "btn_rgb_changecolor2"
        Me.btn_rgb_changecolor2.Size = New System.Drawing.Size(98, 22)
        Me.btn_rgb_changecolor2.TabIndex = 8
        Me.btn_rgb_changecolor2.Text = "Change Color"
        Me.btn_rgb_changecolor2.UseVisualStyleBackColor = True
        '
        'pnl_color2
        '
        Me.pnl_color2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_color2.Location = New System.Drawing.Point(380, 26)
        Me.pnl_color2.Name = "pnl_color2"
        Me.pnl_color2.Size = New System.Drawing.Size(70, 53)
        Me.pnl_color2.TabIndex = 1
        '
        'btn_SetLED
        '
        Me.btn_SetLED.Location = New System.Drawing.Point(380, 160)
        Me.btn_SetLED.Name = "btn_SetLED"
        Me.btn_SetLED.Size = New System.Drawing.Size(181, 34)
        Me.btn_SetLED.TabIndex = 7
        Me.btn_SetLED.Text = "Set Above LED This Color"
        Me.btn_SetLED.UseVisualStyleBackColor = True
        '
        'num_LEDNumber
        '
        Me.num_LEDNumber.Location = New System.Drawing.Point(454, 125)
        Me.num_LEDNumber.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.num_LEDNumber.Name = "num_LEDNumber"
        Me.num_LEDNumber.Size = New System.Drawing.Size(107, 20)
        Me.num_LEDNumber.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(377, 127)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "LED Number:"
        '
        'btn_rgb_stopfadeall
        '
        Me.btn_rgb_stopfadeall.Location = New System.Drawing.Point(43, 215)
        Me.btn_rgb_stopfadeall.Name = "btn_rgb_stopfadeall"
        Me.btn_rgb_stopfadeall.Size = New System.Drawing.Size(181, 34)
        Me.btn_rgb_stopfadeall.TabIndex = 4
        Me.btn_rgb_stopfadeall.Text = "Stop Fade"
        Me.btn_rgb_stopfadeall.UseVisualStyleBackColor = True
        '
        'btn_rgb_fadeallleds
        '
        Me.btn_rgb_fadeallleds.Location = New System.Drawing.Point(43, 175)
        Me.btn_rgb_fadeallleds.Name = "btn_rgb_fadeallleds"
        Me.btn_rgb_fadeallleds.Size = New System.Drawing.Size(181, 34)
        Me.btn_rgb_fadeallleds.TabIndex = 3
        Me.btn_rgb_fadeallleds.Text = "Fade All LEDs This Color"
        Me.btn_rgb_fadeallleds.UseVisualStyleBackColor = True
        '
        'btn_rgb_setallleds
        '
        Me.btn_rgb_setallleds.Location = New System.Drawing.Point(43, 116)
        Me.btn_rgb_setallleds.Name = "btn_rgb_setallleds"
        Me.btn_rgb_setallleds.Size = New System.Drawing.Size(181, 34)
        Me.btn_rgb_setallleds.TabIndex = 2
        Me.btn_rgb_setallleds.Text = "Set All LEDs This Color"
        Me.btn_rgb_setallleds.UseVisualStyleBackColor = True
        '
        'btn_rgb_changecolor
        '
        Me.btn_rgb_changecolor.Location = New System.Drawing.Point(133, 26)
        Me.btn_rgb_changecolor.Name = "btn_rgb_changecolor"
        Me.btn_rgb_changecolor.Size = New System.Drawing.Size(98, 22)
        Me.btn_rgb_changecolor.TabIndex = 1
        Me.btn_rgb_changecolor.Text = "Change Color"
        Me.btn_rgb_changecolor.UseVisualStyleBackColor = True
        '
        'pnl_color
        '
        Me.pnl_color.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_color.Location = New System.Drawing.Point(43, 26)
        Me.pnl_color.Name = "pnl_color"
        Me.pnl_color.Size = New System.Drawing.Size(70, 53)
        Me.pnl_color.TabIndex = 0
        '
        'tp_switches
        '
        Me.tp_switches.Controls.Add(Me.GroupBox5)
        Me.tp_switches.Controls.Add(Me.chk_use_tts)
        Me.tp_switches.Controls.Add(Me.Label7)
        Me.tp_switches.Controls.Add(Me.dg_switches_switchlist)
        Me.tp_switches.Controls.Add(Me.Label6)
        Me.tp_switches.Controls.Add(Me.txt_switches_activity)
        Me.tp_switches.Location = New System.Drawing.Point(4, 22)
        Me.tp_switches.Name = "tp_switches"
        Me.tp_switches.Size = New System.Drawing.Size(692, 525)
        Me.tp_switches.TabIndex = 3
        Me.tp_switches.Text = "Switches"
        Me.tp_switches.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.lbl_recent_switch)
        Me.GroupBox5.Location = New System.Drawing.Point(15, 43)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(363, 102)
        Me.GroupBox5.TabIndex = 9
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Most Recent Activity"
        '
        'lbl_recent_switch
        '
        Me.lbl_recent_switch.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_recent_switch.Location = New System.Drawing.Point(10, 16)
        Me.lbl_recent_switch.Name = "lbl_recent_switch"
        Me.lbl_recent_switch.Size = New System.Drawing.Size(347, 72)
        Me.lbl_recent_switch.TabIndex = 0
        Me.lbl_recent_switch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chk_use_tts
        '
        Me.chk_use_tts.AutoSize = True
        Me.chk_use_tts.Checked = True
        Me.chk_use_tts.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_use_tts.Location = New System.Drawing.Point(15, 20)
        Me.chk_use_tts.Name = "chk_use_tts"
        Me.chk_use_tts.Size = New System.Drawing.Size(100, 17)
        Me.chk_use_tts.TabIndex = 8
        Me.chk_use_tts.Text = "Use TTS (Beta)"
        Me.chk_use_tts.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(392, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Switches:"
        '
        'dg_switches_switchlist
        '
        Me.dg_switches_switchlist.AllowUserToAddRows = False
        Me.dg_switches_switchlist.AllowUserToDeleteRows = False
        Me.dg_switches_switchlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_switches_switchlist.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.dg_switches_switchlist.Location = New System.Drawing.Point(395, 36)
        Me.dg_switches_switchlist.MultiSelect = False
        Me.dg_switches_switchlist.Name = "dg_switches_switchlist"
        Me.dg_switches_switchlist.ReadOnly = True
        Me.dg_switches_switchlist.RowHeadersVisible = False
        Me.dg_switches_switchlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_switches_switchlist.Size = New System.Drawing.Size(240, 471)
        Me.dg_switches_switchlist.TabIndex = 6
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "DisplayName"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Closed"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Closed"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 161)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Switch Actvity:"
        '
        'txt_switches_activity
        '
        Me.txt_switches_activity.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_switches_activity.Location = New System.Drawing.Point(15, 177)
        Me.txt_switches_activity.Multiline = True
        Me.txt_switches_activity.Name = "txt_switches_activity"
        Me.txt_switches_activity.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_switches_activity.Size = New System.Drawing.Size(363, 330)
        Me.txt_switches_activity.TabIndex = 0
        '
        'tp_drivers
        '
        Me.tp_drivers.Controls.Add(Me.cb_pulse_pwm)
        Me.tp_drivers.Controls.Add(Me.Label10)
        Me.tp_drivers.Controls.Add(Me.num_pulse_ms)
        Me.tp_drivers.Controls.Add(Me.Label9)
        Me.tp_drivers.Controls.Add(Me.Label1)
        Me.tp_drivers.Controls.Add(Me.lv_DriverInformation)
        Me.tp_drivers.Controls.Add(Me.btn_ExecuteDriver)
        Me.tp_drivers.Controls.Add(Me.lst_Drivers)
        Me.tp_drivers.Location = New System.Drawing.Point(4, 22)
        Me.tp_drivers.Name = "tp_drivers"
        Me.tp_drivers.Size = New System.Drawing.Size(692, 525)
        Me.tp_drivers.TabIndex = 5
        Me.tp_drivers.Text = "Drivers"
        Me.tp_drivers.UseVisualStyleBackColor = True
        '
        'cb_pulse_pwm
        '
        Me.cb_pulse_pwm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_pulse_pwm.FormattingEnabled = True
        Me.cb_pulse_pwm.Items.AddRange(New Object() {"12.5", "25", "37.5", "50", "62.5", "75", "87.5", "100"})
        Me.cb_pulse_pwm.Location = New System.Drawing.Point(291, 484)
        Me.cb_pulse_pwm.Name = "cb_pulse_pwm"
        Me.cb_pulse_pwm.Size = New System.Drawing.Size(74, 21)
        Me.cb_pulse_pwm.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(237, 487)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 13)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "PWM %:"
        '
        'num_pulse_ms
        '
        Me.num_pulse_ms.Location = New System.Drawing.Point(113, 485)
        Me.num_pulse_ms.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.num_pulse_ms.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.num_pulse_ms.Name = "num_pulse_ms"
        Me.num_pulse_ms.Size = New System.Drawing.Size(71, 20)
        Me.num_pulse_ms.TabIndex = 6
        Me.num_pulse_ms.Value = New Decimal(New Integer() {15, 0, 0, 0})
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(52, 487)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Pulse MS:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Drivers:"
        '
        'lv_DriverInformation
        '
        Me.lv_DriverInformation.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Attribute, Me.Value})
        Me.lv_DriverInformation.Location = New System.Drawing.Point(240, 38)
        Me.lv_DriverInformation.Name = "lv_DriverInformation"
        Me.lv_DriverInformation.Size = New System.Drawing.Size(430, 432)
        Me.lv_DriverInformation.TabIndex = 3
        Me.lv_DriverInformation.UseCompatibleStateImageBehavior = False
        Me.lv_DriverInformation.View = System.Windows.Forms.View.Details
        '
        'Attribute
        '
        Me.Attribute.Text = "Attribute"
        Me.Attribute.Width = 186
        '
        'Value
        '
        Me.Value.Text = "Value"
        Me.Value.Width = 189
        '
        'btn_ExecuteDriver
        '
        Me.btn_ExecuteDriver.Location = New System.Drawing.Point(595, 487)
        Me.btn_ExecuteDriver.Name = "btn_ExecuteDriver"
        Me.btn_ExecuteDriver.Size = New System.Drawing.Size(75, 23)
        Me.btn_ExecuteDriver.TabIndex = 2
        Me.btn_ExecuteDriver.Text = "Pulse"
        Me.btn_ExecuteDriver.UseVisualStyleBackColor = True
        '
        'lst_Drivers
        '
        Me.lst_Drivers.DisplayMember = "ID"
        Me.lst_Drivers.FormattingEnabled = True
        Me.lst_Drivers.Location = New System.Drawing.Point(16, 38)
        Me.lst_Drivers.Name = "lst_Drivers"
        Me.lst_Drivers.Size = New System.Drawing.Size(205, 433)
        Me.lst_Drivers.TabIndex = 0
        '
        'btn_comm_wd0
        '
        Me.btn_comm_wd0.Location = New System.Drawing.Point(162, 48)
        Me.btn_comm_wd0.Name = "btn_comm_wd0"
        Me.btn_comm_wd0.Size = New System.Drawing.Size(140, 23)
        Me.btn_comm_wd0.TabIndex = 3
        Me.btn_comm_wd0.Text = "Disable Watchdog (WD:0)"
        Me.btn_comm_wd0.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(727, 575)
        Me.Controls.Add(Me.tc_areas)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.Text = "FAST Pinball Test Playground"
        Me.tc_areas.ResumeLayout(False)
        Me.tp_hardware.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dg_hardware_nodes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg_hardware_ports, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tp_terminal.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.tp_rgbleds.ResumeLayout(False)
        Me.tp_rgbleds.PerformLayout()
        CType(Me.num_LEDNumber, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tp_switches.ResumeLayout(False)
        Me.tp_switches.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.dg_switches_switchlist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tp_drivers.ResumeLayout(False)
        Me.tp_drivers.PerformLayout()
        CType(Me.num_pulse_ms, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tc_areas As System.Windows.Forms.TabControl
    Friend WithEvents tp_rgbleds As System.Windows.Forms.TabPage
    Friend WithEvents btn_port_autoconfig As System.Windows.Forms.Button
    Friend WithEvents btn_rgb_setallleds As System.Windows.Forms.Button
    Friend WithEvents btn_rgb_changecolor As System.Windows.Forms.Button
    Friend WithEvents pnl_color As System.Windows.Forms.Panel
    Friend WithEvents btn_rgb_fadeallleds As System.Windows.Forms.Button
    Friend WithEvents tp_hardware As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dg_hardware_ports As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tp_terminal As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_terminal_sendcustom As System.Windows.Forms.Button
    Friend WithEvents lbl_Terminal_CMD As System.Windows.Forms.Label
    Friend WithEvents txt_terminal_command As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_terminal_console As System.Windows.Forms.TextBox
    Friend WithEvents cb_terminal_port As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dg_hardware_nodes As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dcol_hardware_nodes_sw As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tp_switches As System.Windows.Forms.TabPage
    Friend WithEvents txt_switches_activity As System.Windows.Forms.TextBox
    Friend WithEvents dg_hardware_comports_portname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dg_hardware_comports_hardware As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dg_hardware_comports_version As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lbl_hardware_networkswitchcount As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dg_switches_switchlist As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btn_rgb_stopfadeall As System.Windows.Forms.Button
    Friend WithEvents tp_drivers As TabPage
    Friend WithEvents lst_Drivers As ListBox
    Friend WithEvents lbl_Terminal_CPU As Label
    Friend WithEvents btn_ExecuteDriver As Button
    Friend WithEvents lv_DriverInformation As ListView
    Friend WithEvents Attribute As ColumnHeader
    Friend WithEvents Value As ColumnHeader
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_SetLED As System.Windows.Forms.Button
    Friend WithEvents num_LEDNumber As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btn_rgb_changecolor2 As System.Windows.Forms.Button
    Friend WithEvents pnl_color2 As System.Windows.Forms.Panel
    Friend WithEvents cb_terminal_includecr As CheckBox
    Friend WithEvents lbl_scanning As Label
    Friend WithEvents cb_pulse_pwm As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents num_pulse_ms As NumericUpDown
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btn_comm_cn As Button
    Friend WithEvents btn_comm_id As Button
    Friend WithEvents btn_comm_sa As Button
    Friend WithEvents chk_use_tts As CheckBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents lbl_recent_switch As Label
    Friend WithEvents btn_comm_wd0 As Button
End Class
