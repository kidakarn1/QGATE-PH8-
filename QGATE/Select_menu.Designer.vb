<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Select_menu
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LB_show_user_id = New System.Windows.Forms.Label()
        Me.user_image = New System.Windows.Forms.PictureBox()
        Me.BTN_exit = New System.Windows.Forms.Button()
        Me.BTN_edit_data = New System.Windows.Forms.Button()
        Me.BTN_start_operation = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BT1 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.user_image, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Coral
        Me.Label1.Location = New System.Drawing.Point(133, 192)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 35)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Welcome"
        '
        'LB_show_user_id
        '
        Me.LB_show_user_id.AutoSize = True
        Me.LB_show_user_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.LB_show_user_id.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_show_user_id.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LB_show_user_id.Location = New System.Drawing.Point(288, 192)
        Me.LB_show_user_id.Name = "LB_show_user_id"
        Me.LB_show_user_id.Size = New System.Drawing.Size(115, 35)
        Me.LB_show_user_id.TabIndex = 4
        Me.LB_show_user_id.Text = "XXXXX"
        '
        'user_image
        '
        Me.user_image.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.user_image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.user_image.Location = New System.Drawing.Point(156, 247)
        Me.user_image.Name = "user_image"
        Me.user_image.Size = New System.Drawing.Size(235, 316)
        Me.user_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.user_image.TabIndex = 5
        Me.user_image.TabStop = False
        '
        'BTN_exit
        '
        Me.BTN_exit.BackgroundImage = Global.QGATE.My.Resources.Resources._42
        Me.BTN_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_exit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_exit.FlatAppearance.BorderSize = 0
        Me.BTN_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_exit.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_exit.Location = New System.Drawing.Point(531, 511)
        Me.BTN_exit.Name = "BTN_exit"
        Me.BTN_exit.Size = New System.Drawing.Size(668, 225)
        Me.BTN_exit.TabIndex = 2
        Me.BTN_exit.UseVisualStyleBackColor = True
        '
        'BTN_edit_data
        '
        Me.BTN_edit_data.BackgroundImage = Global.QGATE.My.Resources.Resources._61
        Me.BTN_edit_data.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_edit_data.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_edit_data.FlatAppearance.BorderSize = 0
        Me.BTN_edit_data.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_edit_data.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_edit_data.Location = New System.Drawing.Point(531, 320)
        Me.BTN_edit_data.Name = "BTN_edit_data"
        Me.BTN_edit_data.Size = New System.Drawing.Size(668, 176)
        Me.BTN_edit_data.TabIndex = 1
        Me.BTN_edit_data.UseVisualStyleBackColor = True
        '
        'BTN_start_operation
        '
        Me.BTN_start_operation.BackgroundImage = Global.QGATE.My.Resources.Resources.nice1_21
        Me.BTN_start_operation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_start_operation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_start_operation.FlatAppearance.BorderSize = 0
        Me.BTN_start_operation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_start_operation.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_start_operation.Location = New System.Drawing.Point(531, 77)
        Me.BTN_start_operation.Name = "BTN_start_operation"
        Me.BTN_start_operation.Size = New System.Drawing.Size(668, 230)
        Me.BTN_start_operation.TabIndex = 0
        Me.BTN_start_operation.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTN_start_operation.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(102, 41)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(347, 715)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'BT1
        '
        Me.BT1.BackgroundImage = Global.QGATE.My.Resources.Resources.nice1
        Me.BT1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BT1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT1.FlatAppearance.BorderSize = 0
        Me.BT1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT1.Location = New System.Drawing.Point(531, 77)
        Me.BT1.Name = "BT1"
        Me.BT1.Size = New System.Drawing.Size(668, 230)
        Me.BT1.TabIndex = 7
        Me.BT1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BT1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.QGATE.My.Resources.Resources._91
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(531, 511)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(668, 225)
        Me.Button1.TabIndex = 9
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Select_menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1280, 800)
        Me.Controls.Add(Me.user_image)
        Me.Controls.Add(Me.LB_show_user_id)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTN_exit)
        Me.Controls.Add(Me.BTN_edit_data)
        Me.Controls.Add(Me.BTN_start_operation)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BT1)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Select_menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.user_image, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTN_start_operation As Button
    Friend WithEvents BTN_edit_data As Button
    Friend WithEvents BTN_exit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents LB_show_user_id As Label
    Friend WithEvents user_image As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BT1 As Button
    Friend WithEvents Button1 As Button
End Class
