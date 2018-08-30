namespace Ribeiro.MF7.Infra.ORM.Migrations
{
    using Ribeiro.MF7.Domain.Features.Users;
    using Ribeiro.MF7.Infra.Crypto;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public class Configuration : DbMigrationsConfiguration<Ribeiro.MF7.Infra.ORM.Contexts.RibeiroMF7Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Ribeiro.MF7.Infra.ORM.Contexts.RibeiroMF7Context context)
        {
            var password = "Admin";

            var _user = new User()
            {
                Id = 1,
                Name = "Admin",
                Email = "admin@admin.com",
                Password = password.GenerateHash(),
            };

            var foundUser = context.Users.Where(u => u.Email == _user.Email).FirstOrDefault();
            if (foundUser == null)
                context.Users.Add(_user);
        }
    }
}
