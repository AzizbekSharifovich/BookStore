using Books.Core.Configurations;
using Books.Core.Entities;
using Books.Core.Entities.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace Books.Core.Data;
public class BookDbContext : DbContext
{
    public BookDbContext(DbContextOptions<BookDbContext> options) : base(options) { }

    public DbSet<Book>? Books { get; set; }
    public DbSet<Writer> Writers { get; set; }
    public DbSet<Genre> Genres { get; set; }
    public DbSet<BookSeries> BookSeries { get; set; }
    public DbSet<BookFile> BookFiles { get; set; }
    public DbSet<BookGenre> BookGenres { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        new BookGenreConfiguration().Configure(modelBuilder.Entity<BookGenre>());
    }
}

