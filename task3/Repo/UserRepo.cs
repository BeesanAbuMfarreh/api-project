using task3.Mdels;
namespace task3.Repo
{
    public class UserRepo
    {

        static List<User> users { get; set; }
        static UserRepo()
        {
            users = new List<User>()
            {
                new User() { Id = 1, Name = "Aliiiiiiiii"},
                new User() { Id = 2, Name = "Sara" },
                new User() { Id = 3, Name = "beesan" },
                new User() { Id = 4, Name = "ahmad" }
        };
        }
        public static List<User> GetAll()
        {
            return users;
        }
        public static User Get(int id)
        {
            return users.FirstOrDefault(user => user.Id == id);
        }
        public static void delete(int id)
        {
            var user = Get(id);
            if (user != null)
                users.Remove(user);
        }

        public static void add (User user)
        {
           users.Add(user);
       



        }
        public static void update(User user)
        {
            var index = users.FindIndex(e=> e.Id == user.Id);
            if (index == -1)
                return;
            users[index] = user;
        }
    }
    }
//



