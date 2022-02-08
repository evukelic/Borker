namespace Borker.Model
{
    public class User : EntityBase<int>
	{
        public static readonly int UndefinedUserID = -1;

		public User() : base(UndefinedUserID)
		{
		}

		public User(int id, string email, string username, string password) : base(id)
		{
			Email = email;
			Username = username;
			Password = password;
		}

		public string Email { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
	}
}
