using api.cloneyoutube.Entity;
using api.cloneyoutube.InterfaceRepository;

namespace api.cloneyoutube.Services
{

    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;
        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public ICollection<UserEntity> getAllUsers()
        {

            var data = this.userRepository.getAllUsers();

            return data;

        }

    }

}