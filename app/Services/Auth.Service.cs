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

        public UserModel? login(string email, string clave)
        {
            UserModel? data = this.authRepository.login(email, clave);
            return data;
        }
    }
}