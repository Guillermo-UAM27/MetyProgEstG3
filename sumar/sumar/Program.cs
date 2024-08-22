namespace sumar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float num1, num2, suma;
            Console.Write("Digite un numero: ");
            num1 = float.Parse(Console.ReadLine());
            Console.Write("Digite otro numero: ");   
            num2 = float.Parse(Console.ReadLine());
            suma = num1 + num2;
            Console.WriteLine("La suma es " + suma);
        }
    }
}
