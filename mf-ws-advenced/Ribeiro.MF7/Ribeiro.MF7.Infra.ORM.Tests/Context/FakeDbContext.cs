using Ribeiro.MF7.Infra.ORM.Contexts;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ribeiro.MF7.Infra.ORM.Tests.Context
{
    public class FakeDbContext : RibeiroMF7Context
    {
        public FakeDbContext(DbConnection connection) : base(connection)
        {

        }
    }
}
