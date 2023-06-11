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

        Console.WriteLine("Ingrese la cantidad de tareas: ");
        int.TryParse(Console.ReadLine(), out cantidad);

        //cargar tareas
        for (int i = 0; i < cantidad; i++)
        {
            Console.WriteLine("Ingrese la descripcion de la tarea: ");
            descripcion = Console.ReadLine();
            duracion = i * 25;

            var Tareax = new Tareas(i+1, descripcion, duracion);
            TareasPendientes.Add(Tareax);
        }

        //mover tareas
        int estado = 0;

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

        //mostrar tareas
        Console.WriteLine("--------TAREAS REALIZADAS--------");
        MostrarTareas(TareasRealizadas);
        Console.WriteLine("-------TAREAS PENDIENTES-------");
        MostrarTareas(TareasPendientes);

        //buscar tarea por descripcion
        BuscarTarea(TareasPendientes); 

        //guardar horas trabajadas
        GuardarArchivo(TareasRealizadas);
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

    private static void BuscarTarea(List<Tareas> tareita)
    {
        string? descripcionbuscada;
        Console.WriteLine("Ingrese la descripcion de la tarea que desea buscar: ");
        descripcionbuscada = Console.ReadLine();
        int a = 0;

        foreach (var tar in tareita)
        {
            if (tar.Descripcion.Contains(descripcionbuscada))
            {
                a = 1;
                Console.WriteLine("Tarea encontrada!!!!!");
                Console.WriteLine("Tarea ID: " + tar.TareaID);
                Console.WriteLine("Descripcion: " + tar.Descripcion);
                Console.WriteLine("Duracion: " + tar.Duracion);
            }
            
        }

        if (a == 0)
        {
            Console.WriteLine("No se encontro la tarea :((");
        }
    }

    private static void GuardarArchivo(List<Tareas> tareita)
    {
        int suma = 0;
        string? ruta = @"C:\taller1\tl1_tp8_2023-guadaatim\";

        foreach (var tar in tareita)
        {
            suma += tar.Duracion;
        }

        StreamWriter sw = new StreamWriter(ruta + "cantidadhorastrabajadas", true);
        sw.WriteLine("Horas trabajadas: " + suma);
        sw.Close();
    }

}

//StreamWriter sw = new StreamWriter(ruta + nombrearchivo, true)/
//writeline //escribe dentro del archivo
//swclose //cerrar archivo