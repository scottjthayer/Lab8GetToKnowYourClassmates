using System;

namespace Lab_8_Get_To_Know_Your_Classmates
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = {
                "Justin Jones", 
                "Matt Bye", 
                "Logan Harris",
                "Raston Gilbert",
                "Yousif Beeai",
                "Yash Majalikar",
                "Chris Paul",
                "Radeen Ahmed",
                "Joshua Carolin",
                "Aron Gibson",
                "Kasean Barber",
                "Scott Thayer",
                "Delmar Presley",
                "Brandon Pietryka"};
            string[] hometowns = {
                "Wyoming, MI",
                "Flint, MI",
                "Plymouth, MI",
                "Zeeland, MI",
                "Oak Park, MI",
                "Detroit, MI",
                "Novi, MI",
                "Warren, MI",
                "Northville, MI",
                "Berea, KY",
                "Detroit, MI",
                "Lansing, MI",
                "Detroit, MI",
                "Novi, MI" };
            string[] favFood = {
                "Baja Blast",
                "Hot Wings",
                "Funyuns",
                "Vanilla Instant Pudding",
                "Deep Dish Pizza",
                "Hot Cheeto Puffs",
                "Tacos",
                "Mexican",
                "Naleśniki",
                "Sushi",
                "Steak",
                "Nashville Chicken",
                "Vietnamese Food",
                "Sushi" };

            Console.WriteLine("Welcome to the 2021 C# Bootcamp Student Database.");

            bool isRunning = true;
            while (isRunning == true)
            {
                Console.WriteLine("Which person would you like to learn more about? Enter a number 1-14.");
                int input = int.Parse(Console.ReadLine()) - 1;
                //validates input to actual array size
                if (input < 0 || input > 13)
                {
                    Console.WriteLine("That is not a valid student, try again.");
                    continue;
                }
                //gets index to find first name.
                int indexSpace = names[input].IndexOf(' ');

                Console.WriteLine($"Student {input + 1} is {names[input]}.");

                bool knowMore = true;
                while (knowMore == true)
                {
                    Console.WriteLine($"What would you like to know about {names[input].Substring(0, indexSpace)}?\nEnter 'hometown' or 'favorite food.'");

                    bool dataType = true;
                    while (dataType == true)
                    {
                        string typeInfo = Console.ReadLine().ToLower();
                        if (typeInfo == "hometown")
                        {
                            Console.WriteLine($"{names[input]}'s hometown is {hometowns[input]}.");
                            dataType = false;
                        }
                        else if (typeInfo == "favorite food")
                        {
                            Console.WriteLine($"{names[input]}'s favorite food is {favFood[input]}. Sounds delicious, doesn't it?");
                            dataType = false;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, that data does not exist. Please enter 'hometown' or 'favorite food'");
                            continue;
                        }
                    }
                    knowMore = GetYesOrNo($"Would you like to know more about {names[input]}?");                    
                }
                isRunning = GetYesOrNo("Do you want to inquire about a different student?");          
            }
            Console.WriteLine("Okay, bye!");
        }

        public static bool GetYesOrNo(string prompt)
        {
            while (true)
            {
                Console.WriteLine(prompt);
                Console.Write("Y/N? ");
                string input = Console.ReadLine().Trim().ToLower();

                if (input == "y")
                {
                    return true;
                }
                else if (input == "n")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("That input is not valid, please try again.");
                }
            }
        }

    }
}
