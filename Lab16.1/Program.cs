using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using System.Text.Encodings.Web;
using System.Text.Unicode;

namespace Lab16._1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 5;
            Product[] product = new Product[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите код товара");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите название товара");
                string name = Console.ReadLine();

            }

            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                WriteIndented = true
            };
            string jsonString = JsonSerializer.Serialize(product, options);

            using (StreamWriter sw = new StreamWriter("../../../Product.json"))
            {
                sw.WriteLine(jsonString);
            }
        }
    }
}
