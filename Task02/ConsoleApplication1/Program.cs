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
            string str1 = "Строка для очередного примера :(";           //создаём исходную строку
            char[] charArr1 = str1.ToCharArray();                       //переводим из String в массив Char
            Console.Write("Исходная строка: ");
            for (int i = 0; i < charArr1.Length; i++)                   //выводим исходную строку
                Console.Write(charArr1[i]);
            Console.WriteLine();

            StringBuilder strBuilder1 = new StringBuilder();            //создаём объект класса StringBuilder
            foreach (char el in charArr1)                                //переводим строку из массива Char в объект класса StringBuilder
                strBuilder1.Append(el);
            Console.WriteLine();

            Console.WriteLine("После перевода в объект класса StringBuilder: " + strBuilder1);
            Console.WriteLine();

            strBuilder1.Replace('(', ')');
            Console.WriteLine("После замены символа получили строку: " + strBuilder1);
            Console.WriteLine();

            strBuilder1.Remove(11, 11);
            Console.WriteLine("После удаления подстроки получили строку: " + strBuilder1);
            Console.WriteLine();

            strBuilder1.Insert(11, "неплохого ");
            Console.WriteLine("После добавления подстроки получили строку: " + strBuilder1);
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
