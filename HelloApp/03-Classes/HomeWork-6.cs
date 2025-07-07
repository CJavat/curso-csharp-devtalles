partial class Program
{
  static void ShowEmployeesInformation()
  {
    List<Employee> employees = new List<Employee>();
    employees.Add(new TeamLeader("Carlos", 5000));
    employees.Add(new Developer("Ana", 4000));
    employees.Add(new TeamLeader("Laura", 6000));
    employees.Add(new Developer("Luis", 3500));

    WriteLine("Lista De Empleados");
    foreach (var employee in employees)
    {
      employee.ShowInfo();
    }
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
    WriteLine($"Nombre: {Name}, Cargo: {Position}, Salario: {Salary:C}, Bono Calculado: {CalculateBonus():C}");
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