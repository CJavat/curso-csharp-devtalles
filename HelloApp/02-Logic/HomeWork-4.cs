partial class Program
{
  static void PrintMultiplicationTable(int number, int tableLimit = 10)
  {
    WriteLine($"La tabla de multiplicar del número {number} desde el 1 hasta el {tableLimit}\n");

    for (int i = 1; i <= tableLimit; i++)
    {
      WriteLine($"{number} x {i} = {number * 1}\n");
    }
  }

  // 🏆 Ejercicio:
  // Crear un método llamado `PrintFactorialTable` que reciba un número 
  // y muestre el factorial de todos los números desde 1 hasta el número ingresado.
  // Ejemplo: PrintFactorialTable(5);
  // 1! = 1
  // 2! = 2
  // 3! = 6
  // 4! = 24
  // 5! = 120
  static void PrintFactorialTable(int number)
  {
    int factorial = 1;
    WriteLine($"Factorial del número {number} desde el 1 hasta el {number}");
    for (int i = 1; i <= number; i++)
    {
      factorial *= i;
      WriteLine($"{i}! = {factorial}");
    }
  }
}