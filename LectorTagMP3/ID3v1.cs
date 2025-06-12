namespace EspacioId3v1;

public class Id3v1Tag
{
  private string header;
  private string titulo;
  private string artista;
  private string album;
  private string anio;
  private string comentario;
  private byte genero;

  public Id3v1Tag(string header, string titulo, string artista, string album, string anio, string comentario, byte genero)
  {
    this.header = header;
    this.titulo = titulo;
    this.artista = artista;
    this.album = album;
    this.anio = anio;
    this.comentario = comentario;
    this.genero = genero;
  }
  public void Mostrar()
  {
    System.Console.WriteLine($"{titulo.ToUpper()} ({anio})");
    System.Console.WriteLine($"{artista} - {album}");
    System.Console.WriteLine(comentario);
    System.Console.WriteLine("----------------------");
  }
}