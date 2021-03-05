Public Class Select_menu
    Private Sub Select_menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            LB_show_user_id.Text = Main.P_user_id
            Dim api = New api()
            If api.DownloadImage("http://192.168.82.23/member/photo/" & LB_show_user_id.Text & ".jpg") IsNot Nothing Then
                user_image.Image = api.DownloadImage("http://192.168.82.23/member/photo/" & LB_show_user_id.Text & ".jpg")
                If Module1.get_permission() = "1" Then
                    BTN_edit_data.Visible = True
                ElseIf Module1.get_permission() = "0" Then
                    BTN_edit_data.Visible = False
                End If
            End If

        Catch ex As Exception

        End Try
        BTN_start_operation.Visible = True
    End Sub

    Private Sub BTN_start_operation_Click(sender As Object, e As EventArgs) Handles BTN_start_operation.Click
        Dim start_opration = New Start_operation()
        start_opration.Show()
        Me.Hide()
    End Sub

    Private Sub BTN_exit_Click(sender As Object, e As EventArgs) Handles BTN_exit.Click
        BTN_start_operation.Visible = True
        Main.Show()
        Me.Close()
    End Sub

    Private Sub BTN_start_operation_MouseHover(sender As Object, e As EventArgs) Handles BTN_start_operation.MouseHover
        BTN_start_operation.Visible = False
        BTN_exit.Visible = True
    End Sub

    Private Sub BTN_edit_data_Click(sender As Object, e As EventArgs) Handles BTN_edit_data.Click
        'BTN_start_operation.Visible = True
        ADD_USER.Show()
        Me.Close()
    End Sub

    Private Sub BT1_Click(sender As Object, e As EventArgs) Handles BT1.Click
        Dim start_opration = New Start_operation()
        start_opration.Show()
        Me.Hide()
    End Sub

    Private Sub Select_menu_MouseHover(sender As Object, e As EventArgs) Handles MyBase.MouseHover
        BTN_start_operation.Visible = True
        BTN_exit.Visible = True
    End Sub

    Private Sub BTN_edit_data_MouseHover(sender As Object, e As EventArgs) Handles BTN_edit_data.MouseHover
        BTN_start_operation.Visible = True
        BTN_exit.Visible = True
    End Sub

    Private Sub BTN_exit_MouseHover(sender As Object, e As EventArgs) Handles BTN_exit.MouseHover
        BTN_start_operation.Visible = True
        BTN_exit.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BTN_start_operation.Visible = True
        Main.Show()
        Me.Close()
    End Sub

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        BTN_start_operation.Visible = True
    End Sub
End Class