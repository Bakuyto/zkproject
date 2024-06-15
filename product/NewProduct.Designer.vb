<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NewProduct
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
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewProduct))
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.ischkavailable = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.txt_proname = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txt_barcode = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txt_qty = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txt_dis = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txt_stock = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txt_price = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.com_category = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.imageBox = New System.Windows.Forms.PictureBox()
        Me.btn_browse = New DevComponents.DotNetBar.ButtonX()
        Me.txt_search = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.btn_search = New DevComponents.DotNetBar.ButtonX()
        Me.btn_add = New DevComponents.DotNetBar.ButtonX()
        Me.btn_clear = New DevComponents.DotNetBar.ButtonX()
        Me.showpicture = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.dgproduct = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn()
        Me.btn_edit = New DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn()
        Me.btn_delete = New DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn()
        Me.btn_prev = New DevComponents.DotNetBar.ButtonX()
        Me.btn_next = New DevComponents.DotNetBar.ButtonX()
        CType(Me.imageBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgproduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelX1
        '
        Me.LabelX1.Anchor = System.Windows.Forms.AnchorStyles.Top
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(22, 29)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(113, 21)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "Product Name :"
        '
        'LabelX2
        '
        Me.LabelX2.Anchor = System.Windows.Forms.AnchorStyles.Top
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.Location = New System.Drawing.Point(22, 65)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(113, 23)
        Me.LabelX2.TabIndex = 1
        Me.LabelX2.Text = "Barcode/Code :"
        '
        'LabelX3
        '
        Me.LabelX3.Anchor = System.Windows.Forms.AnchorStyles.Top
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.Location = New System.Drawing.Point(22, 103)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(113, 23)
        Me.LabelX3.TabIndex = 2
        Me.LabelX3.Text = "Product QTY :"
        '
        'LabelX7
        '
        Me.LabelX7.Anchor = System.Windows.Forms.AnchorStyles.Top
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX7.Location = New System.Drawing.Point(22, 144)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(99, 23)
        Me.LabelX7.TabIndex = 8
        Me.LabelX7.Text = "Discount (%) :"
        '
        'LabelX8
        '
        Me.LabelX8.Anchor = System.Windows.Forms.AnchorStyles.Top
        '
        '
        '
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX8.Location = New System.Drawing.Point(384, 29)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(75, 21)
        Me.LabelX8.TabIndex = 9
        Me.LabelX8.Text = "Category :"
        '
        'LabelX6
        '
        Me.LabelX6.Anchor = System.Windows.Forms.AnchorStyles.Top
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX6.Location = New System.Drawing.Point(384, 65)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(48, 23)
        Me.LabelX6.TabIndex = 10
        Me.LabelX6.Text = "Price :"
        '
        'LabelX5
        '
        Me.LabelX5.Anchor = System.Windows.Forms.AnchorStyles.Top
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX5.Location = New System.Drawing.Point(384, 103)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(75, 23)
        Me.LabelX5.TabIndex = 11
        Me.LabelX5.Text = "Stock :"
        '
        'ischkavailable
        '
        Me.ischkavailable.Anchor = System.Windows.Forms.AnchorStyles.Top
        '
        '
        '
        Me.ischkavailable.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ischkavailable.Checked = True
        Me.ischkavailable.CheckSignSize = New System.Drawing.Size(20, 20)
        Me.ischkavailable.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ischkavailable.CheckValue = "Y"
        Me.ischkavailable.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ischkavailable.Location = New System.Drawing.Point(384, 144)
        Me.ischkavailable.Name = "ischkavailable"
        Me.ischkavailable.Size = New System.Drawing.Size(100, 23)
        Me.ischkavailable.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ischkavailable.TabIndex = 12
        Me.ischkavailable.Text = "Available"
        '
        'txt_proname
        '
        Me.txt_proname.Anchor = System.Windows.Forms.AnchorStyles.Top
        '
        '
        '
        Me.txt_proname.Border.Class = "TextBoxBorder"
        Me.txt_proname.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_proname.Location = New System.Drawing.Point(142, 29)
        Me.txt_proname.Name = "txt_proname"
        Me.txt_proname.PreventEnterBeep = True
        Me.txt_proname.Size = New System.Drawing.Size(150, 21)
        Me.txt_proname.TabIndex = 13
        '
        'txt_barcode
        '
        Me.txt_barcode.Anchor = System.Windows.Forms.AnchorStyles.Top
        '
        '
        '
        Me.txt_barcode.Border.Class = "TextBoxBorder"
        Me.txt_barcode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_barcode.Location = New System.Drawing.Point(141, 67)
        Me.txt_barcode.Name = "txt_barcode"
        Me.txt_barcode.PreventEnterBeep = True
        Me.txt_barcode.Size = New System.Drawing.Size(151, 21)
        Me.txt_barcode.TabIndex = 14
        '
        'txt_qty
        '
        Me.txt_qty.Anchor = System.Windows.Forms.AnchorStyles.Top
        '
        '
        '
        Me.txt_qty.Border.Class = "TextBoxBorder"
        Me.txt_qty.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_qty.Location = New System.Drawing.Point(141, 105)
        Me.txt_qty.Name = "txt_qty"
        Me.txt_qty.PreventEnterBeep = True
        Me.txt_qty.Size = New System.Drawing.Size(151, 21)
        Me.txt_qty.TabIndex = 15
        '
        'txt_dis
        '
        Me.txt_dis.Anchor = System.Windows.Forms.AnchorStyles.Top
        '
        '
        '
        Me.txt_dis.Border.Class = "TextBoxBorder"
        Me.txt_dis.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_dis.Location = New System.Drawing.Point(142, 146)
        Me.txt_dis.Name = "txt_dis"
        Me.txt_dis.PreventEnterBeep = True
        Me.txt_dis.Size = New System.Drawing.Size(150, 21)
        Me.txt_dis.TabIndex = 16
        '
        'txt_stock
        '
        Me.txt_stock.Anchor = System.Windows.Forms.AnchorStyles.Top
        '
        '
        '
        Me.txt_stock.Border.Class = "TextBoxBorder"
        Me.txt_stock.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_stock.Location = New System.Drawing.Point(467, 103)
        Me.txt_stock.Name = "txt_stock"
        Me.txt_stock.PreventEnterBeep = True
        Me.txt_stock.Size = New System.Drawing.Size(151, 21)
        Me.txt_stock.TabIndex = 18
        '
        'txt_price
        '
        Me.txt_price.Anchor = System.Windows.Forms.AnchorStyles.Top
        '
        '
        '
        Me.txt_price.Border.Class = "TextBoxBorder"
        Me.txt_price.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_price.Location = New System.Drawing.Point(468, 65)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.PreventEnterBeep = True
        Me.txt_price.Size = New System.Drawing.Size(150, 21)
        Me.txt_price.TabIndex = 17
        '
        'com_category
        '
        Me.com_category.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.com_category.DisplayMember = "Text"
        Me.com_category.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.com_category.FormattingEnabled = True
        Me.com_category.ItemHeight = 16
        Me.com_category.Location = New System.Drawing.Point(468, 29)
        Me.com_category.Name = "com_category"
        Me.com_category.Size = New System.Drawing.Size(150, 22)
        Me.com_category.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.com_category.TabIndex = 19
        '
        'imageBox
        '
        Me.imageBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.imageBox.Image = Global.zkproject.My.Resources.Resources.upload_image
        Me.imageBox.Location = New System.Drawing.Point(730, 29)
        Me.imageBox.Name = "imageBox"
        Me.imageBox.Size = New System.Drawing.Size(140, 97)
        Me.imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imageBox.TabIndex = 20
        Me.imageBox.TabStop = False
        '
        'btn_browse
        '
        Me.btn_browse.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_browse.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_browse.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_browse.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_browse.Location = New System.Drawing.Point(730, 132)
        Me.btn_browse.Name = "btn_browse"
        Me.btn_browse.Size = New System.Drawing.Size(140, 35)
        Me.btn_browse.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_browse.TabIndex = 21
        Me.btn_browse.Text = "Browse"
        '
        'txt_search
        '
        '
        '
        '
        Me.txt_search.Border.Class = "TextBoxBorder"
        Me.txt_search.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_search.Location = New System.Drawing.Point(22, 239)
        Me.txt_search.Multiline = True
        Me.txt_search.Name = "txt_search"
        Me.txt_search.PreventEnterBeep = True
        Me.txt_search.Size = New System.Drawing.Size(170, 30)
        Me.txt_search.TabIndex = 22
        Me.txt_search.WatermarkFont = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_search
        '
        Me.btn_search.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_search.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_search.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_search.Location = New System.Drawing.Point(190, 239)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(102, 30)
        Me.btn_search.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_search.TabIndex = 23
        Me.btn_search.Text = "SEARCH"
        '
        'btn_add
        '
        Me.btn_add.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_add.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_add.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_add.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.Location = New System.Drawing.Point(768, 239)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(102, 30)
        Me.btn_add.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_add.TabIndex = 24
        Me.btn_add.Text = "ADD"
        '
        'btn_clear
        '
        Me.btn_clear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_clear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_clear.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_clear.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clear.Location = New System.Drawing.Point(655, 239)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(102, 30)
        Me.btn_clear.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_clear.TabIndex = 25
        Me.btn_clear.Text = "CLEAR"
        '
        'showpicture
        '
        Me.showpicture.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.showpicture.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.showpicture.CheckSignSize = New System.Drawing.Size(20, 20)
        Me.showpicture.Font = New System.Drawing.Font("Roboto", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.showpicture.Location = New System.Drawing.Point(534, 246)
        Me.showpicture.Name = "showpicture"
        Me.showpicture.Size = New System.Drawing.Size(87, 23)
        Me.showpicture.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.showpicture.TabIndex = 26
        Me.showpicture.Text = "Picture"
        '
        'dgproduct
        '
        Me.dgproduct.AllowUserToAddRows = False
        Me.dgproduct.AllowUserToDeleteRows = False
        Me.dgproduct.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgproduct.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgproduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgproduct.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column7, Me.Column10, Me.Column6, Me.Column8, Me.Column9, Me.btn_edit, Me.btn_delete})
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgproduct.DefaultCellStyle = DataGridViewCellStyle17
        Me.dgproduct.EnableHeadersVisualStyles = False
        Me.dgproduct.GridColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.dgproduct.Location = New System.Drawing.Point(22, 281)
        Me.dgproduct.Name = "dgproduct"
        Me.dgproduct.ReadOnly = True
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgproduct.RowHeadersDefaultCellStyle = DataGridViewCellStyle18
        Me.dgproduct.RowHeadersVisible = False
        Me.dgproduct.RowTemplate.Height = 49
        Me.dgproduct.Size = New System.Drawing.Size(848, 187)
        Me.dgproduct.TabIndex = 27
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Image = CType(resources.GetObject("ButtonX1.Image"), System.Drawing.Image)
        Me.ButtonX1.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.ButtonX1.Location = New System.Drawing.Point(623, 28)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(44, 23)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 28
        '
        'Column1
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle11
        Me.Column1.HeaderText = "No"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 50
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "Image"
        Me.Column2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "Product Name"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle12
        Me.Column4.HeaderText = "Category"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column5.HeaderText = "Barcode"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column7
        '
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column7.DefaultCellStyle = DataGridViewCellStyle13
        Me.Column7.HeaderText = "QTY"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 50
        '
        'Column10
        '
        Me.Column10.HeaderText = "Price"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column6.DefaultCellStyle = DataGridViewCellStyle14
        Me.Column6.HeaderText = "Stock"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column8
        '
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column8.DefaultCellStyle = DataGridViewCellStyle15
        Me.Column8.HeaderText = "Discount (%)"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.Checked = True
        Me.Column9.CheckState = System.Windows.Forms.CheckState.Indeterminate
        Me.Column9.CheckValue = Nothing
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column9.DefaultCellStyle = DataGridViewCellStyle16
        Me.Column9.HeaderText = "Status"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column9.Width = 50
        '
        'btn_edit
        '
        Me.btn_edit.HeaderText = "Edit"
        Me.btn_edit.Image = CType(resources.GetObject("btn_edit.Image"), System.Drawing.Image)
        Me.btn_edit.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.ReadOnly = True
        Me.btn_edit.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.btn_edit.Text = Nothing
        Me.btn_edit.Width = 50
        '
        'btn_delete
        '
        Me.btn_delete.HeaderText = "Delete"
        Me.btn_delete.Image = CType(resources.GetObject("btn_delete.Image"), System.Drawing.Image)
        Me.btn_delete.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.ReadOnly = True
        Me.btn_delete.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.btn_delete.Text = Nothing
        Me.btn_delete.Width = 50
        '
        'btn_prev
        '
        Me.btn_prev.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_prev.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_prev.Image = CType(resources.GetObject("btn_prev.Image"), System.Drawing.Image)
        Me.btn_prev.ImageFixedSize = New System.Drawing.Size(25, 25)
        Me.btn_prev.Location = New System.Drawing.Point(768, 477)
        Me.btn_prev.Name = "btn_prev"
        Me.btn_prev.Size = New System.Drawing.Size(49, 35)
        Me.btn_prev.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_prev.TabIndex = 32
        '
        'btn_next
        '
        Me.btn_next.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_next.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_next.Image = CType(resources.GetObject("btn_next.Image"), System.Drawing.Image)
        Me.btn_next.ImageFixedSize = New System.Drawing.Size(25, 25)
        Me.btn_next.Location = New System.Drawing.Point(817, 477)
        Me.btn_next.Name = "btn_next"
        Me.btn_next.Size = New System.Drawing.Size(49, 35)
        Me.btn_next.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_next.TabIndex = 33
        '
        'NewProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(896, 523)
        Me.Controls.Add(Me.btn_next)
        Me.Controls.Add(Me.btn_prev)
        Me.Controls.Add(Me.ButtonX1)
        Me.Controls.Add(Me.dgproduct)
        Me.Controls.Add(Me.showpicture)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.btn_search)
        Me.Controls.Add(Me.txt_search)
        Me.Controls.Add(Me.btn_browse)
        Me.Controls.Add(Me.imageBox)
        Me.Controls.Add(Me.com_category)
        Me.Controls.Add(Me.txt_stock)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Me.txt_dis)
        Me.Controls.Add(Me.txt_qty)
        Me.Controls.Add(Me.txt_barcode)
        Me.Controls.Add(Me.txt_proname)
        Me.Controls.Add(Me.ischkavailable)
        Me.Controls.Add(Me.LabelX5)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.LabelX6)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.LabelX8)
        Me.Controls.Add(Me.LabelX3)
        Me.Controls.Add(Me.LabelX7)
        Me.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "NewProduct"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Product"
        CType(Me.imageBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgproduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ischkavailable As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents txt_proname As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txt_barcode As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txt_qty As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txt_dis As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txt_stock As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txt_price As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents com_category As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents imageBox As PictureBox
    Friend WithEvents btn_browse As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txt_search As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btn_search As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btn_add As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btn_clear As DevComponents.DotNetBar.ButtonX
    Friend WithEvents showpicture As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents dgproduct As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewImageColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn
    Friend WithEvents btn_edit As DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn
    Friend WithEvents btn_delete As DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn
    Friend WithEvents btn_prev As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btn_next As DevComponents.DotNetBar.ButtonX
End Class
