using System;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void VerificaMinimo()
        {
            //arrange
            var Rangos = new ArregloEnteros.Rangos(new int[] { 3, 4, 5, 6, 7 });

            //act
            var minimo = Rangos.GetMinimo();

            //
            Assert.Equal<int>(3, minimo);
        }

        [Fact]
        public void VerificaMaximo()
        {
            //arrange
            var Rangos = new ArregloEnteros.Rangos(new int[] { 3, 4, 7, 6, 9 });

            //act
            var maximo = Rangos.GetMaximo();

            //
            Assert.Equal<int>(9, maximo);
        }

        [Fact]
        public void GetPromedio()
        {
            //arrange
            var Rangos = new ArregloEnteros.Rangos(new int[] { 9, 2, 5, 6, 7 });

            //act
            var promedio = Rangos.GetPromedio();

            //
            Assert.Equal<double>(5.8, (double)promedio);
        }
    }
}
