partial class Program
{
  static void Visibility()
  {
    Jedi jedi = new Jedi();
    jedi.PowerLevel = 5000;
    jedi.LightSaberColor = "Azul";
    // jedi.UseForce();

    // WriteLine(jedi.PublicField);
    // jedi.RevealSecrets();

    Stih sith = new Stih();
    sith.ShowProtected();
  }
}

interface IForceUser
{
  int PowerLevel { get; set; }
  string? LightSaberColor { get; set; }
  void UseForce();
}

class Jedi : IForceUser
{
  public string PublicField = "Soy un Jedi y mi poder es conocido";
  private string PrivateField = "Mis pensamientos más profundos son privados";
  protected string ProtectedField = "El lado oscuro no debe de conocer mis secretos";

  public int PowerLevel { get; set; }

  public string? LightSaberColor { get; set; }

  public void UseForce()
  {
    WriteLine($"Soy un Jedi con un sable de luz {LightSaberColor} y mi nivel de poder es {PowerLevel}");
  }

  private void Meditate()
  {
    WriteLine($"Estoy en profunda meditación con la fuerza");
  }

  protected void Train()
  {
    WriteLine($"EStoy entrenando para convertirme en el mejor Jedi");
  }

  public void RevealSecrets()
  {
    WriteLine(ProtectedField);
    WriteLine(PrivateField);
    Meditate();
  }
}

class Stih : Jedi, IForceUser
{
  public new void UseForce()
  {
    WriteLine($"Soy un Sith con un sable de luz {LightSaberColor} y mi nivel de poder es {PowerLevel}");
  }
  public void ShowProtected()
  {
    WriteLine(ProtectedField);
    Train();
  }
}