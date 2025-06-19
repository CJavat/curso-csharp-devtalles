partial class Program
{
  static void Methods()
  {
    Car car = new Car();
    car.Model = "Yaris";
    car.Year = 2022;
    WriteLine(car.ShowInfo());
    // car.ShowMessage();
    // car.ShowMessage("Cambiando de modelo...");
    // car.ChangeModel("Patrol");
    // WriteLine(car.ShowInfo());
    // Car.GeneralInfo();

    Car sportsCar = new Car("Ferrari", 2020);
    WriteLine(sportsCar.ShowInfo());

    // Sintaxis simplificada
    Car collectionCar = new Car { Model = "Cadillac", Year = 1980 };
    WriteLine(sportsCar.ShowInfo());

    // Lista de objetos
    WriteLine("Listado de automóviles:");
    List<Car> cars = new()
    {
      new Car(){Model="Duster", Year=2021},
      new Car(){Model="SteWay", Year=2019},
      new Car(){Model="Captur", Year=2000},
    };

    foreach (var carItem in cars)
    {
      WriteLine(carItem.ShowInfo());
    }
  }

  class Car
  {
    public string? Model { get; set; }
    public int? Year { get; set; }

    // Constructor con parametros
    public Car(string model, int year)
    {
      Model = model;
      year = year;
    }

    // Constructor por defecto
    public Car() { }

    //! Destructor (~)
    ~Car()
    {
      WriteLine("Destructor llamado. Recurso liberado.");
    }

    public void ChangeModel(string newModel)
    {
      Model = newModel;
    }

    public string ShowInfo()
    {
      return $"Automóvil {Model}, Año: {Year}";
    }

    public void ShowMessage() => WriteLine("Este es un automóvil");
    public void ShowMessage(string message) => WriteLine(message);

    public static void GeneralInfo()
    {
      WriteLine("El automóvil es uno de los transportes más utilizados");
    }
  }
}