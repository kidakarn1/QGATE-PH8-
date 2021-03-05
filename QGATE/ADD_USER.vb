Public Class ADD_USER
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Select_menu.Show()
        Me.Close()
    End Sub

    Private Sub ADD_USER_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LB_show_user_id.Text = Main.P_user_id
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim api = New api()
        Dim result_data = api.Load_data("http://192.168.161.102/QGATE/QGATE_Insert_data/INSERT_USERS?USER_ID=" & TUSER_ID.Text & "&FNAME=" & TFNAME.Text & "&LNAME=" & TLNAME.Text & "&CREATED_BY=" & Main.P_user_id)
        If result_data = "1" Then
            MsgBox("INSERT OK")
            Select_menu.Show()
            Me.Close()
        Else
            MsgBox("INSERT FAILL")
        End If
    End Sub
End Class