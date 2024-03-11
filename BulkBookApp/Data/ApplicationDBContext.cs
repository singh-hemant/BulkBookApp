using BulkBookApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkBookApp.Data
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options):base(options)
        { 
        }
        DbSet<Category> categories {  get; set; }
    }
}
