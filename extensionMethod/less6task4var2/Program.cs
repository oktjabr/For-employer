using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Требуется: Создать расширяющий метод для целочисленного массива, который сортирует элементы массива по возрастанию.

namespace less6task4
{
    static class ExtensionForArray
    {
        public static int[] SortArray(this int[] array)
        {
            
            int[] minValArr = new int[array.Length];
            int minVal = 0;
            for (int i = 0; i < minValArr.Length; i++)
            {
             
                array = Recursion(array, ref minVal);
                minValArr[i] = minVal;
            }
            for (int i = 0; i < minValArr.Length; i++)
            {
                Console.WriteLine(minValArr[i]);
            }
            
            return  minValArr;

        }
        public static int[] Recursion(int[] array,ref int n)
        {
            int[] copyArray = new int[array.Length];

            int[] rezArray = new int[array.Length - 1];

            for (int i = 0; i < array.Length; i++)
            {
                copyArray[i] = array[i];
            }
            n = copyArray[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (n > copyArray[i])
                {

                    n = copyArray[i];
                
                }
            }
         
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (copyArray[i] == n)
                {
                    rezArray[i] = copyArray[array.Length - 1];
                }
                else
                {
                    rezArray[i] = copyArray[i];
                }
            }

            if (rezArray.Length > 0)
                return rezArray ;
            else
                return null;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] array = new int[] { 4, 5, 0, 1, 7, 2 };

           int[]sortedArray= array.SortArray();

            for (int i = 0; i <sortedArray.Length; i++)
            {
                Console.WriteLine(sortedArray[i]);
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
