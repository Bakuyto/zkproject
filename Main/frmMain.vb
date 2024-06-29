Imports System.ComponentModel
Imports System.IO.Ports
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

Public Class frmMain

    Dim total_cate_in_panel As Integer = 0
    Dim _count As Integer = 0
    Dim allelement As Integer
    Dim totalcatecontrol As Integer
    Dim procate(10000) As DevComponents.DotNetBar.ButtonX
    Dim categoryid As Integer
    Dim pnl_category_width As Double = 0
    Dim start_cate_ind As Integer = 0
    Dim totalproduct As Double = 0
    Dim controls_per_panel As Integer = 0
    Dim _countproductgrid As Integer = 0
    Dim totalproductingrid As Integer
    Dim height_length As Double = 0
    Dim productpic(1000) As DevComponents.DotNetBar.ButtonX
    Dim width_length As Double = 0
    Dim productmargin As Double = My.Settings.columnsmargin
    Dim control_padding As Double = My.Settings.rowsmargin
    Dim row_count As Integer = My.Settings.viewrows
    Dim column_count As Integer = My.Settings.viewcolumns
    Dim _productClickcount As Integer = 0
    Dim start_ind As Integer = 0
    Dim allicon As New List(Of Image)
    Dim alllabel As New List(Of String)
    Dim osstock As Integer = 0

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbldate.Text = Date.Now.ToString("dd-MM-yyyy     hh:mm:ss")
    End Sub

    Private Sub frmMain_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeForm()
        handlerComport()
    End Sub

    Private Sub frmMain_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            ' Handle behavior when form is minimized
            ' Example: hide certain controls, pause timers, etc.
        Else
            ' Handle behavior when form is restored from minimized state
            ' Example: re-enable timers, refresh data, etc.
            InitializeForm()

            ' Call controlItem() and controlItemPro() methods here
            For i = 0 To objDataTable.Rows.Count - 1
                controlItem(i)
            Next
        End If
    End Sub

    Private Sub InitializeForm()
        Try
            setConnection()
            GetWidthAndHeight()
            LoadProductToCatePanel()
            PanelCategoryControls()
            txt_exchange.Text = My.Settings.exchangeRate
            Timer1.Enabled = True
            txtTotalAllDiscount.Text = "0.00"

            ' Add any other initialization code here
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub handlerComport()
        ' Set the COM port to a valid port
        My.Settings.COMport = "COM3" ' Example COM port, change as needed

        If Not SerialPort1.IsOpen Then
            SerialPort1.PortName = My.Settings.COMport
            SerialPort1.BaudRate = 9600
            Try
                ' Open the serial port
                SerialPort1.Open()
                AddHandler SerialPort1.DataReceived, AddressOf SerialPort_DataReceived
            Catch ex As Exception
                Console.WriteLine("Failed to open serial port: " & ex.Message)
            End Try
        Else
            Try
                ' Close the serial port
                SerialPort1.Close()
            Catch ex As Exception
                Console.WriteLine("Failed to close the serial port: " & ex.Message)
            End Try
        End If
    End Sub

    ' Function to load barcode data from the database
    Public Function LoadBarCodeToSale(ByVal productBarCode As String) As String
        Dim BarcodeSale As String = "SELECT product_pk, pro_name, pro_qty, pro_price, dis_percentage FROM tbl_product WHERE barcode = '" & MySqlHelper.EscapeString(productBarCode) & "';"
        Return BarcodeSale
    End Function

    ' Event handler for data received from the serial port
    Private Sub SerialPort_DataReceived(ByVal sender As Object, ByVal e As SerialDataReceivedEventArgs)
        Try
            Dim indata As String = SerialPort1.ReadExisting().Trim()

            ' Use Invoke to update the UI on the main thread
            Me.Invoke(Sub()
                          txt_barcode.Text = indata
                          ProcessBarcodeData(indata)
                      End Sub)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ProcessBarcodeData(ByVal barcodeData As String)
        Try
            Dim sqltext As String = LoadBarCodeToSale(barcodeData)
            fillDataTable(sqltext)

            If objDataTable.Rows.Count > 1 Then
                ProductViewerTable()
            ElseIf objDataTable.Rows.Count = 1 Then
                filldataWithProCode(objDataTable.Rows(0)("product_pk"))
            Else
                ' Handle case when product is not found
                MsgBox("Product not found for barcode: " & barcodeData)
            End If

            UpdateChange()
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message)
        End Try
    End Sub


    Private Sub PanelCategoryControls()
        Try
            pnl_category_width = panelCategory.Width
            total_cate_in_panel = pnl_category_width \ 105
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub LoadDatafornextandprevious()
        Try
            allicon.Clear()
            alllabel.Clear()
            Dim iconloc As New Point(5, 6)
            sqltext = "Call GetCategory(" & start_cate_ind & "," & total_cate_in_panel & ")"
            fillDataTable(sqltext)

            ' Assuming objDataTable has columns including "cate_name"
            If objDataTable.Rows.Count > 0 Then
                panelCategory.Controls.Clear()
                For i = 0 To objDataTable.Rows.Count - 1
                    ' Assuming you have a procate array to store controls
                    controlItem(i)
                    procate(i).Tag = objDataTable(i)(0)

                    ' Store cate_name along with other details
                    Dim cateName As String = objDataTable(i)("cate_name").ToString()

                    ' Set text for the button/control (procate)
                    If cateName.Length > 11 Then
                        procate(i).Text = "<b>" & objDataTable(i)("cate_name") & "</b>".Substring(0, 11) & "..."
                    Else
                        procate(i).Text = "<b>" & objDataTable(i)("cate_name") & "</b>"
                    End If

                    procate(i).Location = iconloc
                    AddHandler procate(i).Click, AddressOf Me.cateButton_Click

                    If iconloc.X + 105 > panelCategory.Width Then
                        Exit Sub
                    Else
                        panelCategory.Controls.Add(procate(i))
                        iconloc = procate(i).Location + New Point(105, 0)
                    End If
                Next
            End If
        Catch ex As Exception
            MsgBox("Error loading category data: " & ex.Message)
        End Try
    End Sub


    Private Sub controlItem(ByVal int As Integer)
        procate(int) = New DevComponents.DotNetBar.ButtonX With {
            .ColorTable = DevComponents.DotNetBar.eButtonColor.Blue,
            .Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014,
             .Size = New Size(100, 76),
             .Font = New Font("Khmer OS Content", 8.25)
            }

        'procate(int) = New Button
        'procate(int).FlatStyle = FlatStyle.Flat
        'procate(int).TextAlign = ContentAlignment.BottomCenter
        procate(int).ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        'procate(int).ForeColor = Color.Blue
        procate(int).Image = BinarytoImage(objDataTable(int)("cate_image"))
        procate(int).ImageFixedSize = New Size(96, 48)
        procate(int).ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        procate(int).Cursor = Windows.Forms.Cursors.Hand
        procate(int).Padding = New Padding(4, 0, 4, 2)
    End Sub

    Private Sub cateButton_Click(sender As Object, e As EventArgs)
        Dim btnclick = DirectCast(sender, DevComponents.DotNetBar.ButtonX)
        'Dim btnclick = DirectCast(sender, Button)
        categoryid = btnclick.Tag
        LoadAllProductByCategory()
    End Sub

    Private Sub LoadAllProductByCategory()
        'GetWidthAndHeight()
        totalproduct = runFunctionCommandText("SELECT fn_Count_Product_By_Category(" & categoryid & ")")
        'sqltext = "CALL GetProductByCategory('" & categoryid & "')"
        sqltext = "CALL GetProductByCategory('" & categoryid & "',0,'" & controls_per_panel & "')"
        If totalproduct <= controls_per_panel Then
            lbPageNo.Text = totalproduct & " of " & totalproduct
        Else
            lbPageNo.Text = controls_per_panel & " of " & totalproduct
        End If
        ProductViewerTable()

    End Sub

    Private Sub ControlItemPro(ByVal int As Integer)
        productpic(int) = New DevComponents.DotNetBar.ButtonX With {
            .Font = New Font("Khmer OS Content", 8.25),
            .Size = New Size(width_length - productmargin, height_length)
            }
        productpic(int).BackColor = Color.Azure
        productpic(int).Cursor = Windows.Forms.Cursors.Hand
        productpic(int).Padding = New Padding(5, 5, 5, 5)

        productpic(int).Image = BinarytoImage(objDataTable(int)("pro_img"))
        'productpic(int).ImageFixedSize = New Size(width_length - productmargin - 8, height_length - 30)
        productpic(int).ImageFixedSize = New Size(width_length - productmargin - 8, height_length - 45)
        productpic(int).ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        productpic(int).ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
    End Sub

    Public Sub ProductViewerTable()
        Try

            panelProductBox.Controls.Clear()

            Dim _cc = 0
            totalproductingrid = 0
            'GetWidthAndHeight()
            proPrevious.Enabled = False
            proNext.Enabled = True
            '/_productClickcount = 0
            _countproductgrid = 0
            Dim rheight As Integer
            fillDataTable(sqltext)
            panelProductBox.Controls.Clear()
            If objDataTable.Rows.Count > 0 Then
                Dim propicloc As New Point(5, 5)
                'Dim prolabelloc As New Point(5, height_length - height_label)
                'Get Total Product by category

                For i = 0 To objDataTable.Rows.Count - 1
                    If (rheight + height_length > panelProductBox.Height) Then
                        _countproductgrid += 1
                    Else

                        ControlItemPro(i)
                        productpic(i).Location = propicloc
                        If objDataTable(i)("pro_name").ToString.Length > 14 Then
                            productpic(i).Text = "<b>" & objDataTable(i)("pro_name").ToString.Substring(0, 14) & "</b>"
                        Else
                            productpic(i).Text = "<b>" & objDataTable(i)("pro_name").ToString & "</b>"
                        End If
                        productpic(i).Tag = objDataTable(i)("product_pk")
                        AddHandler productpic(i).Click, AddressOf Me.ProductName_Click
                        panelProductBox.Controls.Add(productpic(i))
                        'ToolTip
                        'Dim TooltipPro As New DevComponents.DotNetBar.SuperTooltipInfo() With {
                        '        .HeaderText = objDataTable(i)("itemName").ToString,
                        '        .BodyImage = BinarytoImage(objDataTable(i)("proImage"))
                        '    }

                        'TooltipPro.FooterText = objDataTable(i)("aliasName").ToString() & "  " & objDataTable(i)("method").ToString() & " - [" & My.Settings.currencySign & objDataTable(i)("proPriceUSD") & " = " & My.Settings.ExchangecurrencySign & exch & "]"
                        '/Hide hover
                        'SuperTooltip2.SetSuperTooltip(productpic(i), TooltipPro)
                        If propicloc.X + width_length > panelProductBox.Width Then
                            _cc = _cc + 1
                            propicloc = New Point(5, _cc * (height_length + control_padding) + 5)
                            If propicloc.Y + height_length > panelProductBox.Height Then
                                totalproductingrid = panelProductBox.Controls.Count
                                Exit Sub
                            End If
                        Else
                            propicloc = productpic(i).Location + New Point(width_length, 0)
                        End If
                    End If
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ProductName_Click(sender As Object, e As EventArgs)
        'Dim btnclick = DirectCast(sender, PictureBox)
        Dim btnclick = DirectCast(sender, DevComponents.DotNetBar.ButtonX)
        filldataWithProCode(btnclick.Tag.ToString())
        UpdateChange()
        '/cboSaleCode.Focus()
    End Sub

    Public Sub filldataWithProCode(ByVal id As String)
        Try
            osstock = 0
            Dim _count As Integer = 0
            Dim pstr As String = "CALL Get_ProductToQuickSale('" & id & "')"
            fillDataX(pstr)

            If objdataX.Rows.Count > 0 Then
                Dim productExists As Boolean = False
                Dim existingRowIndex As Integer = -1

                ' Check if product already exists in dgitems
                For Each row As DataGridViewRow In dgitems.Rows
                    If Convert.ToString(row.Cells("Items").Value) = Convert.ToString(objdataX.Rows(0)("pro_name")) Then
                        ' Product already exists
                        productExists = True
                        existingRowIndex = row.Index
                        Exit For
                    End If
                Next

                If productExists Then
                    ' Update existing row
                    Dim existingRow As DataGridViewRow = dgitems.Rows(existingRowIndex)
                    existingRow.Cells("Qty").Value = Convert.ToInt32(existingRow.Cells("Qty").Value) + 1
                    existingRow.Cells("Grand").Value = CalculateGrandTotal(Convert.ToInt32(existingRow.Cells("Qty").Value), Convert.ToDecimal(existingRow.Cells("Price").Value), Convert.ToDecimal(existingRow.Cells("Disc").Value)).ToString("0.00")
                Else
                    ' If product does not exist, add a new row
                    Dim rowIndex As Integer = dgitems.Rows.Add()
                    Dim newRow As DataGridViewRow = dgitems.Rows(rowIndex)
                    newRow.Cells("No").Value = rowIndex + 1
                    newRow.Cells("Items").Value = objdataX.Rows(0)("pro_name")
                    newRow.Cells("Qty").Value = 1 ' Default quantity to 1
                    newRow.Cells("Price").Value = objdataX.Rows(0)("pro_price")
                    newRow.Cells("Disc").Value = objdataX.Rows(0)("dis_percentage")
                    newRow.Cells("Grand").Value = CalculateGrandTotal(Convert.ToInt32(newRow.Cells("Qty").Value), Convert.ToDecimal(newRow.Cells("Price").Value), Convert.ToDecimal(newRow.Cells("Disc").Value)).ToString("0.00")
                End If
                UpdateGrandTotalAndTextBoxes()
            End If
        Catch ex As Exception
            MsgBox("Something went wrong. Please try to select item again. (" & ex.Message & ")")
        End Try
    End Sub

    Private Sub UpdateGrandTotalAndTextBoxes()
        Try
            Dim grandTotal As Decimal = 0
            Dim totalDiscount As Decimal = Decimal.Parse(txtTotalAllDiscount.Text) ' Parse the discount value from txtTotalAllDiscount

            ' Calculate the Grand Total considering the overall discount
            For Each row As DataGridViewRow In dgitems.Rows
                Dim price As Decimal = Convert.ToDecimal(row.Cells("Price").Value)
                Dim discount As Decimal = Convert.ToDecimal(row.Cells("Disc").Value)
                Dim qty As Integer = Convert.ToInt32(row.Cells("Qty").Value)

                ' Calculate discounted price per item
                Dim discountedPrice As Decimal = price - (price * (discount / 100))

                ' Calculate total for this item considering quantity and discounted price
                Dim itemTotal As Decimal = qty * discountedPrice

                ' Accumulate to grand total
                grandTotal += itemTotal
            Next

            ' Apply the overall discount to the grand total
            grandTotal -= (grandTotal * (totalDiscount / 100))

            ' Update the TotalUSD textbox
            txt_totalUS.Text = grandTotal.ToString("0.00")

            ' Get the exchange rate
            Dim exchangeRate As Decimal
            If Decimal.TryParse(My.Settings.exchangeRate, exchangeRate) Then
                ' Update the TotalKHR textbox
                Dim totalKHR As Decimal = grandTotal * exchangeRate
                totalKHR = Math.Round(totalKHR / 100) * 100
                txt_totalKHR.Text = totalKHR.ToString("0.00")
            Else
                MsgBox("Invalid exchange rate. Please enter a valid exchange rate.")
            End If
        Catch ex As Exception
            MsgBox("Error updating totals: " & ex.Message)
        End Try
    End Sub

    Private Function CalculateGrandTotal(qty As Integer, price As Decimal, discount As Decimal) As Decimal
        ' Implement your calculation logic here
        Dim discountedPrice As Decimal = price - (price * (discount / 100))
        Dim grandTotal As Decimal = qty * discountedPrice
        Return grandTotal
    End Function


    Dim height_label As Double = 27
    Private Sub GetWidthAndHeight()
        width_length = (panelProductBox.Width / column_count)
        height_length = (panelProductBox.Height / row_count) - control_padding
        controls_per_panel = My.Settings.viewrows * My.Settings.viewcolumns
        '/controls_per_panel = row_count * column_count
    End Sub

    Public Sub NextAndPrivoiusProduct(sqltext As String)
        Try
            panelProductBox.Controls.Clear()
            Dim _cc = 0
            Dim j As Integer = 0
            Dim rheight As Integer
            GetWidthAndHeight()
            _countproductgrid = 0
            fillDataTable(sqltext)
            Dim propicloc As New Point(5, 3)
            Dim prolabelloc As New Point(5, height_length - height_label)
            If objDataTable.Rows.Count > 0 Then
                For j = 0 To objDataTable.Rows.Count - 1
                    If (rheight + height_length > panelProductBox.Height) Then
                        _countproductgrid += 1
                    Else
                        ControlItemPro(j)
                        productpic(j).Location = propicloc
                        productpic(j).Tag = objDataTable(j)("product_pk")
                        If objDataTable(j)("pro_name").ToString.Length > 14 Then
                            productpic(j).Text = "<b>" & objDataTable(j)("pro_name").ToString.Substring(0, 14) & "</b>"
                        Else
                            productpic(j).Text = "<b>" & objDataTable(j)("pro_name").ToString & "</b>"
                        End If
                        AddHandler productpic(j).Click, AddressOf Me.ProductName_Click
                        panelProductBox.Controls.Add(productpic(j))
                        'Dim TooltipPro As New DevComponents.DotNetBar.SuperTooltipInfo() With {
                        '    .HeaderText = objDataTable(j)("itemName").ToString,
                        '    .BodyImage = BinarytoImage(objDataTable(j)("proImage"))
                        '    }

                        'TooltipPro.FooterText = objDataTable(j)("aliasName").ToString() & "  " & objDataTable(j)("method").ToString() & " - [" & My.Settings.currencySign & objDataTable(j)("proPriceUSD") & " = " & My.Settings.ExchangecurrencySign & exch & "]"
                        '/Hide hover
                        'SuperTooltip2.SetSuperTooltip(productpic(j), TooltipPro)
                        If propicloc.X + width_length > panelProductBox.Width Then
                            _cc = _cc + 1
                            propicloc = New Point(5, _cc * (height_length + control_padding) + 5)
                            If propicloc.Y + height_length > panelProductBox.Height Then
                                totalproductingrid = panelProductBox.Controls.Count
                                Exit Sub
                            End If
                        Else
                            propicloc = productpic(j).Location + New Point(width_length, 0)
                        End If
                    End If
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub LoadProductToCatePanel()
        Try
            'Loading.Show()
            'Loading.Refresh()
            Dim iconloc As New Point(5, 6)
            cateNext.Enabled = True
            _count = 0
            panelCategory.Controls.Clear()
            PanelCategoryControls()
            sqltext = "Call GetCategory(0," & total_cate_in_panel & ")"
            fillDataTable(sqltext)
            If (objDataTable.Rows.Count > 0) Then
                panelCategory.Controls.Clear()
                allelement = runFunctionCommandText("SELECT COUNT(*) FROM tbl_category")
                For i = 0 To objDataTable.Rows.Count - 1
                    controlItem(i)
                    procate(i).Tag = objDataTable(i)(0)
                    'procate(i).Text = objDataTable(i)(1)
                    If objDataTable(i)("cate_name").ToString.Length > 11 Then
                        procate(i).Text = "<b>" & objDataTable(i)("cate_name").ToString.Substring(0, 11) & "..." & "</b>"
                    Else
                        procate(i).Text = "<b>" & objDataTable(i)("cate_name") & "</b>"
                    End If
                    '/Dim superTooltip As New DevComponents.DotNetBar.SuperTooltipInfo() With {
                    '/.HeaderText = objDataTable(i)(1),
                    '/.BodyImage = BinarytoImage(objDataTable(i)("cateicon"))
                    '/}
                    '/Hide hover
                    'SuperTooltip1.DefaultTooltipSettings.Color = DevComponents.DotNetBar.eTooltipColor.Apple
                    'SuperTooltip1.SetSuperTooltip(procate(i), superTooltip)
                    AddHandler procate(i).Click, AddressOf Me.cateButton_Click
                    procate(i).Location = iconloc
                    If iconloc.X + 105 > panelCategory.Width Then
                        Exit For
                    Else
                        panelCategory.Controls.Add(procate(i))
                        iconloc = procate(i).Location + New Point(105, 0)
                    End If
                Next
                totalcatecontrol = panelCategory.Controls.Count
                'Loading.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub LabelX1_Click(sender As Object, e As EventArgs) Handles LabelX1.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure to exit the application?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub cateNext_Click(sender As Object, e As EventArgs) Handles cateNext.Click
        Try
            catePrevious.Enabled = True
            _count = _count + 1
            If _count * totalcatecontrol >= allelement Then
                _count = _count - 1
                cateNext.Enabled = False
            Else
                start_cate_ind = _count * total_cate_in_panel
                cateNext.Enabled = True
                LoadDatafornextandprevious()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub catePrevious_Click(sender As Object, e As EventArgs) Handles catePrevious.Click
        Try
            cateNext.Enabled = True
            _count = _count - 1
            If _count < 0 Then
                _count = _count + 1
                catePrevious.Enabled = False
            Else
                start_cate_ind = _count * total_cate_in_panel
                catePrevious.Enabled = True
                LoadDatafornextandprevious()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub proNext_Click(sender As Object, e As EventArgs) Handles proNext.Click
        Try
            proPrevious.Enabled = True
            _productClickcount = _productClickcount + 1
            If _productClickcount * controls_per_panel >= totalproduct Then
                _productClickcount = _productClickcount - 1
                proNext.Enabled = False
            Else
                proNext.Enabled = True
                start_ind = _productClickcount * controls_per_panel
                NextAndPrivoiusProduct("CALL GetProductByCategory('" & categoryid & "'," & start_ind & "," & controls_per_panel & ")")
                End If
            If totalproduct <= controls_per_panel Then
                lbPageNo.Text = totalproduct & " of " & totalproduct
            Else
                If (start_ind + controls_per_panel) >= totalproduct Then
                    lbPageNo.Text = totalproduct & " of " & totalproduct
                Else
                    lbPageNo.Text = start_ind + controls_per_panel & " of " & totalproduct
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub proPrevious_Click(sender As Object, e As EventArgs) Handles proPrevious.Click
        Try
            proNext.Enabled = True
            _productClickcount = _productClickcount - 1
            If _productClickcount < 0 Then
                _productClickcount = _productClickcount + 1
                proPrevious.Enabled = False
            Else
                proPrevious.Enabled = True
                start_ind = _productClickcount * controls_per_panel
                NextAndPrivoiusProduct("CALL GetProductByCategory('" & categoryid & "'," & start_ind & "," & controls_per_panel & ")")
            End If
            If _productClickcount = 0 Then
                proPrevious.Enabled = False
                If totalproduct <= controls_per_panel Then
                    lbPageNo.Text = totalproduct & " of " & totalproduct
                Else
                    lbPageNo.Text = controls_per_panel & " of " & totalproduct
                End If
            Else
                lbPageNo.Text = _productClickcount * controls_per_panel & " of " & totalproduct
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgitems_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgitems.CellClick
        Try
            If e.ColumnIndex >= 0 AndAlso dgitems.Columns(e.ColumnIndex).Name = "Qty" Then
                Dim currentRow As DataGridViewRow = dgitems.Rows(e.RowIndex)
                Dim numk As New IsNumericKeypad
                If numk.ShowDialog() = DialogResult.OK Then
                    Dim newQty As Integer = numk.EnteredValue
                    currentRow.Cells("Qty").Value = newQty
                    currentRow.Cells("Grand").Value = CalculateGrandTotal(newQty, Convert.ToDecimal(currentRow.Cells("Price").Value), Convert.ToDecimal(currentRow.Cells("Disc").Value)).ToString("0.00")
                    UpdateGrandTotalAndTextBoxes()
                End If
            Else
                ' Check if the clicked cell is part of a valid row (not a header or empty row)
                If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
                    ' Select the entire row when a cell is clicked
                    dgitems.Rows(e.RowIndex).Selected = True

                    ' Optional: Perform specific actions based on the clicked column
                    Dim clickedColumn As String = dgitems.Columns(e.ColumnIndex).Name

                    Select Case clickedColumn
                        Case "SomeColumnName" ' Replace with the actual column name
                            ' Perform specific actions for this column
                            MsgBox("You clicked on column: " & clickedColumn)
                            ' Add more cases as needed for other columns
                    End Select
                End If
            End If
        Catch ex As Exception
            MsgBox("Error handling cell click: " & ex.Message)
        End Try
    End Sub

    Private Sub btn_RemoveOne_Click(sender As Object, e As EventArgs) Handles btn_RemoveOne.Click
        RemoveRow()
    End Sub

    Private Sub RemoveRow()
        Try
            If dgitems.SelectedRows.Count > 0 Then
                Dim selectedIndex As Integer = dgitems.SelectedRows(0).Index
                dgitems.Rows.RemoveAt(selectedIndex)
                UpdateRowNumbers()
                UpdateGrandTotalAndTextBoxes()
                ' Select the next row
                If dgitems.Rows.Count > 0 Then
                    ' If the deleted row was the last row, select the new last row
                    If selectedIndex >= dgitems.Rows.Count Then
                        selectedIndex = dgitems.Rows.Count - 1
                        UpdateChange()
                    End If
                    dgitems.Rows(selectedIndex).Selected = True
                End If
            Else
                MsgBox("Please select a row to remove.")
            End If
        Catch ex As Exception
            MsgBox("Something went wrong. Please try again. (" & ex.Message & ")")
        End Try
    End Sub

    Private Sub UpdateRowNumbers()
        For i As Integer = 0 To dgitems.Rows.Count - 1
            dgitems.Rows(i).Cells(0).Value = i + 1
        Next
    End Sub

    Private Sub txt_exchange_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_exchange.KeyDown
        If e.KeyCode = Keys.Enter Then
            SaveExchangeValue()
            e.SuppressKeyPress = True ' This prevents the "ding" sound when Enter is pressed
        End If
    End Sub

    Private Sub SaveExchangeValue()
        Dim exchangeValue As String = txt_exchange.Text
        My.Settings.exchangeRate = exchangeValue
        My.Settings.Save()
        MessageBox.Show("Value saved successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        txt_exchange.Text = My.Settings.exchangeRate
        UpdateGrandTotalAndTextBoxes()
    End Sub

    Private Sub btnDiscount_Click(sender As Object, e As EventArgs) Handles btnDiscount.Click
        Try
            Dim numk As New IsNumericKeypad
            If numk.ShowDialog() = DialogResult.OK Then
                Dim discountValue As Decimal = numk.EnteredValue

                ' Display the discount value in txtTotalAllDiscount
                txtTotalAllDiscount.Text = discountValue.ToString("0.00")

                ' Update other totals and text boxes
                UpdateGrandTotalAndTextBoxes()
                UpdateChange()
            End If
        Catch ex As Exception
            MsgBox("Error handling discount button click: " & ex.Message)
        End Try
    End Sub

    Private Sub txt_recievedUSD_Click(sender As Object, e As EventArgs) Handles txt_recievedUSD.Click
        Try
            Dim numk As New IsNumericKeypad
            If numk.ShowDialog() = DialogResult.OK Then
                Dim enteredValue As Decimal = numk.EnteredValue
                txt_recievedUSD.Text = enteredValue.ToString("0.00")
                UpdateChange()
            End If
        Catch ex As Exception
            MsgBox("Error opening numeric keypad: " & ex.Message)
        End Try
    End Sub

    Private Sub txt_recievedKHR_Click(sender As Object, e As EventArgs) Handles txt_recievedKHR.Click
        Try
            Dim numk As New IsNumericKeypad
            If numk.ShowDialog() = DialogResult.OK Then
                Dim enteredValue As Decimal = numk.EnteredValue
                txt_recievedKHR.Text = enteredValue.ToString("0.00")
                UpdateChange()
            End If
        Catch ex As Exception
            MsgBox("Error opening numeric keypad: " & ex.Message)
        End Try
    End Sub

    Private Sub UpdateChange()
        Try
            ' Input validation
            If String.IsNullOrWhiteSpace(txt_totalUS.Text) OrElse
               String.IsNullOrWhiteSpace(txt_recievedUSD.Text) OrElse
               String.IsNullOrWhiteSpace(txt_recievedKHR.Text) Then
                Return
            End If

            ' Convert inputs to Decimal
            Dim grandTotal As Decimal
            If Not Decimal.TryParse(txt_totalUS.Text, grandTotal) Then
                MsgBox("Invalid value for total US.")
                Return
            End If

            Dim receivedUSD As Decimal
            If Not Decimal.TryParse(txt_recievedUSD.Text, receivedUSD) Then
                MsgBox("Invalid value for received USD.")
                Return
            End If

            Dim receivedKHR As Decimal
            If Not Decimal.TryParse(txt_recievedKHR.Text, receivedKHR) Then
                MsgBox("Invalid value for received KHR.")
                Return
            End If

            Dim exchangeRate As Decimal = Convert.ToDecimal(My.Settings.exchangeRate)

            ' Convert received KHR to USD
            Dim receivedKHRInUSD As Decimal = receivedKHR / exchangeRate

            ' Calculate total received in USD
            Dim totalReceivedUSD As Decimal = receivedUSD + receivedKHRInUSD

            ' Calculate change in USD
            Dim changeUSD As Decimal = totalReceivedUSD - grandTotal
            Dim dollars As Decimal = Math.Truncate(changeUSD) ' Extract dollars
            Dim cents As Decimal = (changeUSD - dollars) * My.Settings.exchangeRate ' Extract cents
            cents = Math.Round(cents / 100, MidpointRounding.ToEven) * 100
            txt_changeUSD.Text = dollars.ToString("0") & "$ + " & cents.ToString("0") & "៛"

            ' Calculate change in KHR
            Dim changeKHR As Decimal = (totalReceivedUSD - grandTotal) * exchangeRate
            changeKHR = Math.Round(changeKHR / 100, MidpointRounding.ToEven) * 100
            txt_changeKHR.Text = changeKHR.ToString("0")

        Catch ex As Exception
            MsgBox("Error updating change: " & ex.Message)
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Clearance()
    End Sub

    Private Sub Clearance()
        dgitems.Rows.Clear()
        txt_totalUS.Clear()
        txt_totalKHR.Clear()
        txtTotalAllDiscount.Text = "0.00"
        txt_recievedUSD.Clear()
        txt_recievedKHR.Clear()
        txt_changeUSD.Clear()
        txt_changeKHR.Clear()
        txt_barcode.Clear()
        '/panelProductBox.Controls.Clear()
    End Sub

    Public Sub productBarCodeToSale(Optional ByVal productBarCode As String = "")
        Try
            ' Clear previous data from objDataTable
            objDataTable.Clear()

            Dim sqltext As String = "SELECT product_pk, pro_name, pro_qty, pro_price, dis_percentage FROM tbl_product WHERE barcode = '" & MySqlHelper.EscapeString(productBarCode) & "';"
            fillDataTable(sqltext)

            If objDataTable.Rows.Count > 1 Then
                ProductViewerTable()
                UpdateChange()
            ElseIf objDataTable.Rows.Count = 1 Then
                filldataWithProCode(objDataTable.Rows(0)("product_pk"))
                txt_barcode.SelectAll()
            Else
                ' Handle case when no rows are returned
                Console.WriteLine("No products found for barcode: " & productBarCode)
            End If
        Catch ex As Exception
            Console.WriteLine("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        Try
            InsertInvoice()
        Catch ex As Exception
            MsgBox("Invalid value for received USD.")
        End Try
    End Sub

    Private Sub InsertInvoice()
        Try
            ' Validate required input fields before insertion
            If String.IsNullOrWhiteSpace(txt_totalUS.Text) OrElse
       String.IsNullOrWhiteSpace(txt_recievedUSD.Text) OrElse
       String.IsNullOrWhiteSpace(txt_recievedKHR.Text) Then
                MsgBox("Please ensure all required fields are filled in.")
                Return
            End If

            ' Get the next invoice number
            Dim invoiceNum As String = GetNextInvoiceNumber()

            ' Convert input values to Decimal
            Dim totalUS As Decimal = Convert.ToDecimal(txt_totalUS.Text)
            Dim totalDiscount As Decimal = Convert.ToDecimal(txtTotalAllDiscount.Text)
            Dim receivedUSD As Decimal = Convert.ToDecimal(txt_recievedUSD.Text)
            Dim receivedKHR As Decimal = Convert.ToDecimal(txt_recievedKHR.Text)
            Dim exchangeRate As Decimal = Convert.ToDecimal(My.Settings.exchangeRate)

            ' Calculate total received in USD and KHR
            Dim totalReceivedUSD As Decimal = receivedUSD + (receivedKHR / exchangeRate)
            Dim totalReceivedKHR As Decimal = receivedKHR + (receivedUSD * exchangeRate)

            ' Calculate change in USD and KHR
            Dim changeUSD As Decimal = totalReceivedUSD - totalUS
            Dim changeKHR As Decimal = totalReceivedKHR - (totalUS * exchangeRate)

            ' Truncate changeUSD to two decimal places
            changeUSD = Math.Truncate(changeUSD * 100) / 100

            ' Round changeKHR to nearest hundred
            changeKHR = Math.Round(changeKHR / 100, MidpointRounding.ToEven) * 100

            ' Prepare the SQL insert command for main invoice
            Dim queryInvoice As String = "INSERT INTO tbl_invoice (invoice_num, total_qty, total_price, total_dis, amountUSD, amountKHR, getamountUSD, getamountKHR, changeUSD, changeKHR, exRate, invoice_date) " &
                              "VALUES (@invoice_num, @total_qty, @total_price, @total_dis, @amountUSD, @amountKHR, @getamountUSD, @getamountKHR, @changeUSD, @changeKHR, @exRate, @invoice_date)"

            ' Use the public connection from your module
            Using cmdInvoice As New MySqlCommand(queryInvoice, cn)
                ' Add parameters to the SQL command for main invoice
                cmdInvoice.Parameters.AddWithValue("@invoice_num", invoiceNum)
                cmdInvoice.Parameters.AddWithValue("@total_qty", CalculateTotalQuantity()) ' Implement this function according to your logic
                cmdInvoice.Parameters.AddWithValue("@total_price", totalUS)
                cmdInvoice.Parameters.AddWithValue("@total_dis", totalDiscount)
                cmdInvoice.Parameters.AddWithValue("@amountUSD", totalUS)
                cmdInvoice.Parameters.AddWithValue("@amountKHR", totalUS * exchangeRate)
                cmdInvoice.Parameters.AddWithValue("@getamountUSD", receivedUSD)
                cmdInvoice.Parameters.AddWithValue("@getamountKHR", receivedKHR)
                ' Choose which change to insert based on comparison
                If receivedUSD > receivedKHR Then
                    ' Save only changeUSD
                    cmdInvoice.Parameters.AddWithValue("@changeUSD", changeUSD)
                    cmdInvoice.Parameters.AddWithValue("@changeKHR", 0) ' Insert 0 for changeKHR
                ElseIf receivedUSD < receivedKHR Then
                    ' Save only changeKHR
                    cmdInvoice.Parameters.AddWithValue("@changeUSD", 0) ' Insert 0 for changeUSD
                    cmdInvoice.Parameters.AddWithValue("@changeKHR", changeKHR)
                Else
                    ' Handle case where receivedUSD equals receivedKHR (if necessary)
                    cmdInvoice.Parameters.AddWithValue("@changeUSD", changeUSD)
                    cmdInvoice.Parameters.AddWithValue("@changeKHR", changeKHR)
                End If

                cmdInvoice.Parameters.AddWithValue("@exRate", exchangeRate)
                cmdInvoice.Parameters.AddWithValue("@invoice_date", DateTime.Now)

                ' Open the connection and execute the insert command for main invoice
                cn.Open()
                cmdInvoice.ExecuteNonQuery()

                ' Retrieve the auto-generated invoice_fk (assuming it's auto-incremented)
                Dim invoiceFk As Integer = CInt(cmdInvoice.LastInsertedId)
                cn.Close()

                ' Prepare the SQL insert command for invoice detail
                Dim queryDetail As String = "INSERT INTO tbl_invoice_detail (invoice_fk, pro_name, cate_name, pro_qty, pro_price, pro_dis, exRate, total) " &
                                        "VALUES (@invoice_fk, @pro_name, @cate_name, @pro_qty, @pro_price, @pro_dis, @exRate, @total)"

                Using cmdDetail As New MySqlCommand(queryDetail, cn)
                    ' Iterate through DataGridView rows and insert details
                    For Each row As DataGridViewRow In dgitems.Rows
                        cmdDetail.Parameters.Clear()
                        cmdDetail.Parameters.AddWithValue("@invoice_fk", invoiceFk)
                        cmdDetail.Parameters.AddWithValue("@pro_name", row.Cells("Items").Value.ToString())

                        ' Fetch cate_name based on product information
                        Dim cateName As String = GetCategoryNameByProductName(row.Cells("Items").Value.ToString())
                        cmdDetail.Parameters.AddWithValue("@cate_name", cateName)

                        Dim qty As Integer = Convert.ToInt32(row.Cells("Qty").Value)
                        Dim price As Decimal = Convert.ToDecimal(row.Cells("Price").Value)
                        Dim discount As Decimal = Convert.ToDecimal(row.Cells("Disc").Value)

                        cmdDetail.Parameters.AddWithValue("@pro_qty", qty)
                        cmdDetail.Parameters.AddWithValue("@pro_price", price)
                        cmdDetail.Parameters.AddWithValue("@pro_dis", discount)
                        cmdDetail.Parameters.AddWithValue("@exRate", exchangeRate)

                        ' Calculate grand total using the provided function
                        Dim total As Decimal = CalculateGrandTotal(qty, price, discount)
                        cmdDetail.Parameters.AddWithValue("@total", total)

                        ' Open the connection and execute the insert command for detail
                        cn.Open()
                        cmdDetail.ExecuteNonQuery()
                        cn.Close()

                        DeductStock(row.Cells("Items").Value.ToString(), qty)
                    Next
                End Using
            End Using

            MsgBox("Invoice and details inserted successfully.")
            Clearance()
        Catch ex As Exception
            MsgBox("Error inserting invoice: " & ex.Message)
        End Try
    End Sub

    Private Sub DeductStock(productName As String, quantitySold As Integer)
        Try
            Dim queryStock As String = "UPDATE tbl_product SET pro_qty = pro_qty - @quantity WHERE pro_name = @productName"
            Using cmdStock As New MySqlCommand(queryStock, cn)
                cmdStock.Parameters.AddWithValue("@quantity", quantitySold)
                cmdStock.Parameters.AddWithValue("@productName", productName)

                ' Open the connection and execute the stock update command
                cn.Open()
                cmdStock.ExecuteNonQuery()
                cn.Close()
            End Using
        Catch ex As Exception
            MsgBox("Error updating stock: " & ex.Message)
        End Try
    End Sub

    Private Function GetCategoryNameByProductName(productName As String) As String
        Dim cateName As String = String.Empty
        Dim query As String = "SELECT c.cate_name FROM tbl_product p JOIN tbl_category c ON p.cate_fk = c.cate_pk WHERE p.pro_name = @pro_name"
        Using cmd As New MySqlCommand(query, cn)
            cmd.Parameters.AddWithValue("@pro_name", productName)
            cn.Open()
            Using reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    cateName = reader("cate_name").ToString()
                End If
            End Using
            cn.Close()
        End Using
        Return cateName
    End Function

    Private Function CalculateTotalQuantity() As Integer
        ' Calculate the total quantity of items in the invoice (this is a placeholder implementation)
        Dim totalQty As Integer = 0
        For Each row As DataGridViewRow In dgitems.Rows
            totalQty += Convert.ToInt32(row.Cells("Qty").Value)
        Next
        Return totalQty
    End Function

    Private Function GetNextInvoiceNumber() As String
        Dim nextInvoiceNumber As String = "000001" ' Default value if there are no invoices in the database

        Try
            ' SQL query to get the last invoice number
            Dim query As String = "SELECT MAX(invoice_num) FROM tbl_invoice"

            Using cmd As New MySqlCommand(query, cn)
                cn.Open()
                Dim result As Object = cmd.ExecuteScalar()
                cn.Close()

                If result IsNot DBNull.Value AndAlso result IsNot Nothing Then
                    Dim lastInvoiceNumber As Integer
                    If Integer.TryParse(result.ToString(), lastInvoiceNumber) Then
                        nextInvoiceNumber = (lastInvoiceNumber + 1).ToString("D6") ' Increment and format to 6 digits with leading zeros
                    End If
                End If
            End Using
        Catch ex As Exception
            MsgBox("Error fetching next invoice number: " & ex.Message)
        End Try

        Return nextInvoiceNumber
    End Function

End Class