using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArregloEnteros
{
    public class ArrayElements
    {
        private int[] _arreglo;
        public ArrayElements(int[] arreglo)
        {
            _arreglo = arreglo;
        }

        public bool isContinuo()
        {
            int primerElemento = _arreglo[0];
            int siguiente = _arreglo[1];

            for (int i = 0; i < _arreglo.Length; i++)
            {
                
            }

            return true;
        }

        public int[] GetFaltantes()
        {
            return new int[1] { 1 };
        }
    }
}
