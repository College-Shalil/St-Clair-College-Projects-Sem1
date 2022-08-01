// Program name: Assignment 3

// Program author: Shalil Joseph Dsilva
// Date submited: 2022-07-23

using System;
using System.Collections;
using System.Linq;

public class GuessTheNumber
{
    //Arraylist to store history
    ArrayList history = new ArrayList();

    //Random class to generate random number
    Random random = new Random();

    // variable declaration 
    string name;
    int randomNumber;
    int guessNumber = 0;
    int number;
    int assignPoints;
    int gameNumber = 0;

    //Constructor
    public GuessTheNumber()
    {
        Menu();
    }

    // Method to display Menu
    public void Menu()
    {
        // try catch for error handling
        try
        {
            //selection menu with some ternary operations
            Console.WriteLine("\nEnter 1 to Play" + (gameNumber > 0 ? " Again" : "") + (history.Capacity != 0 ? "\nEnter 2 to View History" : "") + "\nEnter 9 to Exit");
            int menuChoice = Convert.ToInt32(Console.ReadLine());
            //switch case to choose menu option
            switch (menuChoice)
            {
                case 1:
                    PlayMenu(guessNumber);
                    break;
                case 2:
                    History();
                    break;
                case 9:
                    Exit();
                    break;
                default:
                    Console.WriteLine("\n---XXX---Wrong Option---XXX---");
                    Menu();
                    break;
            }
        }
        // If somenone enters other than a number than format exception will run
        catch (FormatException)
        {
            Console.WriteLine("Invalid Character entered");
            Menu();
        }
        // If there is any other error generic exception will run
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Menu();
        }
    }

    //method to display playing menu
    public void PlayMenu(int noOfGuesses)
    {
        Console.Write("Enter your Name: ");
        name = Console.ReadLine();
        //Error Handling, so that the entered name should not be empty or contain any other format
        while (string.IsNullOrEmpty(name) || name.Any(x => !char.IsLetter(x)))
        {
            Console.Write("Name is either empty or not in string format. \nEnter your name once more:");
            name = Console.ReadLine();
        }

        randomNumber = random.Next(1, 100);
        // Console.WriteLine(randomNumber);

        // initial conditioning to keep the loop running
        bool condition = true;
        while (condition)
        {
            try
            {
                noOfGuesses += 1;
                // condition to keep no of guesses below 7
                if (noOfGuesses <= 6)
                {

                    Console.Write("\nEnter a number from 1 to 100: ");
                    number = Convert.ToInt32(Console.ReadLine());

                    // condition to keep the number between 1 to 100
                    if (number >= 1 && number <= 100)
                    {
                        //Logic to compare the number with random number
                        if (number > randomNumber)
                        {
                            Console.WriteLine("The entered number is bigger :{");
                        }
                        else if (number < randomNumber)
                        {
                            Console.WriteLine("The entered number is smaller :/");
                        }
                        else
                        {
                            Console.WriteLine("\n----Yay {0}! you have guessed the correct number---- :)", name);
                            condition = false;  //this will result in termination of loop
                        }

                    }
                    else
                    {
                        Console.WriteLine("\nEntered number is out of range");
                        noOfGuesses = noOfGuesses - 1;  // As the user entered a number out of range, so the guess is not considered   
                    }

                }
                else
                {
                    Console.WriteLine("\nUnfortunately {0} your number of guesses are over. So you have lost :(", name);
                    condition = false;  //this will result in termination of loop
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Character entered");
                noOfGuesses = noOfGuesses - 1; // As the user entered a value which has exception, so the guess is not considered 
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                noOfGuesses = noOfGuesses - 1;
            }
        }


        //switch statement to assign points according to number of guesses
        switch (noOfGuesses)
        {
            case 1:
                assignPoints = 60;
                break;
            case 2:
                assignPoints = 50;
                break;
            case 3:
                assignPoints = 40;
                break;
            case 4:
                assignPoints = 30;
                break;
            case 5:
                assignPoints = 20;
                break;
            case 6:
                assignPoints = 10;
                break;
            default:
                assignPoints = 0;
                break;
        }
        //points assigned according to guesses
        Console.WriteLine("\n{0} You have got {1} points", name, assignPoints);

        gameNumber += 1;    //gamenumber is used to keep track of the number of games played by user
        //adding of history in arraylist
        history.Add("Game " + gameNumber + " (" + name + ") -> " + noOfGuesses + " tries -> " + assignPoints + " points");


        // going back to menu screen
        Menu();
    }

    //method to display history
    public void History()
    {
        Console.WriteLine("\n~~~Game History~~~");
        foreach (string item in history)
        {
            Console.WriteLine(item);
        }
        Menu();
    }

    //method to exit from the game
    public void Exit()
    {
        Console.WriteLine("\n---> Thank You for playing! :)\n");

    }
}


