partial class Program
{
  static double CalculateArea(double width, double height)
  {
    return width * height;
  }

  static string EvaluateNumber(int number)
  {
    if (number > 0)
      return "Positivo";
    else if (number < 0)
      return "Negativo";
    else
      return "Cero";
  }

  static void Functions()
  {
    var area = CalculateArea(4.5, 2.3);
    WriteLine($"El área es {area}");
    var evaluate = EvaluateNumber(-45);
    WriteLine($"El número evaluado es {evaluate}");
  }
}