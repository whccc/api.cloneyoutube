using api.cloneyoutube.Entity;
using api.cloneyoutube.InterfaceRepository;
using api.cloneyoutube.Model;
using Microsoft.EntityFrameworkCore;

namespace api.cloneyoutube.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly DBContextApp dbContext;
        public UserRepository(DBContextApp dBContext)
        {
            this.dbContext = dBContext;
        }

        public ICollection<UserEntity> getAllUsers()
        {
            var data = this.dbContext.User.Include(u => u.videos).ToList();
            return data;
        }
    }

}