using Ribeiro.MF7.Domain.Features.Users;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ribeiro.MF7.Infra.ORM.Contexts
{
    public class RibeiroMF7Context : DbContext
    {
        public RibeiroMF7Context(string connection = "Name=MF_WSA_Ribeiro") : base(connection)
        {
            this.Configuration.LazyLoadingEnabled = true;
        }

        protected RibeiroMF7Context(DbConnection connection) : base(connection, true) { }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.AddFromAssembly(System.Reflection.Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
    }
}
