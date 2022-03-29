namespace LList;

public class Node<T>
{
    public T Data {get; set; }
    public Node<T> Next { get; set; }
    public Node<T> Prep { get; set; }
    public Node(T data)
    {
        Data = data;
        Next = null;
        Prep = null;
    }
}