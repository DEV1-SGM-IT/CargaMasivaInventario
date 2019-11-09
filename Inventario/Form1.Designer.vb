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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_LoadFile = New System.Windows.Forms.Button()
        Me.tbx_File = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gb_Load = New System.Windows.Forms.GroupBox()
        Me.gb_Client = New System.Windows.Forms.GroupBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.tbx_Script = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.cbx_Client = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbx_LoadType = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.dgv_SubLocation = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.dgv_Location = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.dgv_Type = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.dgv_Brand = New System.Windows.Forms.DataGridView()
        Me.SelSubLocation = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SelLocation = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SelType = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SelBrand = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Brand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gb_Load.SuspendLayout()
        Me.gb_Client.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.dgv_SubLocation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.dgv_Location, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me.dgv_Type, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel5.SuspendLayout()
        CType(Me.dgv_Brand, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "ofd1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Cliente"
        '
        'btn_LoadFile
        '
        Me.btn_LoadFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_LoadFile.Location = New System.Drawing.Point(900, 24)
        Me.btn_LoadFile.Name = "btn_LoadFile"
        Me.btn_LoadFile.Size = New System.Drawing.Size(75, 23)
        Me.btn_LoadFile.TabIndex = 3
        Me.btn_LoadFile.Text = "Load"
        Me.btn_LoadFile.UseVisualStyleBackColor = True
        '
        'tbx_File
        '
        Me.tbx_File.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbx_File.Location = New System.Drawing.Point(50, 25)
        Me.tbx_File.Name = "tbx_File"
        Me.tbx_File.Size = New System.Drawing.Size(434, 20)
        Me.tbx_File.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "File"
        '
        'gb_Load
        '
        Me.gb_Load.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb_Load.Controls.Add(Me.cbx_LoadType)
        Me.gb_Load.Controls.Add(Me.Label3)
        Me.gb_Load.Controls.Add(Me.btn_LoadFile)
        Me.gb_Load.Controls.Add(Me.Label2)
        Me.gb_Load.Controls.Add(Me.tbx_File)
        Me.gb_Load.Enabled = False
        Me.gb_Load.Location = New System.Drawing.Point(12, 78)
        Me.gb_Load.Name = "gb_Load"
        Me.gb_Load.Size = New System.Drawing.Size(985, 60)
        Me.gb_Load.TabIndex = 6
        Me.gb_Load.TabStop = False
        '
        'gb_Client
        '
        Me.gb_Client.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb_Client.Controls.Add(Me.cbx_Client)
        Me.gb_Client.Controls.Add(Me.Label1)
        Me.gb_Client.Location = New System.Drawing.Point(12, 12)
        Me.gb_Client.Name = "gb_Client"
        Me.gb_Client.Size = New System.Drawing.Size(985, 60)
        Me.gb_Client.TabIndex = 7
        Me.gb_Client.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 144)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(987, 369)
        Me.TabControl1.TabIndex = 8
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TableLayoutPanel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(979, 343)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Missed Data"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.tbx_Script)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(979, 343)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Query: Insert Inventory"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'tbx_Script
        '
        Me.tbx_Script.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbx_Script.Location = New System.Drawing.Point(13, 13)
        Me.tbx_Script.Margin = New System.Windows.Forms.Padding(10)
        Me.tbx_Script.Multiline = True
        Me.tbx_Script.Name = "tbx_Script"
        Me.tbx_Script.ReadOnly = True
        Me.tbx_Script.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.tbx_Script.Size = New System.Drawing.Size(953, 317)
        Me.tbx_Script.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel4, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel5, 3, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(979, 343)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'cbx_Client
        '
        Me.cbx_Client.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbx_Client.FormattingEnabled = True
        Me.cbx_Client.Location = New System.Drawing.Point(50, 19)
        Me.cbx_Client.Name = "cbx_Client"
        Me.cbx_Client.Size = New System.Drawing.Size(925, 21)
        Me.cbx_Client.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(497, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Load Type"
        '
        'cbx_LoadType
        '
        Me.cbx_LoadType.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbx_LoadType.FormattingEnabled = True
        Me.cbx_LoadType.Items.AddRange(New Object() {"Select Load Type", "New Load", "Migration"})
        Me.cbx_LoadType.Location = New System.Drawing.Point(568, 25)
        Me.cbx_LoadType.Name = "cbx_LoadType"
        Me.cbx_LoadType.Size = New System.Drawing.Size(312, 21)
        Me.cbx_LoadType.TabIndex = 7
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.dgv_SubLocation, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(244, 0)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(244, 343)
        Me.TableLayoutPanel2.TabIndex = 4
        '
        'dgv_SubLocation
        '
        Me.dgv_SubLocation.AllowUserToAddRows = False
        Me.dgv_SubLocation.AllowUserToDeleteRows = False
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_SubLocation.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_SubLocation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_SubLocation.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SelSubLocation, Me.DataGridViewTextBoxColumn3})
        Me.dgv_SubLocation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_SubLocation.Location = New System.Drawing.Point(10, 10)
        Me.dgv_SubLocation.Margin = New System.Windows.Forms.Padding(10)
        Me.dgv_SubLocation.Name = "dgv_SubLocation"
        Me.dgv_SubLocation.RowHeadersVisible = False
        Me.dgv_SubLocation.Size = New System.Drawing.Size(224, 283)
        Me.dgv_SubLocation.TabIndex = 6
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.dgv_Location, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(244, 343)
        Me.TableLayoutPanel3.TabIndex = 5
        '
        'dgv_Location
        '
        Me.dgv_Location.AllowUserToAddRows = False
        Me.dgv_Location.AllowUserToDeleteRows = False
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Location.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgv_Location.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Location.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SelLocation, Me.DataGridViewTextBoxColumn2})
        Me.dgv_Location.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_Location.Location = New System.Drawing.Point(10, 10)
        Me.dgv_Location.Margin = New System.Windows.Forms.Padding(10)
        Me.dgv_Location.Name = "dgv_Location"
        Me.dgv_Location.RowHeadersVisible = False
        Me.dgv_Location.Size = New System.Drawing.Size(224, 283)
        Me.dgv_Location.TabIndex = 3
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.dgv_Type, 0, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(488, 0)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(244, 343)
        Me.TableLayoutPanel4.TabIndex = 6
        '
        'dgv_Type
        '
        Me.dgv_Type.AllowUserToAddRows = False
        Me.dgv_Type.AllowUserToDeleteRows = False
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Type.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgv_Type.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Type.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SelType, Me.DataGridViewTextBoxColumn1})
        Me.dgv_Type.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_Type.Location = New System.Drawing.Point(10, 10)
        Me.dgv_Type.Margin = New System.Windows.Forms.Padding(10)
        Me.dgv_Type.Name = "dgv_Type"
        Me.dgv_Type.RowHeadersVisible = False
        Me.dgv_Type.Size = New System.Drawing.Size(224, 283)
        Me.dgv_Type.TabIndex = 2
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.dgv_Brand, 0, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(732, 0)
        Me.TableLayoutPanel5.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 2
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(247, 343)
        Me.TableLayoutPanel5.TabIndex = 7
        '
        'dgv_Brand
        '
        Me.dgv_Brand.AllowUserToAddRows = False
        Me.dgv_Brand.AllowUserToDeleteRows = False
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Brand.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgv_Brand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Brand.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SelBrand, Me.Brand})
        Me.dgv_Brand.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_Brand.Location = New System.Drawing.Point(10, 10)
        Me.dgv_Brand.Margin = New System.Windows.Forms.Padding(10)
        Me.dgv_Brand.Name = "dgv_Brand"
        Me.dgv_Brand.RowHeadersVisible = False
        Me.dgv_Brand.Size = New System.Drawing.Size(227, 283)
        Me.dgv_Brand.TabIndex = 4
        '
        'SelSubLocation
        '
        Me.SelSubLocation.HeaderText = ""
        Me.SelSubLocation.Name = "SelSubLocation"
        Me.SelSubLocation.Width = 25
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.HeaderText = "Sub Location"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'SelLocation
        '
        Me.SelLocation.FillWeight = 20.0!
        Me.SelLocation.HeaderText = ""
        Me.SelLocation.Name = "SelLocation"
        Me.SelLocation.Width = 25
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.HeaderText = "Location"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'SelType
        '
        Me.SelType.HeaderText = ""
        Me.SelType.Name = "SelType"
        Me.SelType.Width = 25
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.HeaderText = "Type"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'SelBrand
        '
        Me.SelBrand.HeaderText = ""
        Me.SelBrand.Name = "SelBrand"
        Me.SelBrand.Width = 25
        '
        'Brand
        '
        Me.Brand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Brand.HeaderText = "Brand"
        Me.Brand.Name = "Brand"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1011, 525)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.gb_Client)
        Me.Controls.Add(Me.gb_Load)
        Me.Name = "Form1"
        Me.gb_Load.ResumeLayout(False)
        Me.gb_Load.PerformLayout()
        Me.gb_Client.ResumeLayout(False)
        Me.gb_Client.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.dgv_SubLocation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        CType(Me.dgv_Location, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel4.ResumeLayout(False)
        CType(Me.dgv_Type, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel5.ResumeLayout(False)
        CType(Me.dgv_Brand, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_LoadFile As Button
    Friend WithEvents tbx_File As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents gb_Load As GroupBox
    Friend WithEvents gb_Client As GroupBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents tbx_Script As TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents cbx_LoadType As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbx_Client As ComboBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents dgv_SubLocation As DataGridView
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents dgv_Location As DataGridView
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents dgv_Type As DataGridView
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents dgv_Brand As DataGridView
    Friend WithEvents SelSubLocation As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents SelLocation As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents SelType As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents SelBrand As DataGridViewCheckBoxColumn
    Friend WithEvents Brand As DataGridViewTextBoxColumn
End Class
