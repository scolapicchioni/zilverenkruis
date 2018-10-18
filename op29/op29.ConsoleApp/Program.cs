using op29.BusinessLogic;
using System;

namespace op29.ConsoleApp {
    class Program {
        static void Main(string[] args) {
            Repository repo = new Repository();
            repo.WriteOnFile("Hello World!\r\n");

            Potato potato = new Potato() {
                Color = "Red",
                Shape = "Long",
                SnelKokend = true,
                Size = 3
            };
            //repo.SerializeBinary(potato);

            //Potato potato2 = repo.DeserializeBinary();

            //repo.SerializeXML(potato);
            //Potato potato2 = repo.DeserializeXML();

            //repo.SerializeJSON(potato);
            //Potato potato2 = repo.DeserializeJSON();

            //CollectionExamples ce = new CollectionExamples();

            //ce.ListExample();

            LinqExamples le = new LinqExamples();
            le.Linq02();

            Console.WriteLine("Done...");
            Console.ReadLine();
        }
    }
}
