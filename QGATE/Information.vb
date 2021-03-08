Imports System.Net
Imports System.IO
Imports System.Web.Script.Serialization
Public Class Information
    Public count_product As Integer = 0
    Public count_product_ng As Integer = 0
    Public count_box As Integer = 1
    Public Default_count_box As Integer = 1
    Public time_count As Integer = 0
    Dim x As ListViewItem
    Dim DEFECT_ID As ArrayList = New ArrayList()
    Dim LOG_QR_PROD As ArrayList = New ArrayList()
    Dim g_index As Integer = 0
    Dim g_index_ng As Integer = 0
    Dim del_g_index_ng As Integer = 1
    Dim next_stock As Integer = 0
    Dim next_stock_ng As Integer = 0
    Private Sub Information_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TEXTBOX_TOTAL_QTY.Enabled = False
        Dim api = New api()
        SCAN_PRODUCT.Focus()
        LB_BOX_NG.Text = 1
        LB_HIDE_ID_REF_FA.Visible = False
        TEXTBOX_TOTAL_QTY.Visible = False
        TEST.Visible = False
        LB_Hide_QR_FA_SCAN.Visible = False
        TEXTBOX_COUNTER_PRODUCT.Enabled = False
        TEXTBOX_COUNTER_PRODUCT_NG.Enabled = False

        Button2.Visible = False
        count_box = CDbl(Val(api.Load_data("http://192.168.161.102/QGATE/GET_FA_TAG_SCAN/LOAD_DATA_SCAN_BOX?QR_CODE=" & LB_Hide_QR_FA_SCAN.Text))) + 1
        LB_show_user_id.Text = Main.P_user_id
        LB_COUNTBOX.Text = count_box
        Default_count_box = count_box
        TEXTBOX_COUNTER_PRODUCT_NG.Text = "0"
        TEXTBOX_COUNTER_PRODUCT.Text = "0"
        Panel_DEFECT.Visible = False
        TEXTBOX_TOTAL_QTY.Text = "0"
        Panel2.Visible = False
        Try
            If LB_Hide_QR_FA_SCAN.Text.Substring(8, 11) <> "" Then
                Dim year As String = LB_Hide_QR_FA_SCAN.Text.Substring(8, 4)
                Dim mouth As String = LB_Hide_QR_FA_SCAN.Text.Substring(12, 2)
                Dim day As String = LB_Hide_QR_FA_SCAN.Text.Substring(14, 2)
                LB_WASHING.Text = year & "/" & mouth & "/" & day
            Else
                LB_WASHING.Text = "NULL"
            End If

        Catch ex As Exception
            LB_WASHING.Text = "NULL"
        End Try
        LB_MAXBOX.Text = api.Load_data("http://192.168.161.102/QGATE/GET_FA_TAG_SCAN/LOAD_DATA_MAX_BOX?QR_CODE=" & LB_Hide_QR_FA_SCAN.Text)
        LB_PART_NAME.Text = api.Load_data("http://192.168.161.102/QGATE/GET_FA_TAG_SCAN/LOAD_DATA_PART_NAME?QR_CODE=" & LB_Hide_QR_FA_SCAN.Text)
        Dim Raw = api.Load_data("http://192.168.161.102/QGATE/GET_FA_TAG_SCAN/LOAD_DATA_FA_TAG_SCAN?QR_CODE=" & LB_Hide_QR_FA_SCAN.Text)
        Try
            Dim dict As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(Raw)
            For Each item As Object In dict
                LB_PART_NO.Text = item("ITEM_CD").ToString()
                LB_MODEL.Text = item("MODEL").ToString()
                LB_SNP.Text = item("SNP").ToString()
                next_stock = CDbl(Val(LB_SNP.Text))
                next_stock_ng = CDbl(Val(LB_SNP.Text))
                LB_HIDE_ID_REF_FA.Text = item("ID").ToString()
                LB_LOT.Text = item("LOT_NO").ToString()
            Next
        Catch ex As Exception
            MsgBox("ERROR")
        End Try

    End Sub
    Public Sub check_box()
        If CDbl(Val(TEXTBOX_TOTAL_QTY.Text)) = next_stock And Button2.Visible = False Then
            next_stock += CDbl(Val(LB_SNP.Text))
            SCAN_FG_TAG.Text = ""
            Panel_FIFO.Visible = False
            Panel2.Visible = True
            SCAN_FG_TAG.Focus()
        End If
    End Sub
    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles SCAN_PRODUCT.KeyDown
        Select Case e.KeyCode
            Case System.Windows.Forms.Keys.Enter

                Dim P_SCAN_PRODUCT As String = ""
                Dim api = New api()
                If SCAN_PRODUCT.Text = "" Then
                    MsgBox("กรุณา สแกน QR CODE ตัวชิ้นงาน")
                    Return
                End If
                If Len(SCAN_PRODUCT.Text) > 20 Then
                    Dim arr_data = SCAN_PRODUCT.Text.Split(",")
                    Dim arr_prd = arr_data(1).Split(":")
                    P_SCAN_PRODUCT = arr_prd(0)
                    LB_RANK_PRODUCT.Text = arr_prd(3)
                Else
                    P_SCAN_PRODUCT = SCAN_PRODUCT.Text
                    LB_RANK_PRODUCT.Text = "A"
                End If
