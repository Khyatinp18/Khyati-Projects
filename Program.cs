using System;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            string vacationType = null;
            int groupSize = 0;
            string result = null;
            bool validVacationType = false;
            bool validGroupSize = false;

            while (!validVacationType)
            {
                Console.WriteLine("What kind of trip would you like to go on, musical, tropical, or adventurous? ");
                vacationType = Console.ReadLine();

                if (vacationType == "musical" || vacationType == "tropical" || vacationType == "adventurous")
                {
                    validVacationType = true;
                } 
                else
                {
                    Console.WriteLine("Invalid vacation type. Please try again. \n");
                }
            }

            while (!validGroupSize)
            {
                Console.WriteLine("How many are in your group?");
                groupSize = int.Parse(Console.ReadLine());

                if (groupSize > 0) 
                {
                    validGroupSize = true;
                }
                else
                {
                    Console.WriteLine("Invalid group size. Please try again. \n");
                }

            }

            result = "Since you’re a group of " + groupSize + " going on a " + vacationType + " vacation, you should take a ";

            if (vacationType == "musical" && groupSize > 0 && groupSize <= 2)
            {
                result +=  "first class to New Orleans.";
            }
            else if (vacationType == "musical" && groupSize >=3 && groupSize <= 5)
            {
                result +=  "helicopter to New Orleans.";
            }
            else if (vacationType == "musical" && groupSize >= 6)
            {
                result +=  "charter flight to New Orleans.";
            }
            else if (vacationType == "tropical" && groupSize > 0 && groupSize <= 2)
            {
                result +=  "first class to a beach vacation in Mexico.";
            }
            else if (vacationType == "tropical" && groupSize >= 3 && groupSize <= 5)
            {
                result += "helicopter to a beach vacation in Mexico.";
            }
            else if (vacationType == "tropical" && groupSize >= 6)
            {
                result +=  "charter flight to a beach vacation in Mexico.";
            }
            else if (vacationType == "adventurous" && groupSize > 0 && groupSize <= 2)
            {
                result +=  "first class to a whitewater rafting the Grand Canyon.";
            }
            else if (vacationType == "adventurous" && groupSize >= 3 && groupSize <= 5)
            {
                result +=  "helicopter to a whitewater rafting the Grand Canyon.";
            }
            else if (vacationType == "adventurous" && groupSize >= 6)
            {
                result +=  "charter flight to a whitewater rafting the Grand Canyon.";
            }
            else
            {
                result = "Invalid input. Please try again.";
            }

            Console.WriteLine (result);
        }
    }
}
