partial class Program
{
  static string? amount;
  static void HandleExceptions()
  {
    try
    {
      // int number = 10;
      // int result = number / 0;

      Write("Ingresa un monto: ");
      amount = ReadLine();
      if (string.IsNullOrEmpty(amount)) return;

      if (double.TryParse(amount, out double amountValue))
      {
        // double amountValue = double.Parse(amount);
        WriteLine($"El monto que introdujiste es el siguiente: {amountValue:C}");
      }
      else
      {
        WriteLine("No se pudo convertir el texto al número.");
      }

      ValidateAge(16);
    }
    catch (DivideByZeroException)
    {
      ForegroundColor = ConsoleColor.Red;
      WriteLine("Error: Division por cero");
    }
    catch (FormatException) when (amount?.Contains('$') == true)
    {
      ForegroundColor = ConsoleColor.Red;
      WriteLine("No es necesario usar el '$'");
    }
    catch (Exception ex)
    {
      ForegroundColor = ConsoleColor.Red;
      WriteLine(ex.Message);
    }
    finally
    {
      ResetColor();
      WriteLine("Esto siempre se ejecutará");
    }
  }

  static void ValidateAge(int age)
  {
    if (age < 18)
    {
      throw new ArgumentException("La edad debe de ser mayor a 18");
    }
  }
}