// Program name: Assignment 2

// Program author: Shalil Joseph Dsilva
// Date submited: 2022-07-13

using System;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //welcome heading
            Console.WriteLine("\n-----Welcome to Speeding Ticket App :)-----\n");

            // try catch for error handling
            try
            {
                Console.Write("Enter Student Number: ");
                int studentNumber = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the Speed Limit: ");
                int speedLimit = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the Ticketed Speed: ");
                int ticketedSpeed = Convert.ToInt32(Console.ReadLine());

                //initial check condition, to check whether ticketedspeed is less than equal to speedlimit 
                if (ticketedSpeed <= speedLimit)
                {
                    Console.WriteLine("/n<----Please Check the Entered Values :(---->");
                    return;
                }

                // object creation
                Ticket ticketApp = new Ticket(speedLimit, ticketedSpeed);

                // Display the menu for selection
                ticketApp.DisplayMenu();

                // Final output screen
                Console.WriteLine("\n~~~~~~~Ticket App~~~~~~~\n");
                Console.WriteLine("Student number: " + studentNumber);
                Console.WriteLine("Classification: " + ticketApp.classification);
                Console.WriteLine("Speed Limit: " + speedLimit + " KPH");
                Console.WriteLine("Reported Speed: " + ticketedSpeed + " KPH");
                Console.WriteLine("\nFine: ${0}\n", ticketApp.SetFine());

            }
            // If somenone enters other than a number than format exception will run
            catch (FormatException)
            {
                Console.WriteLine("Invalid Character entered");
            }
            // If there is any other error generic exception will run
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
