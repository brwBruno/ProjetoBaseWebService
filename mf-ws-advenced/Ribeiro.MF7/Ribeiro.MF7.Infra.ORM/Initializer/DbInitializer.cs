using Ribeiro.MF7.Infra.ORM.Contexts;
using Ribeiro.MF7.Infra.ORM.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ribeiro.MF7.Infra.ORM.Initializer
{
    public class DbInitializer : MigrateDatabaseToLatestVersion<RibeiroMF7Context, Configuration>
    {
    }
}
