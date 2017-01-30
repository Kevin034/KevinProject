using System;

namespace ArrayApplication
{
   class MyArray
   {
      static void Main(string[] args)
      {
         int []  n = new int[10]; /* n is an array of 10 integers */
         int i;
         
         n[0]=0;
         Console.WriteLine(n[0]);
         n[1]=1;
         Console.WriteLine(n[1]);

         /* initialize elements of array n */
         for ( i = 2; i < 10; i++ )
         {
            n[ i ] = n[ i-1 ] + n[ i-2 ];
            Console.WriteLine(n[i]);
         }

//         Console.ReadKey();
      }
   }
}