partial class Program
{
  static void ShowStringType()
  {
    string name = "Juan";
    string message = "Hola " + name;
    string interpolatedMessage = $"Hola {name}";

    Console.WriteLine(message);
    Console.WriteLine(interpolatedMessage);
    Console.WriteLine($"Tu nombre tiene {name.Length} letras");
    Console.WriteLine($"Tu nombre en mayúsculas es {name.ToUpper()}");
    Console.WriteLine($"Tu nombre en mínusculas es {name.ToLower()}");

    int number = 13;
    Console.WriteLine(number.ToString());
    bool isString = true;
    Console.WriteLine(isString.ToString());
  }
}