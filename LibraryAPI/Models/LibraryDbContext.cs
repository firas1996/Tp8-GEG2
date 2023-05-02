using Microsoft.EntityFrameworkCore;

namespace LibraryAPI.Models
{
    public class LibraryDbContext : DbContext
    {
        public LibraryDbContext(DbContextOptions options) : base(options)
        {
        }
        public virtual DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(
                new Book { Id=1,Title="Book 1",Description="Discription 1",Author="Author 1",Rating=3.4,CoverUrl="https://www.book1.com"},
                new Book { Id=2,Title="Book 2",Description="Discription 2",Author="Author 2",Rating=3.4,CoverUrl="https://www.book2.com"},
                new Book { Id=3,Title="Book 3",Description="Discription 3",Author="Author 3",Rating=3.4,CoverUrl="https://www.book3.com"},
                new Book { Id=4,Title="Book 4",Description="Discription 4",Author="Author 4",Rating=3.4,CoverUrl="https://www.book4.com"}
                );
        }
    }
}
