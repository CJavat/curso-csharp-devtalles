partial class Program
{
  static void Conditionals()
  {
    int aget = 19;
    if (aget >= 18)
    {
      WriteLine("Eres mayor de edad");
    }
    else
    {
      WriteLine("No eres mayor de edad");
    }

    string message = aget >= 18 ? "Eres mayor de edad" : "No eres mayor de edad";
    WriteLine(message);

    // Multiples condiciones
    int temperature = 30;

    if (temperature > 35)
    {
      WriteLine("Hace mucho calor");
    }
    else if (temperature >= 20)
    {
      WriteLine("Es agradable");
    }
    else
    {
      WriteLine("Hace frio");
    }

    int day = 3;
    switch (day)
    {
      case 1:
        WriteLine("Lunes");
        break;
      case 2:
        WriteLine("Martes");
        break;
      case 3:
        WriteLine("Miércoles");
        break;
      default:
        WriteLine("Día no válido");
        break;
    }

    // Switch con expresiones
    string dayMessage = day switch
    {
      1 => "Lunes",
      2 => "Martes",
      3 => "Miércoles",
      _ => "Día no válido"
    };

    WriteLine(dayMessage);
  }

}
