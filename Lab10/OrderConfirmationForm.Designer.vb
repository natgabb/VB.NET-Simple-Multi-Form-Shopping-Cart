<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrderConfirmationForm
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
        Me.orderDetailsOutputLabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.totalCostLabel = New System.Windows.Forms.Label()
        Me.continueButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(230, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Order Sent!"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Order Details:"
        '
        'orderDetailsOutputLabel
        '
        Me.orderDetailsOutputLabel.BackColor = System.Drawing.SystemColors.ControlLight
        Me.orderDetailsOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.orderDetailsOutputLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.orderDetailsOutputLabel.Location = New System.Drawing.Point(105, 99)
        Me.orderDetailsOutputLabel.Name = "orderDetailsOutputLabel"
        Me.orderDetailsOutputLabel.Size = New System.Drawing.Size(343, 248)
        Me.orderDetailsOutputLabel.TabIndex = 2
        Me.orderDetailsOutputLabel.Text = "OrderDetailsOutputLabel" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "all items go here"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(144, 365)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 22)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "For a total of:"
        '
        'totalCostLabel
        '
        Me.totalCostLabel.BackColor = System.Drawing.SystemColors.ControlLight
        Me.totalCostLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.totalCostLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalCostLabel.Location = New System.Drawing.Point(280, 361)
        Me.totalCostLabel.Name = "totalCostLabel"
        Me.totalCostLabel.Size = New System.Drawing.Size(129, 29)
        Me.totalCostLabel.TabIndex = 4
        Me.totalCostLabel.Text = "totalCostLabel"
        Me.totalCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'continueButton
        '
        Me.continueButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.continueButton.Location = New System.Drawing.Point(220, 418)
        Me.continueButton.Name = "continueButton"
        Me.continueButton.Size = New System.Drawing.Size(113, 44)
        Me.continueButton.TabIndex = 5
        Me.continueButton.Text = "Continue"
        Me.continueButton.UseVisualStyleBackColor = True
        '
        'OrderConfirmationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(553, 484)
        Me.Controls.Add(Me.continueButton)
        Me.Controls.Add(Me.totalCostLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.orderDetailsOutputLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "OrderConfirmationForm"
        Me.Text = "Order Confirmation"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents orderDetailsOutputLabel As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents totalCostLabel As System.Windows.Forms.Label
    Friend WithEvents continueButton As System.Windows.Forms.Button
End Class
