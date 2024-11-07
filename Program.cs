using YourNamespace.Services;
using YourNamespace.Models;

namespace YourNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tuto C#";

            Random random = new();
            int randomAge = random.Next(18, 65);

            // Utilisation de UserService pour gérer les utilisateurs
            UserService userService = new();
            userService.AddUser(new User { Name = "Alice", Age = randomAge });
            userService.AddUser(new User { Name = "Bob", Age = 25 });
            userService.DisplayAllUsers();

            // Utilisation de Product pour gérer un produit
            Product product = new("Laptop", 999.99m, 10);
            product.DisplayProductInfo();

            // Utilisation de CalculatorService pour effectuer des calculs
            Console.WriteLine($"Résultat de l'addition: {CalculatorService.Add(5, 3)}");

            Console.WriteLine("\nFin du programme. Appuyez sur une touche pour quitter.");
            Console.ReadKey();

        }
    }
}
