using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArregloEnteros
{
    public class Rangos
    {
        private readonly int[] _arreglo;
        public Rangos(int[] arreglo)
        {
            _arreglo = arreglo;
        }

        public int GetMinimo()
        {
            int minimo = _arreglo[0];

            if (_arreglo.Length == 1)
                return minimo;

            for (int i = 0; i < _arreglo.Length; i++)
            {
                if(_arreglo[i] < minimo)
                    minimo = _arreglo[i];
            }

            return minimo;
        }

        public int GetMaximo()
        {
            int maximo = _arreglo[0];

            if (_arreglo.Length == 1)
                return maximo;

            for (int i = 0; i < _arreglo.Length; i++)
            {
                if (_arreglo[i] > maximo)
                    maximo = _arreglo[i];
            }

            return maximo;
        }

        public decimal GetPromedio()
        {
            decimal sumatoria = _arreglo[0];

            if (_arreglo.Length == 1)
                return sumatoria;

            for (int i = 0; i < _arreglo.Length; i++)
            {
                sumatoria = sumatoria + _arreglo[i];
            }

            return sumatoria / _arreglo.Length;
        }
    }
}
