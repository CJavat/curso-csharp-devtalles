partial class Program
{
  static void HandleNulleables()
  {
    // No nullificable.
    string firstName = "Carlos";

    // Nulificable
    string? lastName = null;

    Console.WriteLine($"Nombre: {firstName}");
    if (lastName != null)
    {
      Console.WriteLine($"Apellido: {lastName}");
    }
    else
    {
      Console.WriteLine($"No hay un valor en ese campo.");
    }

    // Operador de coalescencia nula: ??
    Console.WriteLine($"Apellido: {lastName ?? "Apellido no especificado."}");

    // Operador de acceso nulo seguro: ?.
    string? text = null;
    Console.WriteLine(text?.Length);
  }
}
