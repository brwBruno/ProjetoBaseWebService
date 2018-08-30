using Ribeiro.MF7.Domain.Features.Users;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ribeiro.MF7.Infra.ORM.Features.Users
{
    public class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            this.ToTable("TBUsers");
            this.HasKey(u => u.Id);
            this.Property(u => u.Name).HasMaxLength(50).IsRequired();
            this.Property(u => u.Email).HasMaxLength(40).IsRequired();
            this.Property(u => u.Password).HasMaxLength(50).IsRequired();
        }
    }
}
