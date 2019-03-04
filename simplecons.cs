using System;
class bulb
{
    public int x;
    public bulb()
     {
       x=90;
     }
}
class democonst
     {
       public static void Main()
            {
            bulb b1= new bulb();
            bulb b2= new bulb();
            Console.WriteLine(b1.x + " " +b2.x);
            }
      }