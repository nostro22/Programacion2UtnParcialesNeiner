using Microsoft.VisualStudio.TestTools.UnitTesting;
using IO;
namespace PruebasArchivos
{
    [TestClass]
    public class PuntoTxtTest
    {
        [TestMethod]
        public void validarExtension_DebeRetornarTrue_SiLaExtensionEsTxt()
        {
            //Arrange
            PuntoTxt puntoTxt = new PuntoTxt();

            //Act
            bool retorno = puntoTxt.ValidarExtension("archivo.txt");

            //Assert

            Assert.IsTrue(retorno);
        }

        [TestMethod]
        [ExpectedException(typeof(ArchivoIncorrectoException))]
        public void validarExtension_DebeRetornarFalse_SiLaExtensionNoEsTxt()
        {
            //Arrange
            PuntoTxt puntoTxt = new PuntoTxt();

            //Act
            bool retorno = puntoTxt.ValidarExtension("archivo.bin");
         
        }
    }
}
