using System;
using Loja.Entities;
using Loja.Entities.Enums;


namespace Course {

    class Program {

        static void Main(string[] args) {

            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine();

            Order order = new Order();

            order.Client = new Client(name, email, birthDate);

            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            string Status = Console.ReadLine();


        }
    }
    
}