partial class Program
{
  static void LoopsControlExamples()
  {
    for (int i = 0; i < 10; i++)
    {
      if (i == 5)
      {
        break;
      }

      // WriteLine(i);
    }

    for (int i = 0; i < 10; i++)
    {
      if (i == 5)
      {
        continue;
      }

      // WriteLine(i);
    }

    for (int i = 0; i < 10; i++)
    {
      if (i == 3)
      {
        return;
      }

      WriteLine(i);
    }
  }
}
