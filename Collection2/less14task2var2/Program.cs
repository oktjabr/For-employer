using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace less14task2var2


{
    class MyList<T> : IEnumerable, IEnumerator
    {
        T[] myList = null;

        int position = -1;
        int count;
        public MyList()
        {
            this.count = 0;
            myList = new T[0];
        }

        public int Counter { get { return count; } set { count = value; } }

        public void Add(T value)
        {
            T[] item = new T[this.myList.Length + 1];

            for (int i = 0; i < myList.Length; i++)
            {
                item[i] = myList[i];
            }
            item[item.Length - 1] = value;
            myList = item;
            Counter++;
        }

        public T this[int index]
        {
            get
            {
                return myList[index];
            }
        }
        public void Reset()
        {
            this.position = -1;
        }
        public bool MoveNext()
        {
            if (position < myList.Length - 1)
            {
                position++;
                return true;
            }
            else
            {
                Reset();
                return false;
            }
        }
        public object Current
        {
            get
            {
                return myList[position];
            }
        }
        public IEnumerator GetEnumerator()
        {
            return this;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> list = new MyList<string>();

            list.Add("Aaa");
            list.Add("Bbb");
            list.Add("Ccc");
            list.Add("Ddd");
            list.Add("Eee");


            Console.WriteLine(list[1]);
            Console.WriteLine(list.Counter);

            foreach (var s in list)
            {
                Console.WriteLine(s);
            }
        }
    }
}