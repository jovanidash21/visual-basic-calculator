<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CalculatorMainTextBox = New System.Windows.Forms.TextBox()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.ButtonDivide = New System.Windows.Forms.Button()
        Me.ButtonEqual = New System.Windows.Forms.Button()
        Me.ButtonMultiply = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.ButtonMinus = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.ButtonPlus = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button0 = New System.Windows.Forms.Button()
        Me.ButtonPoint = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CalculatorMainTextBox
        '
        Me.CalculatorMainTextBox.BackColor = System.Drawing.Color.Silver
        Me.CalculatorMainTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CalculatorMainTextBox.Enabled = False
        Me.CalculatorMainTextBox.Font = New System.Drawing.Font("Impact", 65.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalculatorMainTextBox.Location = New System.Drawing.Point(5, 6)
        Me.CalculatorMainTextBox.Name = "CalculatorMainTextBox"
        Me.CalculatorMainTextBox.Size = New System.Drawing.Size(343, 107)
        Me.CalculatorMainTextBox.TabIndex = 0
        Me.CalculatorMainTextBox.Text = "123"
        Me.CalculatorMainTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ButtonClear
        '
        Me.ButtonClear.BackColor = System.Drawing.Color.DimGray
        Me.ButtonClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.ButtonClear.FlatAppearance.BorderSize = 2
        Me.ButtonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClear.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClear.ForeColor = System.Drawing.Color.White
        Me.ButtonClear.Location = New System.Drawing.Point(5, 117)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(85, 57)
        Me.ButtonClear.TabIndex = 1
        Me.ButtonClear.Text = "C"
        Me.ButtonClear.UseVisualStyleBackColor = False
        '
        'ButtonDivide
        '
        Me.ButtonDivide.BackColor = System.Drawing.Color.DimGray
        Me.ButtonDivide.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.ButtonDivide.FlatAppearance.BorderSize = 2
        Me.ButtonDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDivide.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDivide.ForeColor = System.Drawing.Color.White
        Me.ButtonDivide.Location = New System.Drawing.Point(91, 117)
        Me.ButtonDivide.Name = "ButtonDivide"
        Me.ButtonDivide.Size = New System.Drawing.Size(85, 57)
        Me.ButtonDivide.TabIndex = 2
        Me.ButtonDivide.Text = "/"
        Me.ButtonDivide.UseVisualStyleBackColor = False
        '
        'ButtonEqual
        '
        Me.ButtonEqual.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.ButtonEqual.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.ButtonEqual.FlatAppearance.BorderSize = 2
        Me.ButtonEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEqual.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEqual.ForeColor = System.Drawing.Color.White
        Me.ButtonEqual.Location = New System.Drawing.Point(263, 292)
        Me.ButtonEqual.Name = "ButtonEqual"
        Me.ButtonEqual.Size = New System.Drawing.Size(85, 116)
        Me.ButtonEqual.TabIndex = 17
        Me.ButtonEqual.Text = "="
        Me.ButtonEqual.UseVisualStyleBackColor = False
        '
        'ButtonMultiply
        '
        Me.ButtonMultiply.BackColor = System.Drawing.Color.DimGray
        Me.ButtonMultiply.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.ButtonMultiply.FlatAppearance.BorderSize = 2
        Me.ButtonMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonMultiply.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonMultiply.ForeColor = System.Drawing.Color.White
        Me.ButtonMultiply.Location = New System.Drawing.Point(177, 117)
        Me.ButtonMultiply.Name = "ButtonMultiply"
        Me.ButtonMultiply.Size = New System.Drawing.Size(85, 57)
        Me.ButtonMultiply.TabIndex = 18
        Me.ButtonMultiply.Text = "x"
        Me.ButtonMultiply.UseVisualStyleBackColor = False
        '
        'ButtonDelete
        '
        Me.ButtonDelete.BackColor = System.Drawing.Color.DimGray
        Me.ButtonDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.ButtonDelete.FlatAppearance.BorderSize = 2
        Me.ButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDelete.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDelete.ForeColor = System.Drawing.Color.White
        Me.ButtonDelete.Location = New System.Drawing.Point(263, 117)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(85, 57)
        Me.ButtonDelete.TabIndex = 19
        Me.ButtonDelete.Text = "<"
        Me.ButtonDelete.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.DimGray
        Me.Button7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Button7.FlatAppearance.BorderSize = 2
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.White
        Me.Button7.Location = New System.Drawing.Point(5, 175)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(85, 57)
        Me.Button7.TabIndex = 20
        Me.Button7.Text = "7"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.DimGray
        Me.Button8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Button8.FlatAppearance.BorderSize = 2
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.White
        Me.Button8.Location = New System.Drawing.Point(91, 175)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(85, 57)
        Me.Button8.TabIndex = 21
        Me.Button8.Text = "8"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.DimGray
        Me.Button9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Button9.FlatAppearance.BorderSize = 2
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.White
        Me.Button9.Location = New System.Drawing.Point(177, 175)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(85, 57)
        Me.Button9.TabIndex = 22
        Me.Button9.Text = "9"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'ButtonMinus
        '
        Me.ButtonMinus.BackColor = System.Drawing.Color.DimGray
        Me.ButtonMinus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.ButtonMinus.FlatAppearance.BorderSize = 2
        Me.ButtonMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonMinus.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonMinus.ForeColor = System.Drawing.Color.White
        Me.ButtonMinus.Location = New System.Drawing.Point(263, 175)
        Me.ButtonMinus.Name = "ButtonMinus"
        Me.ButtonMinus.Size = New System.Drawing.Size(85, 57)
        Me.ButtonMinus.TabIndex = 23
        Me.ButtonMinus.Text = "-"
        Me.ButtonMinus.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.DimGray
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Button4.FlatAppearance.BorderSize = 2
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(5, 233)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(85, 57)
        Me.Button4.TabIndex = 24
        Me.Button4.Text = "4"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.DimGray
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Button5.FlatAppearance.BorderSize = 2
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(91, 233)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(85, 57)
        Me.Button5.TabIndex = 25
        Me.Button5.Text = "5"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.DimGray
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Button6.FlatAppearance.BorderSize = 2
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(177, 233)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(85, 57)
        Me.Button6.TabIndex = 26
        Me.Button6.Text = "6"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'ButtonPlus
        '
        Me.ButtonPlus.BackColor = System.Drawing.Color.DimGray
        Me.ButtonPlus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.ButtonPlus.FlatAppearance.BorderSize = 2
        Me.ButtonPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonPlus.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPlus.ForeColor = System.Drawing.Color.White
        Me.ButtonPlus.Location = New System.Drawing.Point(263, 233)
        Me.ButtonPlus.Name = "ButtonPlus"
        Me.ButtonPlus.Size = New System.Drawing.Size(85, 57)
        Me.ButtonPlus.TabIndex = 27
        Me.ButtonPlus.Text = "+"
        Me.ButtonPlus.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DimGray
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 2
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(5, 292)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 57)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "1"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DimGray
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 2
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(91, 292)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(85, 57)
        Me.Button2.TabIndex = 29
        Me.Button2.Text = "2"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DimGray
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Button3.FlatAppearance.BorderSize = 2
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(177, 292)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(85, 57)
        Me.Button3.TabIndex = 30
        Me.Button3.Text = "3"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button0
        '
        Me.Button0.BackColor = System.Drawing.Color.DimGray
        Me.Button0.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Button0.FlatAppearance.BorderSize = 2
        Me.Button0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button0.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button0.ForeColor = System.Drawing.Color.White
        Me.Button0.Location = New System.Drawing.Point(5, 351)
        Me.Button0.Name = "Button0"
        Me.Button0.Size = New System.Drawing.Size(171, 57)
        Me.Button0.TabIndex = 31
        Me.Button0.Text = "0"
        Me.Button0.UseVisualStyleBackColor = False
        '
        'ButtonPoint
        '
        Me.ButtonPoint.BackColor = System.Drawing.Color.DimGray
        Me.ButtonPoint.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.ButtonPoint.FlatAppearance.BorderSize = 2
        Me.ButtonPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonPoint.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPoint.ForeColor = System.Drawing.Color.White
        Me.ButtonPoint.Location = New System.Drawing.Point(177, 351)
        Me.ButtonPoint.Name = "ButtonPoint"
        Me.ButtonPoint.Size = New System.Drawing.Size(85, 57)
        Me.ButtonPoint.TabIndex = 33
        Me.ButtonPoint.Text = "."
        Me.ButtonPoint.UseVisualStyleBackColor = False
        '
        'Calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(353, 416)
        Me.Controls.Add(Me.ButtonPoint)
        Me.Controls.Add(Me.Button0)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ButtonPlus)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.ButtonMinus)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.ButtonMultiply)
        Me.Controls.Add(Me.ButtonEqual)
        Me.Controls.Add(Me.ButtonDivide)
        Me.Controls.Add(Me.ButtonClear)
        Me.Controls.Add(Me.CalculatorMainTextBox)
        Me.Name = "Calculator"
        Me.Text = "Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CalculatorMainTextBox As TextBox
    Friend WithEvents ButtonClear As Button
    Friend WithEvents ButtonDivide As Button
    Friend WithEvents ButtonEqual As Button
    Friend WithEvents ButtonMultiply As Button
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents ButtonMinus As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents ButtonPlus As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button0 As Button
    Friend WithEvents ButtonPoint As Button
End Class
