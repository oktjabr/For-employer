using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Создайте коллекцию MyList<T>. Реализуйте в простейшем приближении возможность использования ее экземпляра
//аналогично экземпляру класса List<T>. Минимально требуемый интерфейс взаимодействия с экземпляром, 
//должен включать метод добавления элемента, индексатор для получения значения элемента по указанному индексу 
//и свойство только для чтения для получения общего количества элементов. 
//Реализуйте возможность перебора элементов коллекции в цикле foreach.

//TODO Можно сделать без оператора yield и добавить IEnumerator с методами MoveNext, Current, Reset
namespace less14task2
{
    class MyList<T>: IEnumerable
    {
        private int count = 0;
        private int possition = -1;
        private T[] array = new T[0];

        public void Add(T element)
        {
            T[] coppyArray = new T[array.Length+1];
            for (int i = 0; i < array.Length; i++)
            {
                coppyArray[i] = array[i];
            }
            coppyArray[array.Length] = element;
            array = new T[array.Length + 1];
            array = coppyArray;
        }
        public int Count
        {
            get { return count; }
        }

        public T this[int index]
        {
            get
            {
                return array[index];
            }
        }
        public IEnumerator GetEnumerator()
        {
            while (true)
            {
                if (possition < array.Length-1)
                {
                    possition++;
                    yield return array[possition];
                }
                else
                yield break;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> instance = new MyList<int>();
            instance.Add(1);
            instance.Add(2);
            instance.Add(3);
           // instance.Add(4);
            Console.WriteLine("число елементов -  {0}",instance.Count);

            Console.WriteLine("indexator - {0}", instance[0]);
            Console.WriteLine("indexator - {0}", instance[2]);

            foreach (var element in instance)
                Console.Write("{0} ", element);

            Console.ReadKey();
        }
    }
}
