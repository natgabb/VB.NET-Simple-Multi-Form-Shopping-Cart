'filename: ShoppingCartForm.vb
'Natacha Gabbamonte 0932340
'25/11/2011

'This form displays the current state of the ShoppingCart and lets the 
'user remove certain items, place an order, refresh and quit.
Public Class ShoppingCartForm

    Private shopCart As ShoppingCart 'The ShoppingCart that contains all the items selected in the main form.
    Private inv As Inventory 'The Inventory contains all the items for sale.

    'The Constructor creates a new ShoppingCart
    'Parameters:
    'inv is the Inventory of all Items
    Public Sub New(ByVal inv As Inventory)
        InitializeComponent()
        shopCart = New ShoppingCart(inv)
        Me.inv = inv
    End Sub

    'The FormClosing event is intercepted and the form is hidden instead.
    Private Sub ShoppingCartForm_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.FormClosing
        CType(e, FormClosingEventArgs).Cancel = True
        Me.Hide()
    End Sub

    'As soon as the form is loaded, it is refreshed.
    Private Sub ShoppingCartForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        refreshForm()
    End Sub

    'Refreshes the form.
    Private Sub refreshButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles refreshButton.Click
        refreshForm()
    End Sub

    'The Quit button hides the form.
    Private Sub quitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles quitButton.Click
        Me.Hide()
    End Sub

    'The refreshForm sub is what is called whenever the form's Label/ItemBox must be changed because of a change in data.
    Private Sub refreshForm()
        listOfItemsBox.Items.Clear()
        Dim allItems As List(Of Item) = shopCart.Items
        Dim size As Integer = shopCart.NumberOfItems
        Dim numberOfEach As Integer() = shopCart.NumberOfEach
        Dim numOfItem As Integer
        Dim anItem As Item
        Dim i As Integer = 0
        While i < size
            anItem = allItems(i)
            numOfItem = numberOfEach(anItem.OrderNum)
            listOfItemsBox.Items.Add(anItem.Name & "   x" & numOfItem & "   " & FormatCurrency(anItem.Cost * numOfItem))
            i += 1
        End While

        totalCostLabel.Text = FormatCurrency(shopCart.GrossCost)

    End Sub

    'This method is what is cakked by the Main form when it wants to add an item.
    'Parameters:
    'anItem is the Item to be added
    'quantity is the quantity of the Item
    Public Sub addItem(ByVal anItem As Item, ByVal quantity As Integer)
        shopCart.AddItem(anItem, quantity)
        refreshForm()
    End Sub

    'This sub removes a selected item. It then shows an input box for the amount to remove.
    Private Sub removeItemButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles removeItemButton.Click
        Dim index As Integer = listOfItemsBox.SelectedIndex
        If (index = -1) Then
            MessageBox.Show("Please select an item to remove", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim quantity As Integer
            Dim userInput As String = InputBox("Enter a quantity to remove: ", "Input", "1")
            If (Not Integer.TryParse(userInput, quantity)) Then
                MessageBox.Show("Please enter an integer number.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf (quantity < 0) Then
                MessageBox.Show("Please enter a positive number.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf (quantity = 0) Then
                Return
            Else
                Try
                    shopCart.RemoveItem(shopCart.Items(index), quantity)
                Catch ex As ArgumentException
                    MessageBox.Show(ex.Message(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End Try
            End If
        End If
        refreshForm()
    End Sub

    'This is invoked when the Place Order button is clicked. It displays an error message if no items have been selected.
    'It then creates a new PlaceOrderForm and sends in the ShoppingCart and then hides itself.
    Private Sub placeOrderButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles placeOrderButton.Click
        If (shopCart.NumberOfItems < 1) Then
            MessageBox.Show("You can't order if you haven't selected anything yet!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim placeOForm As PlaceOrderForm = New PlaceOrderForm(shopCart)
            Me.Hide()
            placeOForm.ShowDialog(Me)
        End If
    End Sub

    'This sub rmoves all items from the ShoppingCart
    Public Sub removeAllItems()
        Dim i As Integer = 0
        Dim numOfEach As Integer() = shopCart.NumberOfEach
        Dim anItem As Item
        While i < shopCart.NumberOfItems
            anItem = shopCart.Items(i)
            shopCart.RemoveItem(anItem, numOfEach(anItem.OrderNum))
        End While
        refreshForm()
    End Sub
End Class