<<<<<<< HEAD
<<<<<<< HEAD
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
=======
                Dim result_check_qr_product = api.Load_data("http://192.168.161.102/QGATE/QGATE_CHECK_FA_TAG_SCAN/CHECK_QR_SCAN_DETAIL?QR_CODE=" & P_SCAN_PRODUCT)
                If result_check_qr_product = "0" Then
                    count_product += 1
                    TEXTBOX_COUNTER_PRODUCT.Text += 1
                    TEXTBOX_TOTAL_QTY.Text += 1 'TEST'
                    LB_QR_PRODUCT.Text = P_SCAN_PRODUCT
                    Dim INSPECTION_TIME = (CDbl(Val(TEST.Text)) / 10)
                    Dim result_insert = api.Load_data("http://192.168.161.102/QGATE/QGATE_Insert_data/INSERT_QR_SCAN_DETAIL?REF_FA=" & LB_HIDE_ID_REF_FA.Text & "&QR_PROM=" & P_SCAN_PRODUCT & "&USER_ID=" & Main.P_user_id & "&COUNT_QTY=" & TEXTBOX_COUNTER_PRODUCT.Text & "&BOX_NO=" & LB_COUNTBOX.Text & "&INSPECTION_TIME=" & INSPECTION_TIME & "&STATUS=NONG" & "&DEFECT_ID=" & "&RANK_P=" & LB_RANK_PRODUCT.Text)
                    x = New ListViewItem(CType(P_SCAN_PRODUCT, String))
                    ListView_Good.Items.Add(x)
                    Try
                        LOG_QR_PROD.Add(P_SCAN_PRODUCT)
                        If LOG_QR_PROD(count_product - 1) <> " " Then
                            LOG_QR_PROD(count_product - 1) = P_SCAN_PRODUCT
                        End If
                    Catch ex As Exception
                        LOG_QR_PROD.Add(P_SCAN_PRODUCT)
                    End Try

                    time_count = 0
                    TEST.Text = "0"
                    If result_insert = "0" Then
                        MsgBox("INSERT_QR_SCAN_DETAIL  FAILL ")
                    End If
                    If count_product = CDbl(Val(LB_SNP.Text)) Then
                        TEXTBOX_COUNTER_PRODUCT.Text = "0"
                        'count_product = 0
                        count_box += 1
                        LB_COUNTBOX.Text = (LB_COUNTBOX.Text + 1)
                        SCAN_PRODUCT.Visible = False
                        Button2.Visible = True
                        SCAN_PRODUCT.Visible = False
                        'Start_operation.Show()
                        'Me.Close()
                    End If
                Else
                    MsgBox("คุณเคยสแกนชิ้นงานไปแล้ว")
                End If
                SCAN_PRODUCT.Text = ""
                SCAN_PRODUCT.Focus()
                'check_box()
        End Select
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If LB_COUNTBOX.Text = Default_count_box And TEXTBOX_COUNTER_PRODUCT.Text = "0" Then
            GoTo alert_ng
        End If

        If LB_COUNTBOX.Text >= Default_count_box And TEXTBOX_COUNTER_PRODUCT.Text >= "0" Then
            ListViewItem.Items.Clear()
            DEFECT_ID = New ArrayList()
            Dim api = New api()
            Dim Raw = api.Load_data("http://192.168.161.102/QGATE/GET_FA_TAG_SCAN/LOAD_DATA_DEFECT_MASTER")
            'MsgBox(Raw)
            Dim dict As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(Raw)
            For Each item As Object In dict
                x = New ListViewItem(item("DEFECT_CODE").ToString())
                x.SubItems.Add(item("DEFECT_NAME").ToString())
                DEFECT_ID.Add(item("ID").ToString())
                ListViewItem.Items.Add(x)

            Next
            Panel_DEFECT.Visible = True
        Else
