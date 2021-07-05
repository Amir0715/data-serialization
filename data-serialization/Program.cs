using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;
using data_serialization.Models;

namespace data_serialization
{
    class Program
    {
        static async Task Main(string[] args)
        {
            if (args.Length != 2)
            {
                // Если кол-во аргументов < 2, то выводим сообщение
                Console.WriteLine(@"data-serialization.exe [InputXmlFilePath] [OutputJsonFilePath]
    Serializes xml to json.");
                return;
            }
            
            var options = new JsonSerializerOptions
            {
                WriteIndented = true // Опция для красивой записи в файл 
            };
            FileStream myFileStream;
            
            try
            {
                myFileStream = new FileStream(args[0], FileMode.Open); // Открываем файл для чтения по пути args[0]
                
                var mySerializer = new XmlSerializer(typeof(Root)); // Создаем объект сериализации
                
                var myObject = (Root) mySerializer.Deserialize(myFileStream); // Десериализуем файл 
                
                await using (var fs = new FileStream(args[1], FileMode.Create)) 
                {
                    // Сериализуем объект сериализации в JSON формате
                    await JsonSerializer.SerializeAsync<Root>(fs, myObject, options); 
                    Console.WriteLine("Data has been saved to file");
                }
            }
            catch (FileNotFoundException)
            {
                // Файл не найден
                Console.WriteLine($"File {args[0]} does not exist!");
            }
        }
    }
}