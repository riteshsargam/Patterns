class Pattern11
{
  static void Main()
  {
    Console.Write("Enter number of rows: ");
    int num = int.Parse(Console.ReadLine());
    Console.Clear(); 
    for(int i=0;i < num;i++)
    {
      if(i == 0 || i == num - 1)
      {
        for (int j = 0; j < num; j++)
          Console.Write('*');
        Console.WriteLine(); 
      }
      else
      {
        for(int j=0;j<num;j++)
        {
          if (j == 0 || j == num - 1)
            Console.Write('*');
          else
            Console.Write(' ');                        
        }
        Console.WriteLine();
      }
    }
    Console.ReadLine();
  }
}