alert_ng:
            MsgBox("กรุณา สแกน QR CODE ตัวชิ้นงาน")
            Return
        End If
        SCAN_PRODUCT.Text = ""
        SCAN_PRODUCT.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim QR_PRODUCT As String = ""
        Dim api = New api()
        If ListView_Good.Items.Count > 0 Then
            Dim x As Integer
            For x = 0 To ListView_Good.Items.Count - 1
                Try
                    Dim result_data = api.Load_data("http://192.168.161.102/QGATE/GET_FA_TAG_SCAN/GET_REF_ID?PROM_PRO=" & ListView_Good.Items(x).Text)
                    Dim dict As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(result_data)
                    For Each item As Object In dict
                        QR_PRODUCT &= item("ID").ToString() & " "
                    Next
                Catch ex As Exception
                    MsgBox("ERROR API ID")
                End Try
            Next
            ListView_Good.Clear()
        End If

        Print.Set_parameter_print(LB_PART_NO.Text, LB_PART_NAME.Text, LB_MODEL.Text, LB_LOT.Text, LB_COUNTBOX.Text, LB_SNP.Text, LB_Hide_QR_FA_SCAN.Text, LB_MAXBOX.Text, QR_PRODUCT, Default_count_box, TEXTBOX_COUNTER_PRODUCT.Text)
        Dim Start_o = New Start_operation()
        Start_o.Show()
        Me.Close()
    End Sub

    Private Sub Timer1_Elapsed(sender As Object, e As Timers.ElapsedEventArgs) Handles Timer1.Elapsed
        time_count += 1
        TEST.Text = time_count
    End Sub

    Private Sub ListViewItem_SelectedIndexChanged(sender As Object, e As EventArgs)
        If IsNothing(Me.ListViewItem.FocusedItem) Then
        ElseIf ListViewItem.FocusedItem.Index >= 0 Then
            If ListViewItem.Items.Count > 0 Then
                g_index = 0
                Dim index As Integer = ListViewItem.FocusedItem.Index
                g_index = index

            End If
        Else
            MessageBox.Show("An Error has halted thid process")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If count_product_ng = CDbl(Val(LB_SNP.Text)) Then
            TEXTBOX_COUNTER_PRODUCT_NG.Text = "0"
            count_product_ng = 0
            LB_BOX_NG.Text += 1
        ElseIf TEXTBOX_COUNTER_PRODUCT_NG.Text = "0" Then
            TEXTBOX_COUNTER_PRODUCT_NG.Text = "1"
        Else
            TEXTBOX_COUNTER_PRODUCT_NG.Text = count_product_ng
        End If
        Dim api = New api()
        Dim INSPECTION_TIME2 = (CDbl(Val(TEST.Text)) / 10)
        'MsgBox(DEFECT_ID(g_index))
        LB_QR_PRODUCT_NG.Text = LB_QR_PRODUCT.Text
        Dim index_ng As Integer = 0
        Dim check_index_ng As String = "NO_DATA"
        If LB_COUNTBOX.Text >= "1" Then
            If TEXTBOX_COUNTER_PRODUCT.Text = "0" Then
                TEXTBOX_COUNTER_PRODUCT.Text = CDbl(Val(LB_SNP.Text)) - 1
                'count_product -= TEXTBOX_COUNTER_PRODUCT.Text
                LB_COUNTBOX.Text -= 1
            Else
                TEXTBOX_COUNTER_PRODUCT.Text -= 1
                index_ng = TEXTBOX_COUNTER_PRODUCT.Text
            End If
            count_product_ng += 1
            TEXTBOX_COUNTER_PRODUCT_NG.Text = count_product_ng
            g_index_ng = (LOG_QR_PROD.Count() - del_g_index_ng)
            del_g_index_ng += 1
        End If

        If g_index_ng > 0 Then
            index_ng -= 1
            check_index_ng = "NO_ZERO"
        ElseIf g_index_ng = 0 Then
            index_ng = 0
            check_index_ng = "NO_ZERO"
        ElseIf count_product < 0 And LB_COUNTBOX.Text >= "1" Then
