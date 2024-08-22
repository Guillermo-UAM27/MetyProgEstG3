namespace Nombre_y_Apellido
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre, apellido;

            Console.WriteLine("Digite su nombre:");
            nombre = Console.ReadLine();
            Console.Write("Digite su apellido: ");
            apellido = Console.ReadLine();
            Console.WriteLine($"Tu nombre es   {nombre}  {apellido}  mucho gusto");
        }
    }
}
