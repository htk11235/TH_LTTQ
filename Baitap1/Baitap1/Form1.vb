Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Time_Value_Label.Text = DateTime.Now.ToString("dd/MM/yyyy     HH:mm:ss")
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter
        For Each checkedButton As Object In GroupBox2.Controls
            If TypeOf checkedButton Is RadioButton Then
                checkedButton.Checked = False
            End If
        Next
    End Sub

    Private Sub DBI_RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles DBI_RadioButton.CheckedChanged
        If DBI_RadioButton.Checked Then
            Giatri1_Label.Text = "Số bị chia"

            Giatri2_TextBox.Enabled = True
            Giatri2_Label.Enabled = True
            Giatri2_Label.Text = "Số chia"

            Giatri3_TextBox.Enabled = False
            Giatri3_Label.Enabled = False
            Giatri3_Label.Text = "Giá trị 3"
        End If
    End Sub

    Private Sub Exp_RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles Exp_RadioButton.CheckedChanged
        If Exp_RadioButton.Checked Then
            Giatri1_Label.Text = "Cơ số"

            Giatri2_TextBox.Enabled = True
            Giatri2_Label.Enabled = True
            Giatri2_Label.Text = "Số mũ"

            Giatri3_TextBox.Enabled = False
            Giatri3_Label.Enabled = False
            Giatri3_Label.Text = "Giá trị 3"
        End If
    End Sub

    Private Sub Mod_RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles Mod_RadioButton.CheckedChanged
        If Mod_RadioButton.Checked Then
            Giatri1_Label.Text = "Số bị chia"

            Giatri2_TextBox.Enabled = True
            Giatri2_Label.Enabled = True
            Giatri2_Label.Text = "Số chia"

            Giatri3_TextBox.Enabled = False
            Giatri3_Label.Enabled = False
            Giatri3_Label.Text = "Giá trị 3"
        End If

    End Sub

    Private Sub Addition_RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles Addition_RadioButton.CheckedChanged
        If Addition_RadioButton.Checked Then
            Giatri1_Label.Text = "Số hạng 1"

            Giatri2_TextBox.Enabled = True
            Giatri2_Label.Enabled = True
            Giatri2_Label.Text = "Số hạng 2"

            Giatri3_TextBox.Enabled = True
            Giatri3_Label.Enabled = True
            Giatri3_Label.Text = "Số hạng 3"
        End If
    End Sub

    Private Sub Subtraction_RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles Subtraction_RadioButton.CheckedChanged
        If Subtraction_RadioButton.Checked Then
            Giatri1_Label.Text = "Số bị trừ"

            Giatri2_TextBox.Enabled = True
            Giatri2_Label.Enabled = True
            Giatri2_Label.Text = "Số trừ"

            Giatri3_TextBox.Enabled = True
            Giatri3_Label.Enabled = True
            Giatri3_Label.Text = "Số trừ"
        End If
    End Sub

    Private Sub Multiplication_RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles Multiplication_RadioButton.CheckedChanged
        If Multiplication_RadioButton.Checked Then
            Giatri1_Label.Text = "Nhân tử 1"

            Giatri2_TextBox.Enabled = True
            Giatri2_Label.Enabled = True
            Giatri2_Label.Text = "Nhân tử 2"

            Giatri3_TextBox.Enabled = True
            Giatri3_Label.Enabled = True
            Giatri3_Label.Text = "Nhân tử 3"
        End If
    End Sub

    Private Sub Division_RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles Division_RadioButton.CheckedChanged
        If Division_RadioButton.Checked Then
            Giatri1_TextBox.Enabled = True
            Giatri1_Label.Text = "Số bị chia"

            Giatri2_TextBox.Enabled = True
            Giatri2_Label.Enabled = True
            Giatri2_Label.Text = "Số chia"

            Giatri3_TextBox.Enabled = True
            Giatri3_Label.Enabled = True
            Giatri3_Label.Text = "Số chia"
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles KQ_TextBox.TextChanged

    End Sub
    Private Sub THT_Button_Click(sender As Object, e As EventArgs) Handles THT_Button.Click

        Dim a, b, c As Double
        Dim check As Boolean = False
        For Each checkedButton As Object In GroupBox1.Controls
            If TypeOf checkedButton Is RadioButton Then
                If checkedButton.Checked Then
                    check = True
                End If
            End If
        Next

        If Not check Then
            KQ_TextBox.Text = "Chưa chọn toán tử!"
        End If

        a = Giatri1_TextBox.Text
        b = Giatri2_TextBox.Text
        c = Giatri3_TextBox.Text

        If Addition_RadioButton.Checked Then
            KQ_TextBox.Text = a + b + c
        End If

        If Subtraction_RadioButton.Checked Then
            KQ_TextBox.Text = a - b - c
        End If

        If Multiplication_RadioButton.Checked Then
            KQ_TextBox.Text = a * b * c
        End If

        If Division_RadioButton.Checked Then
            If b = 0 Or c = 0 Then
                KQ_TextBox.Text = "Số chia phải khác 0!"
            Else KQ_TextBox.Text = a / b / c
            End If
        End If

        If Mod_RadioButton.Checked Then
            If b = 0 Then
                KQ_TextBox.Text = "Số chia phải khác 0!"
            Else KQ_TextBox.Text = a Mod b
            End If
        End If

        If Exp_RadioButton.Checked Then
            KQ_TextBox.Text = a ^ b
        End If

        If DBI_RadioButton.Checked Then
            If b = 0 Then
                KQ_TextBox.Text = "Số chia phải khác 0!"
            Else KQ_TextBox.Text = a / b - ((a / b) Mod 1)
            End If
        End If
    End Sub

    Private Sub S_ChuNhat_RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles S_ChuNhat_RadioButton.CheckedChanged
        If S_ChuNhat_RadioButton.Checked Then
            Giatri1_Label.Text = "Chiều dài"

            Giatri2_TextBox.Enabled = True
            Giatri2_Label.Enabled = True
            Giatri2_Label.Text = "Chiều rộng"

            Giatri3_TextBox.Enabled = False
            Giatri3_Label.Enabled = False
            Giatri3_Label.Text = "Giá trị 3"
        End If
    End Sub

    Private Sub S_Vuong_RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles S_Vuong_RadioButton.CheckedChanged
        If S_Vuong_RadioButton.Checked Then
            Giatri1_Label.Text = "Chiều dài cạnh"

            Giatri2_TextBox.Enabled = False
            Giatri2_Label.Enabled = False
            Giatri2_Label.Text = "Giá trị 2"

            Giatri3_TextBox.Enabled = False
            Giatri3_Label.Enabled = False
            Giatri3_Label.Text = "Giá trị 3"
        End If
    End Sub

    Private Sub S_Tron_RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles S_Tron_RadioButton.CheckedChanged
        If S_Tron_RadioButton.Checked Then
            Giatri1_Label.Text = "Bán kính"

            Giatri2_TextBox.Enabled = False
            Giatri2_Label.Enabled = False
            Giatri2_Label.Text = "Giá trị 2"

            Giatri3_TextBox.Enabled = False
            Giatri3_Label.Enabled = False
            Giatri3_Label.Text = "Giá trị 3"
        End If
    End Sub

    Private Sub S_TamGiac_RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles S_TamGiac_RadioButton.CheckedChanged
        If S_TamGiac_RadioButton.Checked Then
            Giatri1_Label.Text = "Cạnh a"

            Giatri2_TextBox.Enabled = True
            Giatri2_Label.Enabled = True
            Giatri2_Label.Text = "Cạnh b"

            Giatri3_TextBox.Enabled = True
            Giatri3_Label.Enabled = True
            Giatri3_Label.Text = "Cạnh c"
        End If
    End Sub

    Private Sub T_Button_Click(sender As Object, e As EventArgs) Handles T_Button.Click
        Dim a, b, c As Double
        Dim check As Boolean = False

        For Each checkedButton As Object In GroupBox2.Controls
            If TypeOf checkedButton Is RadioButton Then
                If checkedButton.Checked = True Then
                    check = True
                End If
            End If
        Next
        If check = False Then
            KQ_TextBox.Text = "Chưa chọn phép tính!"
        End If

        a = Giatri1_TextBox.Text
        b = Giatri2_TextBox.Text
        c = Giatri3_TextBox.Text

        If S_ChuNhat_RadioButton.Checked Then
            If a = 0 Or b = 0 Then
                KQ_TextBox.Text = 0
            ElseIf a < 0 Or b < 0 Then
                KQ_TextBox.Text = "Cạnh không được nhỏ hơn 0!"
            Else KQ_TextBox.Text = a * b
            End If
        End If

        If S_Vuong_RadioButton.Checked Then
            If a = 0 Then
                KQ_TextBox.Text = 0
            ElseIf a < 0 Then
                KQ_TextBox.Text = "Cạnh không được nhỏ hơn 0!"
            Else KQ_TextBox.Text = a * a
            End If
        End If

        If S_TamGiac_RadioButton.Checked Then
            If a = 0 Or b = 0 Or c = 0 Then
                KQ_TextBox.Text = 0
            ElseIf a < 0 Or b < 0 Or c < 0 Then
                KQ_TextBox.Text = "Cạnh không được nhỏ hơn 0!"
            ElseIf (a + b) <= c Or (a + c) <= b Or (b + c) <= a Then
                KQ_TextBox.Text = "Chiều dài ba cạnh không hợp lệ!"
            Else KQ_TextBox.Text = 0.25 * Math.Sqrt((a + b + c) * (a + b - c) * (-a + b + c) * (a - b + c))
            End If
        End If

        If S_Tron_RadioButton.Checked Then
            If a = 0 Then
                KQ_TextBox.Text = 0
            ElseIf a < 0 Then
                KQ_TextBox.Text = "Cạnh không được nhỏ hơn 0!"
            Else KQ_TextBox.Text = a * a * Math.PI
            End If
        End If
    End Sub

    Private Sub Giatri1_TextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Giatri1_TextBox.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = "," AndAlso Not e.KeyChar = "." AndAlso Not e.KeyChar = "-" Then
            e.Handled = True
        End If
    End Sub

    Private Sub Giatri2_TextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Giatri2_TextBox.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = "," AndAlso Not e.KeyChar = "." AndAlso Not e.KeyChar = "-" Then
            e.Handled = True
        End If
    End Sub

    Private Sub Giatri3_TextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Giatri3_TextBox.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = "," AndAlso Not e.KeyChar = "." AndAlso Not e.KeyChar = "-" Then
            e.Handled = True
        End If
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter
        For Each checkedButton As Object In GroupBox1.Controls
            If TypeOf checkedButton Is RadioButton Then
                checkedButton.Checked = False
            End If
        Next
    End Sub

    Private Sub Giatri1_TextBox_Click(sender As Object, e As EventArgs) Handles Giatri1_TextBox.Click
        If Giatri1_TextBox.Text = "0" Then
            Giatri1_TextBox.Text = ""
        End If
    End Sub

    Private Sub Giatri1_TextBox_Leave(sender As Object, e As EventArgs) Handles Giatri1_TextBox.Leave
        If Giatri1_TextBox.Text = "" Then
            Giatri1_TextBox.Text = "0"
        End If
    End Sub
    Private Sub Giatri2_TextBox_Click(sender As Object, e As EventArgs) Handles Giatri2_TextBox.Click
        If Giatri2_TextBox.Text = "0" Then
            Giatri2_TextBox.Text = ""
        End If
    End Sub

    Private Sub Giatri2_TextBox_Leave(sender As Object, e As EventArgs) Handles Giatri2_TextBox.Leave
        If Giatri2_TextBox.Text = "" Then
            Giatri2_TextBox.Text = "0"
        End If
    End Sub
    Private Sub Giatri3_TextBox_Click(sender As Object, e As EventArgs) Handles Giatri3_TextBox.Click
        If Giatri3_TextBox.Text = "0" Then
            Giatri3_TextBox.Text = ""
        End If
    End Sub

    Private Sub Giatri3_TextBox_Leave(sender As Object, e As EventArgs) Handles Giatri3_TextBox.Leave
        If Giatri3_TextBox.Text = "" Then
            Giatri3_TextBox.Text = "0"
        End If
    End Sub
End Class
