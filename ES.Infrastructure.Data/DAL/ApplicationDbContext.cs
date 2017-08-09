using ES.Core.Domain;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.Infrastructure.Data.DAL
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public virtual DbSet<Exam> Exam { get; set; }
        public virtual DbSet<Question> Question { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }

    }


}
