using AccountService;
using ScheduleLibrary;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            LoginService login = new LoginService();

            if (!login.Login())
                return;

            Menu menu = new Menu();
            OOPSchedule oop = new OOPSchedule();
            PathfitSchedule pathfit = new PathfitSchedule();

            while (true)
            {
                menu.ShowMenu();

                Console.Write("Select option: ");
                string choice = Console.ReadLine() ?? "";

                switch (choice)
                {
                    case "1":
                        oop.ShowSchedule();
                        break;

                    case "2":
                        pathfit.ShowSchedule();
                        break;

                    case "6":
                        return;

                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }

                Console.WriteLine("\nPress Enter to continue...");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}