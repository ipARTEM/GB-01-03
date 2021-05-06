using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Программа телефонный справочник ***");
            Console.WriteLine();
            Console.WriteLine(" Имя    Тетефон");
            Random random = new Random();

            //int number = random.Next(9999999);

            string[] name = new string[] {"Саша","Петя", "Вася", "Коля", "Толя" }; 


            string[,] phoneDirectory=new string [5,2];

            for (int i = 0; i < phoneDirectory.GetLength(0); i++)
            {
                for (int j = 0; j < phoneDirectory.GetLength(1); j++)
                {
                    if (j==0)
                    {
                        Console.Write(" "+name[i].ToString()+"   ");
                    }
                    else
                    {
                        phoneDirectory[i, j] = Convert.ToString(random.Next(1111111, 9999999));
                        Console.Write(phoneDirectory[i, j]);
                    }
                    

                }
                Console.WriteLine();
            }


        }
    }
}
