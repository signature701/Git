using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            string Input;

            Console.WriteLine("Введите символы в строчку: ");
            Input = Console.ReadLine();

            bool[] Flag = new bool[Input.Length];
            int[] CountType = new int[Input.Length];

            if (Input.Length == 0)
            {
                Console.WriteLine("Ошибка. Пустая строка.");
                Console.ReadKey();
                return;

            }
            i = 0;
            while (i < Flag.Length)
            {
                CountType[i] = 1;
                i++;
            }
           
            i = 0;
            while (i < Input.Length)
            {
                j = i+1;
                while (j < Input.Length)
                {               
                    if ((Input[i] == Input[j]) && (!Flag[j]))
                        {
                            CountType[i]++;
                            Flag[j] = true;
                        }
                    j++;
                }                
                i++;             
            }

            i = 0;
            while (i < Input.Length)
            {   
                if(!Flag[i])
                    Console.WriteLine("Количество символов " + Input[i] + " = " + CountType[i]);  
            i++;                    
            }            
            Console.ReadKey();  
        }
    }
}
