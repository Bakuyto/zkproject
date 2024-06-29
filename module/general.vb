Imports System.IO
Imports System.Net.NetworkInformation
Imports DevComponents.DotNetBar
Imports MySql.Data.MySqlClient
Imports DevComponents.DotNetBar.Controls

Public Module general
    Public cn As MySqlConnection
    Public DBName, DBPwd, UserID, UserName, UserPwd, HostAddress, DBUser, DBPort, DetpName, DeptId As String
    Public Const REG_APPNAME As String = "ZK Management"
    Public Const REG_SECTION_DBSETTING As String = "DBSettings"
    Public Const REG_KEY_DBName As String = "DBName"
    Public Const REG_KEY_DBUSER As String = "DBUser"
    Public Const REG_KEY_DBPWD As String = "DBPwd"
    Public Const REG_KEY_PORT As String = "DBPort"
    Public Const REG_KEY_HOST As String = "DBHost"
    Public Const REG_KEY_UID As String = "UID"
    Public Const REG_KEY_UPWD As String = "UserPwd"
    Public isConnect As Boolean = True

    Public sqlCmd As New MySqlCommand
    Public objDataAdapter As MySqlDataAdapter
    Public objX As MySqlDataAdapter
    Public objDataTable As DataTable
    Public objDataTableX As DataTable
    Public objDataTableXX As DataTable
    Public objdata As DataTable
    Public objdataX As DataTable
    Public objdataXX As DataTable
    Public GetStaffID As Integer
    Public GetUserName As String
    Public GetUserPass As String
    Public UserGrade As Integer
    Public sqltext As String


#Region "Connect To Database"
    Public Function GetDBName() As String
        GetDBName = GetSetting(REG_APPNAME, REG_SECTION_DBSETTING, REG_KEY_DBName)
    End Function
    Public Function GetDBPassword() As String
        GetDBPassword = GetSetting(REG_APPNAME, REG_SECTION_DBSETTING, REG_KEY_DBPWD)
    End Function
    Public Function GetDBUser() As String
        GetDBUser = GetSetting(REG_APPNAME, REG_SECTION_DBSETTING, REG_KEY_DBUSER)
    End Function
    Public Function GetDBHost() As String
        GetDBHost = GetSetting(REG_APPNAME, REG_SECTION_DBSETTING, REG_KEY_HOST)
    End Function
    Public Function GetDBPort() As String
        GetDBPort = GetSetting(REG_APPNAME, REG_SECTION_DBSETTING, REG_KEY_PORT)
    End Function
    Public Function GetUserID() As String
        GetUserID = GetSetting(REG_APPNAME, REG_SECTION_DBSETTING, REG_KEY_UID)
    End Function
    Public Function GetUserPassword() As String
        GetUserPassword = GetSetting(REG_APPNAME, REG_SECTION_DBSETTING, REG_KEY_UPWD)
    End Function
    'set the DB setting and logged in user settings
    Public Sub SetDBName(ByVal sNewName As String)
        SaveSetting(REG_APPNAME, REG_SECTION_DBSETTING, REG_KEY_DBName, sNewName)
    End Sub
    Public Sub SetDBUser(ByVal sNewUser As String)
        SaveSetting(REG_APPNAME, REG_SECTION_DBSETTING, REG_KEY_DBUSER, sNewUser)
    End Sub
    Public Sub SetDBPassword(ByVal sNewPwd As String)
        SaveSetting(REG_APPNAME, REG_SECTION_DBSETTING, REG_KEY_DBPWD, sNewPwd)
    End Sub
    Public Sub SetDBHost(ByVal sNewHost As String)
        SaveSetting(REG_APPNAME, REG_SECTION_DBSETTING, REG_KEY_HOST, sNewHost)
    End Sub
    Public Sub SetDBPort(ByVal sNewPwd As String)
        SaveSetting(REG_APPNAME, REG_SECTION_DBSETTING, REG_KEY_PORT, sNewPwd)
    End Sub
    Public Sub SetUserID(ByVal sNewUID As String)
        SaveSetting(REG_APPNAME, REG_SECTION_DBSETTING, REG_KEY_UID, sNewUID)
    End Sub
    Public Sub SetUserPassword(ByVal sNewPwd As String)
        SaveSetting(REG_APPNAME, REG_SECTION_DBSETTING, REG_KEY_UPWD, sNewPwd)
    End Sub

    Public Sub setConnection()
        Try
            DBPwd = GetDBPassword()
            DBName = GetDBName()
            DBUser = GetDBUser()
            HostAddress = GetDBHost()
            DBPort = GetDBPort()
            UserID = GetUserID()
            UserPwd = GetUserPassword()
            cn = New MySqlConnection
            With cn
                Try
                    .ConnectionString = "DATABASE=" & DBName & ";" & "SERVER=" & HostAddress & ";user id=" & DBUser & ";" _
                        & "password=" & DBPwd & ";" & "port=" & DBPort & ";charset=utf8"
                    .Open()
                    Console.WriteLine("Con open")
                    isConnect = True
                Catch ex As Exception
                    MsgBox("Cannot connect to your Database." & vbCrLf & "Report: " & ex.Message & vbCrLf & "Please contact software vendor for help.")
                    isConnect = False
                    frmConnection.ShowDialog()
                    Exit Sub
                End Try
            End With
            If cn.State <> ConnectionState.Open Then
                MsgBox("Techincal Error: We cannot connect to database.")
            End If
        Catch ex As Exception

        End Try
    End Sub

