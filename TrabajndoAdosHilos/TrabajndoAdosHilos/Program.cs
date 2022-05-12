using System;
using System.IO;
using System.Threading;
   
public class Mensajes{
   public void Mostrar1()
   {
      for(int i=0;i<10;i++){
         Console.WriteLine("Escribiendo desde ==> 1");
         Thread.Sleep(1000);
      }
   }
   
   public void Mostrar2()
   {
      for(int i=0;i<10;i++){
         Console.WriteLine("Escribiendo desde ==> 2" ) ;
         Thread.Sleep(1000);
      }
   }
}
   
public class Ejemplo{
   
   public static void Main()
   {
      Mensajes msg = new Mensajes();
   
      Thread th1 = new Thread(new ThreadStart(msg.Mostrar1));
      Thread th2 = new Thread(new ThreadStart(msg.Mostrar2));
   
      th1.Start();
      th2.Start();
   
      th1.Join();
      th2.Join();
   } 
}
