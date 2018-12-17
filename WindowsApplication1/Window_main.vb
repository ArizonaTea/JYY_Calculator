Public Class Window_main
    Private Sub Window_main(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = 0 ' initialize the text box 
        TextBox2.Text = 100
        TextBox3.Text = 7
        TextBox4.Text = 5
        TextBox5.Text = 10
        TextBox6.Text = 9.75
        TextBox7.Text = 0
        TextBox8.Text = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            Dim Result_DL As Double
            Dim Result_SD As Double

            Dim Ori_Price As Double = CDbl(TextBox1.Text)
            Dim Discount As Double = CDbl(TextBox2.Text)
            Dim Current As Double = CDbl(TextBox3.Text)
            Dim FeeDL As Double = CDbl(TextBox4.Text)
            Dim FeeSD As Double = CDbl(TextBox5.Text)
            Dim Tax As Double = CDbl(TextBox6.Text)
            Dim USPost As Double = CDbl(TextBox7.Text)
            Dim CNPost As Double = CDbl(TextBox8.Text)

            Result_DL = ((Ori_Price * (Discount / 100)) * (1 + FeeDL / 100) + (Ori_Price * (Discount / 100)) * Tax / 100 + USPost) * Current + CNPost
            Result_SD = ((Ori_Price * (Discount / 100)) * (1 + FeeSD / 100) + (Ori_Price * (Discount / 100)) * Tax / 100 + USPost) * Current + CNPost

            Label6.Text = Result_DL
            Label7.Text = Result_SD
        Catch ex As Exception
            MessageBox.Show("参数有误，请检查!", "o(╯□╰)o")
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MessageBox.Show("正式版V1.0" & vbCrLf & "JYY北美折扣猎手" & vbCrLf & "版权所有", "版本信息")
    End Sub

End Class
