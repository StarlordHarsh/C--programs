using System;
//delegate declaration first
public delegate void Edelegate(string str);
class EventClass
{
    //declaration of event
      public event Edelegate Status;
      public void TriggerEvent()
      {
           if(Status!=null)
           Status("Event Triggered");
      }
}
class EventTest
      {
           public static void Main()
           {
             EventClass ec=new EventClass();
             EventTest et= new EventTest();
             ec.Status+=new EDelegate(et.EventCatch);
             ec.TriggerEvent();
           }
           public void EventCatch(string str)
           {
              Console.WriteLine(str);
            }
}
