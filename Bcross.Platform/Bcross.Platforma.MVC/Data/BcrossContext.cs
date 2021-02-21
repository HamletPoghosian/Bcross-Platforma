using Bcross.Platforma.MVC.Models.DbModels;
using Microsoft.EntityFrameworkCore;

namespace Bcross.Platforma.MVC.Models.AppDBContext
{
    public class BcrossContext : DbContext
    {
        public DbSet<DbModels.Company> Company { get; set; }


        public BcrossContext(DbContextOptions<BcrossContext> options)
            :base(options)
        {

        }

    }
}
