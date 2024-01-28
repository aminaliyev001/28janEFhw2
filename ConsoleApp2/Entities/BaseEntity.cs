namespace ConsoleApp2.Entities;
public enum Status_
{
    Inserted,Updated,Deleted
}
public class BaseEntity
{
    public int Id { get; set; }
    public Status_ Status { get; set; }
    public DateTime Created { get; set; }
    public DateTime Updated { get; set; }
}
