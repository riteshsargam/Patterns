class Pattern7
{
  static void Main()
  {
    Console.Write("Enter number of rows: ");
    int num = int.Parse(Console.ReadLine());
    Console.Clear();
    for(int i=1;i<= num;i++)
    {
      for (int space = 1; space <= (num - i); space++)
        Console.Write(" ");
      for (int j = 1; j <= i; j++)
        Console.Write(j);
      for (int k = (i - 1); k >= 1; k--)
        Console.Write(k); 
      Console.WriteLine(); 
    }
    Console.ReadLine(); 
  }
}
