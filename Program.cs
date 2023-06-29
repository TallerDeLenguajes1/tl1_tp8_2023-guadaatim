// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

string? ruta;

Console.WriteLine("Ingrese la ruta de una carpeta: ");
ruta = Console.ReadLine();

//listar archivos
List<string> archivos = Directory.GetFiles(ruta).ToList();
//List<string> archivos = Directory.EnumerateFiles(ruta).ToList();

string? ruta2 = @"C:\taller1\tl1_tp8_2023-guadaatim\";

StreamWriter index = new StreamWriter(ruta2 + "index.csv", true);

int j = 0;

for (int i = 0; i < archivos.Count; i++)
{
    string[] separado = archivos[i].Split(@"\");
    string[] extension = separado[4].Split('.');
    index.WriteLine(j + ' ' + extension[0] + ' ' + extension[1]);
    j++;
}

index.Close();