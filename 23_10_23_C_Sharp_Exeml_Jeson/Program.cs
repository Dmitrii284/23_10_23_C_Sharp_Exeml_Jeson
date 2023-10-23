
/*
 Xeml snd jason

 
 */

//using System.Data.Common;
//using System.IO;
//using System.Security.Cryptography.X509Certificates;
//using System.Xml;
//using System.Text.Json;

//namespace _23_10_23_C_Sharp_Exeml_Jeson
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello, World!");

//            var employees = new List<Person>
//            {
//             new Person("tom", 37, "Microsoft"),
//             new Person("bob", 41, "Googl")
//            };            
//        }
//    }

//    class Person
//    {
//        public string Company { get; set; }
//        public string Name { get; }
//        public int Age { get; set; }

//        public Person(string name, int age, string compane) 
//        {
//            Name = name;
//            Age = age;
//            Company = compane;        
//        }

//    }
//}

/*
 В C# JsonSerializer - это класс, предоставляемый библиотекой Newtonsoft.Json, который используется для преобразования объектов в формат JSON (JavaScript Object Notation) и обратно. 
Он позволяет сериализовать и десериализовать объекты различных типов в строку JSON и из нее. Этот процесс называется “сериализацией”.

Вы можете использовать JsonSerializer для выполнения следующих задач:

Преобразование объектов в строку JSON: Вы можете использовать JsonSerializer.Serialize для преобразования объекта в строку JSON.
Преобразование строки JSON в объект: Вы можете использовать JsonSerializer.Deserialize для преобразования строки JSON в соответствующий объект C#.
Настройка процесса сериализации: Вы можете настроить JsonSerializer для управления процессом сериализации, например, 
указав какие свойства нужно сериализовать или как обрабатывать особые значения.
Чтобы использовать JsonSerializer, вам нужно добавить ссылку на сборку Newtonsoft.Json в ваш проект и импортировать пространство имен Newtonsoft.Json.
Затем вы можете создать экземпляр JsonSerializer и использовать его для сериализации и десериализации объектов.
 */

//using System.Data.Common;
//using System.IO;
//using System.Security.Cryptography.X509Certificates;
//using System.Xml;
//using System.Text.Json;

//namespace _23_10_23_C_Sharp_Exeml_Jeson
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Person Tom = new Person("Tom", 37, "Microsoft");
//            string jison = JsonSerializer.Serialize(Tom);// JsonSerializer.Serialize служит для перевода в jison файл.
//            Console.Write(jison);
//            Console.WriteLine(JsonSerializer.Serialize(Tom));// Можно вывести другим способом


//            // Сейчас выведем в файл но нужно указать путь
//            string path = "C:\\Users\\С - 19\\Documents\\Сагадатов Артур\\23_10_23_C_Sharp_Exeml_Jeson\\23_10_23_C_Sharp_Exeml_Jeson\\jsconfig1.json";
//            using (var streamWrite = new StreamWriter(path))
//            {
//                streamWrite.WriteLine(JsonSerializer.Serialize(Tom));
//            }
//        }


//    }

//    class Person
//    {
//        public string Company { get; set; }
//        public string Name { get; }
//        public int Age { get; set; }

//        public Person(string name, int age, string compane)
//        {
//            Name = name;
//            Age = age;
//            Company = compane;
//        }

//    }
//}

/*
 Делаем несколько записей чс помощъю Jeson
 */

//using System.Data.Common;
//using System.IO;
//using System.Security.Cryptography.X509Certificates;
//using System.Xml;
//using System.Text.Json;
//using System.Text.Json.Serialization;

//namespace _23_10_23_C_Sharp_Exeml_Jeson
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Person Tom = new Person("Tom", 37, "Microsoft");
//            string jison = JsonSerializer.Serialize(Tom);// JsonSerializer.Serialize служит для перевода в jison файл.
//            Console.Write(jison);
//            Console.WriteLine(JsonSerializer.Serialize(Tom));// Можно вывести другим способом


//            // Сейчас выведем в файл но нужно указать путь
//            string path = "C:\\Users\\С - 19\\Documents\\Сагадатов Артур\\23_10_23_C_Sharp_Exeml_Jeson\\23_10_23_C_Sharp_Exeml_Jeson\\jsconfig1.json";
//            using (var streamWrite = new StreamWriter(path))
//            {
//                streamWrite.Write(JsonSerializer.Serialize(Tom));
//            }

//            var options = new JsonSerializerOptions
//            {
//                WriteIndented = true,
//                AllowTrailingCommas = true,
//                IgnoreReadOnlyFields = true
//            };
//            Console.WriteLine(JsonSerializer.Serialize(options));
//        }


//    }

//    class Person
//    {
//        public string Company { get; set; }
//        public string Name { get; }
//      // [JsonIgnorу] //- Если мы не хотим выводить какую либо строчку Пишем этот тег
//        public int Age { get; set; }

//        public Person(string name, int age, string compane)
//        {
//            Name = name;
//            Age = age;
//            Company = compane;
//        }

//    }
//}

/*
 Xml -  serializer
 */

//using System.Data.Common;
//using System.IO;
//using System.Security.Cryptography.X509Certificates;
//using System.Xml;
//using System.Text.Json;
//using System.Text.Json.Serialization;
//using System.Xml.Serialization;

//namespace _23_10_23_C_Sharp_Exeml_Jeson
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Person Tom = new Person("Tom", 37, "Microsoft");

//            var serializer = new XmlSerializer(typeof(Person));
//            using (FileStream fs = new FileStream("person.xml", FileMode.OpenOrCreate))
//            {
//                serializer.Serialize(fs, Tom);
//                Console.WriteLine("Object has been serializede.");
//            }           

