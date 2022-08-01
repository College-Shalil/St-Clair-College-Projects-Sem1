// Program name: Assignment 1
// Program purpose: To develop a program which prints customer's bill according to the inputs of customer.
// Program author: Shalil Joseph Dsilva
// Date submited: 2022-06-05

using System;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nWelcome to Griff's Great Coffee\n");  //Welcome message
            Console.Write("Enter your Full Name: ");
            string fullName = Console.ReadLine();
            
            //Coffee Selection section
            Console.WriteLine("Coffee sizes and range:");
            Console.WriteLine("a) $3(Small) \nb) $5(Medium) \nc) $7(Large)");
            Console.Write("\nEnter your Coffee selection by pressing the equivalent price: ");
            int coffeePrice = Convert.ToInt32(Console.ReadLine());

            //  Switch statement for error handling and giving coffee type value according to coffeeprice
            string coffeeType = "";
            switch (coffeePrice)
            {
                case 3:
                    coffeeType = "Small Coffee";
                    break;
                case 5:
                    coffeeType = "Medium Coffee";
                    break;
                case 7:
                    coffeeType = "Large Coffee";
                    break;
                default:
                    Console.WriteLine("Please enter the equivalent price");
                    return;
            }

            //Tip selection section
            Console.WriteLine("Tip (in percentage)");
            Console.WriteLine("a) 0 \nb) 15 \nc) 20");
            Console.Write("\nEnter your tip by pressing the equivalent tip: ");
            int tipPercentage = Convert.ToInt32(Console.ReadLine());

            // Error handling
            if (tipPercentage != 0 && tipPercentage != 15 && tipPercentage != 20)
            {
                Console.WriteLine("Please enter the equivalent tip");
                return;
            }


            //Calculations
            double tip = (double)coffeePrice * (double)tipPercentage / 100;  //Explicit Type Casting
            //Console.WriteLine(tip);

            double amountWithTip = tip + coffeePrice;
            //Console.WriteLine(amountWithTip);

            double tax = amountWithTip * (double)13 / 100;
            //Console.WriteLine(tax);

            double finalAmount = tax + amountWithTip;

            // Output
            Console.WriteLine("\nCustomer's Bill\n");
            Console.WriteLine("Customer's Full Name: " + fullName);
            Console.WriteLine("Coffee selected by the customer is " + coffeeType + " and the price is $" + coffeePrice);
            Console.WriteLine("Tip given by the customer is " + tipPercentage + "% ($" + Math.Round(tip, 2) + ")"); // Rounded the values to two decimal points

            Console.WriteLine("\nPrice of the coffee with tip is $" + Math.Round(amountWithTip, 2));
            Console.WriteLine("Tax added: $" + Math.Round(tax, 2));
            Console.WriteLine("Total amount to be paid: $" + Math.Round(finalAmount, 2));

            Console.WriteLine("\nThank you for buying Coffee from Griff's Great Coffee\n");
        }
    }
}
