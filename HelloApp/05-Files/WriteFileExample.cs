partial class Program
{
  static void WriteFileExample()
  {
    var filePath = "./05-Files/EjemploEscritura.txt";
    var content = "Esto se añadirá al final del archivo.";
    var streamWriter = new StreamWriter(filePath, append: true); //? append hace que no sobre escriba el archivo.
    streamWriter.WriteLine(content);
    streamWriter.WriteLine("La hora actual es: " + DateTime.Now.ToString("HH:mm:ss"));
    streamWriter.Dispose(); //? Esto es para cerrar el archivo | terminar la ejecución

    WriteLine("Archivoi creado exitosamente.");
  }
}