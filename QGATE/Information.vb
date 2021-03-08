﻿SCAN_PRODUCT.Focus()
LB_BOX_NG.Text = 1
LB_HIDE_ID_REF_FA.Visible = False
TEXTBOX_TOTAL_QTY.Visible = False
TEST.Visible = False
LB_Hide_QR_FA_SCAN.Visible = False
TEXTBOX_COUNTER_PRODUCT.Enabled = False
TEXTBOX_COUNTER_PRODUCT_NG.Enabled = False
@ -85,6 +87,7 @@ Public Class Information
                    LB_RANK_PRODUCT.Text = arr_prd(3)
Else
P_SCAN_PRODUCT = SCAN_PRODUCT.Text
LB_RANK_PRODUCT.Text = "A"
End If
Dim result_check_qr_product = api.Load_data("http://192.168.161.102/QGATE/QGATE_CHECK_FA_TAG_SCAN/CHECK_QR_SCAN_DETAIL?QR_CODE=" & P_SCAN_PRODUCT)
If result_check_qr_product = "0" Then
@ -124,7 +127,7 @@ Public Class Information
                End If
SCAN_PRODUCT.Text = ""
SCAN_PRODUCT.Focus()
check_box()
'check_box()
End Select
End Sub
Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
@ -233,6 +236,9 @@ NEXT_NG
                LB_QR_PRODUCT_NG.Text = LOG_QR_PROD(CDbl(Val(g_index_ng)))
    count_product -= 1
    Dim result_insert = api.Load_data("http://192.168.161.102/QGATE/QGATE_Insert_data/INSERT_QR_SCAN_DETAIL?REF_FA=" & LB_HIDE_ID_REF_FA.Text & "&QR_PROM=" & LOG_QR_PROD(CDbl(Val(g_index_ng))) & "&USER_ID=" & Main.P_user_id & "&COUNT_QTY=" & TEXTBOX_COUNTER_PRODUCT.Text & "&BOX_NO=" & LB_COUNTBOX.Text & "&INSPECTION_TIME=" & INSPECTION_TIME2 & "&STATUS=NG" & "&DEFECT_ID=" & DEFECT_ID(g_index) & "&RANK_P=")
    x = New ListViewItem(CType(LOG_QR_PROD(CDbl(Val(g_index_ng))), String))
    ListView_NG.Items.Add(x)
    x = New ListViewItem(CType(LOG_QR_PROD(CDbl(Val(g_index_ng))), String))
    ListView_NG_ALL.Items.Add(x)
    ListView_Good.Items.RemoveAt(g_index_ng)
    If g_index_ng = 0 And LB_COUNTBOX.Text >= "1" Then
        LOG_QR_PROD = New ArrayList()
    End If
    Else
    GoTo NEXT_NG
    End If
    End If
    Panel_DEFECT.Visible = False
    SCAN_PRODUCT.Visible = True
    Button2.Visible = False
    time_count = 0
    TEST.Text = "0"
    Dim QR_PRODUCT_NG As String = "REF_ID "
    If next_stock_ng = CDbl(Val(TEXTBOX_COUNTER_PRODUCT_NG.Text)) Then
        If ListView_NG.Items.Count > 0 Then
            Dim x As Integer
            For x = 0 To ListView_NG.Items.Count - 1
                Try
                    Dim result_data = api.Load_data("http://192.168.161.102/QGATE/GET_FA_TAG_SCAN/GET_REF_ID?PROM_PRO=" & ListView_NG.Items(x).Text)
                    Dim dict As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(result_data)
                    For Each item As Object In dict
                        QR_PRODUCT_NG &= item("ID").ToString() & " "
                    Next
                Catch ex As Exception
                    MsgBox("ERROR API ID")
                End Try
            Next
            ListView_NG.Clear()
        End If
        Print_NG.Set_parameter_print(LB_PART_NO.Text, LB_PART_NAME.Text, LB_MODEL.Text, LB_LOT.Text, LB_BOX_NG.Text, TEXTBOX_COUNTER_PRODUCT_NG.Text, LB_Hide_QR_FA_SCAN.Text, LB_MAXBOX.Text, QR_PRODUCT_NG)
        '            next_stock_ng = next_stock_ng + CDbl(Val(LB_SNP.Text))
        ListView_NG.Clear()
    End If
End Sub

Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
    Panel_DEFECT.Visible = False
End Sub

Private Sub Panel_DEFECT_Paint(sender As Object, e As PaintEventArgs)

End Sub
Public Sub print_tag()

End Sub

