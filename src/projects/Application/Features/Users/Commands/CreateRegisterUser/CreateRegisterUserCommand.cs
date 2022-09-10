using Application.Features.Users;
using Application.Services.Repositories;
using Core.Domain.Entities;
using Core.Security.Helpers;
namespace Application.Features.Users.Commands.CreateRegisterUser;

public class CreateRegisterUserCommand : IRequest<bool>
{
    public CreateRegisterUserCommandDto User { get; set; }


    public class CreateRegisterUserCommandHandler : IRequestHandler<CreateRegisterUserCommand, bool>
    {
        private readonly IUserRepository _userRepository;
        private readonly UserBusinessRules _rules;

        public CreateRegisterUserCommandHandler(IUserRepository userRepository, UserBusinessRules rules)
        {
            _userRepository = userRepository;
            _rules = rules;
        }

        public async Task<bool> Handle(CreateRegisterUserCommand request, CancellationToken cancellationToken)
        {
            await _rules.UserEmailCanNotBeDuplicated(request.User.Email);

            HashingHelper.CreatePasswordHash(request.User.Password, out var passwordSalt, out var passwordHash);

            await _userRepository.AddAsync(new User
            {
                FirstName = request.User.FirstName,
                LastName = request.User.LastName,
                Email = request.User.Email,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                Status = true
            });

            return true;
        }
    }
}
