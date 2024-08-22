namespace areadelcirculo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, areadelcirculo;
            Console.WriteLine("Calcula el area de un circulo");
            Console.Write("Digite el valor del radio: ");
            num1=Console.Read();
            areadelcirculo= Math.PI * Math.Pow(num1 ,2);
            Console.WriteLine($"El area es {areadelcirculo}.");

        }
    }
}
