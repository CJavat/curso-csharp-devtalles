partial class Program
{
  static void NumericTypes()
  {
    int integerNumber = 42;
    double decimalNumber = 3.1416;
    float floatNumber = 274f;
    long longNumber = 300_200_100L;
    decimal monetaryNumber = 99.99m;

    Console.WriteLine(integerNumber);
    Console.WriteLine(decimalNumber);
    Console.WriteLine(floatNumber);
    Console.WriteLine(longNumber);
    Console.WriteLine(monetaryNumber);
  }
}