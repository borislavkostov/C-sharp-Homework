using System;

namespace Problem01
{
    class Personal
    {
        static void Main()
        {
            Person jim = new Person("Jim", 10);
            Console.WriteLine(jim);
            Person john = new Person("John", 35, "test@gmail.com");
            Console.WriteLine(john);
            //Tests
            //This test, string is it empty
            //Person bob = new Person("", 35, "test@gmail.com");
            //Console.WriteLine(bob);

            //This test range of age
            //Person alex = new Person("Alex", 105, "test@gmail.com");
            //Console.WriteLine(alex);

            //This test email validation
            //Person shmitz = new Person("Shmitz", 35, "test.gmail.com");
            //Console.WriteLine(shmitz);


        }
    }
}
