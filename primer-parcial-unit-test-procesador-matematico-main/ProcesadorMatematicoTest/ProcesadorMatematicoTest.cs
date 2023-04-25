using primer_parcial_unit_test_procesador_matematico;
using Xunit;

namespace ProcesadorMatematicoTest
{
    public class ProcesadorMatematicoTest
    {
        [Fact]
        public void sumaTest()
        {
            //Arrange
            ProcesadorMatematico p = new ProcesadorMatematico();
            int primerValor = 6, segundovalor = 4;
            //Act
            //Assert
            Assert.Equal(p.Sumar(primerValor, segundovalor), 10);
        }

        [Fact]
        public void sumaNegativaTest()
        {
            //Arrange
            ProcesadorMatematico p = new ProcesadorMatematico();
            int primerValor = -6, segundovalor = 4;
            //Act
            //Assert
            Assert.Equal(p.Sumar(primerValor, segundovalor), 0);
        }

        [Fact]
        public void dividirTest()
        {
            //Arrange
            ProcesadorMatematico p = new ProcesadorMatematico();
            int primerValor = 8, segundovalor = 2;
            //Act
            //Assert
            Assert.Equal(p.Dividir(primerValor, segundovalor), 4);
        }

        [Fact]
        public void dividirNegativoTest()
        {
            //Arrange
            ProcesadorMatematico p = new ProcesadorMatematico();
            int primerValor = -8, segundovalor = 2;
            //Act
            //Assert
            Assert.Equal(p.Dividir(primerValor, segundovalor), 0);
        }

        [Fact]
        public void primeroMayorTest()
        {
            //Arrange
            ProcesadorMatematico p = new ProcesadorMatematico();
            int primerValor = 8, segundovalor = 2;
            //Act
            //Assert
            Assert.Equal(p.CalcularMayor(primerValor, segundovalor), 8);
        }

        [Fact]
        public void segundoMayorTest()
        {
            //Arrange
            ProcesadorMatematico p = new ProcesadorMatematico();
            int primerValor = -8, segundovalor = 2;
            //Act
            //Assert
            Assert.Equal(p.CalcularMayor(primerValor, segundovalor), 2);
        }

        [Fact]
        public void igualesTest()
        {
            //Arrange
            ProcesadorMatematico p = new ProcesadorMatematico();
            int primerValor = 2, segundovalor = 2;
            //Act
            //Assert
            Assert.Equal(p.CalcularMayor(primerValor, segundovalor), 2);
        }
    }
}