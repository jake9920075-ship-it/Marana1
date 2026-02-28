using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;

            while (true)
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine("Class Schedule");
                Console.WriteLine("-----------------------");
                Console.WriteLine("1. OOP.");
                Console.WriteLine("2. PATHFIT.");
                Console.WriteLine("3. Filipino.");
                Console.WriteLine("4. Integrative Programming.");
                Console.WriteLine("5. Computer Programming.");
                Console.WriteLine("6. Exit");
                Console.WriteLine("-----------------------");

                if (!int.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine("Invalid input.");
                    continue;
                }

                //OOP
                if (num == 1)
                {
                    Console.WriteLine("OOP - Choose Day:");
                    Console.WriteLine("1. Monday");
                    Console.WriteLine("2. Saturday");

                    int day = Convert.ToInt32(Console.ReadLine());

                    if (day == 1)
                    {
                        Console.WriteLine("Monday - Choose Time:");
                        Console.WriteLine("1. 8:30 AM - 12:30 PM");
                        Console.WriteLine("2. 1:00 PM - 4:00 PM");

                        int time = Convert.ToInt32(Console.ReadLine());

                        if (time == 1)
                            Console.WriteLine("OOP Monday: 8:30 AM - 12:30 PM");
                        else if (time == 2)
                            Console.WriteLine("OOP Monday: 1:00 PM - 4:00 PM");
                        else
                            Console.WriteLine("Invalid time choice.");
                    }
                    else if (day == 2)
                    {
                        Console.WriteLine("Saturday - Choose Time:");
                        Console.WriteLine("1. 2:30 PM - 5:30 PM");
                        Console.WriteLine("2. 6:00 PM - 9:00 PM");

                        int time = Convert.ToInt32(Console.ReadLine());

                        if (time == 1)
                            Console.WriteLine("OOP Saturday: 2:30 PM - 5:30 PM");
                        else if (time == 2)
                            Console.WriteLine("OOP Saturday: 6:00 PM - 9:00 PM");
                        else
                            Console.WriteLine("Invalid time choice.");
                    }
                }

                //PATHFIT
                else if (num == 2)
                {
                    Console.WriteLine("PATHFIT - Choose Day:");
                    Console.WriteLine("1. Monday");
                    Console.WriteLine("2. Wednesday");

                    int day = Convert.ToInt32(Console.ReadLine());

                    if (day == 1)
                    {
                        Console.WriteLine("Monday - Choose Time:");
                        Console.WriteLine("1. 2:00 PM - 5:00 PM");
                        Console.WriteLine("2. 5:30 PM - 8:30 PM");

                        int time = Convert.ToInt32(Console.ReadLine());

                        if (time == 1)
                            Console.WriteLine("PATHFIT Monday: 2:00 PM - 5:00 PM");
                        else if (time == 2)
                            Console.WriteLine("PATHFIT Monday: 5:30 PM - 8:30 PM");
                        else
                            Console.WriteLine("Invalid time choice.");
                    }
                    else if (day == 2)
                    {
                        Console.WriteLine("Wednesday - Choose Time:");
                        Console.WriteLine("1. 8:00 AM - 12:00 PM");
                        Console.WriteLine("2. 1:00 PM - 4:00 PM");

                        int time = Convert.ToInt32(Console.ReadLine());

                        if (time == 1)
                            Console.WriteLine("PATHFIT Wednesday: 8:00 AM - 12:00 PM");
                        else if (time == 2)
                            Console.WriteLine("PATHFIT Wednesday: 1:00 PM - 4:00 PM");
                        else
                            Console.WriteLine("Invalid time choice.");
                    }
                }

                //FILIPINO
                else if (num == 3)
                {
                    Console.WriteLine("Filipino - Choose Day:");
                    Console.WriteLine("1. Wednesday");
                    Console.WriteLine("2. Friday");

                    int day = Convert.ToInt32(Console.ReadLine());

                    if (day == 1)
                    {
                        Console.WriteLine("Wednesday - Choose Time:");
                        Console.WriteLine("1. 2:00 PM - 5:00 PM");
                        Console.WriteLine("2. 5:30 PM - 8:30 PM");

                        int time = Convert.ToInt32(Console.ReadLine());

                        if (time == 1)
                            Console.WriteLine("Filipino Wednesday: 2:00 PM - 5:00 PM");
                        else if (time == 2)
                            Console.WriteLine("Filipino Wednesday: 5:30 PM - 8:30 PM");
                        else
                            Console.WriteLine("Invalid time choice.");
                    }
                    else if (day == 2)
                    {
                        Console.WriteLine("Friday - Choose Time:");
                        Console.WriteLine("1. 2:00 PM - 5:00 PM");
                        Console.WriteLine("2. 6:00 PM - 9:00 PM");

                        int time = Convert.ToInt32(Console.ReadLine());

                        if (time == 1)
                            Console.WriteLine("Filipino Friday: 2:00 PM - 5:00 PM");
                        else if (time == 2)
                            Console.WriteLine("Filipino Friday: 6:00 PM - 9:00 PM");
                        else
                            Console.WriteLine("Invalid time choice.");
                    }
                }

                //INTEGRATIVE PROGRAMMING
                else if (num == 4)
                {
                    Console.WriteLine("Integrative Programming - Choose Day:");
                    Console.WriteLine("1. Sunday");

                    int day = Convert.ToInt32(Console.ReadLine());

                    if (day == 1)
                    {
                        Console.WriteLine("Sunday - Choose Time:");
                        Console.WriteLine("1. 8:30 AM - 12:30 PM");
                        Console.WriteLine("2. 12:30 PM - 3:30 PM");

                        int time = Convert.ToInt32(Console.ReadLine());

                        if (time == 1)
                            Console.WriteLine("Integrative Programming Sunday: 8:30 AM - 12:30 PM");
                        else if (time == 2)
                            Console.WriteLine("Integrative Programming Sunday: 12:30 PM - 3:30 PM");
                        else
                            Console.WriteLine("Invalid time choice.");
                    }
                }

                //COMPUTER PROGRAMMING
                else if (num == 5)
                {
                    Console.WriteLine("Computer Programming - Choose Day:");
                    Console.WriteLine("1. Friday");
                    Console.WriteLine("2. Saturday");

                    int day = Convert.ToInt32(Console.ReadLine());

                    if (day == 1)
                    {
                        Console.WriteLine("Friday - Choose Time:");
                        Console.WriteLine("1. 8:30 AM - 12:30 PM");
                        Console.WriteLine("2. 1:30 PM - 4:30 PM");

                        int time = Convert.ToInt32(Console.ReadLine());

                        if (time == 1)
                            Console.WriteLine("Computer Programming Friday: 8:30 AM - 12:30 PM");
                        else if (time == 2)
                            Console.WriteLine("Computer Programming Friday: 1:30 PM - 4:30 PM");
                        else
                            Console.WriteLine("Invalid time choice.");
                    }
                    else if (day == 2)
                    {
                        Console.WriteLine("Saturday - Choose Time:");
                        Console.WriteLine("1. 8:30 AM - 1:30 PM");
                        Console.WriteLine("2. 2:00 PM - 6:00 PM");

                        int time = Convert.ToInt32(Console.ReadLine());

                        if (time == 1)
                            Console.WriteLine("Computer Programming Saturday: 8:30 AM - 1:30 PM");
                        else if (time == 2)
                            Console.WriteLine("Computer Programming Saturday: 2:00 PM - 6:00 PM");
                        else
                            Console.WriteLine("Invalid time choice.");
                    }
                }

                else if (num == 6)
                {
                    Console.WriteLine("Exiting program...");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice.");
                }

                Console.WriteLine("\nPress Enter to continue...");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}