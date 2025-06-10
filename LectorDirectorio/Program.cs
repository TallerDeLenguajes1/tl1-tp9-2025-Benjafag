using System.Globalization;
using System.IO;
using System.Runtime.Intrinsics.Arm;

string path;
bool existe = false;
do
{
  path = Console.ReadLine();
  existe = Directory.Exists(path);
  if (!existe)
    Console.WriteLine("El directorio no existe, ingrese un path valido nuevamente");
} while (!existe);

string[] directorios = Directory.GetDirectories(path);
string[] archivos = Directory.GetFiles(path);

foreach (var rutaDirectorio in directorios)
{
  string nombreDirectorio = rutaDirectorio.Substring(rutaDirectorio.LastIndexOf('\\') + 1);
  Console.WriteLine(nombreDirectorio);
}
List<string> lineasCSV = new List<string>();

string linea;
foreach (var rutaArchivo in archivos)
{
  FileInfo archivo = new FileInfo(rutaArchivo);
  Console.WriteLine($"{archivo.Name}, {archivo.Length} bytes");
  linea = $"{archivo.Name}, {(archivo.Length/1024.0).ToString("F2", CultureInfo.InvariantCulture)} kb, {archivo.LastWriteTime}";
  lineasCSV.Add(linea);
}
string rutaCSV = @$"{path}\reporte_archivos.csv";
File.WriteAllLines(rutaCSV, lineasCSV);