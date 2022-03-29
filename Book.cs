namespace LList;

public class Book
{
    public string Name { get; set; }
    public int Id { get; set; }
    public Book(string name, int id)
    {
        Name = name;
        Id = id;
    }
}