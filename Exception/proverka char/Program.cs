using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proverka_char
{
    class Program
    {
        static public bool Compare(string s1, string s2)
        {
            char[] c1 = s1.ToCharArray();
            char[] c2 = s2.ToCharArray();
            for (int i = 0; i < c1.Length; i++)
            {
                if (c1[i] < c2[i])
                {
                    return true;
                }

            }
            return false;
        }
        static public string[] newArr(params string []arr)
        {

        }
        static void Main(string[] args)
        {


            string[] arr = new string[] { "ddaa", "aadd", "aaee", "ggww" };
            string[] newArr = new string[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    bool s = Compare(arr[i], arr[j]);

                    if (s == false)
                    {
                        newArr[i] = arr[i];
                    }
                }
            }
            foreach (string item in newArr)
            {
                Console.WriteLine(item);
            }
            // Console.Write(s);

            Console.ReadKey();
        }
    }
}
