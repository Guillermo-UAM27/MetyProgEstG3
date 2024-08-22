using Microsoft.VisualBasic;

namespace aumentodesalario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Strings nombre, cargo;
            float salario, aumento, nuevosalario ;
            Console.Write("Digita tu nombre: ");
            nombre=Console.Read();
            Console.Write("Digite tu cargo en la empresa: ");
            cargo=Console.Read();
            Console.Write("Ingrese el salario actual del trabajador: ");
            salario=Console.Read();
            aumento=salario * 0.1;
            nuevosalario= salario + aumento;
            
            //Imprecion de datos
            Console.Write("\nDatos del trabajador:");
            Console.Write($"Nombre: {nombre}");
            Console.Write($"Cargo: {cargo}");
            Console.Write($"Salario actual: ${salario}");
            Console.Write($"Aumento (10%): ${aumento}");
            Console.Write($"Nuevo salario: ${nuevosalario}");
        }
    }
}
