<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1

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
        Me.Ngay_Label = New System.Windows.Forms.Label()
        Me.Time_Value_Label = New System.Windows.Forms.Label()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Giatri2_TextBox = New System.Windows.Forms.TextBox()
        Me.Giatri3_TextBox = New System.Windows.Forms.TextBox()
        Me.Giatri1_TextBox = New System.Windows.Forms.TextBox()
        Me.Giatri1_Label = New System.Windows.Forms.Label()
        Me.Giatri2_Label = New System.Windows.Forms.Label()
        Me.Giatri3_Label = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DBI_RadioButton = New System.Windows.Forms.RadioButton()
        Me.Exp_RadioButton = New System.Windows.Forms.RadioButton()
        Me.Mod_RadioButton = New System.Windows.Forms.RadioButton()
        Me.Division_RadioButton = New System.Windows.Forms.RadioButton()
        Me.Multiplication_RadioButton = New System.Windows.Forms.RadioButton()
        Me.Subtraction_RadioButton = New System.Windows.Forms.RadioButton()
        Me.Addition_RadioButton = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.S_Tron_RadioButton = New System.Windows.Forms.RadioButton()
        Me.S_TamGiac_RadioButton = New System.Windows.Forms.RadioButton()
        Me.S_Vuong_RadioButton = New System.Windows.Forms.RadioButton()
        Me.S_ChuNhat_RadioButton = New System.Windows.Forms.RadioButton()
        Me.THT_Button = New System.Windows.Forms.Button()
        Me.T_Button = New System.Windows.Forms.Button()
        Me.KQ_TextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Ngay_Label
        '
        Me.Ngay_Label.AutoSize = True
        Me.Ngay_Label.ForeColor = System.Drawing.Color.Coral
        Me.Ngay_Label.Location = New System.Drawing.Point(14, 16)
        Me.Ngay_Label.Name = "Ngay_Label"
        Me.Ngay_Label.Size = New System.Drawing.Size(50, 20)
        Me.Ngay_Label.TabIndex = 0
        Me.Ngay_Label.Text = "Ngày:"
        '
        'Time_Value_Label
        '
        Me.Time_Value_Label.AutoSize = True
        Me.Time_Value_Label.ForeColor = System.Drawing.Color.Coral
        Me.Time_Value_Label.Location = New System.Drawing.Point(70, 16)
        Me.Time_Value_Label.Name = "Time_Value_Label"
        Me.Time_Value_Label.Size = New System.Drawing.Size(156, 20)
        Me.Time_Value_Label.TabIndex = 2
        Me.Time_Value_Label.Text = "09/04/2022    15:35:33"
        '
        'Timer1
        '
        '
        'Giatri2_TextBox
        '
        Me.Giatri2_TextBox.Location = New System.Drawing.Point(382, 119)
        Me.Giatri2_TextBox.Name = "Giatri2_TextBox"
        Me.Giatri2_TextBox.Size = New System.Drawing.Size(129, 27)
        Me.Giatri2_TextBox.TabIndex = 3
        Me.Giatri2_TextBox.Text = "0"
        '
        'Giatri3_TextBox
        '
        Me.Giatri3_TextBox.Location = New System.Drawing.Point(644, 119)
        Me.Giatri3_TextBox.Name = "Giatri3_TextBox"
        Me.Giatri3_TextBox.Size = New System.Drawing.Size(129, 27)
        Me.Giatri3_TextBox.TabIndex = 4
        Me.Giatri3_TextBox.Text = "0"
        '
        'Giatri1_TextBox
        '
        Me.Giatri1_TextBox.Location = New System.Drawing.Point(126, 119)
        Me.Giatri1_TextBox.Name = "Giatri1_TextBox"
        Me.Giatri1_TextBox.Size = New System.Drawing.Size(129, 27)
        Me.Giatri1_TextBox.TabIndex = 5
        Me.Giatri1_TextBox.Text = "0"
        '
        'Giatri1_Label
        '
        Me.Giatri1_Label.AutoSize = True
        Me.Giatri1_Label.Font = New System.Drawing.Font("Segoe UI", 11.78182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Giatri1_Label.ForeColor = System.Drawing.Color.Crimson
        Me.Giatri1_Label.Location = New System.Drawing.Point(126, 80)
        Me.Giatri1_Label.Name = "Giatri1_Label"
        Me.Giatri1_Label.Size = New System.Drawing.Size(82, 25)
        Me.Giatri1_Label.TabIndex = 6
        Me.Giatri1_Label.Text = "Giá trị 1"
        '
        'Giatri2_Label
        '
        Me.Giatri2_Label.AutoSize = True
        Me.Giatri2_Label.Font = New System.Drawing.Font("Segoe UI", 11.78182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Giatri2_Label.ForeColor = System.Drawing.Color.Crimson
        Me.Giatri2_Label.Location = New System.Drawing.Point(382, 80)
        Me.Giatri2_Label.Name = "Giatri2_Label"
        Me.Giatri2_Label.Size = New System.Drawing.Size(82, 25)
        Me.Giatri2_Label.TabIndex = 7
        Me.Giatri2_Label.Text = "Giá trị 2"
        '
        'Giatri3_Label
        '
        Me.Giatri3_Label.AutoSize = True
        Me.Giatri3_Label.Font = New System.Drawing.Font("Segoe UI", 11.78182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Giatri3_Label.ForeColor = System.Drawing.Color.Crimson
        Me.Giatri3_Label.Location = New System.Drawing.Point(644, 80)
        Me.Giatri3_Label.Name = "Giatri3_Label"
        Me.Giatri3_Label.Size = New System.Drawing.Size(82, 25)
        Me.Giatri3_Label.TabIndex = 8
        Me.Giatri3_Label.Text = "Giá trị 3"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DBI_RadioButton)
        Me.GroupBox1.Controls.Add(Me.Exp_RadioButton)
        Me.GroupBox1.Controls.Add(Me.Mod_RadioButton)
        Me.GroupBox1.Controls.Add(Me.Division_RadioButton)
        Me.GroupBox1.Controls.Add(Me.Multiplication_RadioButton)
        Me.GroupBox1.Controls.Add(Me.Subtraction_RadioButton)
        Me.GroupBox1.Controls.Add(Me.Addition_RadioButton)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 183)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(420, 196)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Toán Tử"
        '
        'DBI_RadioButton
        '
        Me.DBI_RadioButton.AutoSize = True
        Me.DBI_RadioButton.Font = New System.Drawing.Font("Segoe UI Semibold", 9.818182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DBI_RadioButton.ForeColor = System.Drawing.Color.Goldenrod
        Me.DBI_RadioButton.Location = New System.Drawing.Point(208, 87)
        Me.DBI_RadioButton.Name = "DBI_RadioButton"
        Me.DBI_RadioButton.Size = New System.Drawing.Size(174, 24)
        Me.DBI_RadioButton.TabIndex = 6
        Me.DBI_RadioButton.TabStop = True
        Me.DBI_RadioButton.Text = "Phép chia lấy nguyên"
        Me.DBI_RadioButton.UseVisualStyleBackColor = True
        '
        'Exp_RadioButton
        '
        Me.Exp_RadioButton.AutoSize = True
        Me.Exp_RadioButton.Font = New System.Drawing.Font("Segoe UI Semibold", 9.818182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Exp_RadioButton.ForeColor = System.Drawing.Color.Goldenrod
        Me.Exp_RadioButton.Location = New System.Drawing.Point(208, 57)
        Me.Exp_RadioButton.Name = "Exp_RadioButton"
        Me.Exp_RadioButton.Size = New System.Drawing.Size(122, 24)
        Me.Exp_RadioButton.TabIndex = 5
        Me.Exp_RadioButton.TabStop = True
        Me.Exp_RadioButton.Text = "Phép lũy thừa"
        Me.Exp_RadioButton.UseVisualStyleBackColor = True
        '
        'Mod_RadioButton
        '
        Me.Mod_RadioButton.AutoSize = True
        Me.Mod_RadioButton.Font = New System.Drawing.Font("Segoe UI Semibold", 9.818182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Mod_RadioButton.ForeColor = System.Drawing.Color.Goldenrod
        Me.Mod_RadioButton.Location = New System.Drawing.Point(208, 26)
        Me.Mod_RadioButton.Name = "Mod_RadioButton"
        Me.Mod_RadioButton.Size = New System.Drawing.Size(182, 24)
        Me.Mod_RadioButton.TabIndex = 4
        Me.Mod_RadioButton.TabStop = True
        Me.Mod_RadioButton.Text = "Phép chia lấy dư(Mod)"
        Me.Mod_RadioButton.UseVisualStyleBackColor = True
        '
        'Division_RadioButton
        '
        Me.Division_RadioButton.AutoSize = True
        Me.Division_RadioButton.Font = New System.Drawing.Font("Segoe UI Semibold", 9.818182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Division_RadioButton.ForeColor = System.Drawing.Color.Coral
        Me.Division_RadioButton.Location = New System.Drawing.Point(25, 118)
        Me.Division_RadioButton.Name = "Division_RadioButton"
        Me.Division_RadioButton.Size = New System.Drawing.Size(112, 24)
        Me.Division_RadioButton.TabIndex = 3
        Me.Division_RadioButton.TabStop = True
        Me.Division_RadioButton.Text = "Phép Chia(/)"
        Me.Division_RadioButton.UseVisualStyleBackColor = True
        '
        'Multiplication_RadioButton
        '
        Me.Multiplication_RadioButton.AutoSize = True
        Me.Multiplication_RadioButton.Font = New System.Drawing.Font("Segoe UI Semibold", 9.818182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Multiplication_RadioButton.ForeColor = System.Drawing.Color.Coral
        Me.Multiplication_RadioButton.Location = New System.Drawing.Point(25, 87)
        Me.Multiplication_RadioButton.Name = "Multiplication_RadioButton"
        Me.Multiplication_RadioButton.Size = New System.Drawing.Size(121, 24)
        Me.Multiplication_RadioButton.TabIndex = 2
        Me.Multiplication_RadioButton.TabStop = True
        Me.Multiplication_RadioButton.Text = "Phép Nhân(*)"
        Me.Multiplication_RadioButton.UseVisualStyleBackColor = True
        '
        'Subtraction_RadioButton
        '
        Me.Subtraction_RadioButton.AutoSize = True
        Me.Subtraction_RadioButton.Font = New System.Drawing.Font("Segoe UI Semibold", 9.818182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Subtraction_RadioButton.ForeColor = System.Drawing.Color.Coral
        Me.Subtraction_RadioButton.Location = New System.Drawing.Point(25, 57)
        Me.Subtraction_RadioButton.Name = "Subtraction_RadioButton"
        Me.Subtraction_RadioButton.Size = New System.Drawing.Size(104, 24)
        Me.Subtraction_RadioButton.TabIndex = 1
        Me.Subtraction_RadioButton.TabStop = True
        Me.Subtraction_RadioButton.Text = "Phép Trừ(-)"
        Me.Subtraction_RadioButton.UseVisualStyleBackColor = True
        '
        'Addition_RadioButton
        '
        Me.Addition_RadioButton.AutoSize = True
        Me.Addition_RadioButton.Font = New System.Drawing.Font("Segoe UI Semibold", 9.818182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Addition_RadioButton.ForeColor = System.Drawing.Color.Coral
        Me.Addition_RadioButton.Location = New System.Drawing.Point(25, 26)
        Me.Addition_RadioButton.Name = "Addition_RadioButton"
        Me.Addition_RadioButton.Size = New System.Drawing.Size(122, 24)
        Me.Addition_RadioButton.TabIndex = 0
        Me.Addition_RadioButton.TabStop = True
        Me.Addition_RadioButton.Text = "Phép Cộng(+)"
        Me.Addition_RadioButton.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.S_Tron_RadioButton)
        Me.GroupBox2.Controls.Add(Me.S_TamGiac_RadioButton)
        Me.GroupBox2.Controls.Add(Me.S_Vuong_RadioButton)
        Me.GroupBox2.Controls.Add(Me.S_ChuNhat_RadioButton)
        Me.GroupBox2.Location = New System.Drawing.Point(507, 183)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(381, 196)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Diện tích hình học"
        '
        'S_Tron_RadioButton
        '
        Me.S_Tron_RadioButton.AutoSize = True
        Me.S_Tron_RadioButton.ForeColor = System.Drawing.Color.Coral
        Me.S_Tron_RadioButton.Location = New System.Drawing.Point(25, 118)
        Me.S_Tron_RadioButton.Name = "S_Tron_RadioButton"
        Me.S_Tron_RadioButton.Size = New System.Drawing.Size(68, 24)
        Me.S_Tron_RadioButton.TabIndex = 3
        Me.S_Tron_RadioButton.TabStop = True
        Me.S_Tron_RadioButton.Text = "S tròn"
        Me.S_Tron_RadioButton.UseVisualStyleBackColor = True
        '
        'S_TamGiac_RadioButton
        '
        Me.S_TamGiac_RadioButton.AutoSize = True
        Me.S_TamGiac_RadioButton.ForeColor = System.Drawing.Color.Coral
        Me.S_TamGiac_RadioButton.Location = New System.Drawing.Point(25, 87)
        Me.S_TamGiac_RadioButton.Name = "S_TamGiac_RadioButton"
        Me.S_TamGiac_RadioButton.Size = New System.Drawing.Size(97, 24)
        Me.S_TamGiac_RadioButton.TabIndex = 2
        Me.S_TamGiac_RadioButton.TabStop = True
        Me.S_TamGiac_RadioButton.Text = "S tam giác"
        Me.S_TamGiac_RadioButton.UseVisualStyleBackColor = True
        '
        'S_Vuong_RadioButton
        '
        Me.S_Vuong_RadioButton.AutoSize = True
        Me.S_Vuong_RadioButton.ForeColor = System.Drawing.Color.Coral
        Me.S_Vuong_RadioButton.Location = New System.Drawing.Point(25, 57)
        Me.S_Vuong_RadioButton.Name = "S_Vuong_RadioButton"
        Me.S_Vuong_RadioButton.Size = New System.Drawing.Size(118, 24)
        Me.S_Vuong_RadioButton.TabIndex = 1
        Me.S_Vuong_RadioButton.TabStop = True
        Me.S_Vuong_RadioButton.Text = "S hình vuông"
        Me.S_Vuong_RadioButton.UseVisualStyleBackColor = True
        '
        'S_ChuNhat_RadioButton
        '
        Me.S_ChuNhat_RadioButton.AutoSize = True
        Me.S_ChuNhat_RadioButton.ForeColor = System.Drawing.Color.Coral
        Me.S_ChuNhat_RadioButton.Location = New System.Drawing.Point(25, 26)
        Me.S_ChuNhat_RadioButton.Name = "S_ChuNhat_RadioButton"
        Me.S_ChuNhat_RadioButton.Size = New System.Drawing.Size(99, 24)
        Me.S_ChuNhat_RadioButton.TabIndex = 0
        Me.S_ChuNhat_RadioButton.TabStop = True
        Me.S_ChuNhat_RadioButton.Text = "S chữ nhật"
        Me.S_ChuNhat_RadioButton.UseVisualStyleBackColor = True
        '
        'THT_Button
        '
        Me.THT_Button.ForeColor = System.Drawing.Color.Coral
        Me.THT_Button.Location = New System.Drawing.Point(141, 385)
        Me.THT_Button.Name = "THT_Button"
        Me.THT_Button.Size = New System.Drawing.Size(130, 26)
        Me.THT_Button.TabIndex = 11
        Me.THT_Button.Text = "Thực hiện tính"
        Me.THT_Button.UseVisualStyleBackColor = True
        '
        'T_Button
        '
        Me.T_Button.ForeColor = System.Drawing.Color.Coral
        Me.T_Button.Location = New System.Drawing.Point(687, 385)
        Me.T_Button.Name = "T_Button"
        Me.T_Button.Size = New System.Drawing.Size(86, 26)
        Me.T_Button.TabIndex = 12
        Me.T_Button.Text = "Tính"
        Me.T_Button.UseVisualStyleBackColor = True
        '
        'KQ_TextBox
        '
        Me.KQ_TextBox.Location = New System.Drawing.Point(304, 477)
        Me.KQ_TextBox.Name = "KQ_TextBox"
        Me.KQ_TextBox.Size = New System.Drawing.Size(279, 27)
        Me.KQ_TextBox.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Coral
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(414, 454)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 20)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Kết quả"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 540)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.KQ_TextBox)
        Me.Controls.Add(Me.T_Button)
        Me.Controls.Add(Me.THT_Button)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Giatri3_Label)
        Me.Controls.Add(Me.Giatri2_Label)
        Me.Controls.Add(Me.Giatri1_Label)
        Me.Controls.Add(Me.Giatri1_TextBox)
        Me.Controls.Add(Me.Giatri3_TextBox)
        Me.Controls.Add(Me.Giatri2_TextBox)
        Me.Controls.Add(Me.Time_Value_Label)
        Me.Controls.Add(Me.Ngay_Label)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 9.818182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bài tập 1 | Huỳnh Trọng Khoa | 2050531200216"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Ngay_Label As Label
    Friend WithEvents Time_Value_Label As Label
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Giatri2_TextBox As TextBox
    Friend WithEvents Giatri3_TextBox As TextBox
    Friend WithEvents Giatri1_TextBox As TextBox
    Friend WithEvents Giatri1_Label As Label
    Friend WithEvents Giatri2_Label As Label
    Friend WithEvents Giatri3_Label As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DBI_RadioButton As RadioButton
    Friend WithEvents Exp_RadioButton As RadioButton
    Friend WithEvents Mod_RadioButton As RadioButton
    Friend WithEvents Division_RadioButton As RadioButton
    Friend WithEvents Multiplication_RadioButton As RadioButton
    Friend WithEvents Subtraction_RadioButton As RadioButton
    Friend WithEvents Addition_RadioButton As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents S_Tron_RadioButton As RadioButton
    Friend WithEvents S_TamGiac_RadioButton As RadioButton
    Friend WithEvents S_Vuong_RadioButton As RadioButton
    Friend WithEvents S_ChuNhat_RadioButton As RadioButton
    Friend WithEvents THT_Button As Button
    Friend WithEvents T_Button As Button
    Friend WithEvents KQ_TextBox As TextBox
    Friend WithEvents Label1 As Label
End Class
