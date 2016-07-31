using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Используя Visual Studio, создайте проект по шаблону Console Application.  
//Создайте класс MyList<T>.Реализуйте в простейшем приближении возможность использования его экземпляра аналогично экземпляру класса
//List<T>.Минимально требуемый интерфейс взаимодействия с экземпляром, должен включать метод добавления элемента, 
//индексатор для получения значения элемента по указанному индексу и свойство только для чтения для получения общего количества элементов. 

//Используя Visual Studio, создайте проект по шаблону Console Application.
//Создайте расширяющий метод: public static T[] GetArray<T>(this MyList<T> list)
//Примените расширяющий метод к экземпляру типа MyList<T>, разработанному в домашнем задании 2 для данного урока.
//Выведите на экран значения элементов массива, который вернул расширяющий метод GetArray(). 

namespace less10task2
{
    static class ExtensionClass
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            
            T[] newList = new T[list.Kolichestvo];
            for (int i = 0; i < list.Kolichestvo; i++)
            {
                newList[i] =list[i] ;
            }
            return newList;
        }
    }
    interface IMyList<T>
    {
        void Add(T numb);
        int Kolichestvo
        { get; }
    }

    class MyList<T>:IMyList<T>
    {
        private T[] newList = new T[5];

        
        int count ;
        public T this[int index]
        {
            get { return newList[index] ; }
        }

        public void Add(T numb)
        {
            newList[count] = numb;
            count++;
        }
        public int Kolichestvo
        {
            get { return count ; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> instance = new MyList<string>();

            instance.Add("fg");
            instance.Add("rt");
            instance.Add("fe");
            instance.Add("asd");
          //  Console.WriteLine(instance[2]);
            Console.WriteLine(instance.Kolichestvo);

           string []array =  instance.GetArray<string>();
            for (int i = 0; i <array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadKey();
        }
    }
}
