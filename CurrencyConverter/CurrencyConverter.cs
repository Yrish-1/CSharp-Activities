
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter amount in USD: ");
        double usd = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter exchange rate from USD to EUR: ");
        double rate = Convert.ToDouble(Console.ReadLine());

        double eur = usd * rate;

        Console.WriteLine("Amount in EUR: " + eur);
        Console.ReadKey();
    }
}