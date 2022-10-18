using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class ListDataAccess : IDataAccess
    {
        public void SaveData()
        {
            Console.WriteLine("Saving data to your List database...");
        }

        public List<Product> LoadData()
        {
            Console.WriteLine("Accessing your List...");
            return new List<Product>()
            {
                new Product() { Name = "Crayons", Price = 1.99m },
                new Product() { Name = "Markers", Price = 6.99m },
                new Product() { Name = "Notebook", Price = 9.99m },
                new Product() { Name = "Scissors", Price = 2.99m },
                new Product() { Name = "Calculator", Price = 29.99m },
                new Product() { Name = "Pocket Folders", Price = 7.99m },
                new Product() { Name = "Pencils", Price = 4.99m }
            };
        }

    }
}
