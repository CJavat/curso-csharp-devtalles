partial class Program
{
  static void AbstractClassExamples()
  {
    HomeAppliance myWasher = new WashingMachine { Brand = "Samsung" };
    HomeAppliance myMicrowave = new Microwave { Brand = "DG" };

    myWasher.ShowBrand();
    myWasher.TurnOn();

    myMicrowave.ShowBrand();
    myMicrowave.TurnOn();
  }
}

abstract class HomeAppliance
{
  public string? Brand { get; set; }

  public abstract void TurnOn();

  public void ShowBrand()
  {
    WriteLine($"La marca del electrodoméstico es: {Brand}");
  }
}

class WashingMachine : HomeAppliance
{
  public override void TurnOn()
  {
    WriteLine("La lavadora ha inicializado el ciclo de lavado");
  }
}

class Microwave : HomeAppliance
{
  public override void TurnOn()
  {
    WriteLine("El microondas está calentando la comida");
  }
}
