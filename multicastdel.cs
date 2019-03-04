using System;
delegate void MDelegate();  
class DM  
{  
    static public void Display()  
    {  
        Console.WriteLine("Meerut");  
    }  
    static public void print()  
    {  
        Console.WriteLine("Roorkee");  
    }  
}  
class MTest  
{  
    public static void Main()  
    {  
        MDelegate m1 = new MDelegate(DM.Display);  
        MDelegate m2 = new MDelegate(DM.print);  
        MDelegate m3 = m1 + m2;  
        MDelegate m4 = m2 + m1;  
        MDelegate m5 = m3 - m2;  
        m3();  
        m4();  
        m5();  
    }  
} 