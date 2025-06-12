using System.IO;
using System.Text;
using EspacioId3v1;
string ruta = @"./LectorTagMP3\audio.mp3";
FileStream fileStream = new FileStream(ruta, FileMode.Open);

fileStream.Seek(fileStream.Length - 128, SeekOrigin.Begin);
byte[] buffer = new byte[128];
int bytesLeidos = fileStream.Read(buffer, 0, 128);
string header = Encoding.Latin1.GetString(buffer,0,3);
string titulo = Encoding.Latin1.GetString(buffer,3,30);
string artista = Encoding.Latin1.GetString(buffer,33,30);
string album = Encoding.Latin1.GetString(buffer,63,30);
string anio = Encoding.Latin1.GetString(buffer,93,4);
string comentario = Encoding.Latin1.GetString(buffer,97,30);
byte genero = buffer[127];
Id3v1Tag nuevaCancion = new Id3v1Tag(header, titulo, artista, album, anio, comentario, genero);
nuevaCancion.Mostrar();




// foreach (var b in buffer)
// {
//   string binario = Convert.ToString(b, 2);
//   char claveAscii = (char)b;
//   System.Console.WriteLine($"{binario} - {claveAscii}");
// }
