2022-06-04:

Welcome to Griff's Great Coffee code

This program is written in dynamic manner

First the user will enter his/her full name,
Than the user can select their coffee size by entering the equivalent
price of the coffee
The price is stored in a variable call coffeePrice

A switch statement is created to check if the price is appropriate
and to give a value to the coffeeType variable.

2022-06-05:

Tip is calculated with error handling.

calculations for getting tip, tax, finalAmount, etc is done
Calculations are carried out with  explicit casting by converting int 
values to double values

After all the calculations final bill of the customer is shown.
Math.Round is used to Round the values to two decimal points

_________________________________________________________________________________________________________

Pseudocode:

Declare string fullName, coffeePrice, coffeeType
Declare int tipPercentage
Declare double tip, amountWithTip, tax, finalAmount

Display "Welcome to Griff's Great Coffee"
Display "Enter your Full Name: "
Input fullName

Display "a) $3(Small) b) $5(Medium) c) $7(Large)"
Display "Enter your Coffee selection by pressing the equivalent price: "
Input coffeePrice

Input coffeeType = ""
switch coffeePrice Then
	case 3: coffeeType = "Small Coffee"
	case 5: coffeeType = "Medium Coffee"
	case 7: coffeeType = "Large Coffee"
	default: Display "Please enter the equivalent price"
End Switch

Display "Tip (in percentage)"
Display "a) 0 b) 15 c) 20"
Display "Enter your tip by pressing the equivalent tip:"
Input tipPercentage

If tipPercentage != 0 and tipPercentage != 15 and tipPercentage != 20 Then
	Display "Please enter the equivalent tip"
End If

tip = coffeePrice  * tipPercentage/100
amountWithTip = tip + coffeePrice
tax = amountWithTip * 13/100
finalAmount = tax + amountWithTip

Display "Customer's Bill"
Display "Customer's Full Name: " + fullName
Display "Coffee selected by the customer is " + coffeeType + " and the price is $" + coffeePrice
Display "Tip given by the customer is " + tipPercentage + "% ($" + tip + ")"

Display "nPrice of the coffee with tip is $" + amountWithTip
Display "Tax added: $" + tax
Display "Total amount to be paid: $" + finalAmount

Display "Thank you for buying Coffee from Griff's Great Coffee"

_________________________________________________________________________________________________________

Calculations:

1) 
input:
coffeePrice = 3
tip = 0%
output:
tip: 0
amountWithTip = 3
tax = 0.39
finalAmount = 3.39

2)
input:
coffeePrice = 5
tip = 15%
output:
tip: 0.75
amountWithTip = 5.75
tax = 0.75
finalAmount = 6.5

3)
input:
coffeePrice = 7
tip = 20%
output:
tip: 1.4
amountWithTip = 8.4
tax = 1.09
finalAmount = 9.49

4)
input:
coffeePrice = 7
tip = 15%
output:
tip: 1.05
amountWithTip = 8.05
tax = 1.05
finalAmount = 9.1

5)
input:
coffeePrice = 7
tip = 0%
output:
tip: 0
amountWithTip = 7
tax = 0.91
finalAmount = 7.91

	

