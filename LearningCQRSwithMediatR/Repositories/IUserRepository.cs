﻿using LearningCQRSwithMediatR.Models;
using System.Collections.Generic;

namespace LearningCQRSwithMediatR.Repositories
{

    public interface IUserRepository
    {

        IEnumerable<User> GetAllUsers();

        void AddUser(User user);

    }

}