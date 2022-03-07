using System;

namespace IMC
{
    class Program
    {
        public static string name;
        public static int age;
        public static float height;
        public static float weight;

        public static void Main(String[] args)
        {
            Person objPerson = new Person(name, age);
            Health objHealth = new Health(weight, height);
            Console.WriteLine("Hello! input the client data: \nClient Name: ");
            name = Console.ReadLine();
            Console.WriteLine("Client age: ");
            age = int.Parse(Console.ReadLine());
            objPerson.SetName(name);
            objPerson.SetAge(age);

            Console.WriteLine("\n|---------------------------------------------------------------------|\n");
            Console.WriteLine("Enter with Weight and Height of " + objPerson.GetName());
            Console.WriteLine("Height: ");
            height = float.Parse(Console.ReadLine());
            Console.WriteLine("Weight: ");
            weight = float.Parse(Console.ReadLine());

            objHealth.SetHeight(height);
            objHealth.SetWeight(weight);

            Calc objCalc = new Calc(objHealth.GetHeight(), objHealth.GetWeight());
            
            Console.WriteLine("\n|---------------------------------------------------------------------|\n");
            Console.WriteLine("Result:\n"); 
            Console.WriteLine("Client Data: ");
            Console.WriteLine("Name: " + objPerson.GetName());
            Console.WriteLine("Age: " + objPerson.GetAge());
            Console.WriteLine("Height: " + objHealth.GetHeight());
            Console.WriteLine("Weight: " + objHealth.GetWeight());
            Console.WriteLine("Final Result: ");
            Console.WriteLine("Status = " + objCalc.getStatus());
            Console.WriteLine("IMC = " + objCalc.getCalc());



        }
    }
}
