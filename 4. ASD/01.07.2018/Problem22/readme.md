# Статична реализация на списък
Създайте статична реализация на списък. 
Използвайте следната структура за класа.
```
public class CustomArrayList
{
      private object[] arr;
 
      private int count;

      public int Count
      {
            get
            {
                  return count;
            }
      }
 
      private static readonly int INITIAL_CAPACITY = 4;
 
      public CustomArrayList()
      {
            arr = new object[INITIAL_CAPACITY];
            count = 0;
      }
	public void Add(object item)
	{
	}

	public void Insert(int index, object item)
	{
      }
	
	public int IndexOf(object item)
	{
	}

	public void Clear()
	{
	}

	public bool Contains(object item)
	{
	}

	public object this[int index]
	{
	}

	public object Remove(int index)
	{
	}

	public int Remove(object item)
	{
	}
}
```