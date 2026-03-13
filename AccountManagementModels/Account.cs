namespace AccountManagementModels
{
    public class Account
    {
        public Guid AccountId { get; set; }

        public string Username { get; set; } = "";

        public string Password { get; set; } = "";

        public Account()
        {
            AccountId = Guid.NewGuid();
        }

        public Account(string username, string password)
        {
            AccountId = Guid.NewGuid();
            Username = username;
            Password = password;
        }
    }
}