#End Region
#Region "Fill Datatable"
    Public Sub fillDataTable(ByVal sql As String)
        Try
            sqlCmd = New MySqlCommand(sql, cn)
            objDataAdapter = New MySqlDataAdapter With {
                .SelectCommand = sqlCmd
                }
            'Initialize the DataTable object
            objDataTable = New DataTable
            'Populate the DataTable
            objDataAdapter.Fill(objDataTable)
            objDataAdapter.Dispose()
            objDataAdapter = Nothing
            sqlCmd.Dispose()
            sqlCmd = Nothing
            cn.Close()
        Catch ex As Exception
            MsgBox("System could not get your datatable." & vbCrLf & "Report: " & ex.Message)
        End Try
    End Sub
    Public Sub fillDataTableX(ByVal sql As String)
        Try
            sqlCmd = New MySqlCommand(sql, cn)
            objDataAdapter = New MySqlDataAdapter With {
                .SelectCommand = sqlCmd
                }
            'Initialize the DataTable object
            objDataTableX = New DataTable
            'Populate the DataTable
            objDataAdapter.Fill(objDataTableX)
            objDataAdapter.Dispose()
            objDataAdapter = Nothing
            sqlCmd.Dispose()
            sqlCmd = Nothing
            cn.Close()
        Catch ex As Exception
            MsgBox("System could not get your datatable." & vbCrLf & "Report: " & ex.Message)
        End Try
    End Sub
    Public Sub fillData(ByVal sql As String)
        Try
            sqlCmd = New MySqlCommand(sql, cn)
            objDataAdapter = New MySqlDataAdapter With {
                .SelectCommand = sqlCmd
                }
            'Initialize the DataTable object
            objdata = New DataTable
            'Populate the DataTable
            objDataAdapter.Fill(objdata)
            objDataAdapter.Dispose()
            objDataAdapter = Nothing
            sqlCmd.Dispose()
            sqlCmd = Nothing
            cn.Close()
        Catch ex As Exception
            MsgBox("System could not get your datatable." & vbCrLf & "Report: " & ex.Message)
        End Try
    End Sub
    Public Sub fillDataX(ByVal sql As String)
        Try
            sqlCmd = New MySqlCommand(sql, cn)
            objX = New MySqlDataAdapter With {
                .SelectCommand = sqlCmd
                }
            'Initialize the DataTable object
            objdataX = New DataTable
            'Populate the DataTable
            objX.Fill(objdataX)
            objX.Dispose()
            objX = Nothing
            sqlCmd.Dispose()
            sqlCmd = Nothing
            cn.Close()
        Catch ex As Exception
            MsgBox("System could not get your datatable." & vbCrLf & "Report: " & ex.Message)
        End Try
    End Sub
    Public Sub fillDataTableXX(ByVal sql As String)
        Try
            sqlCmd = New MySqlCommand(sql, cn)
            objDataAdapter = New MySqlDataAdapter With {
                .SelectCommand = sqlCmd
                }
            'Initialize the DataTable object
            objDataTableXX = New DataTable
            'Populate the DataTable
            objDataAdapter.Fill(objDataTableXX)
            objDataAdapter.Dispose()
            objDataAdapter = Nothing
            sqlCmd.Dispose()
            sqlCmd = Nothing
            cn.Close()
        Catch ex As Exception
            MsgBox("System could not get your datatable." & vbCrLf & "Report: " & ex.Message)
        End Try
    End Sub
    Public Sub fillDataXX(ByVal sql As String)
        Try
            sqlCmd = New MySqlCommand(sql, cn)
            objX = New MySqlDataAdapter With {
                .SelectCommand = sqlCmd
                }
            'Initialize the DataTable object
            objdataXX = New DataTable
            'Populate the DataTable
            objX.Fill(objdataXX)
            objX.Dispose()
            objX = Nothing
            sqlCmd.Dispose()
            sqlCmd = Nothing
            cn.Close()
        Catch ex As Exception
            MsgBox("System could not get your datatable." & vbCrLf & "Report: " & ex.Message)
        End Try
    End Sub
