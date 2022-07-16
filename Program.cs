using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_8_1
{
    internal class Program
    {
        static Dictionary<string, string> DictKeyValue()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            string key = "";
            string value = "";
            for (; ; )
            {

                Console.WriteLine($"Введите номер телефона");
                key = Console.ReadLine();
                if (key == "" || key == " ") { break; }
                Console.WriteLine($"Введите Ф.И.О владельца");
                value = Console.ReadLine();
                dict.Add(key, value);
            }
            return dict;
        }

        static void PrintDictOnConsole(Dictionary<string, string> dict)
        {
            string key = "";
            string value = "";
            Console.WriteLine("Введите ключ (Номер телефона)");
            key = Console.ReadLine();
            while (!dict.TryGetValue(key, out value))
            {
                Console.WriteLine($"Не верный ключ");
                Console.WriteLine("Введите снова");
                key = Console.ReadLine();
            }
            Console.WriteLine(value);
        }
        static void Main(string[] args)
        {
            PrintDictOnConsole(DictKeyValue());
            Console.ReadLine();
        }
    }
}
