using Microsoft.EntityFrameworkCore;

namespace _231130API.Modells {
    public class BlogDBContext : DbContext {
        public BlogDBContext(DbContextOptions options) : base(options) {

        }

        public BlogDBContext() {

        }

        public DbSet<BlogUser> BlogUsers { get; set; } = null;
        public DbSet<BlogPosts> BlogPosts { get; set; } = null;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            if (!optionsBuilder.IsConfigured) {
                string conn = "server=localhost; database=Blog; user=root; password=";

                optionsBuilder.UseMySql(conn, ServerVersion.AutoDetect(conn));
            }
        }
    }
}
