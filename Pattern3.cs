 class Pattern3
{
  static void Main()
  {
    Console.Write("Enter number of rows: ");
    int Rows = int.Parse(Console.ReadLine());
    Console.Clear();
    int x = 1;
    for(int i=1;i<=Rows;i++)
    {
      for (int j = 1; j <= i; j++)
        Console.Write($"{x++} ");
      Console.WriteLine(); 
    }
    Console.ReadLine(); 
  }
}
