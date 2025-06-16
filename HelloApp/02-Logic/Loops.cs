partial class Program
{
  static void Loops()
  {
    // While
    int counter = 1;
    while (counter <= 5)
    {
      // WriteLine($"Iteración: {counter}");
      counter++;
    }

    // Do-While
    int number = 0;
    do
    {
      // WriteLine($"Número: {number}");
      number++;
    } while (number < 3);

    // For
    for (int i = 0; i < 5; i++)
    {
      WriteLine($"Iteración: {i}");
    }

    // Foreach
    string[] fruits = ["Manzana", "Pera", "Piña"];
    foreach (var fruit in fruits)
    {
      WriteLine(fruit);
    }
    List<string> names = ["Pedro", "Luis", "Nancy"];
    foreach (var name in names)
    {
      WriteLine(name);
    }
  }

}
