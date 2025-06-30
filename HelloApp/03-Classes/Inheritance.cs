partial class Program
{
  public static void Inheritance()
  {
    HowgartsStudent student = new HowgartsStudent() { Name = "Harry Potter", House = "Gryffindor" };
    HowgartsProfessor professor = new HowgartsProfessor() { Name = "Severus Sanape", Subject = "Pociones" };

    student.Greet();
    student.ShowHouse();
    professor.Greet();
    professor.MySubject();
  }
}

class Character
{
  public string? Name { get; set; }

  public virtual void Greet()
  {
    WriteLine($"Hola, soy {Name}");
  }
}

class HowgartsStudent : Character
{
  public string? House { get; set; }

  public void ShowHouse()
  {
    WriteLine($"Pertenezco a la casa {House} en Howgarts");
  }

  public override void Greet()
  {
    WriteLine($"Hola, soy {Name} y soy estudiante");
  }
}

class HowgartsProfessor : Character
{
  public string? Subject { get; set; }

  public void MySubject()
  {
    WriteLine($"Enseño {Subject} en Howgarts");
  }

  public override void Greet()
  {
    WriteLine($"Hola, soy {Name} y soy profesor");
  }
}