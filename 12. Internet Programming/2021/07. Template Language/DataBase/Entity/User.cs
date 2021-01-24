namespace DataBase.Entity
{
    public enum Roles
    {
        User, Admin
    }

    public class User : BaseEntity
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public string Fullname { get; set; }

        public string Email { get; set; }

        public Roles Role { get; set; }
    }
}
