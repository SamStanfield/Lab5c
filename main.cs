using System;

class MainClass {
  public static void Main (string[] args) {
    int num;
    Console.WriteLine("Input a number.");
    num = Convert.ToInt32(Console.ReadLine());
    if(num==0)
    {
     Console.WriteLine(num  + " is not a prime number");
    }
    else if(num==1)
    {
      Console.WriteLine(num + " is not a prime number");
    }
    
    else
    {
      for(int filler = 2; filler <= num/2; filler++)
      {
        if (num % filler == 0)
        {
          Console.WriteLine(num + " is not a prime number");
        }
        else if (num % filler !=0)
        {
          Console.WriteLine(num + " is a prime number");
        }
        
      }
    }
  }
}