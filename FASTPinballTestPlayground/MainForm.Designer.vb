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
        Me.btn_port_autoconfig = New System.Windows.Forms.Button()
        Me.tp_terminal = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_terminal_console = New System.Windows.Forms.TextBox()
        Me.btn_terminal_sendcustom = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_terminal_command = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cb_terminal_port = New System.Windows.Forms.ComboBox()
        Me.tp_rgbleds = New System.Windows.Forms.TabPage()
        Me.btn_rgb_fadeallleds = New System.Windows.Forms.Button()
        Me.btn_rgb_setallleds = New System.Windows.Forms.Button()
        Me.btn_rgb_changecolor = New System.Windows.Forms.Button()
        Me.pnl_color = New System.Windows.Forms.Panel()
        Me.tp_switches = New System.Windows.Forms.TabPage()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dg_switches_switchlist = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_switches_activity = New System.Windows.Forms.TextBox()
        Me.btn_rgb_stopfadeall = New System.Windows.Forms.Button()
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
        Me.tp_switches.SuspendLayout()
        CType(Me.dg_switches_switchlist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tc_areas
        '
        Me.tc_areas.Controls.Add(Me.tp_hardware)
        Me.tc_areas.Controls.Add(Me.tp_terminal)
        Me.tc_areas.Controls.Add(Me.tp_rgbleds)
        Me.tc_areas.Controls.Add(Me.tp_switches)
        Me.tc_areas.Location = New System.Drawing.Point(12, 12)
        Me.tc_areas.Name = "tc_areas"
        Me.tc_areas.SelectedIndex = 0
        Me.tc_areas.Size = New System.Drawing.Size(885, 551)
        Me.tc_areas.TabIndex = 0
        '
        'tp_hardware
        '
        Me.tp_hardware.Controls.Add(Me.GroupBox2)
        Me.tp_hardware.Controls.Add(Me.GroupBox1)
        Me.tp_hardware.Location = New System.Drawing.Point(4, 22)
        Me.tp_hardware.Name = "tp_hardware"
        Me.tp_hardware.Size = New System.Drawing.Size(877, 525)
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
        Me.GroupBox2.Size = New System.Drawing.Size(844, 394)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Step 2: Review Hardware"
        '
        'lbl_hardware_networkswitchcount
        '
        Me.lbl_hardware_networkswitchcount.AutoSize = True
        Me.lbl_hardware_networkswitchcount.Location = New System.Drawing.Point(116, 324)
        Me.lbl_hardware_networkswitchcount.Name = "lbl_hardware_networkswitchcount"
        Me.lbl_hardware_networkswitchcount.Size = New System.Drawing.Size(13, 13)
        Me.lbl_hardware_networkswitchcount.TabIndex = 10
        Me.lbl_hardware_networkswitchcount.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 324)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Network Switches:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "FAST Nodes:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 26)
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
        Me.dg_hardware_nodes.Location = New System.Drawing.Point(91, 174)
        Me.dg_hardware_nodes.MultiSelect = False
        Me.dg_hardware_nodes.Name = "dg_hardware_nodes"
        Me.dg_hardware_nodes.ReadOnly = True
        Me.dg_hardware_nodes.RowHeadersVisible = False
        Me.dg_hardware_nodes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_hardware_nodes.Size = New System.Drawing.Size(631, 129)
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
        Me.dg_hardware_ports.Location = New System.Drawing.Point(91, 26)
        Me.dg_hardware_ports.MultiSelect = False
        Me.dg_hardware_ports.Name = "dg_hardware_ports"
        Me.dg_hardware_ports.ReadOnly = True
        Me.dg_hardware_ports.RowHeadersVisible = False
        Me.dg_hardware_ports.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_hardware_ports.Size = New System.Drawing.Size(631, 142)
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
        Me.GroupBox1.Controls.Add(Me.btn_port_autoconfig)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(844, 82)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Step 1: Find FAST Hardware"
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
        Me.tp_terminal.Controls.Add(Me.GroupBox3)
        Me.tp_terminal.Location = New System.Drawing.Point(4, 22)
        Me.tp_terminal.Name = "tp_terminal"
        Me.tp_terminal.Size = New System.Drawing.Size(877, 525)
        Me.tp_terminal.TabIndex = 2
        Me.tp_terminal.Text = "Terminal"
        Me.tp_terminal.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.txt_terminal_console)
        Me.GroupBox4.Controls.Add(Me.btn_terminal_sendcustom)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.txt_terminal_command)
        Me.GroupBox4.Location = New System.Drawing.Point(15, 100)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(844, 422)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Step 2: Communicate"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Terminal:"
        '
        'txt_terminal_console
        '
        Me.txt_terminal_console.Location = New System.Drawing.Point(39, 113)
        Me.txt_terminal_console.Multiline = True
        Me.txt_terminal_console.Name = "txt_terminal_console"
        Me.txt_terminal_console.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_terminal_console.Size = New System.Drawing.Size(776, 289)
        Me.txt_terminal_console.TabIndex = 3
        '
        'btn_terminal_sendcustom
        '
        Me.btn_terminal_sendcustom.Location = New System.Drawing.Point(381, 33)
        Me.btn_terminal_sendcustom.Name = "btn_terminal_sendcustom"
        Me.btn_terminal_sendcustom.Size = New System.Drawing.Size(194, 23)
        Me.btn_terminal_sendcustom.TabIndex = 2
        Me.btn_terminal_sendcustom.Text = "Send Custom Command"
        Me.btn_terminal_sendcustom.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Custom Command:"
        '
        'txt_terminal_command
        '
        Me.txt_terminal_command.Location = New System.Drawing.Point(137, 35)
        Me.txt_terminal_command.Name = "txt_terminal_command"
        Me.txt_terminal_command.Size = New System.Drawing.Size(223, 20)
        Me.txt_terminal_command.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cb_terminal_port)
        Me.GroupBox3.Location = New System.Drawing.Point(15, 15)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(844, 79)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Step 1: Pick A Port"
        '
        'cb_terminal_port
        '
        Me.cb_terminal_port.DisplayMember = "HardwareName"
        Me.cb_terminal_port.FormattingEnabled = True
        Me.cb_terminal_port.Location = New System.Drawing.Point(39, 34)
        Me.cb_terminal_port.Name = "cb_terminal_port"
        Me.cb_terminal_port.Size = New System.Drawing.Size(228, 21)
        Me.cb_terminal_port.TabIndex = 0
        '
        'tp_rgbleds
        '
        Me.tp_rgbleds.Controls.Add(Me.btn_rgb_stopfadeall)
        Me.tp_rgbleds.Controls.Add(Me.btn_rgb_fadeallleds)
        Me.tp_rgbleds.Controls.Add(Me.btn_rgb_setallleds)
        Me.tp_rgbleds.Controls.Add(Me.btn_rgb_changecolor)
        Me.tp_rgbleds.Controls.Add(Me.pnl_color)
        Me.tp_rgbleds.Location = New System.Drawing.Point(4, 22)
        Me.tp_rgbleds.Name = "tp_rgbleds"
        Me.tp_rgbleds.Padding = New System.Windows.Forms.Padding(3)
        Me.tp_rgbleds.Size = New System.Drawing.Size(877, 525)
        Me.tp_rgbleds.TabIndex = 0
        Me.tp_rgbleds.Text = "RGB LEDs"
        Me.tp_rgbleds.UseVisualStyleBackColor = True
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
        Me.tp_switches.Controls.Add(Me.Label7)
        Me.tp_switches.Controls.Add(Me.dg_switches_switchlist)
        Me.tp_switches.Controls.Add(Me.Label6)
        Me.tp_switches.Controls.Add(Me.txt_switches_activity)
        Me.tp_switches.Location = New System.Drawing.Point(4, 22)
        Me.tp_switches.Name = "tp_switches"
        Me.tp_switches.Size = New System.Drawing.Size(877, 525)
        Me.tp_switches.TabIndex = 3
        Me.tp_switches.Text = "Switches"
        Me.tp_switches.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(438, 20)
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
        Me.dg_switches_switchlist.Location = New System.Drawing.Point(441, 36)
        Me.dg_switches_switchlist.MultiSelect = False
        Me.dg_switches_switchlist.Name = "dg_switches_switchlist"
        Me.dg_switches_switchlist.ReadOnly = True
        Me.dg_switches_switchlist.RowHeadersVisible = False
        Me.dg_switches_switchlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_switches_switchlist.Size = New System.Drawing.Size(420, 471)
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
        Me.Label6.Location = New System.Drawing.Point(12, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Switch Actvity:"
        '
        'txt_switches_activity
        '
        Me.txt_switches_activity.Location = New System.Drawing.Point(15, 36)
        Me.txt_switches_activity.Multiline = True
        Me.txt_switches_activity.Name = "txt_switches_activity"
        Me.txt_switches_activity.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_switches_activity.Size = New System.Drawing.Size(406, 471)
        Me.txt_switches_activity.TabIndex = 0
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
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(909, 575)
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
        Me.tp_terminal.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.tp_rgbleds.ResumeLayout(False)
        Me.tp_switches.ResumeLayout(False)
        Me.tp_switches.PerformLayout()
        CType(Me.dg_switches_switchlist, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_terminal_sendcustom As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
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

End Class
