<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalesTaxApplication
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSalesTaxApplication))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtaos = New System.Windows.Forms.TextBox()
        Me.btncalc = New System.Windows.Forms.Button()
        Me.btnclr = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(69, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(404, 41)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Value Added Tax Calculator"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(85, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(368, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Instructions: Input the amount of sales and Click calculate"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(197, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(158, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Amount of Sales:"
        '
        'txtaos
        '
        Me.txtaos.Location = New System.Drawing.Point(169, 225)
        Me.txtaos.Name = "txtaos"
        Me.txtaos.Size = New System.Drawing.Size(210, 22)
        Me.txtaos.TabIndex = 3
        '
        'btncalc
        '
        Me.btncalc.Location = New System.Drawing.Point(169, 267)
        Me.btncalc.Name = "btncalc"
        Me.btncalc.Size = New System.Drawing.Size(98, 46)
        Me.btncalc.TabIndex = 4
        Me.btncalc.Text = "Calculate VAT(12%)"
        Me.btncalc.UseVisualStyleBackColor = True
        '
        'btnclr
        '
        Me.btnclr.Location = New System.Drawing.Point(286, 267)
        Me.btnclr.Name = "btnclr"
        Me.btnclr.Size = New System.Drawing.Size(93, 46)
        Me.btnclr.TabIndex = 5
        Me.btnclr.Text = "Clear"
        Me.btnclr.UseVisualStyleBackColor = True
        '
        'frmSalesTaxApplication
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(554, 437)
        Me.Controls.Add(Me.btnclr)
        Me.Controls.Add(Me.btncalc)
        Me.Controls.Add(Me.txtaos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSalesTaxApplication"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSalesTaxApplication"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtaos As TextBox
    Friend WithEvents btncalc As Button
    Friend WithEvents btnclr As Button
End Class
