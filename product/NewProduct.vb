Imports MySql.Data.MySqlClient
Imports System.IO

Public Class NewProduct
    Private Sub NewProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setConnection()
        Load_Category()
        Load_Table()
    End Sub

    Private Sub Load_Category()
        Try
            sqltext = "CALL Load_Category()"
            RunSqlcombobox(sqltext, com_category, "cate_name", "cate_pk")
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub btn_browse_Click(sender As Object, e As EventArgs) Handles btn_browse.Click
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

            Dim selectedCategoryId As Integer = CInt(com_category.SelectedValue)
            sqltext = "CALL Insert_product( @cateFk ,'" & txt_proname.Text & "' , '" & txt_barcode.Text & "', @proPhoto , '" & txt_qty.Text & "', '" & txt_price.Text & "' , '" & txt_stock.Text & "','" & If(ischkavailable.Checked = True, 1, 0) & "', '" & txt_dis.Text & "')"
            Dim cmd As New MySqlCommand
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If
            With cmd
                .CommandText = sqltext
                .Connection = cn
                .Parameters.AddWithValue("@cateFk", selectedCategoryId)
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
            sqltext = "UPDATE tbl_product SET cate_fk = '" & com_category.SelectedValue & "' , pro_name = '" & txt_proname.Text & "', pro_img = @proPhoto , barcode = '" & txt_barcode.Text & "' , pro_qty = '" & txt_qty.Text & "' , pro_price = '" & txt_price.Text & "', pro_stock = '" & txt_stock.Text & "' , pro_status = @proStatus , dis_percentage = '" & txt_dis.Text & "' WHERE product_pk = '" & selectedproductTag & "' "

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
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        NewCategory.ShowDialog()
        Load_Category()
    End Sub

    Private Sub Load_Table()
        sqltext = "CALL Load_Product();"
        fillDataTableX(sqltext)
        dgproduct.Rows.Clear()
        Try
            If objDataTableX.Rows.Count > 0 Then
                For i = 0 To objDataTableX.Rows.Count - 1
                    dgproduct.Rows.Add()
                    dgproduct(0, i).Value = i + 1
                    dgproduct(0, i).Tag = objDataTableX(i)(0)
                    dgproduct(1, i).Value = objDataTableX(i)("pro_img")
                    dgproduct(2, i).Value = objDataTableX(i)("pro_name")
                    dgproduct(3, i).Value = objDataTableX(i)("cate_name")
                    dgproduct(4, i).Value = objDataTableX(i)("barcode")
                    dgproduct(5, i).Value = objDataTableX(i)("pro_qty")
                    dgproduct(6, i).Value = objDataTableX(i)("pro_price")
                    dgproduct(7, i).Value = objDataTableX(i)("pro_stock")
                    dgproduct(8, i).Value = objDataTableX(i)("dis_percentage")
                    If objDataTableX(i)("pro_status") = 1 Then
                        dgproduct(9, i).Value = CheckState.Checked
                    Else
                        dgproduct(9, i).Value = CheckState.Unchecked
                    End If
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

    Private selectedproductTag As Object
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
                txt_stock.Text = dgv.Cells(7).Value.ToString()
                txt_dis.Text = dgv.Cells(8).Value.ToString()
                ischkavailable.Checked = dgv.Cells(9).Value

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
            Dim pname As String = txt_search.Text.Trim()
            Dim pcode As String = txt_search.Text.Trim()

            ' Check if pname and pcode are empty, then set them to "%" to retrieve all records
            If pname = "" Then pname = "%"
            If pcode = "" Then pcode = "%"

            sqltext = "CALL st_product('" & pname & "', '" & pcode & "')"

            ' Execute the SQL query and fill the data table
            fillDataTableX(sqltext)

            ' Clear existing rows in the DataGridView
            dgproduct.Rows.Clear()

            ' Populate the DataGridView with the fetched data
            If objDataTableX.Rows.Count > 0 Then
                For i = 0 To objDataTableX.Rows.Count - 1
                    dgproduct.Rows.Add()
                    dgproduct(0, i).Value = i + 1
                    dgproduct(0, i).Tag = objDataTableX(i)(0)
                    dgproduct(1, i).Value = objDataTableX(i)("pro_img")
                    dgproduct(2, i).Value = objDataTableX(i)("pro_name")
                    dgproduct(3, i).Value = objDataTableX(i)("cate_name")
                    dgproduct(4, i).Value = objDataTableX(i)("barcode")
                    dgproduct(5, i).Value = objDataTableX(i)("pro_qty")
                    dgproduct(6, i).Value = objDataTableX(i)("pro_price")
                    dgproduct(7, i).Value = objDataTableX(i)("pro_stock")
                    dgproduct(8, i).Value = objDataTableX(i)("dis_percentage")
                    If objDataTableX(i)("pro_status") = 1 Then
                        dgproduct(9, i).Value = CheckState.Checked
                    Else
                        dgproduct(9, i).Value = CheckState.Unchecked
                    End If
                Next
            Else
                MsgBox("There is no item found. Start add new today.")
            End If

            ' Adjust DataGridView based on settings
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

End Class