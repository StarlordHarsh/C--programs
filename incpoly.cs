using System;
class Maruthi
{
   public virtual void Display()
    {
      Console.WriteLine("Maruthi Car");
    }
}
class Esteem:Maruthi
   {
     public override void Display()
      {
        Console.WriteLine("Maruthi Esteem");
      }
  }

class Zen:Maruthi
{
   public override void Display()
     {
        Console.WriteLine("Maruthi Zen");
     }
}
class inclusion
{
   public static void Main()
    {
     Maruthi m= new Maruthi();
     m= new Esteem();//upcasting
     m.Display();
     m=new Zen();    //upcasting
     m.Display();     

   }
}





