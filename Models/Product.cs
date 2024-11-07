namespace YourNamespace.Models
{
    public class Product(string name, decimal price, int stock)
    {
        public string Name { get; set; } = name;
        public decimal Price { get; set; } = price;
        public int Stock { get; set; } = stock;

        public void DisplayProductInfo()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine($"Produit: {Name}, Prix: {Price:C}, Stock: {Stock}");
        }
    }
}
