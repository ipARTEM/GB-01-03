using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите любое слово, а я Вам смогу написать его задом наперёд: ");
            string word = Console.ReadLine();

            char [] revWord= word.ToCharArray();

            for (int i = revWord.Length; i>0; i--)
            {
                Console.Write(revWord[i-1]);
            }

            Console.WriteLine("            Опа,  Угадал)))");

            Console.ReadKey();
        }
    }
}
                                                       
