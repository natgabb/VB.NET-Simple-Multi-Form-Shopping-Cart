Public Class PlaceOrderForm

    Private shopCart As ShoppingCart 'The ShoppingCart that was passed in from ShoppingCartForm

    'One-param constructor
    'Parameter:
    'shopCart is the ShoppingCart containing all the Items that have been selected.
    Public Sub New(ByVal shopCart As ShoppingCart)
        InitializeComponent()
        Me.shopCart = shopCart
    End Sub

    'This checks every key press for all the TextBoxes that should contain only letters. 
    Private Sub letterOnlyTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles firstNameTextBox.KeyPress, lastNameTextBox.KeyPress, countryTextBox.KeyPress, cityTextBox.KeyPress
        If (Not ValidCharacterForLetters(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    'This checks every key press for all the TextBoxes that should contain only numbers. 
    Private Sub apartmentNumTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles apartmentNumTextBox.KeyPress
        If (Not ValidCharacterForNumbers(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    'This checks every key press for the street address textbox, which can contain both letters and numbers.
    Private Sub streetAddressTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles streetAddressTextBox.KeyPress
        If (Not ValidCharacterForLetters(e.KeyChar) And Not ValidCharacterForNumbers(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    'Returns true if the character is a regular letter, dash, apostrophe, or backspace.
    'Parameter:
    'c is the character to be evaluated.
    Private Function ValidCharacterForLetters(ByVal c As Char) As Boolean
        Select Case c
            Case ControlChars.Back, "A"c To "Z"c, "a"c To "z"c, "-"c, " "c, "'"c, _
                "À"c To "Ö"c, "Ø"c To "ö"c, "ø"c To "ÿ"c
                Return True
            Case Else
                Return False
        End Select
    End Function

    'Returns true if the character is a number or a backspace.
    'Parameter:
    'c is the character to be evaluated.
    Private Function ValidCharacterForNumbers(ByVal c As Char) As Boolean
        Select Case c
            Case ControlChars.Back, "1"c To "9"c
                Return True
            Case Else
                Return False
        End Select
    End Function

    'The cancel button closes the current form and reopens the ShoppingCartForm.
    Private Sub theCancelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles theCancelButton.Click
        Me.Close()
        Me.Owner.Show() 'This makes the ShoppingCartForm reappear
    End Sub

    'This takes care of the Order Button click event. It valides all fields except
    'apartment number (since it's optional) It then invokes the next form, OrderConfirmationForm.
    Private Sub orderButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles orderButton.Click
        'All but the apartmentNumtextBox are required.
        If (firstNameTextBox.Text = "") Then
            displayErrorMessageBox(firstNameTextBox, "Please enter a first name.")
        ElseIf (lastNameTextBox.Text = "") Then
            displayErrorMessageBox(firstNameTextBox, "Please enter a last name.")
        ElseIf (streetAddressTextBox.Text = "") Then
            displayErrorMessageBox(firstNameTextBox, "Please enter a street address.")
        ElseIf (cityTextBox.Text = "") Then
            displayErrorMessageBox(firstNameTextBox, "Please enter a city.")
        ElseIf (countryTextBox.Text = "") Then
            displayErrorMessageBox(firstNameTextBox, "Please enter a country.")
        ElseIf (phoneNumberTextBox.Text = "(   )    -") Then
            displayErrorMessageBox(firstNameTextBox, "Please enter a phone number.")
        ElseIf (creditCardTextBox.Text = "    -    -    -") Then
            displayErrorMessageBox(firstNameTextBox, "Please enter a credit card number.")
        Else
            'Created an array with all the data.
            Dim data As String() = New String(7) {}
            data(0) = firstNameTextBox.Text
            data(1) = lastNameTextBox.Text
            data(2) = streetAddressTextBox.Text
            data(3) = apartmentNumTextBox.Text
            data(4) = cityTextBox.Text
            data(5) = countryTextBox.Text
            data(6) = phoneNumberTextBox.Text
            data(7) = creditCardTextBox.Text

            'Calls the OrderConfirmationForm
            Dim orderConForm As OrderConfirmationForm = New OrderConfirmationForm(shopCart, data, CType(Me.Owner, ShoppingCartForm))
            Me.Close()
            orderConForm.ShowDialog()
        End If
    End Sub

    'Displays a message box with the message, and focuses on the TextBox.
    Private Sub displayErrorMessageBox(ByVal obj As TextBox, ByVal message As String)
        MessageBox.Show(message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        obj.Focus()
    End Sub

    'Displays a message box with the message, and focuses on the MaskedTextBox
    Private Sub displayErrorMessageBox(ByVal obj As MaskedTextBox, ByVal message As String)
        MessageBox.Show(message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        obj.Focus()
    End Sub
End Class