<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ADD_USER
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TUSER_ID = New System.Windows.Forms.TextBox()
        Me.TLNAME = New System.Windows.Forms.TextBox()
        Me.TFNAME = New System.Windows.Forms.TextBox()
        Me.CODE_USER = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LB_show_user_id = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TUSER_ID
        '
        Me.TUSER_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TUSER_ID.Location = New System.Drawing.Point(884, 180)
        Me.TUSER_ID.Name = "TUSER_ID"
        Me.TUSER_ID.Size = New System.Drawing.Size(301, 62)
        Me.TUSER_ID.TabIndex = 0
        '
        'TLNAME
        '
        Me.TLNAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TLNAME.Location = New System.Drawing.Point(884, 304)
        Me.TLNAME.Name = "TLNAME"
        Me.TLNAME.Size = New System.Drawing.Size(301, 62)
        Me.TLNAME.TabIndex = 1
        '
        'TFNAME
        '
        Me.TFNAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TFNAME.Location = New System.Drawing.Point(254, 296)
        Me.TFNAME.Name = "TFNAME"
        Me.TFNAME.Size = New System.Drawing.Size(301, 62)
        Me.TFNAME.TabIndex = 1
        '
        'CODE_USER
        '
        Me.CODE_USER.AutoSize = True
        Me.CODE_USER.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CODE_USER.ForeColor = System.Drawing.Color.White
        Me.CODE_USER.Location = New System.Drawing.Point(680, 192)
        Me.CODE_USER.Name = "CODE_USER"
        Me.CODE_USER.Size = New System.Drawing.Size(198, 42)
        Me.CODE_USER.TabIndex = 4
        Me.CODE_USER.Text = "USER_ID :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(79, 316)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 42)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "FNAME :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(685, 316)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(167, 42)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "LNAME :"
        '
        'LB_show_user_id
        '
        Me.LB_show_user_id.AutoSize = True
        Me.LB_show_user_id.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_show_user_id.ForeColor = System.Drawing.Color.White
        Me.LB_show_user_id.Location = New System.Drawing.Point(1081, 32)
        Me.LB_show_user_id.Name = "LB_show_user_id"
        Me.LB_show_user_id.Size = New System.Drawing.Size(115, 35)
        Me.LB_show_user_id.TabIndex = 9
        Me.LB_show_user_id.Text = "XXXXX"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Coral
        Me.Label2.Location = New System.Drawing.Point(933, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 35)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Welcome"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button3.BackgroundImage = Global.QGATE.My.Resources.Resources._17
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.Location = New System.Drawing.Point(33, 638)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(215, 82)
        Me.Button3.TabIndex = 36
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.BackgroundImage = Global.QGATE.My.Resources.Resources._12
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(1007, 638)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(215, 82)
        Me.Button1.TabIndex = 37
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ADD_USER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1264, 761)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.LB_show_user_id)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CODE_USER)
        Me.Controls.Add(Me.TFNAME)
        Me.Controls.Add(Me.TLNAME)
        Me.Controls.Add(Me.TUSER_ID)
        Me.Name = "ADD_USER"
        Me.Text = "ADD_USER"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TUSER_ID As TextBox
    Friend WithEvents TLNAME As TextBox
    Friend WithEvents TFNAME As TextBox
    Friend WithEvents CODE_USER As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LB_show_user_id As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
End Class
