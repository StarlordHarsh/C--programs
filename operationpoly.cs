using System;
class Dog
{
}
class Cat
{
}
class Operation 
{
  static void Call(int x)
   {  
    Console.WriteLine("Dog is called" +x);
   }
   static void Call(Cat c)
     {
      Console.WriteLine("Cat is called");
     }
public static void Main()
   {
    Dog dog=new Dog();
    Cat cat= new Cat();
    Call(78);//invoking Call()
    Call(cat);//again invoking Call()
}
}
