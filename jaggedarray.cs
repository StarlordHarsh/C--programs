using System;


    class bulbjagged
    {
      
        public static void Main(string[] args)
            {
             
                using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] x = new int[4][] ;
                int a,b,c,d,i,j;
                Console.WriteLine("Enter size of x[0] ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter size of x[1] ");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter size of x[2] ");
                c = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter size of x[3] ");
                d = Convert.ToInt32(Console.ReadLine());
                x[0]=new int[a];
                x[1]=new int[b];
                x[2]=new int[c];
                x[3]=new int[d];
          
                
              /* input each array element's value */
                Console.WriteLine("Enter value in 1st jagged array");
                for( i=0; i<a;i++)
                 {
                   x[0][i]=Convert.ToInt32(Console.ReadLine());
                 }
                Console.WriteLine("Enter value in 2nd jagged array");
                 for( j=0; j<b;j++)
                 {
                   x[1][j]=Convert.ToInt32(Console.ReadLine());
                 }
                 Console.WriteLine("Enter value in 3rd jagged array");

                for( i=0; i<c;i++)
                 {
                   x[2][i]=Convert.ToInt32(Console.ReadLine());
                 }
                Console.WriteLine("Enter value in 4rth jagged array");

               for( j=0; j<d;j++)
                 {
                   x[3][j]=Convert.ToInt32(Console.ReadLine());
                 }


                /* output each array element's value */
               Console.WriteLine("Jagged Array1 is ");
                for( j=0;j<a;j++)
                 {
                   Console.WriteLine(x[0][j]);
                 }
                Console.WriteLine("Jagged Array2 is ");
                for (j = 0; j < b; j++)
                {
                    Console.WriteLine(x[1][j]);
                }
                Console.WriteLine("Jagged Array3 is ");
                for (j = 0; j < c; j++)
                {
                    Console.WriteLine(x[2][j]);
                }
                Console.WriteLine("Jagged Array4 is ");
                for (j = 0; j < d; j++)
                {
                    Console.WriteLine(x[3][j]);
                }
                Console.ReadKey();
            
        }
    }
}

            }
        }
    


