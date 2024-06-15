Public Class frmConnection
    Private Sub frmConnection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            '/Check connection  
            setConnection()
            If isConnect = False Then
                txtHost.Text = GetDBHost()
                txtDatabase.Text = GetDBName()
                txtPort.Text = GetDBPort()
                txtUsername.Text = GetDBUser()
                txtPassword.Text = GetDBPassword()
            Else

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub SaveConnection()
        Try
            Call SetDBHost(txtHost.Text)
            Call SetDBPort(txtPort.Text)
            Call SetDBName(txtDatabase.Text)
            Call SetDBUser(txtUsername.Text)
            Call SetDBPassword(txtPassword.Text)
            MsgBox("Your connection setting have been saved. If you have any problems with connection, please contact your software vendor for more help.")
            Me.Close()
            Application.Restart()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SaveConnection()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtHost.Text = ""
        txtDatabase.Text = ""
        txtPort.Text = ""
        txtUsername.Text = ""
        txtPassword.Text = ""
    End Sub

    Private Sub txtHost_KeyDown(sender As Object, e As KeyEventArgs) Handles txtHost.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                txtPort.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtPort_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPort.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                txtDatabase.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtDatabase_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDatabase.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                txtUsername.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtUsername_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsername.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                txtPassword.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                SaveConnection()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class