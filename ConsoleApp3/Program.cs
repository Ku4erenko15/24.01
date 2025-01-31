using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Books Test = new Books("Белые ночи", "Достоевский", 1848, 62);
            Test.Info();
            Console.ReadLine();

        }
        class Books
        {
            public string name;
            public string author;
            public int publication;
            public int volume;

            public Books(string name, string author, int publication, int volume)
            {
                this.name = name;
                this.author = author;
                this.publication = publication;
                this.volume = volume;
            }
            public void Info()
            {
                Console.WriteLine("Информация о книге:");
                Console.WriteLine($"Название: {name}");
                Console.WriteLine($"Автор: {author}");
                Console.WriteLine($"Год выпуска: {publication}");
                Console.WriteLine($"Объем: {volume} страниц");
            }
        }
    }
}
