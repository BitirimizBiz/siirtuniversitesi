using System;
namespace toplama
{
 class ToplamaFonksiyonu
 {
   public static int topla(int a,int b)
   {
    
      return a+b;
   }
   
   public static void Main(string[] args)
   {
     int x = topla(10,20);
     Console.WriteLine(x);
   }
 }
}
