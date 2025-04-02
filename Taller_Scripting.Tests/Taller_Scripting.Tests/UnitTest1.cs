using NUnit.Framework;
using Taller_Scripting;  

namespace Taller_Scripting.Tests
{
    [TestFixture]  
    public class NodoBTTests
    {
        [Test]  
        public void NodoEvaluarDistancia_DeberiaRetornarTrue_CuandoDistanciaEsMenorOIgualAUmbral()
        {
          
            int distanciaActual = 4;
            int distanciaValida = 5;
            var nodo = new NodoEvaluarDistancia(distanciaActual, distanciaValida);

            bool resultado = nodo.Ejecutar();

            Assert.IsTrue(resultado);
        }

        [Test]
        public void NodoEvaluarDistancia_DeberiaRetornarFalse_CuandoDistanciaEsMayorAUmbral()
        {
            int distanciaActual = 10;
            int distanciaValida = 5;
            var nodo = new NodoEvaluarDistancia(distanciaActual, distanciaValida);

            bool resultado = nodo.Ejecutar();

            Assert.IsFalse(resultado);
        }
    }
}
