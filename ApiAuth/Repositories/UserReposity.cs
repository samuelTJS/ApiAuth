using ApiAuth.Models;

namespace ApiAuth.Repositories
{
    public static class UserReposity
    {
        public static User Get(string username, 
            string password)
        {
            var users = new List<User>
            {
                new User { Id = 1, 
                    UserName = "fulano",
                    Password = "123",
                    Role = "gerente"
                },
                new User { Id = 2,
                    UserName = "ciclano",
                    Password = "123",
                    Role = "estagiario"
                }
            };

            return users.First(x =>
                x.UserName == username &&
                x.Password == password);
        }
    }
}
