using api.cloneyoutube.Entity;
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
        public UserEntity login(string email, string clave)
        {
            UserEntity? user = this.dbContext.User.
            FirstOrDefault(e => e.email == email && e.clave == clave);
            return user;
        }
    }
}