<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGradingApplication
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGradingApplication))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtww = New System.Windows.Forms.TextBox()
        Me.txtpt = New System.Windows.Forms.TextBox()
        Me.txtqe = New System.Windows.Forms.TextBox()
        Me.btncalc = New System.Windows.Forms.Button()
        Me.btnclr = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(92, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(356, 51)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Grading Calculator"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(66, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(412, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Instructions: Input the grades in the textboxes and click calculate" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(96, 199)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(196, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Written Works (20%):"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(70, 240)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(222, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Performance Task (60%):"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(86, 282)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(206, 25)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Quarterly Exam (20%):"
        '
        'txtww
        '
        Me.txtww.Location = New System.Drawing.Point(307, 202)
        Me.txtww.Name = "txtww"
        Me.txtww.Size = New System.Drawing.Size(130, 22)
        Me.txtww.TabIndex = 5
        '
        'txtpt
        '
        Me.txtpt.Location = New System.Drawing.Point(307, 244)
        Me.txtpt.Name = "txtpt"
        Me.txtpt.Size = New System.Drawing.Size(130, 22)
        Me.txtpt.TabIndex = 6
        '
        'txtqe
        '
        Me.txtqe.Location = New System.Drawing.Point(307, 286)
        Me.txtqe.Name = "txtqe"
        Me.txtqe.Size = New System.Drawing.Size(130, 22)
        Me.txtqe.TabIndex = 7
        '
        'btncalc
        '
        Me.btncalc.Location = New System.Drawing.Point(305, 351)
        Me.btncalc.Name = "btncalc"
        Me.btncalc.Size = New System.Drawing.Size(132, 28)
        Me.btncalc.TabIndex = 8
        Me.btncalc.Text = "Calculate"
        Me.btncalc.UseVisualStyleBackColor = True
        '
        'btnclr
        '
        Me.btnclr.Location = New System.Drawing.Point(162, 351)
        Me.btnclr.Name = "btnclr"
        Me.btnclr.Size = New System.Drawing.Size(130, 30)
        Me.btnclr.TabIndex = 9
        Me.btnclr.Text = "Clear"
        Me.btnclr.UseVisualStyleBackColor = True
        '
        'frmGradingApplication
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(542, 450)
        Me.Controls.Add(Me.btnclr)
        Me.Controls.Add(Me.btncalc)
        Me.Controls.Add(Me.txtqe)
        Me.Controls.Add(Me.txtpt)
        Me.Controls.Add(Me.txtww)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmGradingApplication"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmGradingApplication"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtww As TextBox
    Friend WithEvents txtpt As TextBox
    Friend WithEvents txtqe As TextBox
    Friend WithEvents btncalc As Button
    Friend WithEvents btnclr As Button
End Class
