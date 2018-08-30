using Ribeiro.MF7.Domain.Exceptions;
using Ribeiro.MF7.Domain.Features.Users;
using Ribeiro.MF7.Infra.ORM.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ribeiro.MF7.Infra.ORM.Features.Users
{
    public class UserRepository : IUserRepository
    {
        RibeiroMF7Context _context;

        public UserRepository(RibeiroMF7Context context)
        {
            _context = context;
        }

        public User GetByCredentials(string usarname, string password)
        {
            var user = _context.Users.FirstOrDefault(u => u.Name == usarname && u.Password == password);
            if (user == null)
                throw new BusinessException(ErrorCodes.BadRequest, "Usuario ou senha invalidos");
            return user;
        }
    }
}
