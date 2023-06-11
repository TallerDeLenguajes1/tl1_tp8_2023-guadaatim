// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

string? ruta;

Console.WriteLine("Ingrese la ruta de una carpeta: ");
ruta = Console.ReadLine();

List<string> archivos = Directory.GetDirectories(ruta).ToList();

foreach (string archivo in archivos)
{
    Console.WriteLine(archivo);
}


