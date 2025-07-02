partial class Program
{
  static void ShowEmployeesInformation()
  {

  }
}

abstract class Employee
{
  protected string? Name { get; set; }
  protected double Salary { get; set; }
  protected string? Position { get; set; }

  public Employee(string name, double salary, string position)
  {
    Name = name;
    Salary = salary;
    Position = position;
  }

  public virtual double CalculateBonus()
  {
    return Salary * 0.05;
  }

  public void ShowInfo()
  {
    WriteLine($"Nombre: {Name}, Cargo: {Position}, Salario: {Salary}, Bono Calculado: {CalculateBonus()}");
  }
}

class TeamLeader : Employee
{

  public TeamLeader(string name, double salary) : base(name, salary, "TeamLeader")
  {

  }

  public override double CalculateBonus()
  {
    return Salary * 0.10;
  }
}

class Developer : Employee
{
  public Developer(string name, double salary) : base(name, salary, "Developer")
  {

  }

  public override double CalculateBonus()
  {
    return Salary * 0.07;
  }
}