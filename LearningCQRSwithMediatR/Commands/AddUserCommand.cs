using MediatR;

namespace LearningCQRSwithMediatR.Commands
{

    public class AddUserCommand : IRequest
    {

        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public AddUserCommand(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

    }

}