'filename: OrderConfirmationForm.vb
'Natacha Gabbamonte 0932340
'25/11/2011

'This form displays the Order Details, and has a button that returns the
'user to the main form, while also clearing the ShoppingCart
Public Class OrderConfirmationForm

    Private shopCart As ShoppingCart 'The ShoppingCart containing the selected Items
    Private data As String() 'The user's data
    Private shopCartForm As ShoppingCartForm 'A reference to the ShoppingCartForm

    'Three-param Constructor
    'Parameters:
    'shopCart is the ShoppingCart that contains all the selected Items
    'data is the String array that contains all the data the user inputed.
    'shopCartForm is a reference to the ShoppingCartForm
    Public Sub New(ByVal shopCart As ShoppingCart, ByVal data As String(), ByVal shopCartForm As ShoppingCartForm)
        InitializeComponent()
        Me.shopCart = shopCart
        Me.data = data
        Me.shopCartForm = shopCartForm
    End Sub

    'This method loads all the information into the labels.
    Private Sub OrderConfirmationForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim outputString As String = "Name: " & data(0) & " " & data(1) & Environment.NewLine & _
                                     "Address: " & data(2) & " " & data(3) & Environment.NewLine & _
                                     "           " & data(4) & "," & data(5) & Environment.NewLine & _
                                     "Phone number: " & data(6) & Environment.NewLine & _
                                     "Credit card number: " & "****-****-****-" & data(7).Substring(15) _
                                     & Environment.NewLine & Environment.NewLine & "Your items:" & _
                                     Environment.NewLine
        Dim i As Integer = 0
        Dim numOfEach As Integer() = shopCart.NumberOfEach
        Dim anItem As Item
        Dim number As Integer
        While i < shopCart.NumberOfItems
            anItem = shopCart.Items(i)
            number = numOfEach(anItem.OrderNum)
            outputString &= anItem.Name & "   x" & number & "   " & FormatCurrency(number * anItem.Cost) _
                & Environment.NewLine
            i += 1
        End While
        orderDetailsOutputLabel.Text = outputString
        totalCostLabel.Text = FormatCurrency(shopCart.GrossCost)
    End Sub

    'The continue button closes the current form, removes all the items from
    'the shopCartForm, and hides the shopCartForm.
    Private Sub continueButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles continueButton.Click
        Me.Close()
        shopCartForm.removeAllItems()
        shopCartForm.Hide()
    End Sub

End Class