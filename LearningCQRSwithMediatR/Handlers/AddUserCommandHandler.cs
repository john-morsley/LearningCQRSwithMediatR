using LearningCQRSwithMediatR.Commands;
using LearningCQRSwithMediatR.Models;
using LearningCQRSwithMediatR.Repositories;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace LearningCQRSwithMediatR.Handlers
{

    public class AddUserCommandHandler : IRequestHandler<AddUserCommand, Unit>
    {

        private readonly IUserRepository _userRepository;

        public AddUserCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<Unit> Handle(AddUserCommand request, CancellationToken cancellationToken)
        {
            var user = new User { FirstName = request.FirstName, LastName = request.LastName }; 
            await Task.Run(() => _userRepository.AddUser(user));            
            return Unit.Value;
        }

    }

}