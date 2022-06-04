using Microsoft.VisualStudio.TestTools.UnitTesting;
using BibliotecaPruebasUnitarias;

namespace UnitTestI01
{
    [TestClass]
    public class CalculadoraStringTest
    {
        [TestMethod]
        //GivenWhenThen
        public void Add_WhenTakeEmptyString_Return0()
        {
            //Arrage
            string text = string.Empty;
            int expected = 0;
            CalculadoraString calculadora = new CalculadoraString();

            //Act
            int actual = calculadora.Add(text);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Add_WhenRecibeOneNumbers_ReturnTheNumber()
        {
            //Arrage
            string text = "1";
            int expected = 1;
            CalculadoraString calculadora = new CalculadoraString();

            //Act
            int actual = calculadora.Add(text);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_WhenRecibeTwoNumbresSepartedWithComma_ReturnTheNumber()
        {
            //Arrage
            string text = "1,2";
            int expected = 3;
            CalculadoraString calculadora = new CalculadoraString();

            //Act
            int actual = calculadora.Add(text);

            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Add_WhenRecibeNCantNumbresSepartedWithComma_ReturnTheNumber()
        {
            //Arrage
            string text = "1,2,3,4";
            int expected = 10;
            CalculadoraString calculadora = new CalculadoraString();

            //Act
            int actual = calculadora.Add(text);

            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Add_WhenRecibeNCantNumbresSepartedWithCommaAndOrlineSkip_ReturnTheNumber()
        {
            //Arrage
            string text = "1\n2,3";
            int expected = 6;
            CalculadoraString calculadora = new CalculadoraString();

            //Act
            int actual = calculadora.Add(text);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_WhenRecibeNCantNumbresSepartedWithSpecialDelimitators_ReturnTheNumber()
        {
            //Arrage
            string text = "//:1\n2:3,4";
            int expected = 10;
            CalculadoraString calculadora = new CalculadoraString();

            //Act
            int actual = calculadora.Add(text);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException (typeof(NegatioNoPermitidoException))]
        public void Add_WhenRecibeNegativeNumbers_ReturnNegativeNotPermitException()
        {
            //Arrage
            string text = "//:1\n2:-3,4";            
            CalculadoraString calculadora = new CalculadoraString();

            //Act
            int actual = calculadora.Add(text);
          
        }

    }
}
