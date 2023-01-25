using System;

namespace Homework7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notebook[] notebooks = new Notebook[4];

            for (int i = 0; i < notebooks.Length; i++)
            {
                Console.Write("Brand: ");
                string brand = Console.ReadLine();

                Console.Write("Model: ");
                string model = Console.ReadLine();

                Console.Write("Price: ");
                string priceStr = Console.ReadLine();
                double price = Convert.ToDouble(priceStr);

                Notebook notebook = new Notebook(brand, model, price);

                notebooks[i] = notebook;

            }

            double sum = 0;
            int count = 0;
            for (int i = 0; i < notebooks.Length; i++)
            {
                sum += notebooks[i].Price;
                count++;
            }
            Console.WriteLine(sum / count);

            //Student st = new Student
            //{
            //    Point = 65
            //};

            //Console.WriteLine(st.IsGraduated());

            //Human hm = new Human
            //{
            //    Name = "Harry",
            //    Surname = "Potter"
            //};
            //Console.WriteLine(hm.GetFullname());
        }
    }
}
