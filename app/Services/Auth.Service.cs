using api.cloneyoutube.Entity;
using api.cloneyoutube.InterfaceRepository;
using api.cloneyoutube.Model;

namespace api.cloneyoutube.Services
{
    public class AuthService : IAuthService
    {
        private readonly IAuthRepository authRepository;
        public AuthService(IAuthRepository authRepository)
        {
            this.authRepository = authRepository;
        }

        public UserEntity? login(string email, string clave)
        {
            UserEntity? data = this.authRepository.login(email, clave);
            return data;
        }
    }
}