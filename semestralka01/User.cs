namespace semestralka01
{

    public class User
    {
        public User(string username, string password, bool adminRole)
        {
            this.Password = password;
            this.Username = username;
            this.AdminRole = adminRole;
        }
        public User()
        {
        }
        public string Username { get; set; }

        public string Password { get; set; }

        public bool AdminRole { get; set; }

    }
       
    
}
