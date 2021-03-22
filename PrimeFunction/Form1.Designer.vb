<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblHighest = New System.Windows.Forms.Label()
        Me.btnFactor = New System.Windows.Forms.Button()
        Me.lstFactors = New System.Windows.Forms.ListBox()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblIntro = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblHighest
        '
        Me.lblHighest.Location = New System.Drawing.Point(13, 253)
        Me.lblHighest.Name = "lblHighest"
        Me.lblHighest.Size = New System.Drawing.Size(120, 46)
        Me.lblHighest.TabIndex = 0
        Me.lblHighest.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnFactor
        '
        Me.btnFactor.BackColor = System.Drawing.Color.Green
        Me.btnFactor.Location = New System.Drawing.Point(36, 302)
        Me.btnFactor.Name = "btnFactor"
        Me.btnFactor.Size = New System.Drawing.Size(75, 23)
        Me.btnFactor.TabIndex = 1
        Me.btnFactor.Text = "Factor!"
        Me.btnFactor.UseVisualStyleBackColor = False
        '
        'lstFactors
        '
        Me.lstFactors.FormattingEnabled = True
        Me.lstFactors.ItemHeight = 15
        Me.lstFactors.Location = New System.Drawing.Point(13, 77)
        Me.lstFactors.Name = "lstFactors"
        Me.lstFactors.Size = New System.Drawing.Size(120, 109)
        Me.lstFactors.TabIndex = 2
        '
        'txtNumber
        '
        Me.txtNumber.Location = New System.Drawing.Point(13, 33)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(120, 23)
        Me.txtNumber.TabIndex = 3
        Me.txtNumber.Text = "600851475143"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "The prime factors of:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(60, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "are:"
        '
        'lblIntro
        '
        Me.lblIntro.AutoSize = True
        Me.lblIntro.Location = New System.Drawing.Point(12, 189)
        Me.lblIntro.Name = "lblIntro"
        Me.lblIntro.Size = New System.Drawing.Size(0, 15)
        Me.lblIntro.TabIndex = 6
        Me.lblIntro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Red
        Me.btnExit.Location = New System.Drawing.Point(36, 332)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit!"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(147, 367)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblIntro)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.lstFactors)
        Me.Controls.Add(Me.btnFactor)
        Me.Controls.Add(Me.lblHighest)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.Text = "Prime Factors"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHighest As Label
    Friend WithEvents btnFactor As Button
    Friend WithEvents lstFactors As ListBox
    Friend WithEvents txtNumber As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblIntro As Label
    Friend WithEvents btnExit As Button
End Class
