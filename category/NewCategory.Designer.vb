<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NewCategory
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewCategory))
        Me.dgCategory = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column4 = New DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn()
        Me.btn_edit = New DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn()
        Me.btn_delete = New DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_browse = New DevComponents.DotNetBar.ButtonX()
        Me.chkIsavailable = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.btn_add = New DevComponents.DotNetBar.ButtonX()
        Me.btn_clear = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.imageBox = New System.Windows.Forms.PictureBox()
        Me.txt_catname = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        CType(Me.dgCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.imageBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgCategory
        '
        Me.dgCategory.AllowUserToAddRows = False
        Me.dgCategory.AllowUserToDeleteRows = False
        Me.dgCategory.AllowUserToOrderColumns = True
        Me.dgCategory.AllowUserToResizeRows = False
        Me.dgCategory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgCategory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgCategory.ColumnHeadersHeight = 32
        Me.dgCategory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.btn_edit, Me.btn_delete})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgCategory.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgCategory.EnableHeadersVisualStyles = False
        Me.dgCategory.GridColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.dgCategory.Location = New System.Drawing.Point(400, 7)
        Me.dgCategory.Margin = New System.Windows.Forms.Padding(6)
        Me.dgCategory.Name = "dgCategory"
        Me.dgCategory.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgCategory.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgCategory.RowHeadersVisible = False
        Me.dgCategory.RowHeadersWidth = 51
        Me.dgCategory.RowTemplate.Height = 40
        Me.dgCategory.Size = New System.Drawing.Size(480, 352)
        Me.dgCategory.TabIndex = 2
        '
        'Column1
        '
        Me.Column1.HeaderText = "No"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column1.Width = 40
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "Category Name"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Image"
        Me.Column3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column3.Width = 120
        '
        'Column4
        '
        Me.Column4.Checked = True
        Me.Column4.CheckState = System.Windows.Forms.CheckState.Indeterminate
        Me.Column4.CheckValue = Nothing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column4.HeaderText = "Status"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column4.Width = 60
        '
        'btn_edit
        '
        Me.btn_edit.HeaderText = "Edit"
        Me.btn_edit.Image = CType(resources.GetObject("btn_edit.Image"), System.Drawing.Image)
        Me.btn_edit.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.btn_edit.MinimumWidth = 6
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.ReadOnly = True
        Me.btn_edit.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.btn_edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.btn_edit.Text = Nothing
        Me.btn_edit.Width = 50
        '
        'btn_delete
        '
        Me.btn_delete.HeaderText = "Delete"
        Me.btn_delete.Image = CType(resources.GetObject("btn_delete.Image"), System.Drawing.Image)
        Me.btn_delete.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.btn_delete.MinimumWidth = 6
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.ReadOnly = True
        Me.btn_delete.Text = Nothing
        Me.btn_delete.Width = 60
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_browse)
        Me.GroupBox1.Controls.Add(Me.chkIsavailable)
        Me.GroupBox1.Controls.Add(Me.btn_add)
        Me.GroupBox1.Controls.Add(Me.btn_clear)
        Me.GroupBox1.Controls.Add(Me.LabelX1)
        Me.GroupBox1.Controls.Add(Me.imageBox)
        Me.GroupBox1.Controls.Add(Me.txt_catname)
        Me.GroupBox1.Controls.Add(Me.LabelX2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Gray
        Me.GroupBox1.Location = New System.Drawing.Point(16, 4)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(6)
        Me.GroupBox1.Size = New System.Drawing.Size(372, 355)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add Category"
        '
        'btn_browse
        '
        Me.btn_browse.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_browse.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_browse.Location = New System.Drawing.Point(146, 219)
        Me.btn_browse.Name = "btn_browse"
        Me.btn_browse.Size = New System.Drawing.Size(81, 32)
        Me.btn_browse.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_browse.TabIndex = 13
        Me.btn_browse.Text = "Browse"
        '
        'chkIsavailable
        '
        '
        '
        '
        Me.chkIsavailable.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkIsavailable.Checked = True
        Me.chkIsavailable.CheckSignSize = New System.Drawing.Size(20, 20)
        Me.chkIsavailable.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkIsavailable.CheckValue = "Y"
        Me.chkIsavailable.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkIsavailable.Location = New System.Drawing.Point(12, 269)
        Me.chkIsavailable.Name = "chkIsavailable"
        Me.chkIsavailable.Size = New System.Drawing.Size(138, 23)
        Me.chkIsavailable.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.chkIsavailable.TabIndex = 12
        Me.chkIsavailable.Text = "AVAILABLE"
        '
        'btn_add
        '
        Me.btn_add.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_add.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_add.Location = New System.Drawing.Point(278, 304)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(81, 32)
        Me.btn_add.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_add.TabIndex = 10
        Me.btn_add.Text = "ADD"
        '
        'btn_clear
        '
        Me.btn_clear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_clear.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_clear.Location = New System.Drawing.Point(178, 304)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(81, 32)
        Me.btn_clear.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_clear.TabIndex = 9
        Me.btn_clear.Text = "CLEAR"
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.ForeColor = System.Drawing.Color.Black
        Me.LabelX1.Location = New System.Drawing.Point(12, 85)
        Me.LabelX1.Margin = New System.Windows.Forms.Padding(6)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(125, 33)
        Me.LabelX1.TabIndex = 6
        Me.LabelX1.Text = "Category Image :"
        '
        'imageBox
        '
        Me.imageBox.Image = Global.zkproject.My.Resources.Resources.upload_image
        Me.imageBox.Location = New System.Drawing.Point(146, 82)
        Me.imageBox.Name = "imageBox"
        Me.imageBox.Size = New System.Drawing.Size(176, 131)
        Me.imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imageBox.TabIndex = 4
        Me.imageBox.TabStop = False
        '
        'txt_catname
        '
        '
        '
        '
        Me.txt_catname.Border.Class = "TextBoxBorder"
        Me.txt_catname.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_catname.DisabledBackColor = System.Drawing.Color.White
        Me.txt_catname.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_catname.Location = New System.Drawing.Point(136, 40)
        Me.txt_catname.Margin = New System.Windows.Forms.Padding(6)
        Me.txt_catname.Name = "txt_catname"
        Me.txt_catname.PreventEnterBeep = True
        Me.txt_catname.Size = New System.Drawing.Size(224, 27)
        Me.txt_catname.TabIndex = 2
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.ForeColor = System.Drawing.Color.Black
        Me.LabelX2.Location = New System.Drawing.Point(12, 40)
        Me.LabelX2.Margin = New System.Windows.Forms.Padding(6)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(157, 33)
        Me.LabelX2.TabIndex = 0
        Me.LabelX2.Text = "Category Name :"
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Blue
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(154, Byte), Integer)))
        '
        'NewCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.ClientSize = New System.Drawing.Size(895, 375)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgCategory)
        Me.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NewCategory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Category"
        CType(Me.dgCategory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.imageBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgCategory As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txt_catname As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents imageBox As PictureBox
    Friend WithEvents btn_clear As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btn_add As DevComponents.DotNetBar.ButtonX
    Friend WithEvents chkIsavailable As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents btn_browse As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewImageColumn
    Friend WithEvents Column4 As DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn
    Friend WithEvents btn_edit As DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn
    Friend WithEvents btn_delete As DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
End Class
