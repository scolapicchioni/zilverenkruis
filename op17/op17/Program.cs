using System;

namespace op17 {
    class Program {
        static void Main(string[] args) {
            //Person p = new Person() {
            //    Name = "Simona",
            //    Surname = "Colapicchioni"
            //};

            //Console.WriteLine(p.SayHi());

            ////PrintPersonData(p, 2);

            //Student s = new Student() {
            //    Name = "Mario",
            //    Surname = "Super"
            //};
            //Console.WriteLine(s.SayHi());

            //PrintPersonData(s);

            //Person person = new Student() { StudentId = 5 }; // new Person();
            //                                                 //person = new Student();

            //Student student = (Student)person;

            ////Student student = new Person();



            //int x = 5;
            //x = 3;


            //Student s = new Student();
            //s.SayHi();

            //Person p = new Student();
            //p.SayHi();


            //Person person1 = CreateSomething(1); //new Person()
            //Console.WriteLine(person1.SayHi()); 

            //Person person2 = CreateSomething(2); //new Student()
            //Console.WriteLine(person2.SayHi());

            //if(person2 is Student) {
            //    Student student2 = (Student)person2;
            //    Console.WriteLine(student2.SayHi());
            //}

            //Student student4 = person2 as Student;
            //if (student4 is null) {
            //    Console.WriteLine(student4.SayHi());
            //} 

            //Student student3 = (Student)CreateSomething(2); //new Student()


            Person p = new Person("Mario", "Super");

            Console.WriteLine(p);

            //Person p = new Person();
            
            Student student = new Student("Princess", "Peach", "SuperMarioGalaxy");

            Console.WriteLine(student);

            Console.ReadLine();
        }

        //static Person CreateSomething(int what) {
        //    if (what == 1) {
        //        Person p = new Person();
        //        return p;
        //    } else if (what == 2) {
        //        Student s = new Student();
        //        return s;
        //    } else {
        //        return new Teacher();
        //    }
        //}


        static void PrintPersonData(Person person) {
            Console.WriteLine($"{person.Name} {person.Surname} {person.Address} the sayhi says: {person.SayHi()}");
        }

        static void PrintPersonData(Person person, int howManyTimes) {
            for (int i = 0; i < howManyTimes; i++) {
                Console.WriteLine($"{person.Name} {person.Surname} {person.Address}");
            }
        }

        //static void PrintPersonData(Student person) {
        //    Console.WriteLine($"{person.Name} {person.Surname} {person.Address}");
        //}


        
    }
}
