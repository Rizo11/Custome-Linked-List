using System.Collections;

namespace LList;

public class CustomeLList<T> : IEnumerable<T>
{
    public Node<T> Head { get; set; }
    public int Count { get; set; }

    public CustomeLList()
    {
        Head = null;
        Count = 0;
    }

    public void AddNode(T data)
    {
        var node = new Node<T>(data);
        if(Head is null)
        {
            Head = node;
        }
        else
        {
            var current = Head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = node; //new head
        }
        Count++;
    }
    
    public void Insert(T data, int index)
    {
        var node = new Node<T>(data);
        var current = Head;
        if(index == 0)
        {
            node.Next = Head;
            Head = node;
            return;
        }
        if(index < 0 || index > Count)
        {
            throw new IndexOutOfRangeException($"index out of range");
        }
        while (--index > 0)
        {
            current = current.Next;
        }
        node.Next = current.Next;
        current.Next = node;
        return;
    }

    public T Remove(T data)
    {
        if (Head == null)
            return data;

        if (Head.Data.Equals(data))
        {
            Head = Head.Next;
            return data;
        }

        var current = Head;
        while (current.Next != null)
        {
            if (current.Next.Data.Equals(data))
            {
                current.Next = current.Next.Next;
                return data;
            }

            current = current.Next;
        }
        return data;
    }

   public T this[int i]
   {
      get
      {
        if(i > Count)
        {
            throw new IndexOutOfRangeException($"index out of range");
        }
        var current = Head;
        while (i-- != 0)
        {
            current = current.Next;
        }
        return current.Data;
      }
   }
    public IEnumerator<T> Enumerator()
    {
        var current = Head;
        while (current != null)
        {
            yield return current.Data;
            current = current.Next;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return Enumerator();
    }

    public IEnumerator<T> GetEnumerator()
    {
        return Enumerator();
    }

}