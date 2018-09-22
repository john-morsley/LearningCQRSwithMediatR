using LearningCQRSwithMediatR.Models;
using LearningCQRSwithMediatR.Queries;
using LearningCQRSwithMediatR.Repositories;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace LearningCQRSwithMediatR.Handlers
{

    public class GetAllUsersQueryHandler : IRequestHandler<GetAllUsersQuery, IEnumerable<User>>
    {

        private readonly IUserRepository _userRepository;

        public GetAllUsersQueryHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public Task<IEnumerable<User>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        {
            return Task.Run(() => _userRepository.GetAllUsers());
        }

    }

}