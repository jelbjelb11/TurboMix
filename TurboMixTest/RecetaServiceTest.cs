using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TurboMix;
using Moq;

namespace TurboMixTest
{
    [TestClass]
    public class RecetaServiceTest
    {
        [TestMethod]
        public void AniadirTest()
        {
            var mockRecetaRepository = new Mock<IRecetaRepository>();
            Receta receta = new Receta();

            IRecetaService sut = new RecetaService(mockRecetaRepository.Object);
            sut.Aniadir(receta);
            mockRecetaRepository.Verify(recetaRepository => recetaRepository.Crear(It.IsAny<Receta>()), Times.Once);

        }
    }
}
