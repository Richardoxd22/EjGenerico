using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjGenerico
{
    
    class ArrayOperaciones<T>
    {
        private  T[] resultado;
        private int k;
        public ArrayOperaciones(int sum)
        {
            resultado = new T[sum];
            k = 0;
        }
        public void opersum(T oobject)
        {
            resultado[k]= oobject;
            k++;
        }
        public T resultadooper(int resultadototal)
        {
            return resultado[resultadototal];
        }
   
    }
}
