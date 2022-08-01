// Program name: Assignment 2

// Program author: Shalil Joseph Dsilva
// Date submited: 2022-07-13

using System;

public class Ticket
{
    // variable declaration with getter and setter
    public int speedLimit { get; set; }
    public int ticketedSpeed { get; set; }
    public string classification { get; set; }
    public int speed { get; set; }
    public double fine { get; set; }

    //Constructor
    public Ticket(int speedLimit, int ticketedSpeed)
    {
        this.speedLimit = speedLimit;
        this.ticketedSpeed = ticketedSpeed;
    }

    // Method to display menu
    public void DisplayMenu()
    {

        Console.WriteLine("Enter your Classification: \n    Freshman <enter 1> \n    Sophomore <enter 2> \n    Junior <enter 3> \n    Senior <enter 4>");
        int menuChoice = Convert.ToInt32(Console.ReadLine());

        switch (menuChoice)
        {
            case 1:
                classification = "Freshman";
                break;
            case 2:
                classification = "Sophomore";
                break;
            case 3:
                classification = "Junior";
                break;
            case 4:
                classification = "Senior";
                break;
            default:
                Console.WriteLine("---xxx---Wrong Option entered :/---xxx---\n");
                DisplayMenu();
                break;
        }
    }

    // Logic to calculate fine
    public double SetFine()
    {
        speed = ticketedSpeed - speedLimit;
        fine = (speed / 5 * 87.50) + 75.00;
        if (classification == "Senior")
        {
            if (speed > 20)
            {
                fine = fine + 200;
            }
            else
            {
                fine = fine + 50;
            }
        }
        else
        {
            if (classification == "Freshman")
            {
                if (speed < 20)
                {
                    fine = fine - 50;
                }
                else
                {
                    fine = fine + 100;
                }
            }
            else
            {
                if (speed > 19)
                {
                    fine = fine + 100;
                }
            }
        }

        return fine;
    }
}

