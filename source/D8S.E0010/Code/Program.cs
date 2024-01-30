using System;

using Bogus;


namespace D8S.E0010
{
    class Program
    {
        static void Main()
        {
            var faker = new Faker();

            var filepath = faker.System.FilePath();


            Console.WriteLine(filepath);
        }
    }
}