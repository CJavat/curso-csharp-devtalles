partial class Program
{
  static void Arrays()
  {
    int[] numbers = new int[5];
    numbers[0] = 1;
    numbers[1] = 3;

    // Directa
    int[] numberArrays = { 5, 10, 15, 20, 25, 30 };
    int[] numberArraysSimp = [5, 10, 15, 20, 25, 30];

    // Índices
    Console.WriteLine($"Primer elemento {numberArrays[0]}");
    Console.WriteLine($"Tercer elemento {numberArrays[3]}");
    // Tamaño del arreglo
    Console.WriteLine($"El número de elementos es: {numberArrays.Length}");

    // Recorrer desde el final del arreglo
    Console.WriteLine($"Último elemento {numberArrays[^1]}");
    Console.WriteLine($"penultimo elemento {numberArrays[^2]}");

    // Rangos para obtener subarreglos ..
    int[] firstThree = numberArrays[..3];
    int[] fromIndexTwo = numberArrays[2..];

    foreach (var number in firstThree)
    {
      Console.Write($"{number}, ");
    }
    Console.WriteLine("\n-----------");
    foreach (var number in fromIndexTwo)
    {
      Console.Write($"{number}, ");
    }
  }

}
