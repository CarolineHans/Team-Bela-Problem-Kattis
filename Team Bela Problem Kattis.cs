// This C# code is the programming for the Kattis Bela Problem attempted by Caroline Hansen.
// Date: 02/24/2022
using System;

namespace Team_Bela_Problem_Kattis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Define hands and suit from input
            int hands = int.Parse(Console.ReadLine());
            char suit = char.Parse(Console.ReadLine());

            // Define variable to store total points
            int total = 0;

            // Read input given
            string input = Console.ReadLine();
            // Start for loop depending on number of hands
            for (int i = 0; i < hands * 4; i++)
                // If statement to determine if input matches the dominant suit
                if (input == "suit")
                {
                    //If / else statements to match each input value and assign points accordingly
                    if (input == "AS")
                    {
                        total += 11;
                    }
                    else if (input == "AH")
                    {
                        total += 11;
                    }
                    else if (input == "AD")
                    {
                        total += 11;
                    }
                    else if (input == "AC")
                    {
                        total += 11;
                    }
                    else if (input == "KS")
                    {
                        total += 4;
                    }
                    else if (input == "KH")
                    {
                        total += 4;
                    }
                    else if (input == "KD")
                    {
                        total += 4;
                    }
                    else if (input == "KC")
                    {
                        total += 4;
                    }
                    else if (input == "QS")
                    {
                        total += 3;
                    }
                    else if (input == "QH")
                    {
                        total += 3;
                    }
                    else if (input == "QD")
                    {
                        total += 3;
                    }
                    else if (input == "QC")
                    {
                        total += 3;
                    }
                    else if (input == "TS")
                    {
                        total += 10;
                    }
                    else if (input == "TH")
                    {
                        total += 10;
                    }
                    else if (input == "TD")
                    {
                        total += 10;
                    }
                    else if (input == "TC")
                    {
                        total += 10;
                    }
                    else if (input == "suit" + "J")
                    {
                        total += 20;
                    }
                    else if (input == "suit" + "9")
                    {
                        total += 14;
                    }
                }

                // Else if statement to determine if input does not match the dominant suit
                else if (input != "suit")
                {
                    if (input != "suit" + "J")
                        {
                        total += 2;
                        }
                }

                // For all other input, assign value of 0 points
                else
                {
                    total += 0;
                }

            // Display the total number of points
            //Console.WriteLine(total);
        }
    }
}
