using Microsoft.VisualStudio.TestTools.UnitTesting;
using IO;
namespace PruebasArchivos
{
    [TestClass]
    public class PuntoXmlTest
    {
        [TestMethod]
        public void validarExtension_DebeRetornarTrue_SiLaExtensionEsXml()
        {
            //Arrange
            PuntoXml<string> puntoXml = new PuntoXml<string>();

            //Act
            bool retorno = puntoXml.ValidarExtension("archivo.xml");

            //Assert

            Assert.IsTrue(retorno);
        }

        [TestMethod]
        [ExpectedException(typeof(ArchivoIncorrectoException))]
        public void validarExtension_DebeRetornarFalse_SiLaExtensionNoEsXml()
        {
            //Arrange
            PuntoXml<string> puntoXml = new PuntoXml<string>();

            //Act
            bool retorno = puntoXml.ValidarExtension("archivo.txt");
         
        }
    }
}
