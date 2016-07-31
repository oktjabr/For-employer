using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Требуется: Описать структуру с именем Worker, содержащую следующие поля:  
//• фамилия и инициалы работника;  
//• название занимаемой должности;  
//• год поступления на работу.
//Написать программу, выполняющую следующие действия:  
//• ввод с клавиатуры данных в массив, состоящий из пяти элементов типа Worker (записи должны быть упорядочены 
//по алфавиту);  
//• если значение года введено не в соответствующем формате выдает исключение.
//• вывод на экран фамилии работника, стаж работы которого превышает введенное значение.  

namespace less15task2
{
    struct Worker
    {
        public string FamilijaImja
        {
            set; get;
        }
        public string Dolgnost
        {
            set; get;
        }
        public int GodPostuplenija
        {
            set; get;
        }

    }
    class WorkerManager
    {
        private int counter;
        
        private Worker[] workerArray = new Worker[5];
       
        public void AddWorker()
        {
            Console.WriteLine("Введите ФИО работника");
            workerArray[counter].FamilijaImja = Console.ReadLine();
            Console.WriteLine("Введите должность");
            workerArray[counter].Dolgnost = Console.ReadLine();
            Console.WriteLine("Введите дату поступления на работу");
            try
            {
                workerArray[counter].GodPostuplenija = Convert.ToInt32 (Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Значение не соответствует формату ");
                workerArray[counter].FamilijaImja = "---";
                workerArray[counter].Dolgnost = "-----";
            }


            counter++;

        }
        public void SortArray()
        {
            Array.Sort(workerArray, (p1, p2) => p1.FamilijaImja.CompareTo(p2.FamilijaImja));
        }
        public void ProverkaStaja(int stag)
        {
            //TODO перебор в массиве из єлементов ВОРКЕР.ГодПоступления
            //сравнение с годом поступления на работу
            //и выброс в консоль имне работников чей стаж (по году поступления) больше числа 
            // в методе  ПроверкаСтажа
            
            for (int i = 0; i < 5; i++)
            {
                int current = DateTime.Now.Year;
                if ((current -workerArray[i].GodPostuplenija)>stag)
                {
                    Console.WriteLine(" {0} {1} {2}", workerArray[i].FamilijaImja, workerArray[i].Dolgnost, workerArray[i].GodPostuplenija);
                }

            }

            Console.WriteLine();
        }
        

    }
    class Program
    {
        static void Main(string[] args)
        {
            WorkerManager inst = new WorkerManager();
            for (int i = 0; i < 5; i++)
            {
                inst.AddWorker();
               
            }
            inst.SortArray();

            inst.ProverkaStaja(20);
            
            
            Console.ReadKey();
        }
    }
}
