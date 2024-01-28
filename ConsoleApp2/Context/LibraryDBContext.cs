using Microsoft.EntityFrameworkCore;
using ConsoleApp2.Entities;
namespace ConsoleApp2.Context;
public class LibraryDBContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string connectionstr = "";
        optionsBuilder.UseSqlServer(connectionstr);
        base.OnConfiguring(optionsBuilder);
    }
    public DbSet<Student> Students { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<BookType> BookTypes { get; set; }
    public DbSet<Operation> Operations { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Operation>()
            .HasOne(p => p.Student)
            .WithMany(b => b.Operations)
            .HasForeignKey(p => p.StudentId);

        modelBuilder.Entity<Operation>()
            .HasOne(p => p.Book)
            .WithMany(t => t.Operations)
            .HasForeignKey(p => p.BookId);

        modelBuilder.Entity<Book>()
            .HasOne(b => b.Author)
            .WithMany(a => a.Books)
            .HasForeignKey(b => b.AuthorId);

        modelBuilder.Entity<Book>()
            .HasOne(b => b.BookType)
            .WithMany(bt => bt.Books)
            .HasForeignKey(b => b.BookTypeId);
    }

}
