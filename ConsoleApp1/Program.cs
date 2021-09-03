using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LoadJson();
            
        }
        public static void LoadJson()
        {
            using (StreamReader r = new StreamReader("../../../data.json"))
            {
                string json = r.ReadToEnd();
                List<Item> items = JsonConvert.DeserializeObject<List<Item>>(json);

                foreach (var i in items)
                {
                    Console.WriteLine(i.vcc);
                }
                
            }
                
            
        }
        
        public class Item
        {
            public int millis;
            public string stamp;
            public DateTime datetime;
            public string light;
            public float temp;
            public float vcc;
        }
    }
}