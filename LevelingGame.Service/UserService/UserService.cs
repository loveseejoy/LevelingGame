using LevelingGame.Core.Entity;
using LevelingGame.Core.IRepository;

namespace LevelingGame.Service.UserService
{
    public class UserService:IUserService
    {
        private IRepository<User> _useRepository;

        public UserService(IRepository<User> useRepository)
        {
            _useRepository = useRepository;
        }

        public void AddUser()
        {
            _useRepository.Insert(new User
            {
                Name = "test",
                Password = "1234"
            });
        }
    }
}