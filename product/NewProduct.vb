Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.IO.Ports

Public Class NewProduct

    Dim ttcontrols As Double = 0
    Dim clickcount As Integer = 1
    Dim limitrow As Integer = 20
    Dim startinx As Integer = 0
    Private selectedproductTag As Object


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

    Private Sub SerialPort_DataReceived(ByVal sender As Object, ByVal e As SerialDataReceivedEventArgs)
        Try
            Dim indata As String = SerialPort1.ReadExisting().Trim()

            ' Use Invoke to update the UI on the main thread
            Me.Invoke(Sub()
                          If IsGroupBoxControlsEnabled() Then
                              txt_barcode.Text = indata
                          Else
                              txt_search.Text = indata
                          End If
                      End Sub)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function IsGroupBoxControlsEnabled() As Boolean
        ' Assuming all controls in the GroupBox have the same enabled state
        Return GroupBox1.Controls.Cast(Of Control)().Any(Function(ctrl) ctrl.Enabled)
    End Function


    Private Sub NewProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setConnection()
        Load_Category()
        Load_Table()
        handlerComport()
        DisableGroupBoxControls()
    End Sub

    Private Sub DisableGroupBoxControls()
        For Each ctrl As Control In GroupBox1.Controls
            ctrl.Enabled = False

            btn_add.Enabled = False
        Next
        txt_search.Enabled = True
    End Sub

    Private Sub Load_Category()
        Try
            sqltext = "CALL Load_Category()"
            RunSqlcombobox(sqltext, com_category, "cate_name", "cate_pk")
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub btn_browse_Click(sender As Object, e As EventArgs) 
        Dim myStream As Stream = Nothing
        Dim openFile As New OpenFileDialog()

        openFile.InitialDirectory = ""
        openFile.Filter = "Image Files|*.gif;*.jpg;*.png;*.bmp"
        openFile.FilterIndex = 2
        openFile.RestoreDirectory = True

        If openFile.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                myStream = openFile.OpenFile()
                If (myStream IsNot Nothing) Then
                    'Insert code to read the stream here.
                    imageBox.Image = Image.FromFile(openFile.FileName)
                    imageBox.SizeMode = PictureBoxSizeMode.Zoom
                End If
            Catch Ex As Exception
                MsgBox("Cannot load image from specific directory. Try again!" & vbCrLf & "Unsupported:  (" & openFile.FileName & ")")
            Finally
                'Check this again, since we need to make sure we didn't throw an exception on open.
                If (myStream IsNot Nothing) Then
                    myStream.Close()
                End If
            End Try
        End If
    End Sub

    Private Sub addproduct()
        Try

            ' Validate that all necessary fields are filled
            If String.IsNullOrWhiteSpace(txt_proname.Text) OrElse String.IsNullOrWhiteSpace(txt_barcode.Text) OrElse String.IsNullOrWhiteSpace(txt_qty.Text) OrElse String.IsNullOrWhiteSpace(txt_price.Text) OrElse String.IsNullOrWhiteSpace(txt_stock.Text) Then
                MsgBox("Please fill out all required fields.")
                Exit Sub
            End If

            ' Convert and validate numeric fields
            Dim selectedproductId As Integer
            If Not Integer.TryParse(com_category.SelectedValue.ToString(), selectedproductId) Then
                MsgBox("Invalid category selected.")
                Exit Sub
            End If

            Dim quantity As Integer
            If Not Integer.TryParse(txt_qty.Text, quantity) Then
                MsgBox("Invalid quantity.")
                Exit Sub
            End If

            Dim price As Decimal
            If Not Decimal.TryParse(txt_price.Text, price) Then
                MsgBox("Invalid price.")
                Exit Sub
            End If

            Dim stock As Integer
            If Not Integer.TryParse(txt_stock.Text, stock) Then
                MsgBox("Invalid stock.")
                Exit Sub
            End If

            sqltext = "CALL Insert_product( @cateFk ,'" & txt_proname.Text & "' , '" & txt_barcode.Text & "', @proPhoto , '" & txt_qty.Text & "', '" & txt_price.Text & "' , '" & txt_stock.Text & "','" & If(ischkavailable.Checked = True, 1, 0) & "', '" & txt_dis.Text & "')"
            Dim cmd As New MySqlCommand
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If
            With cmd
                .CommandText = sqltext
                .Connection = cn
                .Parameters.AddWithValue("@cateFk", selectedproductId)
                .Parameters.AddWithValue("@proPhoto", ImageToBinary(New Bitmap(imageBox.Image, 200, 150)))
            End With
            cmd.ExecuteNonQuery()
            MsgBox("Insert Data Successfully!!!")
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If btn_add.Text = "ADD" Then
            addproduct()
            Load_Table()
        Else
            EDIT()
        End If
    End Sub

    Private Sub EDIT()
        Try
            sqltext = "UPDATE tbl_product SET cate_fk = '" & com_category.SelectedValue & "' , pro_name = '" & txt_proname.Text & "', pro_img = @proPhoto , barcode = '" & txt_barcode.Text & "' , pro_qty = '" & txt_qty.Text & "' , pro_price = '" & txt_price.Text & "', pro_status = @proStatus , dis_percentage = '" & txt_dis.Text & "' WHERE product_pk = '" & selectedproductTag & "' "

            Dim cmd As New MySqlCommand
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If
            Dim cateStatus As Integer = If(ischkavailable.Checked, 1, 0)
            cmd.Parameters.AddWithValue("@proStatus", cateStatus)
            With cmd
                .CommandText = sqltext
                .Connection = cn
                .Parameters.AddWithValue("@proPhoto", ImageToBinary(New Bitmap(imageBox.Image, 200, 150)))
            End With
            cmd.ExecuteNonQuery()
            MsgBox("Update Data Successfully!!!")
            clear()
            Load_Table()
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub DELETE()
        Try

            If selectedproductTag Is Nothing OrElse String.IsNullOrEmpty(selectedproductTag.ToString()) Then
                MsgBox("No product selected for deletion.")
                Exit Sub
            End If

            Dim query As String = "DELETE FROM tbl_product WHERE product_pk = '" & selectedproductTag & "'"
            runCommandText(query)
            MsgBox("Deleted Data Successfully!!!")
            Load_Table()
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub clear()
        txt_proname.Clear()
        com_category.SelectedIndex = -1
        txt_barcode.Clear()
        txt_qty.Clear()
        txt_price.Clear()
        txt_stock.Clear()
        txt_dis.Clear()
        imageBox.Image = My.Resources.upload_image
        ischkavailable.Checked = True
        btn_add.Text = "ADD"
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        clear()
        DisableGroupBoxControls()
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) 
        NewCategory.ShowDialog()
        Load_Category()
    End Sub

    Private Sub Load_Table()
        Try
            Dim str As String = "SELECT COUNT(*) FROM tbl_product"
            ttcontrols = runFunctionCommandText(str)

            If ttcontrols < limitrow Then
                lbTotalRows.Text = ttcontrols & " of " & ttcontrols
            Else
                lbTotalRows.Text = startinx + 1 & " - " & Math.Min(startinx + limitrow, ttcontrols) & " of " & ttcontrols
            End If

            sqltext = "CALL Load_Product(" & startinx & "," & limitrow & ");"
            fillDataTableX(sqltext)
            dgproduct.Rows.Clear()

            If objDataTableX.Rows.Count > 0 Then
                For i = 0 To objDataTableX.Rows.Count - 1
                    dgproduct.Rows.Add()
                    dgproduct(0, i).Value = startinx + i + 1
                    dgproduct(0, i).Tag = objDataTableX(i)(0)
                    dgproduct(1, i).Value = objDataTableX(i)("pro_img")
                    dgproduct(2, i).Value = objDataTableX(i)("pro_name")
                    dgproduct(3, i).Value = objDataTableX(i)("cate_name")
                    dgproduct(4, i).Value = objDataTableX(i)("barcode")
                    dgproduct(5, i).Value = objDataTableX(i)("pro_qty")
                    dgproduct(6, i).Value = objDataTableX(i)("pro_price")
                    dgproduct(7, i).Value = objDataTableX(i)("dis_percentage")
                    dgproduct(8, i).Value = If(objDataTableX(i)("pro_status") = 1, CheckState.Checked, CheckState.Unchecked)
                Next
            Else
                MsgBox("There is no item found. Start add new today.")
            End If

            If My.Settings.showpicture Then
                showpicture.Checked = True
                adjustrowhight(dgproduct, 60)
                dgproduct.Columns(1).Visible = True
            Else
                showpicture.Checked = False
                adjustrowhight(dgproduct, 30)
                dgproduct.Columns(1).Visible = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgproduct_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgproduct.CellContentClick
        Try
            ' Check if the clicked column is "btn_edit"
            If e.RowIndex <> -1 AndAlso dgproduct.Columns(e.ColumnIndex).Name = "btn_edit" Then

                dgproduct.Rows(e.RowIndex).Selected = True
                dgproduct.CurrentCell = dgproduct.Rows(e.RowIndex).Cells(0)
                Dim dgv As DataGridViewRow = dgproduct.SelectedRows(0)
                selectedproductTag = dgv.Cells(0).Tag
                Dim imageData As Byte() = TryCast(dgv.Cells(1).Value, Byte())
                If imageData IsNot Nothing AndAlso imageData.Length > 0 Then
                    Using ms As New IO.MemoryStream(imageData)
                        imageBox.Image = Image.FromStream(ms)
                    End Using
                Else
                    imageBox.Image = Nothing
                End If
                txt_proname.Text = dgv.Cells(2).Value.ToString()
                com_category.Text = dgv.Cells(3).Value.ToString()
                txt_barcode.Text = dgv.Cells(4).Value.ToString()
                txt_qty.Text = dgv.Cells(5).Value.ToString()
                txt_price.Text = dgv.Cells(6).Value.ToString()
                txt_dis.Text = dgv.Cells(7).Value.ToString()
                ischkavailable.Checked = dgv.Cells(8).Value

                btn_add.Text = "UPDATE"

            ElseIf e.RowIndex <> -1 AndAlso dgproduct.Columns(e.ColumnIndex).Name = "btn_delete" Then
                If MessageBox.Show("Are you sure you want to delete this category?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                    Dim dgv As DataGridViewRow = dgproduct.Rows(e.RowIndex)
                    selectedproductTag = dgv.Cells(0).Tag
                    DELETE()
                End If
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub
    Private Sub adjustrowhight(dgv As DataGridView, ByVal hi As Double)
        Try
            For i = 0 To dgv.Rows.Count - 1
                dgv.Rows(i).Height = hi
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub showpicture_CheckedChanged(sender As Object, e As EventArgs) Handles showpicture.CheckedChanged
        Try
            If showpicture.Checked Then
                adjustrowhight(dgproduct, 60)
                dgproduct.Columns(1).Visible = True
                My.Settings.showpicture = True
            Else
                adjustrowhight(dgproduct, 30)
                dgproduct.Columns(1).Visible = False
                My.Settings.showpicture = False
            End If
            My.Settings.Save()
            My.Settings.Reload()
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        search()
    End Sub

    Private Sub search()
        Try
            Dim searchText As String = If(txt_search?.Text?.Trim(), String.Empty)

            If searchText = "" Then
                Load_Table()
                Return
            End If

            Dim sqltext As String = "CALL st_product(@pname, @pcode)"

            Using cmd As New MySqlCommand(sqltext, cn)
                cmd.Parameters.Clear()

                cmd.Parameters.AddWithValue("@pname", "%" & searchText & "%")
                cmd.Parameters.AddWithValue("@pcode", "%" & searchText & "%")

                Using adapter As New MySqlDataAdapter(cmd)
                    Dim objDataTableX As New DataTable()
                    adapter.Fill(objDataTableX)

                    dgproduct.Rows.Clear()

                    If objDataTableX.Rows.Count > 0 Then
                        For i As Integer = 0 To objDataTableX.Rows.Count - 1
                            dgproduct.Rows.Add()
                            dgproduct(0, i).Value = i + 1
                            dgproduct(0, i).Value = startinx + i + 1
                            dgproduct(1, i).Value = objDataTableX(i)("pro_img")
                            dgproduct(2, i).Value = objDataTableX(i)("pro_name")
                            dgproduct(3, i).Value = objDataTableX(i)("cate_name")
                            dgproduct(4, i).Value = objDataTableX(i)("barcode")
                            dgproduct(5, i).Value = objDataTableX(i)("pro_qty")
                            dgproduct(6, i).Value = objDataTableX(i)("pro_price")
                            dgproduct(7, i).Value = objDataTableX(i)("dis_percentage")
                            dgproduct(8, i).Value = If(objDataTableX(i)("pro_status") = 1, CheckState.Checked, CheckState.Unchecked)
                        Next
                    Else
                        MsgBox("There is no item found. Start add new today.")
                    End If
                End Using
            End Using

            If My.Settings.showpicture Then
                showpicture.Checked = True
                adjustrowhight(dgproduct, 60)
                dgproduct.Columns(1).Visible = True
            Else
                showpicture.Checked = False
                adjustrowhight(dgproduct, 30)
                dgproduct.Columns(1).Visible = False
            End If
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message)
        End Try
    End Sub



    Private Sub btn_next_Click(sender As Object, e As EventArgs) Handles btn_next.Click
        Try
            clickcount += 1
            If limitrow * clickcount - limitrow >= ttcontrols Then
                clickcount -= 1
            End If
            startinx = (clickcount - 1) * limitrow
            Load_Table()
            If startinx + limitrow > ttcontrols Then
                lbTotalRows.Text = ttcontrols & " of " & ttcontrols
            Else
                lbTotalRows.Text = startinx + 1 & " - " & Math.Min(startinx + limitrow, ttcontrols) & " of " & ttcontrols
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_prev_Click(sender As Object, e As EventArgs) Handles btn_prev.Click
        Try
            clickcount -= 1
            If clickcount < 1 Then
                clickcount = 1
            End If
            startinx = (clickcount - 1) * limitrow
            Load_Table()
            If clickcount = 1 Then
                If ttcontrols < limitrow Then
                    lbTotalRows.Text = ttcontrols & " of " & ttcontrols
                Else
                    lbTotalRows.Text = limitrow & " of " & ttcontrols
                End If
            Else
                lbTotalRows.Text = startinx + 1 & " - " & Math.Min(startinx + limitrow, ttcontrols) & " of " & ttcontrols
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles ButtonX2.Click
        EnableGroupBoxControls()
    End Sub

    Private Sub EnableGroupBoxControls()
        For Each ctrl As Control In GroupBox1.Controls
            ctrl.Enabled = True
            btn_add.Enabled = True
        Next
        txt_search.Enabled = False
    End Sub
End Class