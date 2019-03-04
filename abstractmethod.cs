using System;
abstract class bulb
   {
      public abstract void life(int x, int y) ;     
            
    }
class tubelight : bulb
    {
          public override void life(int p, int q)
            {
             int t1=p;
              int t2=q;
               
                Console.WriteLine("value of t1 is" +t1);
Console.WriteLine("value of t2 is" +t2);
            }
    }
class newtest
    {
            public static void Main()
           {
                tubelight tb1=new tubelight();
              
                tb1.life(78,79);
             }
    }