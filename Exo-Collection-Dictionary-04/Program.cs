namespace Exo_Collection_Dictionary_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Dictionary<string,int> cart = new Dictionary<string,int>();
            string product;
            int quantity;
            string option;
            do
            {
                Console.WriteLine("Product: ");
                product = Console.ReadLine();
                Console.WriteLine("Qantity: ");
                quantity = int.Parse(Console.ReadLine());
                cart.Add(product, quantity);
                Console.WriteLine($"Choose between 'A'-add, 'M'-modify, 'D'-delete product and its quantity or 'Q' to quit the program");

                do
                {
                    option = Console.ReadKey().Key.ToString();
                } while (option != "M" && option != "D");

                switch (option)
                {
                    case "A":
                        Console.WriteLine();
                        Console.WriteLine("Product: ");
                        product = Console.ReadLine();
                        Console.WriteLine("Qantity: ");
                        quantity = int.Parse(Console.ReadLine());
                        cart.Add(product, quantity);
                        Console.WriteLine();
                        break;
                    case "M":
                        Console.WriteLine();
                        Console.WriteLine("Which product do you want to modify its quantity: ");
                        product = Console.ReadLine();
                        Console.WriteLine("What's the new quantity for this product: ");
                        quantity = int.Parse(Console.ReadLine());
                        cart[product]=quantity;

                        break;
                    case "D":
                        Console.WriteLine();
                        Console.WriteLine("Which product do you want to delete: ");
                        product = Console.ReadLine();
                        cart.Remove(product);
                        Console.WriteLine();
                        break;

                }
                Console.WriteLine();
                foreach (KeyValuePair<string, int> kvp in cart)
                {
                    Console.WriteLine($"Product=>{kvp.Key}, quantity=>{kvp.Value}");
                }
                Console.WriteLine($"Choose between 'A'-add, 'M'-modify, 'D'-delete product and its quantity or 'Q' to quit the program");
                option = Console.ReadKey().Key.ToString();
                Console.WriteLine();
            } while (option != "Q");



        }
    }
}