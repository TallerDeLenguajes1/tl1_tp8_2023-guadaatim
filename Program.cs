// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using Tarea;

List<Tareas> TareasPendientes = new List<Tareas>();
List<Tareas> TareasRealizadas = new List<Tareas>(); 

int cantidad = 0;
string? descripcion;
int duracion = 0;
int id;

Console.WriteLine("Ingrese la cantidad de tareas: ");
int.TryParse(Console.ReadLine(), out cantidad);

for (int i = 0; i < cantidad; i++)
{
    id = i+1;
    Console.WriteLine("Ingrese la descripcion de la tarea: ");
    descripcion = Console.ReadLine();
    duracion = 1 * 2;

    var Tareax = new Tareas(id, descripcion, duracion);

    TareasPendientes.Add(Tareax);
}

foreach (var tar in TareasPendientes)
{
    Console.WriteLine("Tarea ID: " + tar.TareaID);
    Console.WriteLine("Descripcion: " + tar.Descripcion);
    Console.WriteLine("Duracion: " + tar.Duracion);
}
