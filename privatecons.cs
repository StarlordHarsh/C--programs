using System;
class bulb
{
  private int z;
   private bulb(int y)
   {
      z=y;
   }
bulb b1= new bulb(78);
//Console.WriteLine("instance member value" + z);  
}
class privatecons
{
   public static void Main()
{
    bulb b1= new bulb(78);
   
}
}