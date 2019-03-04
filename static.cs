using System;
class bulb
{  
   public static float fun1(float x,float y)
    {
         return x*y;
    }
    public static float fun2(float x, float y)
    {
             return x/y;
    }
}
class tubelight
     {
          public static void Main()
                {
                
                  float a=bulb.fun1(4.0F,5.05F);
                  float b=bulb.fun2(a,2.0F);
                  Console.WriteLine("b ="+b);
                }
     }