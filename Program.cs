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

int realizar = 0;
int j = 0;

Console.WriteLine("-------TAREAS PENDIENTES-------");
for (int i = 0; i < cantidad; i++)
{
    Console.WriteLine("Tarea ID: " + TareasPendientes[i].TareaID);
    Console.WriteLine("Descripcion: " + TareasPendientes[i].Descripcion);
    Console.WriteLine("Duracion: " + TareasPendientes[i].Duracion);

    Console.WriteLine("Realizo la tarea? 1-si, 0-no: ");
    int.TryParse(Console.ReadLine(), out realizar);

    if (realizar == 1)
    {
        TareasRealizadas.Add(TareasPendientes[i]);
        TareasPendientes.RemoveAt(i);
        cantidad--;
        i--;
    }

}

Console.WriteLine("--------TAREAS REALIZADAS--------");
foreach (var tar in TareasRealizadas)
{
    Console.WriteLine("Tarea ID: " + tar.TareaID);
    Console.WriteLine("Descripcion: " + tar.Descripcion);
    Console.WriteLine("Duracion: " + tar.Duracion);
}

Console.WriteLine("-------TAREAS PENDIENTES-------");
foreach (var tar in TareasPendientes)
{

    Console.WriteLine("Tarea ID: " + tar.TareaID);
    Console.WriteLine("Descripcion: " + tar.Descripcion);
    Console.WriteLine("Duracion: " + tar.Duracion);
}