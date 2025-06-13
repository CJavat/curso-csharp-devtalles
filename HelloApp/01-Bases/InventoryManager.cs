partial class Program
{
  // 🏆 Ejercicio:
  // - Mostrar el inventario actualizado después de cada compra. 
  // - Crear un menu con las opciones de 1. Comprar producto y 2. Salir.
  static void InventoryManager()
  {
    string[] products = ["Monitor", "Mouse", "Teclado"];
    int[] stock = [10, 25, 30];
    double[] prices = [250.50, 20.50, 45];

    Console.WriteLine("Inventario De Productos");
    Console.WriteLine("|---------------------------|");
    Console.WriteLine("| Selecciona 1 para COMPRAR |");
    Console.WriteLine("| Selecciona 2 para SALIR   |");
    Console.WriteLine("|---------------------------|");

    int opcionSeleccionada = int.Parse(Console.ReadLine()!);

    if (opcionSeleccionada == 1)
    {
      for (int i = 0; i < products.Length; i++)
      {
        Console.WriteLine($"Producto: {products[i]}, Stock: {stock[i]}, Precio: {prices[i]}");
      }

      Console.WriteLine("\nIngrese el producto que desea comprar: ");
      string? searchedProduct = Console.ReadLine();

      Console.WriteLine("Ingrese la cantidad que desea comprar");
      int quantity = int.Parse(Console.ReadLine()!);

      for (int i = 0; i < products.Length; i++)
      {
        if (products[i].Equals(searchedProduct, StringComparison.OrdinalIgnoreCase))
        {
          if (quantity <= stock[i])
          {
            double total = quantity * prices[i];
            stock[i] = stock[i] - quantity;
            Console.WriteLine($"Compra exitosa. El total a pagar son ${total} Pesos");
            Console.WriteLine($"El stock restante para el producto {products[i]} es: {stock[i]}");
          }
          else
          {
            Console.WriteLine($"No hay suficiente stock disponible");
          }
        }
      }
    }
    else
    {
      Console.WriteLine("Gracias por visitarnos.");
    }
  }
}
