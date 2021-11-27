using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefManager1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Author author = new Author();
            Console.WriteLine(author);
            Console.ReadKey();

            Source source = new Source();
            Console.WriteLine(source);
            Console.ReadKey();
        }
    }
}
