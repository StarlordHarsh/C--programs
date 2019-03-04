using System;
class bulb
{ 
   public static void Main()
  {
     int x,y=0;      
int m=Convert.ToInt32(Console.ReadLine());
     switch(m)
  {
      case 1:
           x=y;
          Console.WriteLine(x);
          
           goto case 2;
    case 2:
              x=y+m;
               Console.WriteLine(x);
           goto default;
     default:
                  x=y-m;
Console.WriteLine(x);
                  break;
}
}
}
     