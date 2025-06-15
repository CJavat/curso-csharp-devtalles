
partial class Program
{
  static void Generics()
  {
    string[] names = ["Juan", "Luis", "Diana"];
    int[] numbers = { 1, 2, 3, 25 };

    Console.WriteLine($"El tamaño del arreglo númerico {GetArrayLength(numbers)}");
    Console.WriteLine($"El tamaño del arreglo nombres {GetArrayLength(names)}");

    Box<int> numberBox = new Box<int> { Content = 50 };
    Box<string> stringBox = new Box<string> { Content = "Hola Mundo" };

    numberBox.Show();
    stringBox.Show();
  }

  // Métodos sin el uso de genericos.
  static int GetIntArrayLength(int[] array)
  {
    return array.Length;
  }

  static int GetStringArrayLength(string[] array)
  {
    return array.Length;
  }

  // Método genérico.
  static int GetArrayLength<T>(T[] array)
  {
    return array.Length;
  }

  class Box<T>
  {
    public T? Content { get; set; }

    public void Show()
    {
      Console.WriteLine($"Contenido: {Content}");
    }
  }
}