partial class Program
{
  static void Tuples()
  {
    (int, string) myTuple = (42, "Hola");
    WriteLine($"Número: {myTuple.Item1}, Texto: {myTuple.Item2}");

    (int Number, string Text) myOtherTuple = (33, "Mundo");
    WriteLine($"Número: {myOtherTuple.Number}, Texto: {myOtherTuple.Text}");

    var operations = Operations(20, 10);
    WriteLine(operations);
    (int sum, int substraction) = Operations(25, 15);
    WriteLine($"Suma: {sum}, Resta: {substraction}");
  }

  static (int Sum, int Substraction) Operations(int a, int b)
  {
    return (a + b, a - b);
  }
}