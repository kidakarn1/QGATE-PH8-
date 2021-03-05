Imports System.Net
Imports System.IO
Imports System.Web.Script.Serialization
Public Class Start_operation
    Dim x As ListViewItem
    Private Sub Start_operation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LB_show_user_id.Text = Main.P_user_id
        Panel_FIFO.Visible = False
    End Sub
    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles SCAN_FG_TAG.KeyDown
        Select Case e.KeyCode
            Case System.Windows.Forms.Keys.Enter
                If SCAN_FG_TAG.Text.Length() = "103" Then
                    Dim api = New api()
                    Dim result_check_scan_loop = api.Load_data("http://192.168.161.102/QGATE/QGATE_CHECK_FA_TAG_SCAN/CHECK_TAG_FG?QR_CODE=" & SCAN_FG_TAG.Text)
                    If result_check_scan_loop = "0" Then
                        GET_FIFO()
                    Else
                        MsgBox("สแกนซ้ำ")
                        SCAN_FG_TAG.Text = ""
                        SCAN_FG_TAG.Focus()
                    End If
                Else
                    MsgBox("FAIL")
                    SCAN_FG_TAG.Text = ""
                    SCAN_FG_TAG.Focus()
                End If
        End Select
    End Sub


    Public Sub GET_FIFO()
        Try
            ListViewItem.Items.Clear()
            Dim api = New api()
            Dim Raw = api.Load_data("http://192.168.161.102/QGATE/QGATE_CHECK_FA_TAG_SCAN/CHECK_FIFO_QGATE?QR_CODE=" & SCAN_FG_TAG.Text)
            'MsgBox(Raw)
            Dim dict As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(Raw)
            For Each item As Object In dict
                x = New ListViewItem(item("LOT_NO").ToString())
                x.SubItems.Add(item("QTY").ToString())
                ListViewItem.Items.Add(x)
            Next
            Panel_FIFO.Visible = True
        Catch ex As Exception
            MsgBox("กรุณาสแกน TAG ให้ถูกต้อง")
            SCAN_FG_TAG.Text = ""
            SCAN_FG_TAG.Focus()
        End Try

    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Panel_FIFO.Visible = False
        If ListViewItem.Items(0).Text = SCAN_FG_TAG.Text.Substring(58, 4) Then
            Dim api = New api()
            Dim result_data = api.Load_data("http://192.168.161.102/QGATE/QGATE_Insert_data/INSERT_FA_TAG_SCAN?QR_CODE=" & SCAN_FG_TAG.Text & "&USER_ID=" & Main.P_user_id)
            Dim information = New Information()
            information.LB_Hide_QR_FA_SCAN.Text = SCAN_FG_TAG.Text
            information.Show()
            Me.Close()
        Else
            MsgBox("กรุณาสแกนตาม FIFO ค่ะ")
            SCAN_FG_TAG.Text = ""
            SCAN_FG_TAG.Focus()
        End If
    End Sub
End Class