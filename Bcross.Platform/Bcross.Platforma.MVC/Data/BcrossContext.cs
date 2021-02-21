using Microsoft.EntityFrameworkCore;
using Bcross.Platforma.MVC.Models.DbModels;

namespace Bcross.Platforma.MVC.Models.AppDBContext
{
    public class BcrossContext : DbContext
    {
        private DbSet<DbModels.Company> Company { get; set; }


        public BcrossContext(DbContextOptions<BcrossContext> options)
            :base(options)
        {

        }

    }
}
