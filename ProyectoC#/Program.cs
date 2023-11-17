internal class Program
{
    private static void Main(string[] args)
    {
    {
        int numero1, numero2, total;
        Console.WriteLine("Introduce el primer numero: ");
        numero1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Introduce el segundo numero: ");
        numero2 = Convert.ToInt32(Console.ReadLine());
        total = numero1 + numero2;
        Console.WriteLine("La suma de numero1 y numero2 es: " + total);
    }
    }
}