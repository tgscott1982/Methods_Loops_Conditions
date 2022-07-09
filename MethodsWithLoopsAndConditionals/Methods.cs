using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsWithLoopsAndConditionals;

internal class Methods
{ 
    public static void SillyLongList() // task 1
    { 
    for (int i = -1000; i <= 1000; i++)
        Console.WriteLine(i);
    }   

    public static void GimmeThreeBro() //task 2
    {
        for (int plusThree = 3; plusThree <= 999; plusThree += 3)
        {
            Console.WriteLine(plusThree);
        }
    }


    public static void YouAreNotMyEqual() //task 3
    {
        Console.WriteLine("Please enter a number.");
        int firstChoice = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter a second number.");
        int secondChoice = Convert.ToInt32(Console.ReadLine());

        if (firstChoice == secondChoice)
            Console.WriteLine($"{firstChoice} and {secondChoice} are equal.");
        else
            Console.WriteLine($"{firstChoice} and {secondChoice} are not equal.");
    }

    public static void EvensAndOdds()
    {
        Console.WriteLine("Sling me a number, yo!");
        int numberSlung = Convert.ToInt32(Console.ReadLine());

        if (numberSlung % 2 == 0)
        {
            Console.WriteLine("Saweeeeet, that's even!");
        }
        else
        {
            Console.WriteLine("That one's odd...just like you!"); 
        }
    } //task 4

    public static void PosAndNeg()
    {

            Console.WriteLine("Hey, hey....gimme a negative number, would ya?");
            int possibleNeg = Convert.ToInt32(Console.ReadLine());

            if (possibleNeg < 0)
            {
                Console.WriteLine("Awesome! Yep, that's negative!");
            }
            else if (possibleNeg > 0)
            {
                Console.WriteLine("That's positive! Did you even read the instructions?");
            }
            else
            {
                Console.WriteLine("OMG! I feel like you're doing this on purpose!");
            } 
            
        
    } //task 5

    public static void VotingMatters() // task 6 basic
    {
        Console.WriteLine("Welcome to voter registration! Please enter your age.");
        var voterAge = Convert.ToInt32(Console.ReadLine());

        switch (voterAge)
        {
            case >= 18:
                Console.WriteLine("Thank you for confirming your age. Please proceed.");
                break;
            default:
                Console.WriteLine("We're sorry. You are not old enough to vote. Have a nice day.");
                break;
        }
        
    }

    public static void VotingMatters2() // task 6 challenge - hard for me to find online examples of try parse that made sense
    {
        bool possibility = true;

        while (possibility == true)
        {

            Console.WriteLine("Please enter your age to verify voter elegibility. (Part 2)");
            var voterAge = Console.ReadLine();
            var tempAge = int.TryParse(voterAge, out int voter);

            if (tempAge == true)
            {
                if (voter >= 18)
                {
                    Console.WriteLine("Elegibility confirmed. Welcome to voter registration!");
                    break;
                }
                else if (voter < 0)
                {
                    Console.WriteLine("We're sorry. That is not a valide age. Please try again.");
                }
                else
                {
                    Console.WriteLine("We're sorry. You are not old enough for voter registration.");
                    break;
                }
            }
            else
            {
                Console.WriteLine("We're sorry. That is not a valid number. Please try again.");
            }
        }
       
    }



    public static void InBetweenTens() // task 7 extra
    {
        bool range = true;
        while (range == true)
        {
            Console.WriteLine("Please enter a number in the range of -10 and 10.");
            var rangeInput = Convert.ToInt32(Console.ReadLine());

            if (rangeInput >= -10 && rangeInput <= 10)
            {
                Console.WriteLine("Good job! Your number is in the range of -10 and 10.");
                break;
            }
            else
            {
                Console.WriteLine("We're sorry. Your number is NOT in the range of -10 and 10.");
                break;
            }

        }
    }



    public static void TimesTables() // task 8 extra
    {
        Console.WriteLine("Please enter a number to display it's multiplication table from 1 to 12.");
        
        var timesTable = Convert.ToInt32(Console.ReadLine());
        

        for (int i = 1; i <= 12; i++)
        {
            Console.WriteLine($"{timesTable} * {i} = {timesTable * i}");
        }
    }


}



