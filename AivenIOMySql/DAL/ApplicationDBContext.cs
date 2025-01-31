using AivenIOMySql.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace AivenIOMySql.DAL
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }


        #region DBSet

        public DbSet<TestTable> TestTable { get; set; }

        #endregion

    }
}
