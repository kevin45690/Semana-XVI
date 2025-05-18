using System;
class program
{
    static void Main(string[] args)
    {
        Console.Write("^^Ingrese el nombre del estudiante: ^^");
        string nombre = Console.ReadLine();

        while (string.IsNullOrWhiteSpace(nombre))
        {
            Console.Write("El nombre no puede estar vacio. Ingrese el nombre porfavor: ");
            nombre = Console.ReadLine();
        }
        Console.Write("°°°°°°°°°°°°°°°INGRESE LA CALIFICACION DEL ESTUDIANTE (0-10)°°°°°°°°°°°°°°:");
        string inputCalifacion = Console.ReadLine();
        double calificacion;
while (!double.TryParse(inputCalifacion, out calificacion)|| calificacion <0 || calificacion > 10)
        {
            Console.Write("Calificacion Invalida. Ingresar una calificacion entre  0 y 10");
            inputCalifacion = Console.ReadLine();
        }
if (calificacion >= 6)
        {
            Console.WriteLine($"Ï Felicidades, {nombre}! Has aprobado con una calificacion de {calificacion}. ");
        }
        else {
            Console.WriteLine($"Lo sentimos Mucho, {nombre}. Has roprobado con una calificacion de {calificacion}.");
        }
    }
}
// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


