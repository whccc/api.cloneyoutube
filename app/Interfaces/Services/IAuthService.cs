using api.cloneyoutube.Model;

namespace api.cloneyoutube.InterfaceRepository
{
    public interface IAuthService
    {
        UserModel? login(string email, string clave);
    }
}