//        }


//    }

//   public class Person
//    {
//        public string Company { get; set; }
//        public string Name { get; }
//        // [JsonIgnorу] //- Если мы не хотим выводить какую либо строчку Пишем этот тег
//        public int Age { get; set; }

//        public Person(string name, int age, string compane)
//        {
//            Name = name;
//            Age = age;
//            Company = compane;
//        }

//        public Person() { }
//    }
//}


/*
 * В языке C# ключевое слово var используется для указания типа переменной во время компиляции. Например,
 * если у вас есть строка текста, и вы хотите сохранить её в переменной, вы можете написать:

var text = "Hello, World!";
Здесь text является строковой переменной. Но ключевое слово var позволяет компилятору самому определить тип переменной 
на основе инициализирующего выражения. В данном случае, компилятор определит, что text имеет строковый тип.

Таким образом, использование var может упростить код и сделать его более читаемым, поскольку вам не нужно явно указывать тип переменной. 
Однако, это может привести к ошибкам, если вы случайно укажете неверный тип. 
Поэтому рекомендуется использовать var только тогда, когда это действительно необходимо.
 * 
 * 
 * 
 Задача

напишите приложение, сохраняющее в XML-файл информацию о заказах.
Каждый заказ представляет собой несколько товаров.
Информацию, характеризующую заказы и товары необходимо разработать самостоятельно.
Считайте информацию из XML-документа

и то же самое в json.

 */

using System.Data.Common;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Xml;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml.Serialization;
using System.Data;
using System.Xml.Linq;
using System.Net.Http.Json;
using static _23_10_23_C_Sharp_Exeml_Jeson.Program;

namespace _23_10_23_C_Sharp_Exeml_Jeson
{
    public class Program
    {
        static void Main(string[] args)
        {


            //Person Tom = new Person("Tom", 37, "Microsoft");

            //var serializer = new XmlSerializer(typeof(Person));
            //using (FileStream fs = new FileStream("person.xml", FileMode.OpenOrCreate))
            //{
            //    serializer.Serialize(fs, Tom);
            //    Console.WriteLine("Object has been serializede.");
            //}

            var order1 = new Order()
            {
                OrderDate = DateTime.Now,
                OrderID = 1,
                Products = new List<Product>
                {
                    new Product {Name = "Product A", Prise = 10.47f, Quantiti = 2},
                    new Product{ Name = "Product B", Prise = 20.95f, Quantiti = 5},
                    new Product{ Name = "Product C", Prise = 30.5f, Quantiti = 5},
                    new Product{ Name = "Product D", Prise = 220.85f, Quantiti = 5},
                    new Product{ Name = "Product E", Prise = 40.65f, Quantiti = 5},
                    new Product{ Name = "Product F", Prise = 50.75f, Quantiti = 5},
                }
            };

            var order2 = new Order()
            {
                OrderDate = DateTime.Now,
                OrderID = 2,
                Products = new List<Product>
                {
                    new Product{ Name = "Product D", Prise = 220.85f, Quantiti = 5},
                    new Product{ Name = "Product E", Prise = 40.65f, Quantiti = 5},
                    new Product{ Name = "Product F", Prise = 50.75f, Quantiti = 5},
                }
            };

            var xmlSerializer = new XmlSerializer(typeof(Order));

            

           
                using (FileStream fs = new FileStream("orders1.xml", FileMode.OpenOrCreate))
                {
                    xmlSerializer.Serialize(fs, order1);
                    Console.WriteLine("Object has been serializede.");
                    
               }
                using (FileStream fs = new FileStream("orders2.xml", FileMode.OpenOrCreate))
                {
                    xmlSerializer.Serialize(fs, order2);
                    Console.WriteLine("Object has been serializede.");
                }
           
               


            var xmlDoc = new XmlDocument();
            xmlDoc.Load("C:\\Users\\С - 19\\Documents\\Сагадатов Артур\\23_10_23_C_Sharp_Exeml_Jeson\\23_10_23_C_Sharp_Exeml_Jeson\\bin\\Debug\\net6.0\\orders1.xml");
            XmlElement rootElement = xmlDoc.DocumentElement;
            Console.WriteLine(" " + rootElement.Name);
            if (rootElement != null)
            {
                foreach (XmlNode node in rootElement.ChildNodes)
                {
                    //XmlNode? attr = XNode.
                    //Console.WriteLine(node.Name);
                }
            }

            var jsonFromFile = File.ReadAllText("orders1.json");
            var ordersFromJson = JsonContent.Create(jsonFromFile);

            Console.WriteLine("Заказы из JSON-файла:");

            

            //var jsonFromFile = File.ReadAllText("orders.json");
            //var ordersFromJson = JsonConvert.DeserializeObject<List<Order>>(jsonFromFile);

            //Console.WriteLine("Заказы из JSON-файла:");
            //    foreach (var order in ordersFromJson)
            //    {
            //        Console.Write

        }

        public class Product
        {
            //public string Company { get; set; }
            //public string Name { get; }
            //// [JsonIgnorу] //- Если мы не хотим выводить какую либо строчку Пишем этот тег
            //public int Age { get; set; }

            //public Person(string name, int age, string compane)
            //{
            //    Name = name;
            //    Age = age;
            //    Company = compane;
            //}

            //public Person() { }

            public string Name { get; set; }
            public float Prise { get; set; }
            public int Quantiti { get; set; }
        }

        public class Order
        {
            public int OrderID { get; set; }
            public DateTime OrderDate { get; set; }
            public List<Product> Products { get; set; }
        }


    }
}

