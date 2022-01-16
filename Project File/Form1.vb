Public Class Form1
    'Price for Every Item
    Dim Price_Potatoes() As Single = {0, 10, 20, 15, 14}
    Dim Price_Box() As Single = {0, 6.95, 11.95, 15.95}
    Dim Price_GreenLfyVeg() As Single = {18.5, 18.5, 18.5}
    Dim Price_RootVeg() As Single = {20, 20, 20, 20}
    Dim Price_DeliveryOpt() As Single = {0, 0, 1.95, 1.95, 4.95}
    Dim Price_Salad() As Single = {5, 5, 5}
    Dim Price_Core() As Single = {4, 4}
    Dim Price_Soft() As Single = {7, 7, 7, 7}
   
    'Stock for Potatoes
    Dim Stock_Potatoes_Wednesday() = {0, 31, 76, 50, 30}
    Dim Stock_Potatoes_Thursday() = {0, 14, 49, 405, 115}
    'Stock for Box
    Dim Stock_Box_Monday() = {0, 80, 98, 108}
    Dim Stock_Box_Tuesday() = {0, 19, 96, 87}
    'Stock for Green Leafy vegetable
    Dim Stock_GreenLeafyVeg_Friday() = {80, 80, 80}
    Dim Stock_GreenLeafyVeg_Saturday() = {90, 90, 90}
    'Stock for Root Vegetable
    Dim Stock_RootVeg_Monday() = {70, 70, 70, 70}
    Dim Stock_RootVeg_Tuesday() = {47, 47, 47, 47}


    Private Sub Form1_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Cmb1DayofDelivery.Items.Add("Select Please")
        Cmb1DayofDelivery.Items.Add("Monday")
        Cmb1DayofDelivery.Items.Add("Tuesday")
        Cmb1DayofDelivery.Items.Add("Wednesday")
        Cmb1DayofDelivery.Items.Add("Thursday")
        Cmb1DayofDelivery.Items.Add("Friday")
        Cmb1DayofDelivery.Items.Add("Saturday")
        Cmb1DayofDelivery.SelectedIndex = 0

        Cmb2TypeofPotatoes.Items.Add("Select Please")
        Cmb2TypeofPotatoes.Items.Add("Maris Piper")
        Cmb2TypeofPotatoes.Items.Add("Shetland Black")
        Cmb2TypeofPotatoes.Items.Add("King Edward")
        Cmb2TypeofPotatoes.Items.Add("Yukon Gold")
        Cmb2TypeofPotatoes.SelectedIndex = 0

        Cmb3TypeofBox.Items.Add("Select Please")
        Cmb3TypeofBox.Items.Add("Small (£6.95)")
        Cmb3TypeofBox.Items.Add("Medium (£11.95)")
        Cmb3TypeofBox.Items.Add("Large (£15.95)")
        Cmb3TypeofBox.SelectedIndex = 0

        LstBx1GreenVeg.Items.Add("Spinach")
        LstBx1GreenVeg.Items.Add("Rocket")
        LstBx1GreenVeg.Items.Add("Ice Lettuce")

        LstBx2RootVeg.Items.Add("Onion")
        LstBx2RootVeg.Items.Add("Parsnip")
        LstBx2RootVeg.Items.Add("Turnip")
        LstBx2RootVeg.Items.Add("Carrot")

        LstBx3SaladVeg.Items.Add("Curcumber")
        LstBx3SaladVeg.Items.Add("Tomatoes")
        LstBx3SaladVeg.Items.Add("Radish")

        LstBx4CoreFruits.Items.Add("Apples")
        LstBx4CoreFruits.Items.Add("Pears")

        LstBx5SoftFruits.Items.Add("Peaches")
        LstBx5SoftFruits.Items.Add("Plums")
        LstBx5SoftFruits.Items.Add("Respberries")
        LstBx5SoftFruits.Items.Add("Blackberries")

        Cmb4DeliveryOption.Items.Add("Select Please")
        Cmb4DeliveryOption.Items.Add("7:00am to 7:00pm (Free)")
        Cmb4DeliveryOption.Items.Add("Morning (£1.95)")
        Cmb4DeliveryOption.Items.Add("Afternoon (£1.95)")
        Cmb4DeliveryOption.Items.Add("One-hour Lunchtime (£4.95)")
        Cmb4DeliveryOption.SelectedIndex = 0

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim SrtDayofDelivery, SrtTypeofPotatoes, SrtTypeofBox, SrtGreenLeafyVegetable, SrtRootVegetable, SrtDeliveryOpt, SrtOptional, SrtTotal, SrtTotal2 As String
        Dim Pricepota, Pricebox, Pricegreenveg, Pricerootveg, Pricedelivery, Priceoptional, Pricetotal As Single

        'Cheking for Day of Delivery
        If Cmb1DayofDelivery.SelectedIndex = 0 Then
            MessageBox.Show("Please Select Day of Delivery")
            Exit Sub
        Else
            SrtDayofDelivery = "[You Select Day of Delivery :--->>> " & Cmb1DayofDelivery.SelectedItem & "]" & vbCrLf
        End If

        'Cheking for Type of Potatoes
        If Cmb2TypeofPotatoes.SelectedIndex = 0 Then
            MessageBox.Show("Please Select Type of Potatoes")
            Exit Sub
        Else
            Pricepota = Price_Potatoes(Cmb2TypeofPotatoes.SelectedIndex)
            SrtTypeofPotatoes = "Type of Potato :--->>> " & Cmb2TypeofPotatoes.SelectedItem & ", Price : £" & Pricepota
        End If

        'Cheking for Type of Box
        If Cmb3TypeofBox.SelectedIndex = 0 Then
            MessageBox.Show("Please Select Type of Box")
            Exit Sub
        Else
            Pricebox = Price_Box(Cmb3TypeofBox.SelectedIndex)
            SrtTypeofBox = "Type of Box :--->>> " & Cmb3TypeofBox.SelectedItem
        End If

        'Cheaking for Green Leafy Vegetable
        If LstBx1GreenVeg.SelectedIndex < 0 Then
            MessageBox.Show("Please Select One or More Green Leafy Vegetable")
            Exit Sub
        Else
            Pricegreenveg = Price_GreenLfyVeg(LstBx1GreenVeg.SelectedIndex)
            For Each u In LstBx1GreenVeg.SelectedItems
                SrtGreenLeafyVegetable += u & ", Price : £" & Pricegreenveg & ", "
            Next
        End If

        'Cheking for Root Vegetable
        If LstBx2RootVeg.SelectedIndex < 0 Then
            MessageBox.Show("Please Select One or More Root Vegetable")
            Exit Sub
        Else
            Pricerootveg = Price_RootVeg(LstBx2RootVeg.SelectedIndex)
            For Each u In LstBx2RootVeg.SelectedItems
                SrtRootVegetable += u & ", Price : £" & Pricerootveg & ", "
            Next
        End If

        'Cheaking for DeliverybOption
        If Cmb4DeliveryOption.SelectedIndex = 0 Then
            MessageBox.Show("Please Select Delivery Option")
            Exit Sub
        Else
            Pricedelivery = Price_DeliveryOpt(Cmb4DeliveryOption.SelectedIndex)
            SrtDeliveryOpt = "Delivery Option :--->>> " & Cmb4DeliveryOption.SelectedItem
        End If

        Dim DayOfDelivery, TypeOfPotatoes, TypeofBox, GreenLeafyVegetable, RootVegetable As Integer
        DayOfDelivery = Cmb1DayofDelivery.SelectedIndex
        TypeOfPotatoes = Cmb2TypeofPotatoes.SelectedIndex
        TypeofBox = Cmb3TypeofBox.SelectedIndex
        GreenLeafyVegetable = LstBx1GreenVeg.SelectedIndex
        RootVegetable = LstBx2RootVeg.SelectedIndex

        'Cheking Potatoes Wednesday Stock
        If Cmb1DayofDelivery.SelectedIndex = 3 Then
            For potatoes As Integer = 1 To 4
                If Convert.ToString(Cmb2TypeofPotatoes.Items(potatoes)) = Cmb2TypeofPotatoes.SelectedItem Then
                    If Stock_Potatoes_Wednesday(TypeOfPotatoes) < 1 Then
                        MessageBox.Show(Cmb2TypeofPotatoes.SelectedItem & " Potato Is Not Available On " & Cmb1DayofDelivery.SelectedItem)
                        Exit Sub
                    End If
                    Stock_Potatoes_Wednesday(TypeOfPotatoes) = Stock_Potatoes_Wednesday(TypeOfPotatoes) - 1
                End If
            Next
        End If
        'Cheking Potatoes Thursday Stock
        If Cmb1DayofDelivery.SelectedIndex = 4 Then
            For potatoes As Integer = 1 To 4
                If Convert.ToString(Cmb2TypeofPotatoes.Items(potatoes)) = Cmb2TypeofPotatoes.SelectedItem Then
                    If Stock_Potatoes_Thursday(TypeOfPotatoes) < 1 Then
                        MessageBox.Show(Cmb2TypeofPotatoes.SelectedItem & " Potato Is Not Available On " & Cmb1DayofDelivery.SelectedItem)
                        Exit Sub
                    End If
                    Stock_Potatoes_Thursday(TypeOfPotatoes) = Stock_Potatoes_Thursday(TypeOfPotatoes) - 1
                End If
            Next
        End If

        'Cheking Stock Box Monady 
        If Cmb1DayofDelivery.SelectedIndex = 1 Then
            For box As Integer = 1 To 3
                If Convert.ToString(Cmb3TypeofBox.Items(box)) = Cmb3TypeofBox.SelectedItem Then
                    If Stock_Box_Monday(TypeofBox) < 1 Then
                        MessageBox.Show(Cmb3TypeofBox.SelectedItem & " Box Type Is Not Available On " & Cmb1DayofDelivery.SelectedItem)
                        Exit Sub
                    End If
                    Stock_Box_Monday(TypeofBox) = Stock_Box_Monday(TypeofBox) - 1
                End If
            Next
        End If
        'Cheking Stock Box Tuesday 
        If Cmb1DayofDelivery.SelectedIndex = 2 Then
            For box As Integer = 1 To 3
                If Convert.ToString(Cmb3TypeofBox.Items(box)) = Cmb3TypeofBox.SelectedItem Then
                    If Stock_Box_Tuesday(TypeofBox) < 1 Then
                        MessageBox.Show(Cmb3TypeofBox.SelectedItem & " Box Type Is Not Available On " & Cmb1DayofDelivery.SelectedItem)
                        Exit Sub
                    End If
                    Stock_Box_Tuesday(TypeofBox) = Stock_Box_Tuesday(TypeofBox) - 1
                End If
            Next
        End If

        'Checking for Green Leafy Vegetable Stock On Friday
        If Cmb1DayofDelivery.SelectedIndex = 5 Then
            For GrnVeg As Integer = 0 To 2
                If Convert.ToString(LstBx1GreenVeg.Items(GrnVeg)) = LstBx1GreenVeg.SelectedItem Then
                    If Stock_GreenLeafyVeg_Friday(GreenLeafyVegetable) < 1 Then
                        MessageBox.Show(LstBx1GreenVeg.SelectedItem & " Vegetable Is Not Available On " & Cmb1DayofDelivery.SelectedItem)
                        Exit Sub
                    End If
                    Stock_GreenLeafyVeg_Friday(GreenLeafyVegetable) = Stock_GreenLeafyVeg_Friday(GreenLeafyVegetable) - 1
                End If
            Next
        End If
        'Checking for Green Leafy Vegetable Stock On Saturday
        If Cmb1DayofDelivery.SelectedIndex = 6 Then
            For GrnVeg As Integer = 0 To 2
                If Convert.ToString(LstBx1GreenVeg.Items(GrnVeg)) = LstBx1GreenVeg.SelectedItem Then
                    If Stock_GreenLeafyVeg_Saturday(GreenLeafyVegetable) < 1 Then
                        MessageBox.Show(LstBx1GreenVeg.SelectedItem & " Vegetable Is Not Available On " & Cmb1DayofDelivery.SelectedItem)
                        Exit Sub
                    End If
                    Stock_GreenLeafyVeg_Saturday(GreenLeafyVegetable) = Stock_GreenLeafyVeg_Saturday(GreenLeafyVegetable) - 1
                End If
            Next
        End If

        'Cheking for Root Vegetable Stock On Monday
        If Cmb1DayofDelivery.SelectedIndex = 1 Then
            For Rootveg As Integer = 0 To 3
                If Convert.ToString(LstBx2RootVeg.Items(Rootveg)) = LstBx2RootVeg.SelectedItem Then
                    If Stock_RootVeg_Monday(RootVegetable) < 1 Then
                        MessageBox.Show(LstBx2RootVeg.SelectedItem & " Vegetable Is Not Available On " & Cmb1DayofDelivery.SelectedItem)
                        Exit Sub
                    End If
                    Stock_RootVeg_Monday(RootVegetable) = Stock_RootVeg_Monday(RootVegetable) - 1
                End If
            Next
        End If
        'Cheking for Root Vegetable Stock On Tuesday
        If Cmb1DayofDelivery.SelectedIndex = 2 Then
            For Rootveg As Integer = 0 To 3
                If Convert.ToString(LstBx2RootVeg.Items(Rootveg)) = LstBx2RootVeg.SelectedItem Then
                    If Stock_RootVeg_Tuesday(RootVegetable) < 1 Then
                        MessageBox.Show(LstBx2RootVeg.SelectedItem & " Vegetable Is Not Available On " & Cmb1DayofDelivery.SelectedItem)
                        Exit Sub
                    End If
                    Stock_RootVeg_Tuesday(RootVegetable) = Stock_RootVeg_Tuesday(RootVegetable) - 1
                End If
            Next
        End If

        'Cheking for Optional(Produce)
        Dim opt1, opt2, opt3 As String
        Dim opt1p, opt2p, opt3p As Single
        If LstBx3SaladVeg.SelectedIndex > -1 Then
            opt1p = Price_Salad(LstBx3SaladVeg.SelectedIndex)
        End If
        For Each u In LstBx3SaladVeg.SelectedItems
            opt1 += u & ", Price : £" & opt1p & ", "
        Next
        If LstBx4CoreFruits.SelectedIndex > -1 Then
            opt2p = Price_Core(LstBx4CoreFruits.SelectedIndex)
        End If
        For Each u In LstBx4CoreFruits.SelectedItems
            opt2 += u & ", Price : £" & opt2p & ", "
        Next
        If LstBx5SoftFruits.SelectedIndex > -1 Then
            opt2p = Price_Soft(LstBx5SoftFruits.SelectedIndex)
        End If
        For Each u In LstBx5SoftFruits.SelectedItems
            opt3 += u & ", Price : £" & opt2p & ", "
        Next
        SrtOptional = "Optional :--->>> " & opt1 & opt2 & opt3
        Priceoptional = opt1p + opt2p + opt3p
        Dim i, k, m, total As Integer
        i = LstBx3SaladVeg.SelectedItems.Count
        k = LstBx4CoreFruits.SelectedItems.Count
        m = LstBx5SoftFruits.SelectedItems.Count
        total = i + k + m
        If Cmb3TypeofBox.SelectedIndex = 1 Then
            If total > 1 Then
                MessageBox.Show("For Small Boxes You May Choose a maximum of 1")
                Exit Sub
            End If
        End If

        If Cmb3TypeofBox.SelectedIndex = 2 Then
            If total > 3 Then
                MessageBox.Show("For Medium Boxes You May Choose a maximum of 3")
                Exit Sub
            End If
        End If

        If Cmb3TypeofBox.SelectedIndex = 3 Then
            If total > 6 Then
                MessageBox.Show("For Large Boxes You May Choose a maximum of 6")
                Exit Sub
            End If
        End If
        'if did not select optional item
        If LstBx3SaladVeg.SelectedIndex < 0 And LstBx4CoreFruits.SelectedIndex < 0 And LstBx5SoftFruits.SelectedIndex < 0 Then
            Pricetotal = Pricepota + Pricebox + Pricegreenveg + Pricerootveg + Pricedelivery
            SrtTotal2 = SrtDayofDelivery & vbCrLf & SrtTypeofPotatoes & vbCrLf & SrtTypeofBox & vbCrLf & "Green Leafy Vegetable :--->>> " & SrtGreenLeafyVegetable & vbCrLf & "Root Vegetables :--->>> " & SrtRootVegetable & vbCrLf & SrtDeliveryOpt & vbCrLf & "You Did Not Select Any Optional Item." & vbCrLf & "Price Total :--->>> £" & Pricetotal & vbCrLf & vbCrLf & "Do You Like To Order?"
            Dim y As DialogResult = MessageBox.Show(SrtTotal2, "<<<- - - - - - Summary of Choices - - - - - ->>>", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If y = DialogResult.OK Then
                MessageBox.Show("Thanks for Ordering")
                Form2.Show()
                Exit Sub
            Else
                MessageBox.Show("Thanks For Visit")
                Application.Exit()
            End If
        Else
            'if select optional item
            Pricetotal = Pricepota + Pricebox + Pricegreenveg + Pricerootveg + Pricedelivery + Priceoptional
            SrtTotal = SrtDayofDelivery & vbCrLf & SrtTypeofPotatoes & vbCrLf & SrtTypeofBox & vbCrLf & "Green Leafy Vegetable :--->>> " & SrtGreenLeafyVegetable & vbCrLf & "Root Vegetables :--->>> " & SrtRootVegetable & vbCrLf & SrtDeliveryOpt & vbCrLf & SrtOptional & vbCrLf & "Price Total :--->>> £" & Pricetotal & vbCrLf & vbCrLf & "Do You Like To Order?"
            Dim x As DialogResult = MessageBox.Show(SrtTotal, "<<<- - - - - - Summary of Choices - - - - - ->>>", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If x = DialogResult.OK Then
                MessageBox.Show("Thanks for Ordering")
                Form2.Show()
            Else
                MessageBox.Show("Thanks For Visit")
                Application.Exit()
            End If
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MessageBox.Show("Thanks For Visit")
        Application.Exit()
    End Sub
End Class