using System.ComponentModel.DataAnnotations;
namespace ConsoleApp2.Entities;
public class Author : BaseEntity
{
    [Required]
    public string FirstName { get; set; }

    [Required]
    public string LastName { get; set; }

    public ICollection<Book> Books { get; set; }
}
