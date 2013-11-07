<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShoppingCartForm
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
        Me.listOfItemsBox = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.placeOrderButton = New System.Windows.Forms.Button()
        Me.quitButton = New System.Windows.Forms.Button()
        Me.refreshButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.totalCostLabel = New System.Windows.Forms.Label()
        Me.removeItemButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'listOfItemsBox
        '
        Me.listOfItemsBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listOfItemsBox.FormattingEnabled = True
        Me.listOfItemsBox.ItemHeight = 20
        Me.listOfItemsBox.Location = New System.Drawing.Point(43, 45)
        Me.listOfItemsBox.Name = "listOfItemsBox"
        Me.listOfItemsBox.Size = New System.Drawing.Size(486, 264)
        Me.listOfItemsBox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(43, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(485, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Your shopping cart:"
        '
        'placeOrderButton
        '
        Me.placeOrderButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.placeOrderButton.Location = New System.Drawing.Point(154, 396)
        Me.placeOrderButton.Name = "placeOrderButton"
        Me.placeOrderButton.Size = New System.Drawing.Size(114, 47)
        Me.placeOrderButton.TabIndex = 2
        Me.placeOrderButton.Text = "Place Order"
        Me.placeOrderButton.UseVisualStyleBackColor = True
        '
        'quitButton
        '
        Me.quitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quitButton.Location = New System.Drawing.Point(434, 396)
        Me.quitButton.Name = "quitButton"
        Me.quitButton.Size = New System.Drawing.Size(114, 47)
        Me.quitButton.TabIndex = 3
        Me.quitButton.Text = "Quit"
        Me.quitButton.UseVisualStyleBackColor = True
        '
        'refreshButton
        '
        Me.refreshButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.refreshButton.Location = New System.Drawing.Point(294, 396)
        Me.refreshButton.Name = "refreshButton"
        Me.refreshButton.Size = New System.Drawing.Size(114, 47)
        Me.refreshButton.TabIndex = 4
        Me.refreshButton.Text = "Refresh"
        Me.refreshButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(162, 343)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Total Cost:"
        '
        'totalCostLabel
        '
        Me.totalCostLabel.AutoSize = True
        Me.totalCostLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalCostLabel.Location = New System.Drawing.Point(290, 343)
        Me.totalCostLabel.Name = "totalCostLabel"
        Me.totalCostLabel.Size = New System.Drawing.Size(110, 20)
        Me.totalCostLabel.TabIndex = 6
        Me.totalCostLabel.Text = "total cost here"
        '
        'removeItemButton
        '
        Me.removeItemButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.removeItemButton.Location = New System.Drawing.Point(14, 396)
        Me.removeItemButton.Name = "removeItemButton"
        Me.removeItemButton.Size = New System.Drawing.Size(114, 47)
        Me.removeItemButton.TabIndex = 7
        Me.removeItemButton.Text = "Remove"
        Me.removeItemButton.UseVisualStyleBackColor = True
        '
        'ShoppingCartForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(562, 467)
        Me.Controls.Add(Me.removeItemButton)
        Me.Controls.Add(Me.totalCostLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.refreshButton)
        Me.Controls.Add(Me.quitButton)
        Me.Controls.Add(Me.placeOrderButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.listOfItemsBox)
        Me.Name = "ShoppingCartForm"
        Me.Text = "Your Shopping Cart"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents listOfItemsBox As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents placeOrderButton As System.Windows.Forms.Button
    Friend WithEvents quitButton As System.Windows.Forms.Button
    Friend WithEvents refreshButton As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents totalCostLabel As System.Windows.Forms.Label
    Friend WithEvents removeItemButton As System.Windows.Forms.Button
End Class
