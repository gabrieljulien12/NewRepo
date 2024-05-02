using Microsoft.EntityFrameworkCore;
using MvcCrudScrafOlding.Entities;

namespace MvcCrudScrafOlding.Models
{
    public class UserContext:DbContext
    {
        public UserContext(DbContextOptions options) : base(options)
        {


        }
       
        public DbSet<User> Users { get; set; }
    }
}
