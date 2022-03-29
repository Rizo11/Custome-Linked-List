namespace LList;

public class Program
{
    public static void Main()
    {
        CustomeLList<Book> bookList = new CustomeLList<Book>();
        var b1 = new Book("Alchemist", 1);
        var b2 = new Book("Atomic habbits", 2);
        var b3 = new Book("Alif", 3);
        var b4 = new Book("Tom", 4);
        bookList.AddNode(b1);
        bookList.AddNode(b2);
        bookList.AddNode(b3);
        bookList.AddNode(b4);


        bookList.Insert(b2, -1);

        foreach (var item in bookList)
        {
            System.Console.WriteLine($"{item.Name}");
        }
    }

}