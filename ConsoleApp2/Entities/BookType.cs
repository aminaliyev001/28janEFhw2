using System.ComponentModel.DataAnnotations;

namespace ConsoleApp2.Entities;
public class BookType : BaseEntity
{
    [Required]
    public string Name { get; set; }
    public ICollection<Book> Books { get; set; }
}
