using Microsoft.EntityFrameworkCore;

namespace AutoMapper.Data
{
    public class ApplicationDbContext :DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
        { 

        }

    }
}
