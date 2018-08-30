using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ribeiro.MF7.Domain.Features.Users
{
    public interface IUserRepository
    {
        User GetByCredentials(string email, string password);
    }
}
