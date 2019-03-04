using System;
class bulb
{
   public static int x;
  public int z;
   static bulb()
   {
      Console.WriteLine("Enter Value of static member");
      x=Convert.ToInt32(Console.ReadLine());
   }
   public bulb(int y)
   {
      z=y;
   }
  
}
class staticons
{
   public static void Main()
{
    bulb b1= new bulb(78);
    
    Console.WriteLine("static value is " + bulb.x );
    Console.WriteLine("instance member value " + b1.z);
}
}