using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ribeiro.MF7.Domain.Features.Users
{
    public class User : Entity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
