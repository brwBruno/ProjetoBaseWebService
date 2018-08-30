using Ribeiro.MF7.Domain.Features.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ribeiro.MF7.Applications.Features.Authentications
{
    public interface IAuthenticationService
    {
        User Login(string email, string password);
    }
}