NEXT_NG:
            MsgBox("ไม่มี PRODUCT ให้ NG")
            LOG_QR_PROD = New ArrayList()
            Return
        End If
        If g_index_ng >= 0 And LB_COUNTBOX.Text >= "1" Then
            If check_index_ng <> "ZERO" Then
                LB_QR_PRODUCT_NG.Text = LOG_QR_PROD(CDbl(Val(g_index_ng)))
=======
                Dim result_check_qr_product = api.Load_data("http://192.168.161.102/QGATE/QGATE_CHECK_FA_TAG_SCAN/CHECK_QR_SCAN_DETAIL?QR_CODE=" & P_SCAN_PRODUCT)
                If result_check_qr_product = "0" Then
                    count_product += 1
                    TEXTBOX_COUNTER_PRODUCT.Text += 1
                    TEXTBOX_TOTAL_QTY.Text += 1 'TEST'
                    LB_QR_PRODUCT.Text = P_SCAN_PRODUCT
                    Dim INSPECTION_TIME = (CDbl(Val(TEST.Text)) / 10)
                    Dim result_insert = api.Load_data("http://192.168.161.102/QGATE/QGATE_Insert_data/INSERT_QR_SCAN_DETAIL?REF_FA=" & LB_HIDE_ID_REF_FA.Text & "&QR_PROM=" & P_SCAN_PRODUCT & "&USER_ID=" & Main.P_user_id & "&COUNT_QTY=" & TEXTBOX_COUNTER_PRODUCT.Text & "&BOX_NO=" & LB_COUNTBOX.Text & "&INSPECTION_TIME=" & INSPECTION_TIME & "&STATUS=NONG" & "&DEFECT_ID=" & "&RANK_P=" & LB_RANK_PRODUCT.Text)
                    x = New ListViewItem(CType(P_SCAN_PRODUCT, String))
                    ListView_Good.Items.Add(x)
                    Try
                        LOG_QR_PROD.Add(P_SCAN_PRODUCT)
                        If LOG_QR_PROD(count_product - 1) <> " " Then
                            LOG_QR_PROD(count_product - 1) = P_SCAN_PRODUCT
                        End If
                    Catch ex As Exception
                        LOG_QR_PROD.Add(P_SCAN_PRODUCT)
                    End Try

                    time_count = 0
                    TEST.Text = "0"
                    If result_insert = "0" Then
                        MsgBox("INSERT_QR_SCAN_DETAIL  FAILL ")
                    End If
                    If count_product = CDbl(Val(LB_SNP.Text)) Then
                        TEXTBOX_COUNTER_PRODUCT.Text = "0"
                        'count_product = 0
                        count_box += 1
                        LB_COUNTBOX.Text = (LB_COUNTBOX.Text + 1)
                        SCAN_PRODUCT.Visible = False
                        Button2.Visible = True
                        SCAN_PRODUCT.Visible = False
                        'Start_operation.Show()
                        'Me.Close()
                    End If
                Else
                    MsgBox("คุณเคยสแกนชิ้นงานไปแล้ว")
                End If
                SCAN_PRODUCT.Text = ""
                SCAN_PRODUCT.Focus()
                'check_box()
        End Select
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If LB_COUNTBOX.Text = Default_count_box And TEXTBOX_COUNTER_PRODUCT.Text = "0" Then
            GoTo alert_ng
        End If

        If LB_COUNTBOX.Text >= Default_count_box And TEXTBOX_COUNTER_PRODUCT.Text >= "0" Then
            ListViewItem.Items.Clear()
            DEFECT_ID = New ArrayList()
            Dim api = New api()
            Dim Raw = api.Load_data("http://192.168.161.102/QGATE/GET_FA_TAG_SCAN/LOAD_DATA_DEFECT_MASTER")
            'MsgBox(Raw)
            Dim dict As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(Raw)
            For Each item As Object In dict
                x = New ListViewItem(item("DEFECT_CODE").ToString())
                x.SubItems.Add(item("DEFECT_NAME").ToString())
                DEFECT_ID.Add(item("ID").ToString())
                ListViewItem.Items.Add(x)

            Next
            Panel_DEFECT.Visible = True
        Else
