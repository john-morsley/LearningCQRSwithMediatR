using LearningCQRSwithMediatR.Models;
using System.Collections.Generic;

namespace LearningCQRSwithMediatR.Managers
{

    public interface IUserManager
    {

        void AddUser(User user);

        IEnumerable<User> GetAllUsers();
        
    }

}