Public Class Print_NG
    Private part_no As String = "NO_DATA"
    Private PART_NAME As String = "NO_DATA"
    Private Model As String = "NO_DATA"
    Private LOT_NO As String = "NO_DATA"
    Private BOX_NO As Integer = 0
    Private SHIFT As String = "NO_DATA"
    Private QTY As String = "NO_DATA"
    Private LINE As String = "NO_DATA"
    Private CHECK_DATE As String = "NO_DATA"
    Private M_BOX As String = "NO_DATA"
    Private NEW_QR As String = "NO_DATA"
    Private box_seq As String = "NO_DATA"
    Private new_gen_qr As String = "NO_DATA"
    Private QR_PRODUCT As String = ""
    Private BOX_SEQ_NG As String = "NO_DATA"
    Private default_NG As String = "1000"
    Public Sub Set_parameter_print(LB_PART_NO As String, LB_PART_NAME As String, LB_MODEL As String, LB_LOT As String, LB_COUNTBOX As String, LB_SNP As String, LB_Hide_QR_FA_SCAN As String, max_box As String, QR_PRODUCT_SCAN As String)
        part_no = LB_PART_NO
        PART_NAME = LB_PART_NAME
        Model = LB_MODEL
        LOT_NO = LB_LOT
        BOX_NO = LB_COUNTBOX
        M_BOX = max_box
        SHIFT = "NO_DATA"
        QTY = LB_SNP
        LINE = LB_Hide_QR_FA_SCAN.Substring(2, 6)
        CHECK_DATE = "NO_DATA"
        NEW_QR = LB_Hide_QR_FA_SCAN.Substring(0, 100)
        BOX_SEQ_NG = CDbl(Val(default_NG)) - CDbl(Val(LB_COUNTBOX))
        new_gen_qr = NEW_QR & BOX_SEQ_NG
        QR_PRODUCT = QR_PRODUCT_SCAN
        PrintDocument1.Print()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim aPen = New Pen(Color.Black)
        aPen.Width = 3.0F  'border 

        'MsgBox(Label10.Text)

        'vertical

        e.Graphics.DrawLine(aPen, 80, 5, 80, 295)
        e.Graphics.DrawLine(aPen, 500, 5, 500, 200)
        e.Graphics.DrawLine(aPen, 400, 90, 400, 295)
        e.Graphics.DrawLine(aPen, 200, 200, 200, 295)
        'e.Graphics.DrawLine(aPen, 333, 200, 333, 295)


        e.Graphics.DrawLine(aPen, 540, 200, 540, 295)

        e.Graphics.DrawLine(aPen, 670, 5, 670, 295)





        'Horizontal

        e.Graphics.DrawLine(aPen, 80, 5, 670, 5)
        e.Graphics.DrawLine(aPen, 80, 40, 500, 40)
        e.Graphics.DrawLine(aPen, 80, 90, 500, 90)
        e.Graphics.DrawLine(aPen, 80, 140, 400, 140)

        e.Graphics.DrawLine(aPen, 500, 140, 670, 140) '

        e.Graphics.DrawLine(aPen, 80, 200, 670, 200)




        e.Graphics.DrawLine(aPen, 80, 250, 540, 250)
        e.Graphics.DrawLine(aPen, 80, 295, 670, 295)




        'TAG LAYOUT

        e.Graphics.DrawString("TBKK", Label5.Font, Brushes.Black, 10, 10)
        e.Graphics.DrawString("(Thailand) Co.,Ltd.", Label6.Font, Brushes.Black, 0, 40)

        e.Graphics.DrawString("Q GATE", Label7.Font, Brushes.Black, 10, 100)
        e.Graphics.DrawString("System", Label7.Font, Brushes.Black, 15, 120)

        e.Graphics.DrawString("To", Label1.Font, Brushes.Black, 102, 10)
        e.Graphics.DrawString("MITSUBISHI TURBOCHARGER ASIA Co., LTD. ", Label1.Font, Brushes.Black, 110, 25)
        e.Graphics.DrawString("PART NO.", Label1.Font, Brushes.Black, 90, 50)
        e.Graphics.DrawString(part_no, Label10.Font, Brushes.Black, 100, 60)
        e.Graphics.DrawString("PART NAME", Label1.Font, Brushes.Black, 90, 100)
        e.Graphics.DrawString(PART_NAME, Label1.Font, Brushes.Black, 102, 120)
        e.Graphics.DrawString("MODEL", Label1.Font, Brushes.Black, 90, 150)
        e.Graphics.DrawString(Model, Label8.Font, Brushes.Black, 102, 165)
        e.Graphics.DrawString("QTY", Label8.Font, Brushes.Black, 425, 100)
        e.Graphics.DrawString(QTY, Label12.Font, Brushes.Black, 420, 130)

        e.Graphics.DrawString("LOT NO.", Label1.Font, Brushes.Black, 90, 200)
        e.Graphics.DrawString(LOT_NO, Label8.Font, Brushes.Black, 100, 220)

        e.Graphics.DrawString("BOX NO.", Label1.Font, Brushes.Black, 200, 200)
        e.Graphics.DrawString(BOX_NO & "/" & M_BOX, Label8.Font, Brushes.Black, 235, 220)

        e.Graphics.DrawString("LINE", Label1.Font, Brushes.Black, 405, 200)
        e.Graphics.DrawString(LINE, Label8.Font, Brushes.Black, 415, 220)

        e.Graphics.DrawString("WASHING DATE", Label1.Font, Brushes.Black, 505, 145)
        e.Graphics.DrawString("22/02/2021", Label8.Font, Brushes.Black, 505, 170)

        e.Graphics.DrawString("PHASE", Label1.Font, Brushes.Black, 90, 252)
        e.Graphics.DrawString("8", Label8.Font, Brushes.Black, 125, 265)

        e.Graphics.DrawString("SHIFT", Label1.Font, Brushes.Black, 200, 252)
        e.Graphics.DrawString("A", Label2.Font, Brushes.Black, 255, 265)

        e.Graphics.DrawString("PROCESS", Label1.Font, Brushes.Black, 405, 252)
        e.Graphics.DrawString("Q-GATE", Label9.Font, Brushes.Black, 420, 265)

        e.Graphics.DrawString("Info", Label1.Font, Brushes.Black, 545, 200)
        'e.Graphics.DrawString("K2M133", Label2.Font, Brushes.Black, 490, 265)

        Dim qrcode As New MessagingToolkit.QRCode.Codec.QRCodeEncoder
        Dim qr = "TESTTTTT"
        qrcode.QRCodeScale = 10
        Dim bitmap_qr_box As Bitmap = qrcode.Encode(new_gen_qr)
        Dim bitmap_qr_product As Bitmap = qrcode.Encode(QR_PRODUCT)
        e.Graphics.DrawString("NG", Label13.Font, Brushes.Black, 510, 20)
        ' e.Graphics.DrawImage(bitmap_qr_box, 532, 20, 115, 115) 'TOP
        e.Graphics.DrawImage(bitmap_qr_box, 0, 210, 75, 75) 'left
        e.Graphics.DrawImage(bitmap_qr_product, 570, 220, 70, 70) 'button right
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class