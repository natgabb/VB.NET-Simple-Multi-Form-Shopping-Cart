'filename: ShoppingCart.vb
'Natacha Gabbamonte 0932340
'25/11/2011

'This class defines an object of type ShoppingCart.
Public Class ShoppingCart

    'The Items in the ShoppingCart
    Private listOfItems As List(Of Item) = New List(Of Item)
    'Number of Items in the ShoppingCart
    Private numOfItems As Integer = 0
    'The totalCost of all the Items
    Private totalGrossCost As Double
    'The number of each Item
    Private numberOfEachItem As Integer()
    'The inventory from which the Items will come from.
    Private invent As Inventory

    Public ReadOnly Property Items As List(Of Item)
        Get
            Return listOfItems
        End Get
    End Property
    Public ReadOnly Property NumberOfItems As Integer
        Get
            Return numOfItems
        End Get
    End Property

    Public ReadOnly Property NumberOfEach As Integer()
        Get
            Return numberOfEachItem
        End Get
    End Property

    Public ReadOnly Property GrossCost As Double
        Get
            Return totalGrossCost
        End Get
    End Property

    'One-param constructor
    'Parameter:
    'invent is the Inventory from which all the Items will come from.
    Public Sub New(ByVal invent As Inventory)
        Me.invent = invent
        numberOfEachItem = New Integer(invent.NumberOfItems - 1) {}
    End Sub

    'This sub adds an Item to the ShoppingCart
    'Parameters:
    'anItem is the Item to add
    'quantity is how many of the Item to add.
    Public Sub AddItem(ByVal anItem As Item, ByVal quantity As Integer)

        If (numberOfEachItem(anItem.OrderNum) + quantity > anItem.NumberInStock) Then
            Throw New ArgumentException("There are only " & anItem.NumberInStock & " " & anItem.Name)
        End If

        If (listOfItems.Contains(anItem)) Then
            numberOfEachItem(anItem.OrderNum) += quantity
        Else
            listOfItems.Add(anItem)
            numOfItems += 1
            numberOfEachItem(anItem.OrderNum) += quantity
        End If

        totalGrossCost += anItem.Cost * quantity
    End Sub

    'This sub removes an Item from the ShoppingCart
    'Parameters:
    'anItem is the Item to remove
    'quantity is how many of the Item to remove.
    Public Sub RemoveItem(ByVal anItem As Item, ByVal quantity As Integer)
        If (listOfItems.Contains(anItem)) Then
            If (quantity > numberOfEachItem(anItem.OrderNum)) Then
                Throw New ArgumentException("You cannot remove more items than you have.")
            End If
            If (quantity = numberOfEachItem(anItem.OrderNum)) Then
                listOfItems.Remove(anItem)
                numOfItems -= 1
                numberOfEachItem(anItem.OrderNum) = 0
            Else
                numberOfEachItem(anItem.OrderNum) -= quantity
            End If
        Else
            Throw New ArgumentException("This shopping cart does not have this item.")
        End If

        totalGrossCost -= anItem.Cost * quantity
    End Sub

End Class
