using System.Collections.Generic;
using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.GeoShapeGenerator.Enums;
using NUnit.Framework;

namespace DevelopmentChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        [TestCase]
        public void TestResumenListaVacia()
        {
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
                FormaGeometrica.Imprimir(new List<FormaGeometrica>(), Idiomas.Castellano));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                FormaGeometrica.Imprimir(new List<FormaGeometrica>(), Idiomas.Ingles));
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var cuadrados = new List<FormaGeometrica> {new FormaGeometrica(Formas.Cuadrado, 5)};

            var resumen = FormaGeometrica.Imprimir(cuadrados, Idiomas.Castellano);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 formas Perimetro 20 Area 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConUnRectanguloItaliano()
        {
            var rectangulos = new List<FormaGeometrica> { new FormaGeometrica(Formas.Rectangulo, 5,2) };

            var resumen = FormaGeometrica.Imprimir(rectangulos, Idiomas.Italiano);

            Assert.AreEqual("<h1>Rapporto sulle forme</h1>1 Rettangolo | Area 10 | Perimetro 14 <br/>TOTAL:<br/>1 forme Perimetro 14 Area 10", resumen);
        }

        [TestCase]
        public void TestResumenListaConUnTrapecioItaliano()
        {
            var trapecios = new List<FormaGeometrica> { new FormaGeometrica(Formas.Trapecio, 6, 2, 3, 4, 5) };

            var resumen = FormaGeometrica.Imprimir(trapecios, Idiomas.Italiano);

            Assert.AreEqual("<h1>Rapporto sulle forme</h1>1 Trapezio | Area 9 | Perimetro 18 <br/>TOTAL:<br/>1 forme Perimetro 18 Area 9", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            var cuadrados = new List<FormaGeometrica>
            {
                new FormaGeometrica(Formas.Cuadrado, 5),
                new FormaGeometrica(Formas.Cuadrado, 1),
                new FormaGeometrica(Formas.Cuadrado, 3)
            };

            var resumen = FormaGeometrica.Imprimir(cuadrados, Idiomas.Ingles);

            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            var formas = new List<FormaGeometrica>
            {
                new FormaGeometrica(Formas.Cuadrado, 5),
                new FormaGeometrica(Formas.Circulo, 3),
                new FormaGeometrica(Formas.TrianguloEquilatero, 4),
                new FormaGeometrica(Formas.Cuadrado, 2),
                new FormaGeometrica(Formas.TrianguloEquilatero, 9),
                new FormaGeometrica(Formas.Circulo, 2.75m),
                new FormaGeometrica(Formas.TrianguloEquilatero, 4.2m),
                new FormaGeometrica(Formas.Trapecio, 6, 2, 3, 4, 5),
                new FormaGeometrica(Formas.Trapecio, 6, 2, 3, 4, 5)
            };

            var resumen = FormaGeometrica.Imprimir(formas, Idiomas.Ingles);

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13,01 | Perimeter 18,06 <br/>3 Triangles | Area 49,64 | Perimeter 51,6 <br/>2 Trapezoids | Area 18 | Perimeter 36 <br/>TOTAL:<br/>9 shapes Perimeter 133,66 Area 109,65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            var formas = new List<FormaGeometrica>
            {
                new FormaGeometrica(Formas.Cuadrado, 5),
                new FormaGeometrica(Formas.Circulo, 3),
                new FormaGeometrica(Formas.TrianguloEquilatero, 4),
                new FormaGeometrica(Formas.Cuadrado, 2),
                new FormaGeometrica(Formas.TrianguloEquilatero, 9),
                new FormaGeometrica(Formas.Circulo, 2.75m),
                new FormaGeometrica(Formas.TrianguloEquilatero, 4.2m)
            };

            var resumen = FormaGeometrica.Imprimir(formas, Idiomas.Castellano);

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13,01 | Perimetro 18,06 <br/>3 Triángulos | Area 49,64 | Perimetro 51,6 <br/>TOTAL:<br/>7 formas Perimetro 97,66 Area 91,65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMaTiposItaliano()
        {
            var formas = new List<FormaGeometrica>
            {
                new FormaGeometrica(Formas.Cuadrado, 5),
                new FormaGeometrica(Formas.Circulo, 3),
                new FormaGeometrica(Formas.TrianguloEquilatero, 4),
                new FormaGeometrica(Formas.Cuadrado, 2),
                new FormaGeometrica(Formas.TrianguloEquilatero, 9),
                new FormaGeometrica(Formas.Circulo, 2.75m),
                new FormaGeometrica(Formas.TrianguloEquilatero, 4.2m)
            };

            var resumen = FormaGeometrica.Imprimir(formas, Idiomas.Italiano);

            Assert.AreEqual(
                "<h1>Rapporto sulle forme</h1>2 Quadrati | Area 29 | Perimetro 28 <br/>2 Cerchi | Area 13,01 | Perimetro 18,06 <br/>3 Triangoli equilateri | Area 49,64 | Perimetro 51,6 <br/>TOTAL:<br/>7 forme Perimetro 97,66 Area 91,65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConNovoTipoItaliano()
        {
            var formas = new List<FormaGeometrica>
            {
                new FormaGeometrica(Formas.Cuadrado, 5),
                new FormaGeometrica(Formas.Circulo, 3),
                new FormaGeometrica(Formas.TrianguloEquilatero, 4),
                new FormaGeometrica(Formas.Cuadrado, 2),
                new FormaGeometrica(Formas.TrianguloEquilatero, 9),
                new FormaGeometrica(Formas.Circulo, 2.75m),
                new FormaGeometrica(Formas.TrianguloEquilatero, 4.2m),
                 new FormaGeometrica(Formas.Trapecio, 6, 2, 3, 4, 5)
            };

            var resumen = FormaGeometrica.Imprimir(formas, Idiomas.Italiano);

            Assert.AreEqual(
                "<h1>Rapporto sulle forme</h1>2 Quadrati | Area 29 | Perimetro 28 <br/>2 Cerchi | Area 13,01 | Perimetro 18,06 <br/>3 Triangoli equilateri | Area 49,64 | Perimetro 51,6 <br/>1 Trapezio | Area 9 | Perimetro 18 <br/>TOTAL:<br/>8 forme Perimetro 115,66 Area 100,65",
                resumen);
        }
    }
}
