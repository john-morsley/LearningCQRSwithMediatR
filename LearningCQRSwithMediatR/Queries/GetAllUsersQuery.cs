using LearningCQRSwithMediatR.Models;
using MediatR;
using System.Collections.Generic;

namespace LearningCQRSwithMediatR.Queries
{

    public class GetAllUsersQuery : IRequest<IEnumerable<User>> { }

}