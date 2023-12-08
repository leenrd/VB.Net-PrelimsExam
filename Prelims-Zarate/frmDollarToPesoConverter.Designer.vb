<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDollarToPesoConverter
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtdl = New System.Windows.Forms.TextBox()
        Me.txtps = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnclr = New System.Windows.Forms.Button()
        Me.btncvrt = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(84, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(380, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Dollar - Peso Converter"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(134, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(261, 34)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Instruction: Input the dollar value on the " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "textbox and click convert" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(162, 191)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 38)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "$"
        '
        'txtdl
        '
        Me.txtdl.Location = New System.Drawing.Point(198, 200)
        Me.txtdl.Name = "txtdl"
        Me.txtdl.Size = New System.Drawing.Size(145, 22)
        Me.txtdl.TabIndex = 3
        '
        'txtps
        '
        Me.txtps.Location = New System.Drawing.Point(198, 332)
        Me.txtps.Name = "txtps"
        Me.txtps.Size = New System.Drawing.Size(145, 22)
        Me.txtps.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(162, 324)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 38)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "₽"
        '
        'btnclr
        '
        Me.btnclr.Location = New System.Drawing.Point(179, 259)
        Me.btnclr.Name = "btnclr"
        Me.btnclr.Size = New System.Drawing.Size(75, 30)
        Me.btnclr.TabIndex = 6
        Me.btnclr.Text = "Clear"
        Me.btnclr.UseVisualStyleBackColor = True
        '
        'btncvrt
        '
        Me.btncvrt.Location = New System.Drawing.Point(277, 259)
        Me.btncvrt.Name = "btncvrt"
        Me.btncvrt.Size = New System.Drawing.Size(75, 30)
        Me.btncvrt.TabIndex = 7
        Me.btncvrt.Text = "Convert"
        Me.btncvrt.UseVisualStyleBackColor = True
        '
        'frmDollarToPesoConverter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(538, 450)
        Me.Controls.Add(Me.btncvrt)
        Me.Controls.Add(Me.btnclr)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtps)
        Me.Controls.Add(Me.txtdl)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmDollarToPesoConverter"
        Me.Text = "frmDollarToPesoConverter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtdl As TextBox
    Friend WithEvents txtps As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnclr As Button
    Friend WithEvents btncvrt As Button
End Class