alert_ng:
            MsgBox("กรุณา สแกน QR CODE ตัวชิ้นงาน")
            Return
        End If
        SCAN_PRODUCT.Text = ""
        SCAN_PRODUCT.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim QR_PRODUCT As String = "REF_ID "
        Dim api = New api()
        If ListView_Good.Items.Count > 0 Then
            Dim x As Integer
            For x = 0 To ListView_Good.Items.Count - 1
                Try
                    Dim result_data = api.Load_data("http://192.168.161.102/QGATE/GET_FA_TAG_SCAN/GET_REF_ID?PROM_PRO=" & ListView_Good.Items(x).Text)
                    Dim dict As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(result_data)
                    For Each item As Object In dict
                        QR_PRODUCT &= item("ID").ToString() & " "
                    Next
                Catch ex As Exception
                    MsgBox("ERROR API ID")
                End Try
            Next
            ListView_Good.Clear()
        End If

        Print.Set_parameter_print(LB_PART_NO.Text, LB_PART_NAME.Text, LB_MODEL.Text, LB_LOT.Text, LB_COUNTBOX.Text, LB_SNP.Text, LB_Hide_QR_FA_SCAN.Text, LB_MAXBOX.Text, QR_PRODUCT, Default_count_box, TEXTBOX_COUNTER_PRODUCT.Text)
        Dim Start_o = New Start_operation()
        Start_o.Show()
        Me.Close()
    End Sub

    Private Sub Timer1_Elapsed(sender As Object, e As Timers.ElapsedEventArgs) Handles Timer1.Elapsed
        time_count += 1
        TEST.Text = time_count
    End Sub

    Private Sub ListViewItem_SelectedIndexChanged(sender As Object, e As EventArgs)
        If IsNothing(Me.ListViewItem.FocusedItem) Then
        ElseIf ListViewItem.FocusedItem.Index >= 0 Then
            If ListViewItem.Items.Count > 0 Then
                g_index = 0
                Dim index As Integer = ListViewItem.FocusedItem.Index
                g_index = index

            End If
        Else
            MessageBox.Show("An Error has halted thid process")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If count_product_ng = CDbl(Val(LB_SNP.Text)) Then
            TEXTBOX_COUNTER_PRODUCT_NG.Text = "0"
            count_product_ng = 0
            LB_BOX_NG.Text += 1
        ElseIf TEXTBOX_COUNTER_PRODUCT_NG.Text = "0" Then
            TEXTBOX_COUNTER_PRODUCT_NG.Text = "1"
        Else
            TEXTBOX_COUNTER_PRODUCT_NG.Text = count_product_ng
        End If
        Dim api = New api()
        Dim INSPECTION_TIME2 = (CDbl(Val(TEST.Text)) / 10)
        'MsgBox(DEFECT_ID(g_index))
        LB_QR_PRODUCT_NG.Text = LB_QR_PRODUCT.Text
        Dim index_ng As Integer = 0
        Dim check_index_ng As String = "NO_DATA"
        If LB_COUNTBOX.Text >= "1" Then
            If TEXTBOX_COUNTER_PRODUCT.Text = "0" Then
                TEXTBOX_COUNTER_PRODUCT.Text = CDbl(Val(LB_SNP.Text)) - 1
                'count_product -= TEXTBOX_COUNTER_PRODUCT.Text
                LB_COUNTBOX.Text -= 1
            Else
                TEXTBOX_COUNTER_PRODUCT.Text -= 1
                index_ng = TEXTBOX_COUNTER_PRODUCT.Text
            End If
            count_product_ng += 1
            TEXTBOX_COUNTER_PRODUCT_NG.Text = count_product_ng
            g_index_ng = (LOG_QR_PROD.Count() - del_g_index_ng)
            del_g_index_ng += 1
        End If

        If g_index_ng > 0 Then
            index_ng -= 1
            check_index_ng = "NO_ZERO"
        ElseIf g_index_ng = 0 Then
            index_ng = 0
            check_index_ng = "NO_ZERO"
        ElseIf count_product < 0 And LB_COUNTBOX.Text >= "1" Then
