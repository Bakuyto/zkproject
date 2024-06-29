<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbldate = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.panelCategory = New System.Windows.Forms.Panel()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.cateNext = New DevComponents.DotNetBar.ButtonX()
        Me.catePrevious = New DevComponents.DotNetBar.ButtonX()
        Me.panelProductBox = New System.Windows.Forms.Panel()
        Me.dgProByCate = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.panelFooter = New DevComponents.DotNetBar.PanelEx()
        Me.lbPageNo = New DevComponents.DotNetBar.LabelX()
        Me.proNext = New DevComponents.DotNetBar.ButtonX()
        Me.proPrevious = New DevComponents.DotNetBar.ButtonX()
        Me.txt_exchange = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.panelRightMain = New DevComponents.DotNetBar.PanelEx()
        Me.panelControlRight = New DevComponents.DotNetBar.PanelEx()
        Me.PanelEx3 = New DevComponents.DotNetBar.PanelEx()
        Me.LabelX18 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX19 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX20 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX21 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX22 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX23 = New DevComponents.DotNetBar.LabelX()
        Me.dgitems = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Items = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Disc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Grand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.txt_changeKHR = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.txt_changeUSD = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.txtTotalAllDiscount = New DevComponents.Editors.DoubleInput()
        Me.btnDiscount = New DevComponents.DotNetBar.ButtonX()
        Me.btn_RemoveOne = New DevComponents.DotNetBar.ButtonX()
        Me.txt_recievedKHR = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX14 = New DevComponents.DotNetBar.LabelX()
        Me.txt_recievedUSD = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX15 = New DevComponents.DotNetBar.LabelX()
        Me.txt_totalKHR = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX16 = New DevComponents.DotNetBar.LabelX()
        Me.btnClear = New DevComponents.DotNetBar.ButtonX()
        Me.btnPay = New DevComponents.DotNetBar.ButtonX()
        Me.txt_totalUS = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX17 = New DevComponents.DotNetBar.LabelX()
        Me.PanelEx4 = New DevComponents.DotNetBar.PanelEx()
        Me.txt_barcode = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Panel1.SuspendLayout()
        Me.PanelEx1.SuspendLayout()
        Me.panelProductBox.SuspendLayout()
        CType(Me.dgProByCate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelFooter.SuspendLayout()
        Me.panelRightMain.SuspendLayout()
        Me.panelControlRight.SuspendLayout()
        Me.PanelEx3.SuspendLayout()
        CType(Me.dgitems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.PanelEx2.SuspendLayout()
        CType(Me.txtTotalAllDiscount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.lbldate)
        Me.Panel1.Controls.Add(Me.LabelX1)
        Me.Panel1.Controls.Add(Me.panelCategory)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1060, 86)
        Me.Panel1.TabIndex = 46
        '
        'lbldate
        '
        Me.lbldate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.lbldate.BackgroundStyle.BorderBottomWidth = 1
        Me.lbldate.BackgroundStyle.BorderColor = System.Drawing.Color.Gray
        Me.lbldate.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.lbldate.BackgroundStyle.BorderLeftWidth = 1
        Me.lbldate.BackgroundStyle.BorderRightWidth = 1
        Me.lbldate.BackgroundStyle.BorderTopWidth = 1
        Me.lbldate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbldate.Font = New System.Drawing.Font("Roboto", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.Location = New System.Drawing.Point(548, 0)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(512, 86)
        Me.lbldate.TabIndex = 2
        Me.lbldate.Text = "Date"
        Me.lbldate.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'LabelX1
        '
        Me.LabelX1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(1016, 21)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(27, 39)
        Me.LabelX1.TabIndex = 1
        '
        'panelCategory
        '
        Me.panelCategory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelCategory.Location = New System.Drawing.Point(0, 0)
        Me.panelCategory.Name = "panelCategory"
        Me.panelCategory.Size = New System.Drawing.Size(548, 86)
        Me.panelCategory.TabIndex = 0
        '
        'PanelEx1
        '
        Me.PanelEx1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.cateNext)
        Me.PanelEx1.Controls.Add(Me.catePrevious)
        Me.PanelEx1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx1.Location = New System.Drawing.Point(0, 86)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(548, 62)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 47
        '
        'cateNext
        '
        Me.cateNext.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cateNext.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cateNext.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cateNext.Image = CType(resources.GetObject("cateNext.Image"), System.Drawing.Image)
        Me.cateNext.ImageFixedSize = New System.Drawing.Size(25, 25)
        Me.cateNext.Location = New System.Drawing.Point(474, 14)
        Me.cateNext.Name = "cateNext"
        Me.cateNext.Size = New System.Drawing.Size(49, 32)
        Me.cateNext.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cateNext.TabIndex = 35
        '
        'catePrevious
        '
        Me.catePrevious.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.catePrevious.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.catePrevious.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.catePrevious.Image = CType(resources.GetObject("catePrevious.Image"), System.Drawing.Image)
        Me.catePrevious.ImageFixedSize = New System.Drawing.Size(25, 25)
        Me.catePrevious.Location = New System.Drawing.Point(419, 14)
        Me.catePrevious.Name = "catePrevious"
        Me.catePrevious.Size = New System.Drawing.Size(49, 32)
        Me.catePrevious.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.catePrevious.TabIndex = 34
        '
        'panelProductBox
        '
        Me.panelProductBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelProductBox.Controls.Add(Me.dgProByCate)
        Me.panelProductBox.Location = New System.Drawing.Point(0, 148)
        Me.panelProductBox.Name = "panelProductBox"
        Me.panelProductBox.Size = New System.Drawing.Size(548, 483)
        Me.panelProductBox.TabIndex = 55
        '
        'dgProByCate
        '
        Me.dgProByCate.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgProByCate.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgProByCate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Roboto", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgProByCate.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgProByCate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Roboto", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgProByCate.DefaultCellStyle = DataGridViewCellStyle10
        Me.dgProByCate.EnableHeadersVisualStyles = False
        Me.dgProByCate.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgProByCate.Location = New System.Drawing.Point(0, 0)
        Me.dgProByCate.Name = "dgProByCate"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Roboto", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgProByCate.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dgProByCate.Size = New System.Drawing.Size(548, 483)
        Me.dgProByCate.TabIndex = 0
        '
        'panelFooter
        '
        Me.panelFooter.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelFooter.CanvasColor = System.Drawing.SystemColors.Control
        Me.panelFooter.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.panelFooter.Controls.Add(Me.lbPageNo)
        Me.panelFooter.Controls.Add(Me.proNext)
        Me.panelFooter.Controls.Add(Me.proPrevious)
        Me.panelFooter.Controls.Add(Me.txt_exchange)
        Me.panelFooter.DisabledBackColor = System.Drawing.Color.Empty
        Me.panelFooter.Location = New System.Drawing.Point(0, 631)
        Me.panelFooter.Name = "panelFooter"
        Me.panelFooter.Size = New System.Drawing.Size(548, 69)
        Me.panelFooter.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.panelFooter.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.panelFooter.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.panelFooter.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.panelFooter.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.panelFooter.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.panelFooter.Style.GradientAngle = 90
        Me.panelFooter.TabIndex = 56
        '
        'lbPageNo
        '
        Me.lbPageNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.lbPageNo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbPageNo.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPageNo.Location = New System.Drawing.Point(338, 21)
        Me.lbPageNo.Name = "lbPageNo"
        Me.lbPageNo.Size = New System.Drawing.Size(75, 23)
        Me.lbPageNo.TabIndex = 38
        Me.lbPageNo.Text = "0 of 0"
        Me.lbPageNo.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'proNext
        '
        Me.proNext.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.proNext.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.proNext.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.proNext.Image = CType(resources.GetObject("proNext.Image"), System.Drawing.Image)
        Me.proNext.ImageFixedSize = New System.Drawing.Size(25, 25)
        Me.proNext.Location = New System.Drawing.Point(474, 17)
        Me.proNext.Name = "proNext"
        Me.proNext.Size = New System.Drawing.Size(49, 32)
        Me.proNext.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.proNext.TabIndex = 37
        '
        'proPrevious
        '
        Me.proPrevious.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.proPrevious.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.proPrevious.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.proPrevious.Image = CType(resources.GetObject("proPrevious.Image"), System.Drawing.Image)
        Me.proPrevious.ImageFixedSize = New System.Drawing.Size(25, 25)
        Me.proPrevious.Location = New System.Drawing.Point(419, 17)
        Me.proPrevious.Name = "proPrevious"
        Me.proPrevious.Size = New System.Drawing.Size(49, 32)
        Me.proPrevious.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.proPrevious.TabIndex = 36
        '
        'txt_exchange
        '
        Me.txt_exchange.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txt_exchange.Border.Class = "TextBoxBorder"
        Me.txt_exchange.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_exchange.Font = New System.Drawing.Font("Roboto", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_exchange.Location = New System.Drawing.Point(11, 17)
        Me.txt_exchange.Multiline = True
        Me.txt_exchange.Name = "txt_exchange"
        Me.txt_exchange.PreventEnterBeep = True
        Me.txt_exchange.Size = New System.Drawing.Size(100, 40)
        Me.txt_exchange.TabIndex = 0
        Me.txt_exchange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_exchange.WatermarkText = "0.00"
        '
        'panelRightMain
        '
        Me.panelRightMain.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelRightMain.CanvasColor = System.Drawing.SystemColors.Control
        Me.panelRightMain.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.panelRightMain.Controls.Add(Me.panelControlRight)
        Me.panelRightMain.DisabledBackColor = System.Drawing.Color.Empty
        Me.panelRightMain.Location = New System.Drawing.Point(548, 147)
        Me.panelRightMain.Name = "panelRightMain"
        Me.panelRightMain.Size = New System.Drawing.Size(512, 553)
        Me.panelRightMain.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.panelRightMain.Style.BackColor1.Color = System.Drawing.Color.White
        Me.panelRightMain.Style.BackColor2.Color = System.Drawing.Color.White
        Me.panelRightMain.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.panelRightMain.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.panelRightMain.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.panelRightMain.Style.GradientAngle = 90
        Me.panelRightMain.TabIndex = 86
        '
        'panelControlRight
        '
        Me.panelControlRight.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelControlRight.CanvasColor = System.Drawing.SystemColors.Control
        Me.panelControlRight.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.panelControlRight.Controls.Add(Me.PanelEx3)
        Me.panelControlRight.Controls.Add(Me.dgitems)
        Me.panelControlRight.Controls.Add(Me.Panel2)
        Me.panelControlRight.DisabledBackColor = System.Drawing.Color.Empty
        Me.panelControlRight.Location = New System.Drawing.Point(0, 0)
        Me.panelControlRight.Name = "panelControlRight"
        Me.panelControlRight.Size = New System.Drawing.Size(512, 553)
        Me.panelControlRight.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.panelControlRight.Style.BackColor1.Color = System.Drawing.Color.White
        Me.panelControlRight.Style.BackColor2.Color = System.Drawing.Color.White
        Me.panelControlRight.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.panelControlRight.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.panelControlRight.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.panelControlRight.Style.GradientAngle = 90
        Me.panelControlRight.TabIndex = 56
        '
        'PanelEx3
        '
        Me.PanelEx3.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx3.Controls.Add(Me.LabelX18)
        Me.PanelEx3.Controls.Add(Me.LabelX19)
        Me.PanelEx3.Controls.Add(Me.LabelX20)
        Me.PanelEx3.Controls.Add(Me.LabelX21)
        Me.PanelEx3.Controls.Add(Me.LabelX22)
        Me.PanelEx3.Controls.Add(Me.LabelX23)
        Me.PanelEx3.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx3.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEx3.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx3.Name = "PanelEx3"
        Me.PanelEx3.Size = New System.Drawing.Size(512, 60)
        Me.PanelEx3.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx3.Style.GradientAngle = 90
        Me.PanelEx3.TabIndex = 70
        '
        'LabelX18
        '
        '
        '
        '
        Me.LabelX18.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.LabelX18.BackgroundStyle.BorderBottomWidth = 1
        Me.LabelX18.BackgroundStyle.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.LabelX18.BackgroundStyle.BorderLeftWidth = 1
        Me.LabelX18.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.LabelX18.BackgroundStyle.BorderRightWidth = 1
        Me.LabelX18.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.LabelX18.BackgroundStyle.BorderTopWidth = 1
        Me.LabelX18.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX18.BackgroundStyle.PaddingLeft = 5
        Me.LabelX18.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX18.Location = New System.Drawing.Point(409, 0)
        Me.LabelX18.Name = "LabelX18"
        Me.LabelX18.Size = New System.Drawing.Size(103, 60)
        Me.LabelX18.TabIndex = 5
        Me.LabelX18.Text = "Grand Total"
        '
        'LabelX19
        '
        '
        '
        '
        Me.LabelX19.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.LabelX19.BackgroundStyle.BorderBottomWidth = 1
        Me.LabelX19.BackgroundStyle.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.LabelX19.BackgroundStyle.BorderLeftWidth = 1
        Me.LabelX19.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.LabelX19.BackgroundStyle.BorderRightWidth = 1
        Me.LabelX19.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.LabelX19.BackgroundStyle.BorderTopWidth = 1
        Me.LabelX19.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX19.BackgroundStyle.PaddingLeft = 5
        Me.LabelX19.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX19.Location = New System.Drawing.Point(352, 0)
        Me.LabelX19.Name = "LabelX19"
        Me.LabelX19.Size = New System.Drawing.Size(57, 60)
        Me.LabelX19.TabIndex = 4
        Me.LabelX19.Text = "Disc."
        '
        'LabelX20
        '
        '
        '
        '
        Me.LabelX20.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.LabelX20.BackgroundStyle.BorderBottomWidth = 1
        Me.LabelX20.BackgroundStyle.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.LabelX20.BackgroundStyle.BorderLeftWidth = 1
        Me.LabelX20.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.LabelX20.BackgroundStyle.BorderRightWidth = 1
        Me.LabelX20.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.LabelX20.BackgroundStyle.BorderTopWidth = 1
        Me.LabelX20.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX20.BackgroundStyle.PaddingLeft = 5
        Me.LabelX20.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX20.Location = New System.Drawing.Point(276, 0)
        Me.LabelX20.Name = "LabelX20"
        Me.LabelX20.Size = New System.Drawing.Size(76, 60)
        Me.LabelX20.TabIndex = 3
        Me.LabelX20.Text = "Price"
        '
        'LabelX21
        '
        '
        '
        '
        Me.LabelX21.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.LabelX21.BackgroundStyle.BorderBottomWidth = 1
        Me.LabelX21.BackgroundStyle.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.LabelX21.BackgroundStyle.BorderLeftWidth = 1
        Me.LabelX21.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.LabelX21.BackgroundStyle.BorderRightWidth = 1
        Me.LabelX21.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.LabelX21.BackgroundStyle.BorderTopWidth = 1
        Me.LabelX21.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX21.BackgroundStyle.PaddingLeft = 5
        Me.LabelX21.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX21.Location = New System.Drawing.Point(223, 0)
        Me.LabelX21.Name = "LabelX21"
        Me.LabelX21.Size = New System.Drawing.Size(51, 60)
        Me.LabelX21.TabIndex = 2
        Me.LabelX21.Text = "Qty"
        '
        'LabelX22
        '
        '
        '
        '
        Me.LabelX22.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.LabelX22.BackgroundStyle.BorderBottomWidth = 1
        Me.LabelX22.BackgroundStyle.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.LabelX22.BackgroundStyle.BorderLeftWidth = 1
        Me.LabelX22.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.LabelX22.BackgroundStyle.BorderRightWidth = 1
        Me.LabelX22.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.LabelX22.BackgroundStyle.BorderTopWidth = 1
        Me.LabelX22.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX22.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX22.Location = New System.Drawing.Point(0, 0)
        Me.LabelX22.Name = "LabelX22"
        Me.LabelX22.Size = New System.Drawing.Size(48, 60)
        Me.LabelX22.TabIndex = 0
        Me.LabelX22.Text = "No"
        Me.LabelX22.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'LabelX23
        '
        '
        '
        '
        Me.LabelX23.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.LabelX23.BackgroundStyle.BorderBottomWidth = 1
        Me.LabelX23.BackgroundStyle.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.LabelX23.BackgroundStyle.BorderLeftWidth = 1
        Me.LabelX23.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.LabelX23.BackgroundStyle.BorderRightWidth = 1
        Me.LabelX23.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.LabelX23.BackgroundStyle.BorderTopWidth = 1
        Me.LabelX23.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX23.BackgroundStyle.PaddingLeft = 5
        Me.LabelX23.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX23.Location = New System.Drawing.Point(49, 0)
        Me.LabelX23.Name = "LabelX23"
        Me.LabelX23.Size = New System.Drawing.Size(173, 60)
        Me.LabelX23.TabIndex = 1
        Me.LabelX23.Text = "Items"
        '
        'dgitems
        '
        Me.dgitems.AllowUserToAddRows = False
        Me.dgitems.AllowUserToDeleteRows = False
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.AliceBlue
        Me.dgitems.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle12
        Me.dgitems.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgitems.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgitems.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Roboto", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgitems.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.dgitems.ColumnHeadersHeight = 60
        Me.dgitems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgitems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.No, Me.Items, Me.Qty, Me.Price, Me.Disc, Me.Grand})
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Roboto", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgitems.DefaultCellStyle = DataGridViewCellStyle15
        Me.dgitems.EnableHeadersVisualStyles = False
        Me.dgitems.GridColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.dgitems.Location = New System.Drawing.Point(0, 0)
        Me.dgitems.Name = "dgitems"
        Me.dgitems.ReadOnly = True
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Roboto", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgitems.RowHeadersDefaultCellStyle = DataGridViewCellStyle16
        Me.dgitems.RowHeadersVisible = False
        Me.dgitems.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgitems.RowTemplate.Height = 45
        Me.dgitems.Size = New System.Drawing.Size(512, 138)
        Me.dgitems.TabIndex = 63
        '
        'No
        '
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.No.DefaultCellStyle = DataGridViewCellStyle14
        Me.No.HeaderText = "No"
        Me.No.Name = "No"
        Me.No.ReadOnly = True
        Me.No.Width = 46
        '
        'Items
        '
        Me.Items.HeaderText = "Items"
        Me.Items.Name = "Items"
        Me.Items.ReadOnly = True
        Me.Items.Width = 174
        '
        'Qty
        '
        Me.Qty.HeaderText = "Qty"
        Me.Qty.Name = "Qty"
        Me.Qty.ReadOnly = True
        Me.Qty.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Qty.Width = 52
        '
        'Price
        '
        Me.Price.HeaderText = "Price"
        Me.Price.Name = "Price"
        Me.Price.ReadOnly = True
        Me.Price.Width = 78
        '
        'Disc
        '
        Me.Disc.HeaderText = "Disc."
        Me.Disc.Name = "Disc"
        Me.Disc.ReadOnly = True
        Me.Disc.Width = 57
        '
        'Grand
        '
        Me.Grand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Grand.HeaderText = "Grand Total"
        Me.Grand.Name = "Grand"
        Me.Grand.ReadOnly = True
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.LabelX4)
        Me.Panel2.Controls.Add(Me.txt_changeKHR)
        Me.Panel2.Controls.Add(Me.LabelX2)
        Me.Panel2.Controls.Add(Me.txt_changeUSD)
        Me.Panel2.Controls.Add(Me.LabelX3)
        Me.Panel2.Controls.Add(Me.PanelEx2)
        Me.Panel2.Controls.Add(Me.txt_recievedKHR)
        Me.Panel2.Controls.Add(Me.LabelX14)
        Me.Panel2.Controls.Add(Me.txt_recievedUSD)
        Me.Panel2.Controls.Add(Me.LabelX15)
        Me.Panel2.Controls.Add(Me.txt_totalKHR)
        Me.Panel2.Controls.Add(Me.LabelX16)
        Me.Panel2.Controls.Add(Me.btnClear)
        Me.Panel2.Controls.Add(Me.btnPay)
        Me.Panel2.Controls.Add(Me.txt_totalUS)
        Me.Panel2.Controls.Add(Me.LabelX17)
        Me.Panel2.Location = New System.Drawing.Point(0, 138)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(512, 415)
        Me.Panel2.TabIndex = 62
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.Location = New System.Drawing.Point(243, 230)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(24, 35)
        Me.LabelX4.TabIndex = 47
        Me.LabelX4.Text = "Or"
        Me.LabelX4.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txt_changeKHR
        '
        '
        '
        '
        Me.txt_changeKHR.Border.BackColor = System.Drawing.Color.Transparent
        Me.txt_changeKHR.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txt_changeKHR.Border.BorderBottomWidth = 1
        Me.txt_changeKHR.Border.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.txt_changeKHR.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txt_changeKHR.Border.BorderLeftWidth = 1
        Me.txt_changeKHR.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txt_changeKHR.Border.BorderRightWidth = 1
        Me.txt_changeKHR.Border.BorderTopWidth = 1
        Me.txt_changeKHR.Border.Class = "TextBoxBorder"
        Me.txt_changeKHR.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_changeKHR.Border.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.txt_changeKHR.Font = New System.Drawing.Font("Roboto", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_changeKHR.Location = New System.Drawing.Point(275, 237)
        Me.txt_changeKHR.Multiline = True
        Me.txt_changeKHR.Name = "txt_changeKHR"
        Me.txt_changeKHR.PreventEnterBeep = True
        Me.txt_changeKHR.ReadOnly = True
        Me.txt_changeKHR.Size = New System.Drawing.Size(220, 47)
        Me.txt_changeKHR.TabIndex = 43
        Me.txt_changeKHR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_changeKHR.WatermarkText = "0.00"
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.LightGray
        '
        '
        '
        Me.LabelX2.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.LabelX2.BackgroundStyle.BorderBottomWidth = 1
        Me.LabelX2.BackgroundStyle.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.LabelX2.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.LabelX2.BackgroundStyle.BorderLeftWidth = 1
        Me.LabelX2.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.LabelX2.BackgroundStyle.BorderRightWidth = 1
        Me.LabelX2.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.LabelX2.BackgroundStyle.BorderTopWidth = 1
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.Location = New System.Drawing.Point(275, 216)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(220, 23)
        Me.LabelX2.TabIndex = 42
        Me.LabelX2.Text = "Change KHR ( ៛ )"
        Me.LabelX2.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txt_changeUSD
        '
        '
        '
        '
        Me.txt_changeUSD.Border.BackColor = System.Drawing.Color.Transparent
        Me.txt_changeUSD.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txt_changeUSD.Border.BorderBottomWidth = 1
        Me.txt_changeUSD.Border.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.txt_changeUSD.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txt_changeUSD.Border.BorderLeftWidth = 1
        Me.txt_changeUSD.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txt_changeUSD.Border.BorderRightWidth = 1
        Me.txt_changeUSD.Border.BorderTopWidth = 1
        Me.txt_changeUSD.Border.Class = "TextBoxBorder"
        Me.txt_changeUSD.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_changeUSD.Border.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.txt_changeUSD.Font = New System.Drawing.Font("Roboto", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_changeUSD.Location = New System.Drawing.Point(17, 237)
        Me.txt_changeUSD.Multiline = True
        Me.txt_changeUSD.Name = "txt_changeUSD"
        Me.txt_changeUSD.PreventEnterBeep = True
        Me.txt_changeUSD.ReadOnly = True
        Me.txt_changeUSD.Size = New System.Drawing.Size(220, 47)
        Me.txt_changeUSD.TabIndex = 41
        Me.txt_changeUSD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_changeUSD.WatermarkText = "0.00"
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.LightGray
        '
        '
        '
        Me.LabelX3.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.LabelX3.BackgroundStyle.BorderBottomWidth = 1
        Me.LabelX3.BackgroundStyle.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.LabelX3.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.LabelX3.BackgroundStyle.BorderLeftWidth = 1
        Me.LabelX3.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.LabelX3.BackgroundStyle.BorderRightWidth = 1
        Me.LabelX3.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.LabelX3.BackgroundStyle.BorderTopWidth = 1
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.Location = New System.Drawing.Point(17, 216)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(220, 23)
        Me.LabelX3.TabIndex = 40
        Me.LabelX3.Text = "Change USD ( $ )"
        Me.LabelX3.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'PanelEx2
        '
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx2.Controls.Add(Me.txtTotalAllDiscount)
        Me.PanelEx2.Controls.Add(Me.btnDiscount)
        Me.PanelEx2.Controls.Add(Me.btn_RemoveOne)
        Me.PanelEx2.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx2.Location = New System.Drawing.Point(-1, -1)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(512, 54)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 25
        '
        'txtTotalAllDiscount
        '
        '
        '
        '
        Me.txtTotalAllDiscount.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txtTotalAllDiscount.BackgroundStyle.BorderBottomColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtTotalAllDiscount.BackgroundStyle.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.SplitterBorder
        Me.txtTotalAllDiscount.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txtTotalAllDiscount.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txtTotalAllDiscount.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txtTotalAllDiscount.BackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarCaptionBackground2
        Me.txtTotalAllDiscount.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtTotalAllDiscount.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtTotalAllDiscount.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.txtTotalAllDiscount.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.txtTotalAllDiscount.Font = New System.Drawing.Font("Khmer OS Content", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalAllDiscount.Increment = 0R
        Me.txtTotalAllDiscount.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Center
        Me.txtTotalAllDiscount.InputMouseWheelEnabled = False
        Me.txtTotalAllDiscount.IsInputReadOnly = True
        Me.txtTotalAllDiscount.Location = New System.Drawing.Point(368, 9)
        Me.txtTotalAllDiscount.MinValue = 0R
        Me.txtTotalAllDiscount.Name = "txtTotalAllDiscount"
        Me.txtTotalAllDiscount.Size = New System.Drawing.Size(86, 35)
        Me.txtTotalAllDiscount.TabIndex = 21
        Me.txtTotalAllDiscount.WatermarkAlignment = DevComponents.Editors.eTextAlignment.Center
        Me.txtTotalAllDiscount.WatermarkText = "0.00"
        '
        'btnDiscount
        '
        Me.btnDiscount.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnDiscount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDiscount.Image = CType(resources.GetObject("btnDiscount.Image"), System.Drawing.Image)
        Me.btnDiscount.Location = New System.Drawing.Point(451, 9)
        Me.btnDiscount.Name = "btnDiscount"
        Me.btnDiscount.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.btnDiscount.Size = New System.Drawing.Size(44, 35)
        Me.btnDiscount.SymbolSize = 16.0!
        Me.btnDiscount.TabIndex = 20
        Me.btnDiscount.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        'btn_RemoveOne
        '
        Me.btn_RemoveOne.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_RemoveOne.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_RemoveOne.Image = CType(resources.GetObject("btn_RemoveOne.Image"), System.Drawing.Image)
        Me.btn_RemoveOne.ImageFixedSize = New System.Drawing.Size(28, 28)
        Me.btn_RemoveOne.Location = New System.Drawing.Point(18, 9)
        Me.btn_RemoveOne.Name = "btn_RemoveOne"
        Me.btn_RemoveOne.Size = New System.Drawing.Size(46, 35)
        Me.btn_RemoveOne.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_RemoveOne.TabIndex = 0
        '
        'txt_recievedKHR
        '
        '
        '
        '
        Me.txt_recievedKHR.Border.BackColor = System.Drawing.Color.Transparent
        Me.txt_recievedKHR.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txt_recievedKHR.Border.BorderBottomWidth = 1
        Me.txt_recievedKHR.Border.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.txt_recievedKHR.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txt_recievedKHR.Border.BorderLeftWidth = 1
        Me.txt_recievedKHR.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txt_recievedKHR.Border.BorderRightWidth = 1
        Me.txt_recievedKHR.Border.BorderTopWidth = 1
        Me.txt_recievedKHR.Border.Class = "TextBoxBorder"
        Me.txt_recievedKHR.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_recievedKHR.Border.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.txt_recievedKHR.Font = New System.Drawing.Font("Roboto", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_recievedKHR.Location = New System.Drawing.Point(266, 160)
        Me.txt_recievedKHR.Multiline = True
        Me.txt_recievedKHR.Name = "txt_recievedKHR"
        Me.txt_recievedKHR.PreventEnterBeep = True
        Me.txt_recievedKHR.ReadOnly = True
        Me.txt_recievedKHR.Size = New System.Drawing.Size(229, 40)
        Me.txt_recievedKHR.TabIndex = 20
        Me.txt_recievedKHR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_recievedKHR.WatermarkText = "0.00"
        '
        'LabelX14
        '
        Me.LabelX14.BackColor = System.Drawing.Color.LightGray
        '
        '
        '
        Me.LabelX14.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.LabelX14.BackgroundStyle.BorderBottomWidth = 1
        Me.LabelX14.BackgroundStyle.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.LabelX14.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.LabelX14.BackgroundStyle.BorderLeftWidth = 1
        Me.LabelX14.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.LabelX14.BackgroundStyle.BorderRightWidth = 1
        Me.LabelX14.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.LabelX14.BackgroundStyle.BorderTopWidth = 1
        Me.LabelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX14.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX14.Location = New System.Drawing.Point(266, 139)
        Me.LabelX14.Name = "LabelX14"
        Me.LabelX14.Size = New System.Drawing.Size(229, 23)
        Me.LabelX14.TabIndex = 19
        Me.LabelX14.Text = "Received KHR ( ៛ )"
        Me.LabelX14.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txt_recievedUSD
        '
        '
        '
        '
        Me.txt_recievedUSD.Border.BackColor = System.Drawing.Color.Transparent
        Me.txt_recievedUSD.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txt_recievedUSD.Border.BorderBottomWidth = 1
        Me.txt_recievedUSD.Border.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.txt_recievedUSD.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txt_recievedUSD.Border.BorderLeftWidth = 1
        Me.txt_recievedUSD.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txt_recievedUSD.Border.BorderRightWidth = 1
        Me.txt_recievedUSD.Border.BorderTopWidth = 1
        Me.txt_recievedUSD.Border.Class = "TextBoxBorder"
        Me.txt_recievedUSD.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_recievedUSD.Border.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.txt_recievedUSD.Font = New System.Drawing.Font("Roboto", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_recievedUSD.Location = New System.Drawing.Point(17, 160)
        Me.txt_recievedUSD.Multiline = True
        Me.txt_recievedUSD.Name = "txt_recievedUSD"
        Me.txt_recievedUSD.PreventEnterBeep = True
        Me.txt_recievedUSD.ReadOnly = True
        Me.txt_recievedUSD.Size = New System.Drawing.Size(229, 40)
        Me.txt_recievedUSD.TabIndex = 18
        Me.txt_recievedUSD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_recievedUSD.WatermarkText = "0.00"
        '
        'LabelX15
        '
        Me.LabelX15.BackColor = System.Drawing.Color.LightGray
        '
        '
        '
        Me.LabelX15.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.LabelX15.BackgroundStyle.BorderBottomWidth = 1
        Me.LabelX15.BackgroundStyle.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.LabelX15.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.LabelX15.BackgroundStyle.BorderLeftWidth = 1
        Me.LabelX15.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.LabelX15.BackgroundStyle.BorderRightWidth = 1
        Me.LabelX15.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.LabelX15.BackgroundStyle.BorderTopWidth = 1
        Me.LabelX15.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX15.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX15.Location = New System.Drawing.Point(17, 139)
        Me.LabelX15.Name = "LabelX15"
        Me.LabelX15.Size = New System.Drawing.Size(229, 23)
        Me.LabelX15.TabIndex = 17
        Me.LabelX15.Text = "Received USD ( $ )"
        Me.LabelX15.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txt_totalKHR
        '
        '
        '
        '
        Me.txt_totalKHR.Border.BackColor = System.Drawing.Color.Transparent
        Me.txt_totalKHR.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txt_totalKHR.Border.BorderBottomWidth = 1
        Me.txt_totalKHR.Border.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.txt_totalKHR.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txt_totalKHR.Border.BorderLeftWidth = 1
        Me.txt_totalKHR.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txt_totalKHR.Border.BorderRightWidth = 1
        Me.txt_totalKHR.Border.BorderTopWidth = 1
        Me.txt_totalKHR.Border.Class = "TextBoxBorder"
        Me.txt_totalKHR.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_totalKHR.Border.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.txt_totalKHR.Font = New System.Drawing.Font("Roboto", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_totalKHR.Location = New System.Drawing.Point(266, 88)
        Me.txt_totalKHR.Multiline = True
        Me.txt_totalKHR.Name = "txt_totalKHR"
        Me.txt_totalKHR.PreventEnterBeep = True
        Me.txt_totalKHR.ReadOnly = True
        Me.txt_totalKHR.Size = New System.Drawing.Size(229, 41)
        Me.txt_totalKHR.TabIndex = 16
        Me.txt_totalKHR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_totalKHR.WatermarkText = "0.00"
        '
        'LabelX16
        '
        Me.LabelX16.BackColor = System.Drawing.Color.LightGray
        '
        '
        '
        Me.LabelX16.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.LabelX16.BackgroundStyle.BorderBottomWidth = 1
        Me.LabelX16.BackgroundStyle.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.LabelX16.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.LabelX16.BackgroundStyle.BorderLeftWidth = 1
        Me.LabelX16.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.LabelX16.BackgroundStyle.BorderRightWidth = 1
        Me.LabelX16.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.LabelX16.BackgroundStyle.BorderTopWidth = 1
        Me.LabelX16.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX16.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX16.Location = New System.Drawing.Point(266, 65)
        Me.LabelX16.Name = "LabelX16"
        Me.LabelX16.Size = New System.Drawing.Size(229, 23)
        Me.LabelX16.TabIndex = 15
        Me.LabelX16.Text = "Total KHR ( ៛ )"
        Me.LabelX16.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'btnClear
        '
        Me.btnClear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnClear.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnClear.Font = New System.Drawing.Font("Roboto", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(266, 303)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(229, 94)
        Me.btnClear.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnClear.TabIndex = 14
        Me.btnClear.Text = "Cancel"
        '
        'btnPay
        '
        Me.btnPay.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnPay.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnPay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPay.Font = New System.Drawing.Font("Roboto", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPay.Location = New System.Drawing.Point(17, 303)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(229, 94)
        Me.btnPay.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnPay.TabIndex = 13
        Me.btnPay.Text = "Pay Now"
        '
        'txt_totalUS
        '
        '
        '
        '
        Me.txt_totalUS.Border.BackColor = System.Drawing.Color.Transparent
        Me.txt_totalUS.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txt_totalUS.Border.BorderBottomWidth = 1
        Me.txt_totalUS.Border.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.txt_totalUS.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txt_totalUS.Border.BorderLeftWidth = 1
        Me.txt_totalUS.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txt_totalUS.Border.BorderRightWidth = 1
        Me.txt_totalUS.Border.BorderTopWidth = 1
        Me.txt_totalUS.Border.Class = "TextBoxBorder"
        Me.txt_totalUS.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_totalUS.Border.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.txt_totalUS.Font = New System.Drawing.Font("Roboto", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_totalUS.Location = New System.Drawing.Point(17, 88)
        Me.txt_totalUS.Multiline = True
        Me.txt_totalUS.Name = "txt_totalUS"
        Me.txt_totalUS.PreventEnterBeep = True
        Me.txt_totalUS.ReadOnly = True
        Me.txt_totalUS.Size = New System.Drawing.Size(229, 41)
        Me.txt_totalUS.TabIndex = 2
        Me.txt_totalUS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_totalUS.WatermarkText = "0.00"
        '
        'LabelX17
        '
        Me.LabelX17.BackColor = System.Drawing.Color.LightGray
        '
        '
        '
        Me.LabelX17.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.LabelX17.BackgroundStyle.BorderBottomWidth = 1
        Me.LabelX17.BackgroundStyle.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.LabelX17.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.LabelX17.BackgroundStyle.BorderLeftWidth = 1
        Me.LabelX17.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.LabelX17.BackgroundStyle.BorderRightWidth = 1
        Me.LabelX17.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.LabelX17.BackgroundStyle.BorderTopWidth = 1
        Me.LabelX17.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX17.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX17.Location = New System.Drawing.Point(17, 65)
        Me.LabelX17.Name = "LabelX17"
        Me.LabelX17.Size = New System.Drawing.Size(229, 23)
        Me.LabelX17.TabIndex = 0
        Me.LabelX17.Text = "Total USD ( $ )"
        Me.LabelX17.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'PanelEx4
        '
        Me.PanelEx4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelEx4.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx4.Controls.Add(Me.txt_barcode)
        Me.PanelEx4.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx4.Location = New System.Drawing.Point(548, 86)
        Me.PanelEx4.Name = "PanelEx4"
        Me.PanelEx4.Size = New System.Drawing.Size(512, 62)
        Me.PanelEx4.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx4.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx4.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx4.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx4.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx4.Style.GradientAngle = 90
        Me.PanelEx4.TabIndex = 99
        '
        'txt_barcode
        '
        '
        '
        '
        Me.txt_barcode.Border.Class = "TextBoxBorder"
        Me.txt_barcode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_barcode.Font = New System.Drawing.Font("Roboto", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_barcode.Location = New System.Drawing.Point(25, 15)
        Me.txt_barcode.Name = "txt_barcode"
        Me.txt_barcode.PreventEnterBeep = True
        Me.txt_barcode.Size = New System.Drawing.Size(249, 30)
        Me.txt_barcode.TabIndex = 0
        '
        'Timer1
        '
        '
        'frmMain
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(1060, 700)
        Me.Controls.Add(Me.PanelEx4)
        Me.Controls.Add(Me.panelRightMain)
        Me.Controls.Add(Me.panelFooter)
        Me.Controls.Add(Me.panelProductBox)
        Me.Controls.Add(Me.PanelEx1)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Roboto", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmMain"
        Me.Text = "ZK project"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.PanelEx1.ResumeLayout(False)
        Me.panelProductBox.ResumeLayout(False)
        CType(Me.dgProByCate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelFooter.ResumeLayout(False)
        Me.panelRightMain.ResumeLayout(False)
        Me.panelControlRight.ResumeLayout(False)
        Me.PanelEx3.ResumeLayout(False)
        CType(Me.dgitems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.PanelEx2.ResumeLayout(False)
        CType(Me.txtTotalAllDiscount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents panelCategory As Panel
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents cateNext As DevComponents.DotNetBar.ButtonX
    Friend WithEvents catePrevious As DevComponents.DotNetBar.ButtonX
    Friend WithEvents panelProductBox As Panel
    Friend WithEvents dgProByCate As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents panelFooter As DevComponents.DotNetBar.PanelEx
    Friend WithEvents txt_exchange As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents proNext As DevComponents.DotNetBar.ButtonX
    Friend WithEvents proPrevious As DevComponents.DotNetBar.ButtonX
    Friend WithEvents lbPageNo As DevComponents.DotNetBar.LabelX
    Friend WithEvents panelRightMain As DevComponents.DotNetBar.PanelEx
    Friend WithEvents panelControlRight As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txt_recievedKHR As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX14 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txt_recievedUSD As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX15 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txt_totalKHR As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX16 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnClear As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnPay As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txt_totalUS As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX17 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dgitems As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PanelEx3 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents LabelX18 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX19 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX20 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX21 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX22 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX23 As DevComponents.DotNetBar.LabelX
    Friend WithEvents PanelEx4 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents No As DataGridViewTextBoxColumn
    Friend WithEvents Items As DataGridViewTextBoxColumn
    Friend WithEvents Qty As DataGridViewTextBoxColumn
    Friend WithEvents Price As DataGridViewTextBoxColumn
    Friend WithEvents Disc As DataGridViewTextBoxColumn
    Friend WithEvents Grand As DataGridViewTextBoxColumn
    Friend WithEvents btn_RemoveOne As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtTotalAllDiscount As DevComponents.Editors.DoubleInput
    Friend WithEvents btnDiscount As DevComponents.DotNetBar.ButtonX
    Friend WithEvents lbldate As DevComponents.DotNetBar.LabelX
    Friend WithEvents Timer1 As Timer
    Friend WithEvents txt_changeKHR As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txt_changeUSD As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txt_barcode As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
End Class
