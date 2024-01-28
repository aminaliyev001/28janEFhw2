using System.ComponentModel.DataAnnotations;
using System.Reflection;
namespace ConsoleApp2.Entities;
public enum Gender
{
    Male, Female
}
public class Student : BaseEntity
{
    [Required]
    public string FirstName { get; set; }

    [Required]
    public string LastName { get; set; }

    public int SchoolNumber { get; set; }

    public Gender Gender { get; set; }

    public DateTime BirthDay { get; set; }

    public string PhoneNumber { get; set; }

    public ICollection<Operation> Operations { get; set; }
}
