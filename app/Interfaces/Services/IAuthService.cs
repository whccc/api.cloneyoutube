using api.cloneyoutube.Entity;
using api.cloneyoutube.Model;

namespace api.cloneyoutube.InterfaceRepository
{
    public interface IAuthService
    {
        UserEntity? login(string email, string clave);
    }
}