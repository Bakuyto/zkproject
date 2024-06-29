Public Class IsNumericKeypad

    Public drag As Boolean
    Public mouseX As Integer
    Public mouseY As Integer
    Public Property EnteredValue As Integer

    Private vData As String = ""
    Private Sub panelHeaderBar_MouseDown(sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles panelBox.MouseDown
        drag = True
        mouseX = System.Windows.Forms.Cursor.Position.X - Me.Left
        mouseY = System.Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub panelHeaderBar_MouseMove(sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles panelBox.MouseMove
        If drag Then
            Me.Top = System.Windows.Forms.Cursor.Position.Y - mouseY
            Me.Left = System.Windows.Forms.Cursor.Position.X - mouseX
        End If
    End Sub

    Private Sub panelHeaderBar_MouseUp(sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles panelBox.MouseUp
        drag = False
    End Sub
    Public Property Data As String
        Get
            Return vData
        End Get
        Set(ByVal value As String)
            vData = value
            If value = "" Then
                buDisplay.Text = "0"
            ElseIf value = "-" Then
                buDisplay.Text = "0"
            Else
                buDisplay.Text = value
            End If
        End Set
    End Property

    Public Property NumericValue As Integer

    Public Sub NumericMouseUp(ByVal sender As Object, ByVal e As EventArgs) Handles Button0.MouseUp, Button1.MouseUp, Button2.MouseUp, Button3.MouseUp, Button4.MouseUp, Button5.MouseUp, Button6.MouseUp, Button7.MouseUp, Button8.MouseUp, Button9.MouseUp
        If sender Is Button0 And vData = "0" Then
            Exit Sub
        End If
        Data += sender.text
    End Sub

    Private Sub buClear_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles buClear.MouseUp
        Data = ""
    End Sub

    Private Sub buBksp_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles buBksp.MouseUp
        If Data.Length = 0 Then
            Data = ""
        Else
            Data = Data.Substring(0, Data.Length - 1)
        End If
    End Sub

    Private Sub buDecimal_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If Data.Contains(".") = False Then
            Data += "."
        End If
    End Sub

    Private Sub buNegative_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If Data.Contains("-") = False Then
            Data = "-" + Data
        Else
            Data = Data.Substring(1, Data.Length - 1)
        End If
    End Sub

    Private Sub buAccept_Click(sender As Object, e As EventArgs) Handles buAccept.Click
        If Integer.TryParse(buDisplay.Text, EnteredValue) Then
            DialogResult = DialogResult.OK
            Me.Close()
        Else
            MessageBox.Show("Please enter a valid number.")
        End If
    End Sub

    Private Sub IsNumericKeypad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        getInput.Focus()
    End Sub

    Private Sub buCancel_Click(sender As Object, e As EventArgs) Handles buCancel.Click
        'buDisplay.Text = 0
        DialogResult = Windows.Forms.DialogResult.No
        Me.Close()
    End Sub

    Private Sub getInput_ValueChanged(sender As Object, e As EventArgs) Handles getInput.ValueChanged
        buDisplay.Text = getInput.Value
    End Sub

    Private Sub buDisplay_Click(sender As Object, e As EventArgs) Handles buDisplay.Click
        getInput.Focus()
    End Sub

    Private Sub buDisplay_TextChanged(sender As Object, e As EventArgs) Handles buDisplay.TextChanged
        AcceptButton = buAccept
    End Sub

    Private Sub IsNumericKeypad_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Try
            If e.KeyCode = Keys.Escape Then
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class
