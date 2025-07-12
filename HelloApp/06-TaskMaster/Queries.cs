using BetterConsoleTables;

namespace TaskMaster
{
  public class Queries(List<Task> _tasks)
  {
    private List<Task> Tasks = _tasks;

    public void ListTasks()
    {
      ForegroundColor = ConsoleColor.DarkBlue;
      WriteLine("|------------------------- Lista De Tareas -------------------------|");
      Table table = new Table("Id", "Descripción", "Estado");
      foreach (var task in Tasks)
      {
        table.AddRow(task.Id, task.Description, task.Completed ? "Completada" : "");
      }
      table.Config = TableConfiguration.Unicode();
      Write(table.ToString());
      ReadKey();
    }

    public List<Task> AddTask()
    {
      try
      {
        ResetColor();
        Clear();
        WriteLine("|------------------------- Añadir Tarea -------------------------|");
        WriteLine("Ingrese la descripción de la tarea: ");
        var description = ReadLine()!;
        Task newTask = new Task(Utils.GenerateId(), description);
        Tasks.Add(newTask);
        ForegroundColor = ConsoleColor.Green;
        WriteLine("Tarea añadida con exito.");
        ResetColor();

        return Tasks;
      }
      catch (Exception ex)
      {
        ForegroundColor = ConsoleColor.Red;
        WriteLine(ex.Message);
        return Tasks;
      }
    }

    public List<Task> MarkAsCompleted()
    {
      try
      {
        ResetColor();
        Clear();
        WriteLine("|------------------------- Completar Tarea -------------------------|");
        WriteLine("Ingrese el ID de la tarea que deseas marcar como completada: ");
        var id = ReadLine()!;
        Task task = Tasks.Find(t => t.Id == id)!;
        if (task == null)
        {
          ForegroundColor = ConsoleColor.Red;
          WriteLine("No se encontró la tarea con el ID proporcionado.");
          ResetColor();
          return Tasks;
        }

        task.Completed = true;
        task.ModifiedAt = DateTime.Now;
        ForegroundColor = ConsoleColor.Green;
        WriteLine("Tarea marcada como completada exitosamente.");
        ResetColor();

        return Tasks;
      }
      catch (Exception ex)
      {
        ForegroundColor = ConsoleColor.Red;
        WriteLine(ex.Message);
        return Tasks;
      }
    }

    public List<Task> EditTask()
    {
      try
      {
        ResetColor();
        Clear();
        WriteLine("|------------------------- Editar Tarea -------------------------|");
        WriteLine("Ingrese el ID de la tarea que deseas editar: ");
        var id = ReadLine()!;
        Task task = Tasks.Find(t => t.Id == id)!;
        if (task == null)
        {
          ForegroundColor = ConsoleColor.Red;
          WriteLine("No se encontró la tarea con el ID proporcionado.");
          ResetColor();
          return Tasks;
        }

        WriteLine("Ingresa la descripción de la tarea: ");
        var description = ReadLine();
        task.Description = description;
        task.ModifiedAt = DateTime.Now;
        ForegroundColor = ConsoleColor.Green;
        WriteLine("Tarea modificada exitosamente.");
        ResetColor();

        return Tasks;
      }
      catch (Exception ex)
      {
        ForegroundColor = ConsoleColor.Red;
        WriteLine(ex.Message);
        return Tasks;
      }
    }

    public List<Task> RemoveTask()
    {
      try
      {
        ResetColor();
        Clear();
        WriteLine("|------------------------- Eliminar Tarea -------------------------|");
        WriteLine("Ingrese el ID de la tarea que deseas eliminar: ");
        var id = ReadLine()!;

        Task task = Tasks.Find(t => t.Id == id)!;
        if (task == null)
        {
          ForegroundColor = ConsoleColor.Red;
          WriteLine("No se encontró la tarea con el ID proporcionado.");
          ResetColor();
          return Tasks;
        }

        Tasks.Remove(task);
        ForegroundColor = ConsoleColor.Green;
        WriteLine("Tarea eliminada exitosamente.");
        ResetColor();

        return Tasks;
      }
      catch (Exception ex)
      {
        ForegroundColor = ConsoleColor.Red;
        WriteLine(ex.Message);
        return Tasks;
      }
    }

    public void TasksByState()
    {
      try
      {
        ResetColor();
        Clear();
        WriteLine("|------------------------- Tareas Por Estado -------------------------|");
        WriteLine("1. Completadas");
        WriteLine("2. Pendientes");
        Write("Ingresa la opción de las tareas a mostrar: ");
        var taskState = ReadLine()!;
        if (taskState != "1" && taskState != "2")
        {
          ForegroundColor = ConsoleColor.Red;
          WriteLine("Opción Inválida");
          ResetColor();
          return;
        }

        bool completed = taskState == "1";
        List<Task> filteredTasks = Tasks.Where(t => t.Completed == completed).ToList();
        if (filteredTasks.Count == 0)
        {
          ForegroundColor = ConsoleColor.Red;
          WriteLine("No se encontraron tareas con ese estado");
          ResetColor();
          return;
        }

        ForegroundColor = completed ? ConsoleColor.Green : ConsoleColor.Red;
        Table table = new Table("Id", "Descripción", "Estado");
        foreach (var task in filteredTasks)
        {
          table.AddRow(task.Id, task.Description, task.Completed ? "Completada" : "");
        }
        table.Config = TableConfiguration.Unicode();
        Write(table.ToString());
        ReadKey();


      }
      catch (Exception ex)
      {
        ForegroundColor = ConsoleColor.Red;
        WriteLine($"Ocurrió un error al filtrar las tareas: {ex.Message}");
      }
    }

    public void TasksByDescription()
    {
      try
      {
        ResetColor();
        Clear();
        WriteLine("|------------------------- Tareas Por Descripción -------------------------|");
        Write("Ingresa la descripción de las tareas a buscar: ");
        var description = ReadLine()!;
        List<Task> matchingTasks = Tasks.FindAll(t => t.Description?.Contains(description, StringComparison.OrdinalIgnoreCase) ?? false);
        if (matchingTasks.Count == 0)
        {
          ForegroundColor = ConsoleColor.Red;
          WriteLine("No se encontraron tareas con esa descripción");
          ResetColor();
          return;
        }

        Table table = new Table("Id", "Descripción", "Estado");
        foreach (var task in matchingTasks)
        {
          table.AddRow(task.Id, task.Description, task.Completed ? "Completada" : "");
        }
        table.Config = TableConfiguration.Unicode();
        Write(table.ToString());
        ReadKey();


      }
      catch (Exception ex)
      {
        ForegroundColor = ConsoleColor.Red;
        WriteLine($"Ocurrió un error al filtrar las tareas por descripcion: {ex.Message}");
      }
    }
  }
}