#End Region
#Region "Run MysqlCommand"
    Public Sub runCommandText(ByVal sql As String)
        If cn.State <> ConnectionState.Open Then
            cn.Open()
        End If
        sqlCmd = New MySqlCommand
        sqlCmd.Connection() = cn
        sqlCmd.CommandText = (sql)
        sqlCmd.ExecuteNonQuery()
        cn.Close()
    End Sub
    Public Function runFunctionCommandText(ByVal sql As String) As Object
        Dim result As String = ""
        If cn.State <> ConnectionState.Open Then
            cn.Open()
        End If
        sqlCmd = New MySqlCommand
        sqlCmd.Connection() = cn
        sqlCmd.CommandText = (sql)
        result = sqlCmd.ExecuteScalar()
        cn.Close()
        Return result
    End Function
    Public Function FunctionRetunImage(sql As String) As Byte()
        Dim result As Byte()
        If cn.State <> ConnectionState.Open Then
            cn.Open()
        End If
        sqlCmd = New MySqlCommand
        sqlCmd.Connection() = cn
        sqlCmd.CommandText = (sql)
        result = sqlCmd.ExecuteScalar()
        cn.Close()
        Return result
    End Function
#End Region

#Region "Convert From Image to Binary"
    'Convert From Image to Binary   //Ravy Pheng//02-10-2014
    Public Function ImageToBinary(ByRef NewImage As Image) As Byte()
        Dim ImageByteArray() As Byte = Nothing
        Dim ReadImage As New MemoryStream()
        NewImage.Save(ReadImage, Drawing.Imaging.ImageFormat.Png)
        ReDim ImageByteArray(CInt(ReadImage.Length - 1))
        ReadImage.Position = 0
        ReadImage.Read(ImageByteArray, 0, CInt(ReadImage.Length))
        Return ImageByteArray
    End Function

#End Region
#Region "Convert From Binary to Image"
    'Convert From Binary to Image   //Ravy Pheng//02-10-2014
    Public Function BinarytoImage(ByRef imageByteArray() As Byte) As Image
        Dim newImage As Image = Nothing
        Dim Ms As MemoryStream
        If imageByteArray.GetUpperBound(0) > 0 Then
            Ms = New MemoryStream(imageByteArray)
            newImage = Image.FromStream(Ms)
            Ms = Nothing
        End If
        Return newImage
    End Function

#End Region

#Region "Display Combobox"
    Public Sub RunSqlcombobox(ByVal sql As String, ByVal cbo As ComboBox, ByVal Display As String, ByVal ValueMem As String)
        Try
            Dim adapter = New MySqlDataAdapter(sql, cn)
            Dim dt As New DataTable
            adapter.Fill(dt)
            If dt.Rows.Count > 0 Then
                cbo.DataSource = dt
                cbo.DisplayMember = Display
                cbo.ValueMember = ValueMem
                cbo.SelectedIndex = -1
            Else
                'If not found any relavent ID, It display no SelectedIndex
                cbo.DataSource = dt
                cbo.DisplayMember = ""
                cbo.ValueMember = ""
            End If
            adapter.Dispose()
            cn.Close()
        Catch ex As Exception
            MsgBox("Problem occurred while trying to collect your data. Please contact your software vendor for more help. Report: " & ex.Message)
        End Try
    End Sub
#End Region
#Region "Update  Database"
    Public Sub CommandTextUpdate(ByVal tbl As String, ByVal fields As String, ByVal cond As String)
        Dim sqlUpdate As String = "Update " & tbl & " Set " & fields & " Where " & cond & ""
        RunSql(sqlUpdate)
    End Sub
    Public Sub RunSql(ByVal sql As String)
        Try
            Dim dt As New DataTable
            Dim adapter = New MySqlDataAdapter(sql, cn)
            adapter.Fill(dt)
            dt.Dispose()
            adapter.Dispose()
            cn.Close()
        Catch ex As Exception
            MsgBox("Problem occurred while trying to collect your data. Please contact your software vendor for more help. Report: " & ex.Message)
        End Try
    End Sub
#End Region
#Region "Save To Database"
    Public Sub Save(ByVal table As String, ByVal fieldname As String, ByVal Value As String)
        Dim sqlSave As String = "insert into " & table & " (" & fieldname & ")" & " Values(" & Value & ")"
        runCommandText(sqlSave)
    End Sub
#End Region


End Module
