using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNGtoICO_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"I:\Filme";
            string newfilm = "";
            var films = Directory.GetDirectories(path);

            foreach (string film in films)
            {
                if (film.Contains(path))
                    newfilm = film.Replace(path + "\\", "");
                Console.WriteLine(newfilm);
            }

            Console.ReadKey();
        }
    }
}
