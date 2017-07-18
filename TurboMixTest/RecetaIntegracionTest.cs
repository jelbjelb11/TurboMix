using System;
using Microsoft.Practices.Unity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TurboMix;

namespace TurboMixTest
{
    [TestClass]
    public class RecetaIntegracionTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Receta receta = new Receta();
            //            IRecetaRepository recetaRepository = new RecetaRepository();

            IUnityContainer container = new UnityContainer();
            container.RegisterType<ITurboMixService, TurboMixService>();
            container.RegisterType<IRecetaRepository, RecetaRepository>();
            container.RegisterType<ICocinaService, CocinaService>();
            container.RegisterType<IBasculaService, BasculaService>();
            container.RegisterType<IRecetaService, RecetaService>();

            //            IRecetaService sut = new RecetaService(recetaRepository);
            IRecetaService sut = container.Resolve<IRecetaService>();

            sut.Aniadir(receta);
           
        }
    }
}
