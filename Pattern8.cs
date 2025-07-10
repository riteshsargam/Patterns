class Pattern8
{
  static void Main()
  {
    Console.Write("Enter number of rows: ");
    int num = int.Parse(Console.ReadLine());
    Console.Clear();
    int result;
    for(int i=0;i<=num;i++)                                 
    {
      result = 1;
      for(int j=i;j <= num - 1;j++)                            
        Console.Write(" "); 
      for(int k=0;k<=i;k++)                                        
      {
        Console.Write(result + " ");                 
        result = (result * (i - k) / (k + 1));                          
      }
      Console.WriteLine(); 
    }
    Console.ReadLine(); 
  }
}
