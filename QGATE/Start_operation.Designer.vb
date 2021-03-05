<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Start_operation
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.SCAN_FG_TAG = New System.Windows.Forms.TextBox()
        Me.LB_show_user_id = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel_FIFO = New System.Windows.Forms.Panel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.ListViewItem = New System.Windows.Forms.ListView()
        Me.LOT_NO = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.QTY = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Button4 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel_FIFO.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SCAN_FG_TAG
        '
        Me.SCAN_FG_TAG.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.SCAN_FG_TAG.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SCAN_FG_TAG.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SCAN_FG_TAG.ForeColor = System.Drawing.Color.White
        Me.SCAN_FG_TAG.Location = New System.Drawing.Point(429, 403)
        Me.SCAN_FG_TAG.Name = "SCAN_FG_TAG"
        Me.SCAN_FG_TAG.Size = New System.Drawing.Size(479, 73)
        Me.SCAN_FG_TAG.TabIndex = 0
        Me.SCAN_FG_TAG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LB_show_user_id
        '
        Me.LB_show_user_id.AutoSize = True
        Me.LB_show_user_id.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_show_user_id.ForeColor = System.Drawing.Color.White
        Me.LB_show_user_id.Location = New System.Drawing.Point(1097, 37)
        Me.LB_show_user_id.Name = "LB_show_user_id"
        Me.LB_show_user_id.Size = New System.Drawing.Size(115, 35)
        Me.LB_show_user_id.TabIndex = 6
        Me.LB_show_user_id.Text = "XXXXX"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Coral
        Me.Label2.Location = New System.Drawing.Point(949, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 35)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Welcome"
        '
        'Panel_FIFO
        '
        Me.Panel_FIFO.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Panel_FIFO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel_FIFO.Controls.Add(Me.PictureBox4)
        Me.Panel_FIFO.Controls.Add(Me.Label17)
        Me.Panel_FIFO.Controls.Add(Me.ListViewItem)
        Me.Panel_FIFO.Controls.Add(Me.Button4)
        Me.Panel_FIFO.Location = New System.Drawing.Point(166, 75)
        Me.Panel_FIFO.Name = "Panel_FIFO"
        Me.Panel_FIFO.Size = New System.Drawing.Size(971, 680)
        Me.Panel_FIFO.TabIndex = 38
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = Global.QGATE.My.Resources.Resources._16
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Location = New System.Drawing.Point(76, 73)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(799, 49)
        Me.PictureBox4.TabIndex = 42
        Me.PictureBox4.TabStop = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 35.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Tomato
        Me.Label17.Location = New System.Drawing.Point(382, 12)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(211, 58)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = " F I F O "
        '
        'ListViewItem
        '
        Me.ListViewItem.BackColor = System.Drawing.Color.White
        Me.ListViewItem.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListViewItem.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.LOT_NO, Me.QTY})
        Me.ListViewItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListViewItem.FullRowSelect = True
        Me.ListViewItem.HideSelection = False
        Me.ListViewItem.Location = New System.Drawing.Point(86, 73)
        Me.ListViewItem.Name = "ListViewItem"
        Me.ListViewItem.Size = New System.Drawing.Size(789, 456)
        Me.ListViewItem.TabIndex = 1
        Me.ListViewItem.UseCompatibleStateImageBehavior = False
        Me.ListViewItem.View = System.Windows.Forms.View.Details
        '
        'LOT_NO
        '
        Me.LOT_NO.Text = "LOT_NO"
        Me.LOT_NO.Width = 375
        '
        'QTY
        '
        Me.QTY.Text = "QTY"
        Me.QTY.Width = 400
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Black
        Me.Button4.BackgroundImage = Global.QGATE.My.Resources.Resources._12
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button4.Location = New System.Drawing.Point(656, 543)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(219, 85)
        Me.Button4.TabIndex = 34
        Me.Button4.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.QGATE.My.Resources.Resources._13
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(131, 100)
        Me.PictureBox2.TabIndex = 43
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.QGATE.My.Resources.Resources._14
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(230, 371)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(789, 141)
        Me.PictureBox3.TabIndex = 41
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.QGATE.My.Resources.Resources._15
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(193, 250)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(888, 106)
        Me.PictureBox1.TabIndex = 39
        Me.PictureBox1.TabStop = False
        '
        'Start_operation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1280, 800)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Panel_FIFO)
        Me.Controls.Add(Me.SCAN_FG_TAG)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LB_show_user_id)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Start_operation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel_FIFO.ResumeLayout(False)
        Me.Panel_FIFO.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SCAN_FG_TAG As TextBox
    Friend WithEvents LB_show_user_id As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel_FIFO As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents ListViewItem As ListView
    Friend WithEvents LOT_NO As ColumnHeader
    Friend WithEvents QTY As ColumnHeader
    Friend WithEvents Label17 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
