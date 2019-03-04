using System;
class Item
  {
    public void Company()  //base class
     {
       Console.WriteLine("Item Code=123");
     }
  }
class Fan:Item
{
   public void Model()
    {
     Console.WriteLine("Fan Model:Classic");
    }
}
class simpleinheritance
{
   public static void Main()
    {
    Item item=new Item();
    Fan fan= new Fan();
    item.Company();
    fan.Company();
    fan.Model();
}
}