using LearningCQRSwithMediatR.Models;
using LearningCQRSwithMediatR.Repositories;
using System.Collections.Generic;

namespace LearningCQRSwithMediatR.Managers
{

    public class UserManager : IUserManager
    {

        private readonly IUserRepository _userRepository;

        public UserManager(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void AddUser(User user)
        {
            _userRepository.AddUser(user);
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _userRepository.GetAllUsers();
        }

    }

}