using System;
class bulb
   {
      public void life()
            {
               Console.WriteLine("Life is great");
            }
      public void weekend()
            {
               Console.WriteLine("Tomorrow is weekend");
            }
    }
class tubelight : bulb
    {
          public new void life()
            {
                Console.WriteLine("My Life is great");
            }
    }
class newtest
    {
            public static void Main()
            {
                bulb b1=new bulb();
                tubelight tb1=new tubelight();
                b1.life();
                b1.weekend();
                tb1.life();
             }
    }