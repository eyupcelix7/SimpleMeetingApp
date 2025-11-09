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
            CreateUser(new UserInfo {Id = 1, Name = "Ahmet", Email = "ahmet1234@gmail.com", Phone = "05322312345", KatilimDurumu = false });
            CreateUser(new UserInfo {Id = 2, Name = "Emre", Email = "emre04@gmail.com", Phone = "053223122131", KatilimDurumu = true });
            CreateUser(new UserInfo {Id = 3, Name = "Yunus", Email = "yunus1252@gmail.com", Phone = "05322312325", KatilimDurumu = true });
        }
        public static void CreateUser(UserInfo user)
        {
            user.Id = Users.Count + 1;
            _users.Add(user);
        }
        public static UserInfo? GetById(int id)
        {
            return _users.FirstOrDefault(x => x.Id == id);
        }
    }
}
