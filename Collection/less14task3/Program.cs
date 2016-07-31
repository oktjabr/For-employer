using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Создайте коллекцию MyDictionary<TKey,TValue>. Реализуйте в простейшем приближении возможность использования 
//ее экземпляра аналогично экземпляру класса Dictionary<TKey,TValue>. Минимально требуемый интерфейс 
//взаимодействия с экземпляром, должен включать метод добавления элемента, индексатор для получения значения 
//элемента по указанному индексу и свойство только для чтения для получения общего количества элементов. 
//Реализуйте возможность перебора элементов коллекции в цикле foreach. 
namespace less14task3
{
    class MyDictionary<TKey, TValue> : IEnumerable, IEnumerator
    {
        int possition = -1;
        int count = 0;
        TKey[] arrayKey = null;
        TValue[] arrayValue = null;

        public MyDictionary()
        {
            arrayKey = new TKey[0];
            arrayValue = new TValue[0];
        }

       
        public void Add(TKey key, TValue value)
        {
            TKey[] coppyArrayKey = new TKey[arrayKey.Length + 1];
            TValue[] coppyArrayValue = new TValue[arrayValue.Length + 1];
            for (int i = 0; i < arrayKey.Length; i++)
            {
                coppyArrayKey[i] = arrayKey[i];
                coppyArrayValue[i] = arrayValue[i];
            }

            count++;

            arrayKey = new TKey[arrayKey.Length + 1];
            arrayValue = new TValue[arrayValue.Length + 1];

            coppyArrayKey[coppyArrayKey.Length-1] = key;
            coppyArrayValue[coppyArrayValue.Length-1] = value;

            arrayKey = coppyArrayKey;
            arrayValue = coppyArrayValue;
        }

        public int Count
        {
            get { return count; }
        }

        public object this[int index]
        {
            get
            {
                if (index >= 0 && index < arrayKey.Length)
                    return arrayValue[index];
                else
                    return "Выход за пределы массива";
            }
        }
        public object this [string index]
        {
            get {
                for (int i = 0; i < arrayKey.Length; i++)
                    if ((string)(object)arrayKey[i] == index)
                        return arrayKey[i] + " - " + arrayValue[i];
                return "Обращение за пределы массива";
                 }
        }

        public bool MoveNext()
        {
            if (possition < arrayKey.Length - 1)
            {
                possition++;
                return true;
            }
            else { return false; }
        }

        public object Current
        {
            get
            {
                return arrayKey[possition] +" - "+ arrayValue[possition];
            }
        }

        public void Reset()
        {
            possition = -1;
        }

        public IEnumerator GetEnumerator()
        {
            return this as IEnumerator;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //MyDictionary<int, string> instance = new MyDictionary<int, string>();

            //instance.Add(1, "A");
            //instance.Add(2, "B");
            //instance.Add(3, "C");
            //instance.Add(4, "D");

            MyDictionary<string, string> instance2 = new MyDictionary<string, string>();

            instance2.Add("w", "W");
            instance2.Add("q", "Q");
            instance2.Add("e", "E");
            instance2.Add("z", "Z");

            Console.WriteLine("элемент по указанному индексу   - {0}, {1}, {2}", instance2["q"],instance2["t"],instance2[6]);

            Console.WriteLine("общеe количествo элементов - {0}", instance2.Count);

            foreach (var element in instance2)
                Console.WriteLine(element);
            Console.ReadKey();
        }
    }
}
