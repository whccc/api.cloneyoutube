using api.cloneyoutube.Entity;

namespace api.cloneyoutube.InterfaceRepository
{
    public interface IAuthRepository
    {
        UserEntity? login(string email, string clave);

    }
}