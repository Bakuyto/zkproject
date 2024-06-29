Imports MySql.Data.MySqlClient
Imports System.IO
Public Class NewCategory
    Private Sub NewCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setConnection()
        Table_load()
    End Sub

    Private Sub btn_add_Click_1(sender As Object, e As EventArgs) Handles btn_add.Click
        If btn_add.Text = "ADD" Then
            ADDCategory()
        Else
            EDIT()
        End If
    End Sub

    Public Sub ADDCategory()
        Try

            If String.IsNullOrWhiteSpace(txt_catname.Text) Then
                MsgBox("Category name cannot be empty.")
                Exit Sub
            End If

            Dim checkQuery As String = "SELECT COUNT(*) FROM tbl_category WHERE cate_name = @CategoryName or cate_order ='" & txt_order.Text & "' "
            Using checkCmd As New MySqlCommand(checkQuery, cn)
                checkCmd.Parameters.AddWithValue("@CategoryName", txt_catname.Text)

                If cn.State <> ConnectionState.Open Then
                    cn.Open()
                End If

                Dim count As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())
                If count > 0 Then
                    MsgBox("Category name or Category order are already exists.")
                    Exit Sub
                End If
            End Using

            sqltext = "INSERT INTO tbl_category (cate_order,cate_name, cate_image,cate_status) VALUES ('" & txt_order.Text & "','" & txt_catname.Text & "',@proPhoto,'" & If(chkIsavailable.Checked = True, 1, 0) & "')"
            Dim cmd As New MySqlCommand
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If
            With cmd
                .CommandText = sqltext
                .Connection = cn
                .Parameters.AddWithValue("@proPhoto", ImageToBinary(New Bitmap(imageBox.Image, 200, 150)))
            End With
            cmd.ExecuteNonQuery()
            MsgBox("Insert Data Successfully!!!")

        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message)
        End Try
        clear()
        Table_load()
    End Sub


    Private Sub EDIT()
        Try
            If selectedCategoryTag Is Nothing Then
                MsgBox("No category selected.")
                Return
            End If
            sqltext = "UPDATE tbl_category SET cate_order = '" & txt_order.Text & "', cate_name = '" & txt_catname.Text & "', cate_image = @proPhoto , cate_status = @cateStatus  WHERE cate_pk = '" & selectedCategoryTag & "'"

            Dim cmd As New MySqlCommand
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If
            Dim cateStatus As Integer = If(chkIsavailable.Checked, 1, 0)
            cmd.Parameters.AddWithValue("@cateStatus", cateStatus)
            With cmd
                .CommandText = sqltext
                .Connection = cn
                .Parameters.AddWithValue("@proPhoto", ImageToBinary(New Bitmap(imageBox.Image, 200, 150)))
            End With
            cmd.ExecuteNonQuery()
            MsgBox("Update Data Successfully!!!")
            clear()
            Table_load()
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub DELETE()
        Try

            If selectedCategoryTag Is Nothing OrElse String.IsNullOrEmpty(selectedCategoryTag.ToString()) Then
                MsgBox("No category selected for deletion.")
                Exit Sub
            End If

            Dim query As String = "DELETE FROM tbl_category WHERE cate_pk = '" & selectedCategoryTag & "'"
            runCommandText(query)
            MsgBox("Deleted Data Successfully!!!")
            Table_load()
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub Table_load()
        sqltext = "CALL Load_Category();"
        fillDataTableX(sqltext)
        dgCategory.Rows.Clear()
        Try
            If objDataTableX.Rows.Count > 0 Then
                For i = 0 To objDataTableX.Rows.Count - 1
                    dgCategory.Rows.Add()
                    dgCategory(0, i).Value = i + 1
                    dgCategory(0, i).Tag = objDataTableX(i)(0)
                    dgCategory(2, i).Value = objDataTableX(i)("cate_name")
                    dgCategory(1, i).Value = objDataTableX(i)("cate_order")
                    dgCategory(3, i).Value = objDataTableX(i)("cate_image")
                    If objDataTableX(i)("cate_status") = 1 Then
                        dgCategory(4, i).Value = CheckState.Checked
                    Else
                        dgCategory(4, i).Value = CheckState.Unchecked
                    End If
                Next
            Else
                MsgBox("There is no item found. Start add new today.")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub clear()
        txt_catname.Clear()
        imageBox.Image = My.Resources.upload_image
        chkIsavailable.Checked = True
        btn_add.Text = "ADD"
    End Sub

    Private Sub btn_clear_Click_1(sender As Object, e As EventArgs) Handles btn_clear.Click
        clear()
    End Sub

    Private selectedCategoryTag As Object
    Private Sub dgCategory_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgCategory.CellContentClick
        Try
            ' Check if the clicked column is "btn_edit"
            If e.RowIndex <> -1 AndAlso dgCategory.Columns(e.ColumnIndex).Name = "btn_edit" Then

                dgCategory.Rows(e.RowIndex).Selected = True
                dgCategory.CurrentCell = dgCategory.Rows(e.RowIndex).Cells(0)
                Dim dgv As DataGridViewRow = dgCategory.SelectedRows(0)
                selectedCategoryTag = dgv.Cells(0).Tag
                txt_order.Text = dgv.Cells(1).Value.ToString()
                txt_catname.Text = dgv.Cells(2).Value.ToString()
                Dim imageData As Byte() = TryCast(dgv.Cells(3).Value, Byte())
                If imageData IsNot Nothing AndAlso imageData.Length > 0 Then
                    Using ms As New IO.MemoryStream(imageData)
                        imageBox.Image = Image.FromStream(ms)
                    End Using
                Else
                    imageBox.Image = Nothing
                End If
                chkIsavailable.Checked = dgv.Cells(4).Value

                btn_add.Text = "UPDATE"

            ElseIf e.RowIndex <> -1 AndAlso dgCategory.Columns(e.ColumnIndex).Name = "btn_delete" Then
                If MessageBox.Show("Are you sure you want to delete this category?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                    Dim dgv As DataGridViewRow = dgCategory.Rows(e.RowIndex)
                    selectedCategoryTag = dgv.Cells(0).Tag
                    DELETE()
                End If
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
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

End Class