// See https://aka.ms/new-console-template for more information
using _12_1023_net;
using Newtonsoft.Json;
using System.Runtime.Serialization.Formatters.Binary;


/*
    Product prod1 = new Product("Apple", 1, 21.45f);
    string json = JsonConvert.SerializeObject(prod1);
    Console.WriteLine(json);
    string content = File.ReadAllText(pathToFile);
    Product prod2 = JsonConvert.DeserializeObject<Product>(content);
    Console.WriteLine(prod2);
    using (FileStream fs = new FileStream("product.bin", FileMode.Open))
    {
        BinaryFormatter bf = new BinaryFormatter();
        Product obj = (Product)bf.Deserialize(fs);
        Console.WriteLine(obj);
    }
}
}
using (FileStream fs = new FileStream("product.bin", FileMode.Open))
{
    BinaryFormatter bf = new BinaryFormatter();
    Product obj = (Product)bf.Deserialize(fs);
    foreach (var el in obj.ints)
    {
        Console.WriteLine(el);
    }
}*/
Console.WriteLine("Введите путь к файлу:");
string filePath = Console.ReadLine();

try
{
    if (File.Exists(filePath))
    {
        string fileContent = File.ReadAllText(filePath);
        Console.WriteLine($"Contents of the file {filePath}:\n{fileContent}");
    }
    else
    {
        Console.WriteLine($"The file {filePath} does not exist.");
    }
}
catch (Exception ex)
{
    Console.WriteLine($"error: {ex.Message}");
}
    