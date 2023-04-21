using api.cloneyoutube.Entity;

namespace api.cloneyoutube.InterfaceRepository
{

    public interface IUserService
    {
        public ICollection<UserEntity> getAllUsers();
    }

}