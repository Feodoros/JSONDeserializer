using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterFromJson
{
    class Program
    {
        static void Main(string[] args)
        {

            string path = @"C:\Users\fzhil\Downloads\22.txt";
            string json = "";

            Console.ForegroundColor = ConsoleColor.White;

            try
            {
                Console.WriteLine("Cчитываем весь текстовый файл формата JSON");
                using (StreamReader sr = new StreamReader(path))
                {
                    json = sr.ReadToEnd();
                    sr.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            //Создаем список JSON-объектов
            List<Cities.RootObject> cities = JsonConvert.DeserializeObject<List<Cities.RootObject>>(json);

            //Вытаскиваем нужные поля
            foreach (Cities.RootObject items in cities)
            {
                Console.WriteLine('"' + items.name + '"' + ',');
            }

            Console.ReadKey();
        }

    }
}
