// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using Tarea;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Tareas> TareasPendientes = new List<Tareas>();
        List<Tareas> TareasRealizadas = new List<Tareas>();

        int cantidad = 0;
        string? descripcion;
        int duracion = 0;
        int id;

        Console.WriteLine("Ingrese la cantidad de tareas: ");
        int.TryParse(Console.ReadLine(), out cantidad);

        //cargar tareas
        for (int i = 0; i < cantidad; i++)
        {
            id = i + 1;
            Console.WriteLine("Ingrese la descripcion de la tarea: ");
            descripcion = Console.ReadLine();
            duracion = 1 * 2;

            var Tareax = new Tareas(id, descripcion, duracion);

            TareasPendientes.Add(Tareax);
        }

        int estado = 0;

        //mover tareas
        Console.WriteLine("-------TAREAS PENDIENTES-------");
        for (int i = 0; i < TareasPendientes.Count; i++)
        {
            Console.WriteLine("Tarea ID: " + TareasPendientes[i].TareaID);
            Console.WriteLine("Descripcion: " + TareasPendientes[i].Descripcion);
            Console.WriteLine("Duracion: " + TareasPendientes[i].Duracion);

            Console.WriteLine("Realizo la tarea? 1-si, 0-no: ");
            int.TryParse(Console.ReadLine(), out estado);

            if (estado == 1)
            {
                TareasRealizadas.Add(TareasPendientes[i]);
                TareasPendientes.RemoveAt(i);
                //cantidad--;
                i--;
            }
        }

        Console.WriteLine("--------TAREAS REALIZADAS--------");
        MostrarTareas(TareasRealizadas);

        Console.WriteLine("-------TAREAS PENDIENTES-------");
        MostrarTareas(TareasPendientes);

        string? descripcionbuscada;

        Console.WriteLine("Ingrese la descripcion de la tarea que desea buscar: ");
        descripcionbuscada = Console.ReadLine();

        foreach (var tar in TareasPendientes)
        {
            if (tar.Descripcion.Contains(descripcionbuscada))
            {
                Console.WriteLine("Tarea encontrada!!!!!");
                Console.WriteLine("Tarea ID: " + tar.TareaID);
                Console.WriteLine("Descripcion: " + tar.Descripcion);
                Console.WriteLine("Duracion: " + tar.Duracion);
            }
            else
            {
                Console.WriteLine("No se encontro la tarea :((");
            }
        }
    }

    private static void MostrarTareas(List<Tareas> tareita)
    {
        foreach (var tar in tareita)
        {
            Console.WriteLine("Tarea ID: " + tar.TareaID);
            Console.WriteLine("Descripcion: " + tar.Descripcion);
            Console.WriteLine("Duracion: " + tar.Duracion);
        }
        
    }

}