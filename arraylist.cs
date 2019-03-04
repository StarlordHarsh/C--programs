using System;
using System.Collections;
class city
{
  public static void Main()
{
   ArrayList n= new ArrayList();

for(int i=0;i<=4;i++)
{
   String str=Console.ReadLine();
  n.Add(str);
}
//n.Add("Madras");
//n.Add("Bombay");
//n.Add("Kolkata");
//n.Add("Dehradun");
//n.Add("89");
Console.WriteLine("Capacity= "+n.Capacity);
Console.WriteLine("Elemets present="+n.Count);
n.Sort();
for(int i=0;i<n.Count;i++)
{
   Console.WriteLine(n[i]);
}
Console.WriteLine();
n.RemoveAt(4);
for(int i=0;i<n.Count;i++)
{
  Console.WriteLine(n[i]);
}
}
}

