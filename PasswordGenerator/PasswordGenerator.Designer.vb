<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PasswordGenerator
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
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkUpper = New System.Windows.Forms.CheckBox()
        Me.chkLower = New System.Windows.Forms.CheckBox()
        Me.chkNumbers = New System.Windows.Forms.CheckBox()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(60, 210)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(164, 23)
        Me.btnGenerate.TabIndex = 0
        Me.btnGenerate.Text = "Generate Password"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(60, 101)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.Size = New System.Drawing.Size(164, 22)
        Me.txtOutput.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(72, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Length of Password"
        '
        'chkUpper
        '
        Me.chkUpper.AutoSize = True
        Me.chkUpper.Location = New System.Drawing.Point(73, 129)
        Me.chkUpper.Name = "chkUpper"
        Me.chkUpper.Size = New System.Drawing.Size(142, 21)
        Me.chkUpper.TabIndex = 4
        Me.chkUpper.Text = "Upper Characters"
        Me.chkUpper.UseVisualStyleBackColor = True
        '
        'chkLower
        '
        Me.chkLower.AutoSize = True
        Me.chkLower.Location = New System.Drawing.Point(74, 156)
        Me.chkLower.Name = "chkLower"
        Me.chkLower.Size = New System.Drawing.Size(141, 21)
        Me.chkLower.TabIndex = 5
        Me.chkLower.Text = "Lower Characters"
        Me.chkLower.UseVisualStyleBackColor = True
        '
        'chkNumbers
        '
        Me.chkNumbers.AutoSize = True
        Me.chkNumbers.Location = New System.Drawing.Point(74, 183)
        Me.chkNumbers.Name = "chkNumbers"
        Me.chkNumbers.Size = New System.Drawing.Size(87, 21)
        Me.chkNumbers.TabIndex = 6
        Me.chkNumbers.Text = "Numbers"
        Me.chkNumbers.UseVisualStyleBackColor = True
        '
        'txtNumber
        '
        Me.txtNumber.Location = New System.Drawing.Point(122, 38)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(31, 22)
        Me.txtNumber.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(57, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Generate Your Password"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 253)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.chkNumbers)
        Me.Controls.Add(Me.chkLower)
        Me.Controls.Add(Me.chkUpper)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.btnGenerate)
        Me.Name = "Form1"
        Me.Text = "Password Generator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGenerate As Button
    Friend WithEvents txtOutput As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents chkUpper As CheckBox
    Friend WithEvents chkLower As CheckBox
    Friend WithEvents chkNumbers As CheckBox
    Friend WithEvents txtNumber As TextBox
    Friend WithEvents Label2 As Label
End Class
