using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace JSON
{
    class PublishingHouse
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }

    }
    class Book
    {
        //[JsonIgnore]
        //Щоб у подальшому не серіалізувати параметр PublishingHouseId
        public uint PublishingHouseId { get; set; }
        //[JsonPropertyName("Name")]
        //Щоб серіалізований об’єкт містив параметр Title з назвою “Name”
        public string Title { get; set; }
        public PublishingHouse PublishingHouse { get; set; }
    }
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string path = @"C:\Users\Admin\source\repos\JSON\data.json";
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                fs.Position = 0;
                var books = await JsonSerializer.DeserializeAsync< List<Book> >(fs);
                foreach (var book in books)
                {
                    Console.WriteLine($"{book.PublishingHouseId} - {book.Title} - {book.PublishingHouse.Name}");
                }
            }
            Console.ReadKey();
        }
    }
}
