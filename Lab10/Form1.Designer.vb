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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.item1Label = New System.Windows.Forms.Label()
        Me.item2Label = New System.Windows.Forms.Label()
        Me.item3Label = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.item1PriceLabel = New System.Windows.Forms.Label()
        Me.item2PriceLabel = New System.Windows.Forms.Label()
        Me.item3PriceLabel = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.item1TextBox = New System.Windows.Forms.TextBox()
        Me.item2TextBox = New System.Windows.Forms.TextBox()
        Me.item3TextBox = New System.Windows.Forms.TextBox()
        Me.addToCartButton = New System.Windows.Forms.Button()
        Me.clearSelectedButton = New System.Windows.Forms.Button()
        Me.viewCartButton = New System.Windows.Forms.Button()
        Me.quitButton = New System.Windows.Forms.Button()
        Me.item3PictureBox = New System.Windows.Forms.PictureBox()
        Me.item2PictureBox = New System.Windows.Forms.PictureBox()
        Me.item1PictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.item3PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.item2PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.item1PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(114, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(362, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select the items you would like to add to your cart."
        '
        'item1Label
        '
        Me.item1Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.item1Label.Location = New System.Drawing.Point(182, 144)
        Me.item1Label.Name = "item1Label"
        Me.item1Label.Size = New System.Drawing.Size(146, 64)
        Me.item1Label.TabIndex = 4
        Me.item1Label.Text = "Name"
        '
        'item2Label
        '
        Me.item2Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.item2Label.Location = New System.Drawing.Point(182, 260)
        Me.item2Label.Name = "item2Label"
        Me.item2Label.Size = New System.Drawing.Size(146, 67)
        Me.item2Label.TabIndex = 5
        Me.item2Label.Text = "Name"
        '
        'item3Label
        '
        Me.item3Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.item3Label.Location = New System.Drawing.Point(182, 373)
        Me.item3Label.Name = "item3Label"
        Me.item3Label.Size = New System.Drawing.Size(146, 73)
        Me.item3Label.TabIndex = 6
        Me.item3Label.Text = "Name"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(182, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 30)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(341, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 30)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Price"
        '
        'item1PriceLabel
        '
        Me.item1PriceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.item1PriceLabel.Location = New System.Drawing.Point(341, 144)
        Me.item1PriceLabel.Name = "item1PriceLabel"
        Me.item1PriceLabel.Size = New System.Drawing.Size(82, 32)
        Me.item1PriceLabel.TabIndex = 9
        Me.item1PriceLabel.Text = "Price"
        '
        'item2PriceLabel
        '
        Me.item2PriceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.item2PriceLabel.Location = New System.Drawing.Point(341, 258)
        Me.item2PriceLabel.Name = "item2PriceLabel"
        Me.item2PriceLabel.Size = New System.Drawing.Size(82, 30)
        Me.item2PriceLabel.TabIndex = 10
        Me.item2PriceLabel.Text = "Price"
        '
        'item3PriceLabel
        '
        Me.item3PriceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.item3PriceLabel.Location = New System.Drawing.Point(341, 372)
        Me.item3PriceLabel.Name = "item3PriceLabel"
        Me.item3PriceLabel.Size = New System.Drawing.Size(82, 22)
        Me.item3PriceLabel.TabIndex = 11
        Me.item3PriceLabel.Text = "Price"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(451, 74)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 30)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Quantity"
        '
        'item1TextBox
        '
        Me.item1TextBox.Location = New System.Drawing.Point(469, 144)
        Me.item1TextBox.Name = "item1TextBox"
        Me.item1TextBox.Size = New System.Drawing.Size(36, 20)
        Me.item1TextBox.TabIndex = 0
        '
        'item2TextBox
        '
        Me.item2TextBox.Location = New System.Drawing.Point(469, 258)
        Me.item2TextBox.Name = "item2TextBox"
        Me.item2TextBox.Size = New System.Drawing.Size(36, 20)
        Me.item2TextBox.TabIndex = 1
        '
        'item3TextBox
        '
        Me.item3TextBox.Location = New System.Drawing.Point(469, 374)
        Me.item3TextBox.Name = "item3TextBox"
        Me.item3TextBox.Size = New System.Drawing.Size(36, 20)
        Me.item3TextBox.TabIndex = 2
        '
        'addToCartButton
        '
        Me.addToCartButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addToCartButton.Location = New System.Drawing.Point(37, 488)
        Me.addToCartButton.Name = "addToCartButton"
        Me.addToCartButton.Size = New System.Drawing.Size(106, 47)
        Me.addToCartButton.TabIndex = 3
        Me.addToCartButton.Text = "Add To Cart"
        Me.addToCartButton.UseVisualStyleBackColor = True
        '
        'clearSelectedButton
        '
        Me.clearSelectedButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearSelectedButton.Location = New System.Drawing.Point(311, 488)
        Me.clearSelectedButton.Name = "clearSelectedButton"
        Me.clearSelectedButton.Size = New System.Drawing.Size(106, 47)
        Me.clearSelectedButton.TabIndex = 5
        Me.clearSelectedButton.Text = "Clear"
        Me.clearSelectedButton.UseVisualStyleBackColor = True
        '
        'viewCartButton
        '
        Me.viewCartButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewCartButton.Location = New System.Drawing.Point(174, 488)
        Me.viewCartButton.Name = "viewCartButton"
        Me.viewCartButton.Size = New System.Drawing.Size(106, 47)
        Me.viewCartButton.TabIndex = 4
        Me.viewCartButton.Text = "View Cart"
        Me.viewCartButton.UseVisualStyleBackColor = True
        '
        'quitButton
        '
        Me.quitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.quitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quitButton.Location = New System.Drawing.Point(448, 488)
        Me.quitButton.Name = "quitButton"
        Me.quitButton.Size = New System.Drawing.Size(106, 47)
        Me.quitButton.TabIndex = 6
        Me.quitButton.Text = "Quit"
        Me.quitButton.UseVisualStyleBackColor = True
        '
        'item3PictureBox
        '
        Me.item3PictureBox.Location = New System.Drawing.Point(50, 346)
        Me.item3PictureBox.Name = "item3PictureBox"
        Me.item3PictureBox.Size = New System.Drawing.Size(111, 100)
        Me.item3PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.item3PictureBox.TabIndex = 3
        Me.item3PictureBox.TabStop = False
        '
        'item2PictureBox
        '
        Me.item2PictureBox.Location = New System.Drawing.Point(50, 227)
        Me.item2PictureBox.Name = "item2PictureBox"
        Me.item2PictureBox.Size = New System.Drawing.Size(111, 100)
        Me.item2PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.item2PictureBox.TabIndex = 2
        Me.item2PictureBox.TabStop = False
        '
        'item1PictureBox
        '
        Me.item1PictureBox.Location = New System.Drawing.Point(50, 108)
        Me.item1PictureBox.Name = "item1PictureBox"
        Me.item1PictureBox.Size = New System.Drawing.Size(111, 100)
        Me.item1PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.item1PictureBox.TabIndex = 1
        Me.item1PictureBox.TabStop = False
        '
        'Form1
        '
        Me.AcceptButton = Me.addToCartButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.quitButton
        Me.ClientSize = New System.Drawing.Size(591, 591)
        Me.Controls.Add(Me.quitButton)
        Me.Controls.Add(Me.viewCartButton)
        Me.Controls.Add(Me.clearSelectedButton)
        Me.Controls.Add(Me.addToCartButton)
        Me.Controls.Add(Me.item3TextBox)
        Me.Controls.Add(Me.item2TextBox)
        Me.Controls.Add(Me.item1TextBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.item3PriceLabel)
        Me.Controls.Add(Me.item2PriceLabel)
        Me.Controls.Add(Me.item1PriceLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.item3Label)
        Me.Controls.Add(Me.item2Label)
        Me.Controls.Add(Me.item1Label)
        Me.Controls.Add(Me.item3PictureBox)
        Me.Controls.Add(Me.item2PictureBox)
        Me.Controls.Add(Me.item1PictureBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Gabbamonte Food Mart"
        CType(Me.item3PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.item2PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.item1PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents item1PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents item2PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents item3PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents item1Label As System.Windows.Forms.Label
    Friend WithEvents item2Label As System.Windows.Forms.Label
    Friend WithEvents item3Label As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents item1PriceLabel As System.Windows.Forms.Label
    Friend WithEvents item2PriceLabel As System.Windows.Forms.Label
    Friend WithEvents item3PriceLabel As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents item1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents item2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents item3TextBox As System.Windows.Forms.TextBox
    Friend WithEvents addToCartButton As System.Windows.Forms.Button
    Friend WithEvents clearSelectedButton As System.Windows.Forms.Button
    Friend WithEvents viewCartButton As System.Windows.Forms.Button
    Friend WithEvents quitButton As System.Windows.Forms.Button

End Class