NEXT_NG:
            MsgBox("ไม่มี PRODUCT ให้ NG")
            LOG_QR_PROD = New ArrayList()
            Return
        End If
        If g_index_ng >= 0 And LB_COUNTBOX.Text >= "1" Then
            If check_index_ng <> "ZERO" Then
                LB_QR_PRODUCT_NG.Text = LOG_QR_PROD(CDbl(Val(g_index_ng)))
>>>>>>> parent of caa5b6a (update)
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
<<<<<<< HEAD
        Dim QR_PRODUCT_NG As String = ""
=======
        Dim QR_PRODUCT_NG As String = "REF_ID "
>>>>>>> parent of caa5b6a (update)
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

    Private Sub SCAN_FG_TAG_KeyDown_1(sender As Object, e As KeyEventArgs)

    End Sub
    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
<<<<<<< HEAD
        Dim QR_PRODUCT As String = ""
        Dim QR_PRODUCT_NG As String = ""
=======
        Dim QR_PRODUCT As String = "REF_ID "
        Dim QR_PRODUCT_NG As String = "REF_ID "
>>>>>>> parent of caa5b6a (update)
        Dim api = New api()
        If ListView_Good.Items.Count > 0 Then
            Dim x As Integer
            For x = 0 To ListView_Good.Items.Count - 1
                Try
                    Dim result_data = api.Load_data("http://192.168.161.102/QGATE/GET_FA_TAG_SCAN/GET_REF_ID?PROM_PRO=" & ListView_Good.Items(x).Text)
                    Dim dict As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(result_data)
                    For Each item As Object In dict
                        QR_PRODUCT &= item("ID").ToString() & " "
                    Next
                Catch ex As Exception
                    MsgBox("ERROR API ID")
                End Try
            Next
            ListView_Good.Clear()
        End If
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
        Print.Set_parameter_print(LB_PART_NO.Text, LB_PART_NAME.Text, LB_MODEL.Text, LB_LOT.Text, LB_COUNTBOX.Text, LB_SNP.Text, LB_Hide_QR_FA_SCAN.Text, LB_MAXBOX.Text, QR_PRODUCT, Default_count_box, TEXTBOX_COUNTER_PRODUCT.Text)
        If TEXTBOX_COUNTER_PRODUCT_NG.Text <> "0" Then
            Print_NG.Set_parameter_print(LB_PART_NO.Text, LB_PART_NAME.Text, LB_MODEL.Text, LB_LOT.Text, LB_BOX_NG.Text, TEXTBOX_COUNTER_PRODUCT_NG.Text, LB_Hide_QR_FA_SCAN.Text, LB_MAXBOX.Text, QR_PRODUCT_NG)
            ListView_NG.Clear()
        End If
        Dim Start_o = New Start_operation()
        Start_o.Show()
        Me.Close()
    End Sub

    Private Sub ListView_Good_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView_Good.SelectedIndexChanged

    End Sub
<<<<<<< HEAD
>>>>>>> parent of 43d3d74 (UPDATED)
=======
>>>>>>> parent of caa5b6a (update)
End Class