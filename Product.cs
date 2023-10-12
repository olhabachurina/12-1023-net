using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace _12_1023_net
{
    [Serializable]
    internal class Product
    {
        
        public string Name { get; set; }
        public int Id { get; set; }
        public float Price { get; set; }
        public Product( string name, int id, float price)
        {
            Name = name;
            Id = id;
            Price = price;
        }
        public override string ToString()
        {
            string pathToFile ="product.json";
           
            return $"ID: {Id}, Name: {Name}, Price: {Price}";
            
        }
    }
}

