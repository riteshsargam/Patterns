class Pattern1
{
  static void Main()
  {
    Console.Write("Enter a number: ");
    int num = int.Parse(Console.ReadLine());    
    Console.Clear();
    for(int i=1;i<=num;i++)
    {
      for(int j=1;j<=i;j++)
        Console.Write(j); 
      Console.WriteLine(); 
    }
    Console.ReadLine(); 
  }
}
