'filename: Item.vb
'Natacha Gabbamonte 0932340
'25/11/2011

'This class defines an object of type Item.
Public Class Item : Implements IEquatable(Of Item)

    Private itemName As String 'Name of item
    Private itemCost As Double 'Cost of item
    Private itemDesc As String 'Description of item
    Private itemImage As Image 'Image associated with item

    'Order number in Inventory list, not to be confused with an IDNumber,
    'since this number may change if the inventory is changed.
    Public Property OrderNum As Integer

    'Number of Item in stock
    Public Property NumberInStock As Integer

    Public ReadOnly Property Name As String
        Get
            Return itemName
        End Get
    End Property
    Public ReadOnly Property Cost As Double
        Get
            Return itemCost
        End Get
    End Property
    Public ReadOnly Property Description As String
        Get
            Return itemDesc
        End Get
    End Property
    Public ReadOnly Property TheImage As Image
        Get
            Return itemImage
        End Get
    End Property

    'Constructor
    'Parameters:
    'name is the name of the Item
    'cost is the cost of the Item
    'desc is a description of the Item
    'anImage is the image of the Item
    'numInStock is the number of available Items
    Public Sub New(ByVal name As String, ByVal cost As Double, ByVal desc As String, ByVal anImage As Image, ByVal numInStock As Integer)
        itemName = name
        itemCost = cost
        itemDesc = desc
        itemImage = anImage
        NumberInStock = numInStock
    End Sub

    'This equals is needed to be able to use the contains method for a List(of Item)
    'Parameter:
    'other is the Item that will be compared to the current Item.
    Public Overloads Function Equals(ByVal other As Item) As Boolean Implements IEquatable(Of Item).Equals
        If ReferenceEquals(Me, other) Then
            Return True
        ElseIf other Is Nothing Then
            Return False
        Else
            Dim i As Item = CType(other, Item)
            Return i.Name.Equals(Me.Name)
        End If
    End Function

    'This overrides the Equals function.
    'Parameter:
    'obj is the object that will be compared to the current Item.
    Public Overrides Function Equals(ByVal obj As Object) As Boolean
        If ReferenceEquals(Me, obj) Then
            Return True
        ElseIf obj Is Nothing Then
            Return False
        ElseIf obj.GetType <> Me.GetType Then
            Return False
        Else
            Dim i As Item = CType(obj, Item)
            Return i.Name.Equals(Me.Name)
        End If

    End Function

    'This overrides the ToString function.
    Public Overrides Function ToString() As String
        Return "Order Number: " & CStr(OrderNum) & Environment.NewLine & "Name: " & _
            itemName & Environment.NewLine & "Cost: " & FormatCurrency(itemCost) & Environment.NewLine & _
            "Description: " & itemDesc & Environment.NewLine & "Items in stock: " & CStr(NumberInStock)
    End Function

End Class
