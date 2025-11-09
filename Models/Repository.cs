namespace SimpleMeetingApp.Models
{
    public static class Repository
    {
        private static List<UserInfo> _users = new();
        public static List<UserInfo> Users
        {
            get
            {
                return _users;
            }
        }
        static Repository()
        {
            CreateUser(new UserInfo { Name = "Ahmet", Email = "ahmet1234@gmail.com", Phone = "05322312345", KatilimDurumu = false });
            CreateUser(new UserInfo { Name = "Emre", Email = "emre04@gmail.com", Phone = "053223122131", KatilimDurumu = true });
            CreateUser(new UserInfo { Name = "Yunus", Email = "yunus1252@gmail.com", Phone = "05322312325", KatilimDurumu = true });
        }
        public static void CreateUser(UserInfo user)
        {
            _users.Add(user);
        }
    }
}
