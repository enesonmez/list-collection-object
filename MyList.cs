using System;

namespace ListObject
{
    // Generic
    class MyList<T>
    {
        T[] items;

        public int Count 
        { 
            get
            {
                return items.Length;
            }
        }

        // Constructor
        public MyList()
        {
            items = new T[0];
        }


        public object this[int i]
        {
            get
            {
                try
                {
                    return items[i]!;
                }
                catch (System.Exception)
                {
                    throw;
                }
                
            }
        }
        

        public void Add(T item)
        {
            T[] temp = items;
            items = new T[items.Length+1];

            for (int i = 0; i < temp.Length; i++)
            {
                items[i] = temp[i];
            }
            items[temp.Length] = item;
        }


        public void Clear()
        {
            items = new T[0];
        }

        // Deep Copy
        public T[] CopyTo()
        {
            T[] temp = new T[Count];

            for (int i = 0; i < Count; i++)
            {
                temp[i] = items[i];
            }
            return temp;
        }

        // Shallow Copy
        public T[] Clone()
        {
            return items;
        }


        public int IndexOf(T item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (items[i]!.Equals(item))
                {
                    return i;
                }
            }
            return -1;
        }


        public void Insert(int index, T item)
        {
            T[] temp = items;
            items = new T[items.Length+1];

            for (int i = 0; i < index; i++)
            {
                items[i] = temp[i];
            }
            items[index] = item;
            for (int i = (index+1); i < Count; i++)
            {
                items[i] = temp[i-1];
            }
        }


        public void RemoveAt(int index)
        {
            T[] temp = items;
            items = new T[items.Length-1];

            for (int i = 0; i < index; i++)
            {
                items[i] = temp[i];
            }
            for (int i = index; i < Count; i++)
            {
                items[i] = temp[i+1];
            }
        }
    }
}