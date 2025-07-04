class Pattern2
{
  static void Main()
  {
    Console.Write("Enter a number: ");
    int Number = int.Parse(Console.ReadLine());
    Console.Clear();
    for (int i = Number; i >= 1; i--)
    {
      for (int j = Number; j >= i; j--)
        Console.Write(j);
      Console.WriteLine();
    }
    Console.ReadLine(); 
  }
}
