using api.cloneyoutube.InterfaceRepository;
using api.cloneyoutube.Model;

namespace api.cloneyoutube.Repository
{
    public class AuthRepository : IAuthRepository
    {
        private readonly DBContextApp dbContext;
        public AuthRepository(DBContextApp dBContextApp)
        {
            this.dbContext = dBContextApp;
        }
        public UserModel? login(string email, string clave)
        {
            UserModel? user = this.dbContext.Users.
            FirstOrDefault(e => e.Email == email && e.Clave == clave);
            return user;
        }
    }
}