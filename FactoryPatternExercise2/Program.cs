namespace FactoryPatternExercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What Database type do you want to use? (List, SQL, or Mongo)");
            var userInput = Console.ReadLine();


            IDataAccess databaseAccess = DataAccessFactory.GetDataAccess(userInput);


            List<Product> products = databaseAccess.LoadData();
            databaseAccess.SaveData();


            Console.WriteLine("These are your products:");


            foreach (var product in products)
            {
                Console.WriteLine($"{product.Name} > {product.Price,0:c}");
            }

        }
    }
}