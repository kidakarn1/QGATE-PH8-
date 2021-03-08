SCAN_PRODUCT.Focus()
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

    If g_index_ng = 0 And LB_COUNTBOX.Text >= "1" Then
        LOG_QR_PROD = New ArrayList()
    End If
@ -342,4 +348,15 @@ NEXT_NG

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