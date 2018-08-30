using Ribeiro.MF7.Domain.Features.Users;
using Ribeiro.MF7.Infra.Crypto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ribeiro.MF7.Applications.Features.Authentications
{
    public class AuthenticationService : IAuthenticationService
    {
        IUserRepository _repository;

        public AuthenticationService(IUserRepository repository)
        {
            _repository = repository;
        }

        public User Login(string email, string password)
        {
            password = password.GenerateHash();
            return _repository.GetByCredentials(email, password);
        }
    }
}
