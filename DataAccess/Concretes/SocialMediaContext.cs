using Core.Entities.Concrete;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class SocialMediaContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=SocialMediaDb;Trusted_Connection=true");
        }

        public DbSet<Like> likes { get; set; }
        public DbSet<Comment> comments { get; set; }
        public DbSet<Post> posts { get; set; }
        public DbSet<OperationClaim> Operationclaims { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
    }
}
