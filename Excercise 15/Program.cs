using System;

namespace Excercise_15
{
    class Program
    {
        static void Main(string[] args)
        {
            {
            
                {
                    while (true)
                    {
                        Console.Write("Please Enter a number ");
                        int userNumber = int.Parse(Console.ReadLine());
                        int power = 3;
                        int userIter = 1;
                        string uChoice;


                        for (int i = 1; i <= userNumber; i++)
                        {
                            double result = Math.Pow(userIter, power);
                            Console.WriteLine(result);
                            userIter++;
                        }


                        Console.WriteLine("Would you like to enter another number?? Y or N");
                        uChoice = Console.ReadLine().ToLower();

                        if (uChoice == "n")
                        {
                            Console.WriteLine("Thank you, Goodbye!");
                            break;
                        }

                    }
                }
            }
        }
    }
    }

