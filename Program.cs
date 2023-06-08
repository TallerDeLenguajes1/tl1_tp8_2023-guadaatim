// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using Tarea;

List<Tareas> TareasPendientes = new List<Tareas>();
List<Tareas> TareasRealizadas = new List<Tareas>(); 

// int cantidad = 0;

// Console.WriteLine("Ingrese la cantidad de tareas que desea cargar: ");
// bool control = int.TryParse(Console.ReadLine(), out cantidad);

// for (int i = 0; i < cantidad; i++)
// {
//     TareasPendientes[i].TareaID = i + 1;
//     Console.WriteLine("Ingrese una deescripcion: ");
//     TareasPendientes[i].Descripcion = Console.ReadLine();
//     Console.WriteLine("Ingrese la duracion: ");
//     //int.TryParse(Console.ReadLine(), out TareasPendientes[i].Duracion);
//     TareasPendientes[i].Duracion = Console.Read();    
// }

Tareas tarea;

tarea.Descripcion = "hohhl";
tarea.Duracion = 100;
tarea.TareaID = 1;

TareasPendientes.Add(tarea);

foreach (var tar in TareasPendientes)
{
    Console.WriteLine(tarea);
}