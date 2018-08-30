using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ribeiro.MF7.Infra.ORM.Contexts
{
    public class DbContextFactory : IDbContextFactory<RibeiroMF7Context>
    {
        public RibeiroMF7Context Create()
        {
            return new RibeiroMF7Context();
        }
    }
}
