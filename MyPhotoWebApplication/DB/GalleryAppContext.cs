using Microsoft.EntityFrameworkCore;
using MyPhotoWebApplication.Models;

namespace MyPhotoWebApplication.DB
{
    public class GalleryAppContext : DbContext
    {
        public GalleryAppContext(DbContextOptions<GalleryAppContext> options)
            : base(options)
        { }

        public DbSet<Image> Images { get; set; }
    }
    
}
