using System;
class bulb
{
    public bulb(int x)
       {  
          Console.WriteLine("In constructor");
       }
     ~bulb()
        {
           Console.WriteLine("In destructor");
        }
}
class desctdemo
{
    public static void Main()
{
     bulb b1 = new bulb(55);
    }
}