Private Sub SCAN_FG_TAG_KeyDown(sender As Object, e As KeyEventArgs) Handles SCAN_FG_TAG.KeyDown
    Select Case e.KeyCode
        Case System.Windows.Forms.Keys.Enter
            If SCAN_FG_TAG.Text.Length() = "103" Then
                Dim api = New api()
                Dim result_check_scan_loop = api.Load_data("http://192.168.161.102/QGATE/QGATE_CHECK_FA_TAG_SCAN/CHECK_TAG_FG?QR_CODE=" & SCAN_FG_TAG.Text)
                If result_check_scan_loop = "0" Then
                    GET_FIFO()
                Else
                    MsgBox("สแกนซ้ำ")
                End If
            Else
                MsgBox("FAIL")
            End If
    End Select
End Sub
Public Sub GET_FIFO()
    Try
        ListView1.Items.Clear()
        Dim api = New api()
        Dim Raw = api.Load_data("http://192.168.161.102/QGATE/QGATE_CHECK_FA_TAG_SCAN/CHECK_FIFO_QGATE?QR_CODE=" & SCAN_FG_TAG.Text)
        'MsgBox(Raw)
        Dim dict As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(Raw)
        For Each item As Object In dict
            x = New ListViewItem(item("LOT_NO").ToString())
            x.SubItems.Add(item("QTY").ToString())
            ListView1.Items.Add(x)
        Next
        Panel_FIFO.Visible = True
    Catch ex As Exception
        MsgBox("กรุณาสแกน TAG ให้ถูกต้อง")
        SCAN_FG_TAG.Text = ""
        SCAN_FG_TAG.Focus()
    End Try

End Sub

Public Sub load_data()
    Dim api = New api()
    Try
        If SCAN_FG_TAG.Text.Substring(8, 11) <> "" Then
            Dim year As String = SCAN_FG_TAG.Text.Substring(8, 4)
            Dim mouth As String = SCAN_FG_TAG.Text.Substring(12, 2)
            Dim day As String = SCAN_FG_TAG.Text.Substring(14, 2)
            LB_WASHING.Text = year & "/" & mouth & "/" & day
        Else
            LB_WASHING.Text = "NULL"
        End If
    Catch ex As Exception
        LB_WASHING.Text = "NULL"
    End Try
    LB_MAXBOX.Text = api.Load_data("http://192.168.161.102/QGATE/GET_FA_TAG_SCAN/LOAD_DATA_MAX_BOX?QR_CODE=" & SCAN_FG_TAG.Text)
    LB_PART_NAME.Text = api.Load_data("http://192.168.161.102/QGATE/GET_FA_TAG_SCAN/LOAD_DATA_PART_NAME?QR_CODE=" & SCAN_FG_TAG.Text)
    Dim Raw = api.Load_data("http://192.168.161.102/QGATE/GET_FA_TAG_SCAN/LOAD_DATA_FA_TAG_SCAN?QR_CODE=" & SCAN_FG_TAG.Text)
    Dim dict As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(Raw)
    For Each item As Object In dict
        LB_PART_NO.Text = item("ITEM_CD").ToString()
        LB_MODEL.Text = item("MODEL").ToString()
        LB_SNP.Text = item("SNP").ToString()

        LB_HIDE_ID_REF_FA.Text = item("ID").ToString()
        LB_LOT.Text = item("LOT_NO").ToString()
    Next
End Sub

Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
    Panel_FIFO.Visible = False
    'ListViewItem.Items.Clear()
    If ListView1.Items(0).Text = SCAN_FG_TAG.Text.Substring(58, 4) Then
        Dim api = New api()
        Dim result_data = api.Load_data("http://192.168.161.102/QGATE/QGATE_Insert_data/INSERT_FA_TAG_SCAN?QR_CODE=" & SCAN_FG_TAG.Text & "&USER_ID=" & Main.P_user_id)
        load_data()
        Panel2.Hide()
    Else
        MsgBox("กรุณาสแกนตาม FIFO ค่ะ")
        SCAN_FG_TAG.Text = ""
        SCAN_FG_TAG.Focus()
    End If
End Sub

Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
    Dim QR_PRODUCT As String = ""
    For Each value In LOG_QR_PROD
        QR_PRODUCT &= value & " "
    Next
    Print.Set_parameter_print(LB_PART_NO.Text, LB_PART_NAME.Text, LB_MODEL.Text, LB_LOT.Text, LB_COUNTBOX.Text, TEXTBOX_COUNTER_PRODUCT.Text, LB_Hide_QR_FA_SCAN.Text, LB_MAXBOX.Text, QR_PRODUCT)
    Print_NG.Set_parameter_print(LB_PART_NO.Text, LB_PART_NAME.Text, LB_MODEL.Text, LB_LOT.Text, LB_BOX_NG.Text, TEXTBOX_COUNTER_PRODUCT_NG.Text, LB_Hide_QR_FA_SCAN.Text, LB_MAXBOX.Text, QR_PRODUCT)
    Dim Start_o = New Start_operation()
    Start_o.Show()
    Me.Close()
End Sub
End Class