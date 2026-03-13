using AccountManagementModels;

namespace AccountService
{
    public class LoginService
    {
        public bool Login()
        {
            Console.Write("Enter Username: ");
            string username = Console.ReadLine() ?? "";

            Console.Write("Enter Password: ");
            string password = Console.ReadLine() ?? "";

            if (username == "admin" && password == "1234")
            {
                Console.WriteLine("Login Successful!");
                return true;
            }
            else
            {
                Console.WriteLine("Invalid Username or Password");
                return false;
            }
        }
    }
}