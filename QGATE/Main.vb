
Public Class Main
    Public P_user_id As String = ""
    Public myConn = "NODATA"
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connect_db = New connect()
        myConn = connect_db.conn()
        ' Print.PrintDocument1.Print()
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles user_id.KeyDown
        Select Case e.KeyCode
            Case System.Windows.Forms.Keys.Enter
                Dim api = New api()
                Try
                    If Len(user_id.Text) > 5 Then
                        Dim arr_data = user_id.Text.Split(",")
                        Dim arr_user = arr_data(1).Split(":")
                        P_user_id = arr_user(0)
                    Else
                        P_user_id = user_id.Text
                    End If
                Catch ex As Exception
                    GoTo alert_msg
                End Try

                Dim result_api_checkper = api.Load_data("http://192.168.161.102/QGATE/Check_permission/USER_LOAD_DATA?USER_ID=" & P_user_id)
                If result_api_checkper = "1" Then
                    Dim Select_menu As Select_menu = New Select_menu()
                    Dim result_per = api.Load_data("http://192.168.161.102/QGATE/Check_permission/USER_CHECK_PERMISSION?USER_ID=" & P_user_id)
                    Module1.set_permission(result_per)
                    Module1.set_user_id(user_id.Text)
                    Select_menu.Show()
                    Me.Hide()
                Else
alert_msg:
                    MsgBox("รหัสผ่านผิด")
                End If
        End Select
    End Sub

    Private Sub user_id_TextChanged(sender As Object, e As EventArgs) Handles user_id.TextChanged

    End Sub
End Class
