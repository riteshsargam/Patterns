class Pattern4
{
  static void Main()
  {
    Console.Write("Enter number of rows: ");
    int Rows = int.Parse(Console.ReadLine());
    Console.Clear();
    int x = 0, y = 0;
    for (int i = 1; i <= Rows; i++)
    {
      if(i % 2 == 0)
      {
        x = 1;
        y = 0;
      }
      else
      {
        x = 0;
        y = 1;
      }
      for (int j = 1; j <= i; j++)
      {
        if (j % 2 == 0)
          Console.Write(x);
        else
          Console.Write(y); 
      }
      Console.WriteLine();
    }
    Console.ReadLine();
  }
}
