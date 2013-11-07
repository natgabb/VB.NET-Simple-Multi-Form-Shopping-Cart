'filename: Form1.vb
'Natacha Gabbamonte 0932340
'25/11/2011

'This is the main form in this application. It displays all the available items and
'lets the user add items, display details on an item, show the shopping cart, and quit.
Public Class Form1

    Private inv As Inventory = New Inventory() 'Contains all items for sale
    Private shopCartForm As ShoppingCartForm

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Creating the Item objects
            Dim image0 As Image = My.Resources.i0
            Dim i0 As Item = New Item("Celery Soup", 2.99, "A delicious creamy celery soup!", image0, 10)

            Dim image1 As Image = My.Resources.i1
            Dim i1 As Item = New Item("Chicken Nuggets", 16.59, "Ever felt like having a quick and tasty snack while watching a movie? Chicken nuggets are the ideal deal for you!", image1, 4)

            Dim image2 As Image = My.Resources.i2
            Dim i2 As Item = New Item("Strawberry Cheese Cake", 19.99, "Made with the best cheese and starberries in the world!", image2, 12)

            'Adding the Items to the Inventory
            inv.AddItem(i0)
            inv.AddItem(i1)
            inv.AddItem(i2)

            'Setting the GUI components
            item1Label.Text = inv.Items(0).Name
            item1PriceLabel.Text = FormatCurrency(inv.Items(0).Cost)
            item1PictureBox.Image = inv.Items(0).TheImage

            item2Label.Text = inv.Items(1).Name
            item2PriceLabel.Text = FormatCurrency(inv.Items(1).Cost)
            item2PictureBox.Image = inv.Items(1).TheImage

            item3Label.Text = inv.Items(2).Name
            item3PriceLabel.Text = FormatCurrency(inv.Items(2).Cost)
            item3PictureBox.Image = inv.Items(2).TheImage

            'Creating a ShoppingCartForm
            shopCartForm = New ShoppingCartForm(Me.inv)

        Catch exc As Exception 'Just incase something goes wrong
            MessageBox.Show("Error: " & exc.Message)
        End Try

    End Sub

    Private Sub pictureBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles item1PictureBox.Click
        setItemDetailsForm(inv.Items(0))
    End Sub

    Private Sub item2PictureBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles item2PictureBox.Click
        setItemDetailsForm(inv.Items(1))
    End Sub

    Private Sub item3PictureBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles item3PictureBox.Click
        setItemDetailsForm(inv.Items(2))
    End Sub

    'Sets the ItemDetailsForm's components to the corresponding Item.
    'Parameters:
    'anItem is the Item whose information will be displayed.
    Private Sub setItemDetailsForm(ByVal anItem As Item)
        ItemDetailsForm.itemPictureBox.Image = anItem.TheImage
        ItemDetailsForm.itemNameLabel.Text = anItem.Name
        ItemDetailsForm.itemDescriptionLabel.Text = anItem.Description
        ItemDetailsForm.itemPriceLabel.Text = FormatCurrency(anItem.Cost)
        ItemDetailsForm.itemInStockLabel.Text = CStr(anItem.NumberInStock)
        ItemDetailsForm.ShowDialog()
    End Sub

    'Click button closes the form.
    Private Sub quitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles quitButton.Click
        Me.Close()
    End Sub

    'Clears the form.
    Private Sub clearSelectedButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearSelectedButton.Click
        clearForm()
    End Sub

    'Checks to make sur the characters entered into the quantity TextBoxes are only numbers (or a backspace).
    Private Sub item1TextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles item1TextBox.KeyPress, item2TextBox.KeyPress, item3TextBox.KeyPress
        Select Case e.KeyChar
            Case ControlChars.Back, "0"c To "9"c
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub

    'Adds an item to the ShoppingCart (which is contained in the ShoppingCartForm)
    Private Sub addToCartButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addToCartButton.Click
        Dim isInvalid As Boolean = True
        Dim quantity As Integer
        Try
            If (Not item1TextBox.Text = "") Then
                'add item0
                quantity = CInt(item1TextBox.Text)
                If (CInt(item1TextBox.Text) <> 0) Then
                    isInvalid = False
                    shopCartForm.addItem(inv.Items(0), quantity)
                End If
            End If
        Catch exc As ArgumentException
            item1TextBox.Focus()
            MessageBox.Show(exc.Message(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
        Try
            If (Not item2TextBox.Text = "") Then
                'add item1
                quantity = CInt(item2TextBox.Text)
                If (CInt(item2TextBox.Text) <> 0) Then
                    isInvalid = False
                    shopCartForm.addItem(inv.Items(1), quantity)
                End If
            End If
        Catch exc As ArgumentException
            item2TextBox.Focus()
            MessageBox.Show(exc.Message(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
        Try
            If (Not item3TextBox.Text = "") Then
                'add item2
                quantity = CInt(item3TextBox.Text)
                If (CInt(item3TextBox.Text) <> 0) Then
                    isInvalid = False
                    shopCartForm.addItem(inv.Items(2), quantity)
                End If
            End If
        Catch exc As ArgumentException
            item3TextBox.Focus()
            MessageBox.Show(exc.Message(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
        If (isInvalid) Then
            MessageBox.Show("You must add at least one item!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        clearForm()

    End Sub

    'Shows the ShoppingCartForm.
    Private Sub viewCartButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles viewCartButton.Click
        shopCartForm.Show()
    End Sub

    'Clears the TextBoxes.
    Private Sub clearForm()
        item1TextBox.Text = ""
        item2TextBox.Text = ""
        item3TextBox.Text = ""
    End Sub
End Class


