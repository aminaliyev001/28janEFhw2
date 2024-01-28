using System.ComponentModel.DataAnnotations;
namespace ConsoleApp2.Entities;
public class Book : BaseEntity
{
    [Required]
    public string Name { get; set; }

    public int PageCount { get; set; }

    public int AuthorId { get; set; }
    public Author Author { get; set; }

    public int BookTypeId { get; set; }
    public BookType BookType { get; set; }

    public ICollection<Operation> Operations { get; set; }
}
