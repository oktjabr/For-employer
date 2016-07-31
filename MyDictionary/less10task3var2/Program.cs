using System;
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Создайте класс MyDictionary<TKey, TValue>. Реализуйте в простейшем приближении возможность использования его экземпляра 
//аналогично экземпляру класса Dictionary (Урок 6 пример 5). Минимально требуемый интерфейс взаимодействия с экземпляром,
//должен включать метод добавления пар элементов, индексатор для получения значения элемента по указанному индексу
//и свойство только для чтения для получения общего количества пар элементов.

namespace less10task3
{
   
    interface IMyDictionary<TKey, TValue>
    {
        void Add(TKey key, TValue value);
        int Counter
        { get; }
    }
    class MyDictionary<TKey, TValue> : IMyDictionary<TKey, TValue>
    {
        private int count = 0;

        private TKey[] key = null;
        private TValue[] value = null;
        public MyDictionary(int length)
        {
            key = new TKey[length];

            value = new TValue[length];

        }


        public void Add(TKey key, TValue value)
        {
            this.key[count] = key;
            this.value[count] = value;
            count++;

        }
        public int Counter
        {
            get { return count; }
        }


        public TValue this[TKey index]
        {
            get
            {
                for (int i = 0; i < key.Length; i++)
                {

                    if ((string)(object)key[i] == (string)(object)index)
                    {
                        return (TValue)(object)(value[i] + " " + key[i]);
                    }
                }
                return (TValue)(object)("нет превода");
            }


        }
        public TValue this[int index]
        {
            get
            {
                return value[index];
            }
        }
    }

    namespace less10task3
    {
        class Program
        {
            static void Main(string[] args)
            {
                MyDictionary<string, string> instance = new MyDictionary<string, string>(5);
                instance.Add("ручка", "pen");
                instance.Add("карандаш", "pencil");
                instance.Add("солнце", "sun");
                instance.Add("стол", "tabel");
                // instance.Add(1, "qqqqqq");
                // instance.Add(2, "wwwwww");
                // instance.Add(3, "eeeeee");

                Console.WriteLine(instance["ручка"]);
                Console.WriteLine(instance["солнце"]);
                Console.WriteLine(instance["ручка11111"]);
                Console.WriteLine(instance[0]);
                Console.WriteLine(instance[1]);

                int c = instance.Counter;
                Console.WriteLine(c);
                Console.ReadKey();
            }
        }
    }
}
