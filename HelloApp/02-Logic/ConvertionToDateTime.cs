using System.Globalization;

partial class Program
{
  static void ConvertionToDateTime()
  {
    CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("es-MX");

    int friends = int.Parse("101");
    double cost = 25.50;
    DateTime birthday = DateTime.Parse("2 Marzo 2025");
    WriteLine($"Tengo {friends} amigos para invitar a mi fiesta.");
    WriteLine($"La celebración de mi cumpleaños será {birthday}");
    WriteLine($"Formato largo {birthday:D}");
    WriteLine($"El costo de la entrada será {cost:C}");
  }
}