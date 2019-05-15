using Microsoft.EntityFrameworkCore;
using WebVueModel;

namespace WebVueDAL
{
    public class StudentDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base (options)
        {

        }
    }
}
