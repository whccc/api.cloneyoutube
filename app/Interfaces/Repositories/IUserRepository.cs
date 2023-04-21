using api.cloneyoutube.Entity;

namespace api.cloneyoutube.InterfaceRepository
{
    public interface IUserRepository
    {
        public ICollection<UserEntity> getAllUsers();
    }

}