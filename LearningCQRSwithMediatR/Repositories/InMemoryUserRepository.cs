using LearningCQRSwithMediatR.Models;
using System.Collections.Generic;

namespace LearningCQRSwithMediatR.Repositories
{

    internal class InMemoryUserRepository : IUserRepository
    {

        private IList<User> _users;

        public InMemoryUserRepository()
        {
            _users = new List<User>();

            _users.Add(new User { FirstName = "Bruce", LastName = "Banner" });
            _users.Add(new User { FirstName = "Steve", LastName = "Rogers" });
            _users.Add(new User { FirstName = "Tony", LastName = "Stark" });
        }

        public void AddUser(User user)
        {
            _users.Add(user);
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _users;
        }

    }

}