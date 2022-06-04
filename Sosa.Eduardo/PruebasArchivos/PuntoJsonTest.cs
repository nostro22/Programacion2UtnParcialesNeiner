using Microsoft.VisualStudio.TestTools.UnitTesting;
using IO;
namespace PruebasArchivos
{
    [TestClass]
    public class PuntoJsonTest
    {
        [TestMethod]
        public void validarExtension_DebeRetornarTrue_SiLaExtensionEsJson()
        {
            //Arrange
            puntoJson<string> puntoJson = new puntoJson<string>();

            //Act
            bool retorno = puntoJson.ValidarExtension("archivo.json");

            //Assert

            Assert.IsTrue(retorno);
        }

        [TestMethod]
        [ExpectedException(typeof(ArchivoIncorrectoException))]
        public void validarExtension_DebeRetornarFalse_SiLaExtensionNoEsJson()
        {
            //Arrange
            puntoJson<string> puntoJson = new puntoJson<string>();

            //Act
            bool retorno = puntoJson.ValidarExtension("archivo.txt");
         
        }
    }
}
