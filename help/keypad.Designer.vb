<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class IsNumericKeypad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IsNumericKeypad))
        Me.panelBox = New System.Windows.Forms.Panel()
        Me.buDisplay = New System.Windows.Forms.Button()
        Me.getInput = New DevComponents.Editors.DoubleInput()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.buAccept = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.buCancel = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.buClear = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.buBksp = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button0 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.panelBox.SuspendLayout()
        CType(Me.getInput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelBox
        '
        Me.panelBox.BackColor = System.Drawing.Color.Transparent
        Me.panelBox.Controls.Add(Me.buDisplay)
        Me.panelBox.Controls.Add(Me.getInput)
        Me.panelBox.Controls.Add(Me.Button1)
        Me.panelBox.Controls.Add(Me.Button2)
        Me.panelBox.Controls.Add(Me.buAccept)
        Me.panelBox.Controls.Add(Me.Button3)
        Me.panelBox.Controls.Add(Me.buCancel)
        Me.panelBox.Controls.Add(Me.Button4)
        Me.panelBox.Controls.Add(Me.Button5)
        Me.panelBox.Controls.Add(Me.buClear)
        Me.panelBox.Controls.Add(Me.Button6)
        Me.panelBox.Controls.Add(Me.buBksp)
        Me.panelBox.Controls.Add(Me.Button7)
        Me.panelBox.Controls.Add(Me.Button0)
        Me.panelBox.Controls.Add(Me.Button8)
        Me.panelBox.Controls.Add(Me.Button9)
        Me.panelBox.Location = New System.Drawing.Point(7, 6)
        Me.panelBox.Name = "panelBox"
        Me.panelBox.Size = New System.Drawing.Size(400, 327)
        Me.panelBox.TabIndex = 18
        '
        'buDisplay
        '
        Me.buDisplay.BackColor = System.Drawing.Color.White
        Me.buDisplay.Enabled = False
        Me.buDisplay.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.buDisplay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.buDisplay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.buDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buDisplay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.buDisplay.Location = New System.Drawing.Point(6, 6)
        Me.buDisplay.Name = "buDisplay"
        Me.buDisplay.Size = New System.Drawing.Size(388, 76)
        Me.buDisplay.TabIndex = 19
        Me.buDisplay.Text = "0.00"
        Me.buDisplay.UseVisualStyleBackColor = False
        '
        'getInput
        '
        '
        '
        '
        Me.getInput.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.getInput.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.getInput.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.getInput.Increment = 1.0R
        Me.getInput.Location = New System.Drawing.Point(288, 10)
        Me.getInput.MinValue = 0R
        Me.getInput.Name = "getInput"
        Me.getInput.ShowUpDown = True
        Me.getInput.Size = New System.Drawing.Size(103, 20)
        Me.getInput.TabIndex = 18
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button1.Location = New System.Drawing.Point(6, 207)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 54)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button2.Location = New System.Drawing.Point(87, 207)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 54)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'buAccept
        '
        Me.buAccept.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.buAccept.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.buAccept.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buAccept.ForeColor = System.Drawing.Color.SteelBlue
        Me.buAccept.Location = New System.Drawing.Point(250, 207)
        Me.buAccept.Name = "buAccept"
        Me.buAccept.Size = New System.Drawing.Size(144, 114)
        Me.buAccept.TabIndex = 14
        Me.buAccept.Text = "ENTER"
        Me.buAccept.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button3.Location = New System.Drawing.Point(168, 207)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 54)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'buCancel
        '
        Me.buCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.buCancel.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.buCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buCancel.ForeColor = System.Drawing.Color.SteelBlue
        Me.buCancel.Image = CType(resources.GetObject("buCancel.Image"), System.Drawing.Image)
        Me.buCancel.Location = New System.Drawing.Point(250, 147)
        Me.buCancel.Name = "buCancel"
        Me.buCancel.Size = New System.Drawing.Size(144, 54)
        Me.buCancel.TabIndex = 13
        Me.buCancel.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button4.Location = New System.Drawing.Point(6, 147)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 54)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button5.Location = New System.Drawing.Point(87, 147)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 54)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'buClear
        '
        Me.buClear.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.buClear.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.buClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buClear.ForeColor = System.Drawing.Color.SteelBlue
        Me.buClear.Location = New System.Drawing.Point(250, 87)
        Me.buClear.Name = "buClear"
        Me.buClear.Size = New System.Drawing.Size(65, 54)
        Me.buClear.TabIndex = 11
        Me.buClear.Text = "C"
        Me.buClear.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button6.Location = New System.Drawing.Point(168, 147)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 54)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "6"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'buBksp
        '
        Me.buBksp.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.buBksp.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.buBksp.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buBksp.ForeColor = System.Drawing.Color.SteelBlue
        Me.buBksp.Location = New System.Drawing.Point(321, 87)
        Me.buBksp.Name = "buBksp"
        Me.buBksp.Size = New System.Drawing.Size(73, 54)
        Me.buBksp.TabIndex = 10
        Me.buBksp.Text = "«"
        Me.buBksp.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button7.Location = New System.Drawing.Point(6, 87)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 54)
        Me.Button7.TabIndex = 6
        Me.Button7.Text = "7"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button0
        '
        Me.Button0.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button0.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button0.Location = New System.Drawing.Point(6, 267)
        Me.Button0.Name = "Button0"
        Me.Button0.Size = New System.Drawing.Size(237, 54)
        Me.Button0.TabIndex = 9
        Me.Button0.Text = "0"
        Me.Button0.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button8.Location = New System.Drawing.Point(87, 87)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 54)
        Me.Button8.TabIndex = 7
        Me.Button8.Text = "8"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button9.Location = New System.Drawing.Point(168, 87)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(75, 54)
        Me.Button9.TabIndex = 8
        Me.Button9.Text = "9"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'IsNumericKeypad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 339)
        Me.Controls.Add(Me.panelBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "IsNumericKeypad"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.panelBox.ResumeLayout(False)
        CType(Me.getInput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelBox As Panel
    Friend WithEvents buDisplay As Button
    Friend WithEvents getInput As DevComponents.Editors.DoubleInput
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents buAccept As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents buCancel As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents buClear As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents buBksp As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button0 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
End Class
