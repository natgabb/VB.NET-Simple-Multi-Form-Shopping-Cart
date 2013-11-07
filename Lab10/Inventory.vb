'filename: Inventory.vb
'Natacha Gabbamonte 0932340
'25/11/2011

'This class defines an object of type Inventory
Public Class Inventory

    'This is a list of type Item
    Private listOfItemsInInventory As List(Of Item) = New List(Of Item)
    'This is the number of Items in the list.
    Private numOfItems As Integer = 0

    Public ReadOnly Property Items As List(Of Item)
        Get
            Return listOfItemsInInventory
        End Get
    End Property

    Public ReadOnly Property NumberOfItems As Integer
        Get
            Return numOfItems
        End Get
    End Property

    'This lets you add an Item to the Inventory.
    Public Sub AddItem(ByRef anItem As Item)
        If (Not listOfItemsInInventory.Contains(anItem)) Then
            listOfItemsInInventory.Add(anItem)
            anItem.OrderNum = numOfItems
            numOfItems += 1
        Else
            Throw New ArgumentException("This inventory already has this item.")
        End If
    End Sub

    'This lets you remove an Item from the inventory.
    Public Sub RemoveItem(ByVal anItem As Item)
        If (listOfItemsInInventory.Contains(anItem)) Then
            listOfItemsInInventory.Remove(anItem)
            numOfItems -= 1
            'Must fix the OrderNum of the remaining Items
            Dim i As Integer = 0
            Do While (i <= numOfItems - 1)
                listOfItemsInInventory(i).OrderNum = i
                i += 1
            Loop
        Else
            Throw New ArgumentException("This inventory does not have this item.")
        End If
    End Sub

End Class
