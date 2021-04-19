using System;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
             int i, r, con, n;
	         double d;	
             

            Console.WriteLine("Feito por Tiago gostosão!");
		    Console.WriteLine("Escreva o número ao qual você quer fazer as operações:");
            n = int.Parse(Console.ReadLine());
            con = n ;

            for (i=0;i<=10;i++) {
            r= con + i;
			Console.WriteLine(+con +" + " + i +"= " +r);
			
		}
        Console.WriteLine("_________________________");
		for (i=0;i<=10;i++) {
			r= con - i;
			Console.WriteLine(+con +" - " + i +"= " +r);
			
		}
        Console.WriteLine("_________________________");
		for (i=0;i<=10;i++) {
			r= con * i;
			Console.WriteLine(+con +" x " + i +"= " +r);
			
		}
        Console.WriteLine("_________________________");
		for (i=1;i<=10;i++) {
			d = con / i;
			Console.WriteLine(+con +" : " + i +"= " +d);
			
		}
        }
    }
}
