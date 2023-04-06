using api.cloneyoutube.Model;

namespace api.cloneyoutube.InterfaceRepository
{
    public interface IAuthRepository
    {
        UserModel? login(string email, string clave);

    }
}