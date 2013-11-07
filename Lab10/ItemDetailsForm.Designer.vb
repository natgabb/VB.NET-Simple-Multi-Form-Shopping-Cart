<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ItemDetailsForm
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
        Me.itemPictureBox = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.itemNameLabel = New System.Windows.Forms.Label()
        Me.itemPriceLabel = New System.Windows.Forms.Label()
        Me.itemDescriptionLabel = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.itemInStockLabel = New System.Windows.Forms.Label()
        CType(Me.itemPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'itemPictureBox
        '
        Me.itemPictureBox.Location = New System.Drawing.Point(96, 11)
        Me.itemPictureBox.Name = "itemPictureBox"
        Me.itemPictureBox.Size = New System.Drawing.Size(350, 250)
        Me.itemPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.itemPictureBox.TabIndex = 0
        Me.itemPictureBox.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(103, 283)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 35)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(103, 323)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 35)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Price:"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(103, 403)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 35)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Description:"
        '
        'itemNameLabel
        '
        Me.itemNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.itemNameLabel.Location = New System.Drawing.Point(230, 283)
        Me.itemNameLabel.Name = "itemNameLabel"
        Me.itemNameLabel.Size = New System.Drawing.Size(216, 35)
        Me.itemNameLabel.TabIndex = 4
        Me.itemNameLabel.Text = "name"
        '
        'itemPriceLabel
        '
        Me.itemPriceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.itemPriceLabel.Location = New System.Drawing.Point(230, 323)
        Me.itemPriceLabel.Name = "itemPriceLabel"
        Me.itemPriceLabel.Size = New System.Drawing.Size(130, 35)
        Me.itemPriceLabel.TabIndex = 5
        Me.itemPriceLabel.Text = "price"
        '
        'itemDescriptionLabel
        '
        Me.itemDescriptionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.itemDescriptionLabel.Location = New System.Drawing.Point(230, 403)
        Me.itemDescriptionLabel.Name = "itemDescriptionLabel"
        Me.itemDescriptionLabel.Size = New System.Drawing.Size(216, 118)
        Me.itemDescriptionLabel.TabIndex = 6
        Me.itemDescriptionLabel.Text = "description"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(444, 480)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 42)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Quit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(103, 363)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 35)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Items in stock:"
        '
        'itemInStockLabel
        '
        Me.itemInStockLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.itemInStockLabel.Location = New System.Drawing.Point(230, 363)
        Me.itemInStockLabel.Name = "itemInStockLabel"
        Me.itemInStockLabel.Size = New System.Drawing.Size(130, 35)
        Me.itemInStockLabel.TabIndex = 9
        Me.itemInStockLabel.Text = "number"
        '
        'ItemDetailsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 534)
        Me.Controls.Add(Me.itemInStockLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.itemDescriptionLabel)
        Me.Controls.Add(Me.itemPriceLabel)
        Me.Controls.Add(Me.itemNameLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.itemPictureBox)
        Me.Name = "ItemDetailsForm"
        Me.Text = "Item Description"
        CType(Me.itemPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents itemPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents itemNameLabel As System.Windows.Forms.Label
    Friend WithEvents itemPriceLabel As System.Windows.Forms.Label
    Friend WithEvents itemDescriptionLabel As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents itemInStockLabel As System.Windows.Forms.Label
End Class
