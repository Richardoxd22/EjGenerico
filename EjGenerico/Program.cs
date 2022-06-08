using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjGenerico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Ingrese valor");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese valor");
                int y = Convert.ToInt32(Console.ReadLine());
                ArrayOperaciones<int> proceso = new ArrayOperaciones<int>(4);

                proceso.opersum(x + y);
                proceso.opersum(x - y);
                proceso.opersum(x * y);
                proceso.opersum(x / y);

                int resum = proceso.resultadooper(0);
                int reres = proceso.resultadooper(1);
                int remul = proceso.resultadooper(2);
                int rediv = proceso.resultadooper(3);
                Console.WriteLine("Proceso sum:{0}+{1}={2}",x,y , resum);
                Console.WriteLine("Proceso res:{0}-{1}={2}", x, y, reres);
                Console.WriteLine("Proceso mul:{0}*{1}={2}", x, y, remul);
                Console.WriteLine("Proceso Div:{0}+{1}={2}", x, y, rediv);

                
            }catch (Exception ex)
            {
                Console.WriteLine("Error Solo numeros");
            }
            Console.ReadKey();
        }
        
    }
  
}
