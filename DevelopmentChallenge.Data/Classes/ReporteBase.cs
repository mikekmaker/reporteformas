using DevelopmentChallenge.Data.GeoShapeGenerator;
using DevelopmentChallenge.Data.GeoShapeGenerator.Enums;
using DevelopmentChallenge.Data.GeoShapeGenerator.Interfaces;
using System.Collections.Generic;
using System.Text;

namespace DevelopmentChallenge.Data.Classes
{
    public class FormaGeometricaData
    {
        public int Numero { get; set; }
        public decimal Area { get; set; }
        public decimal Perimetro { get; set; }
    }

    public class ReporteBase
    {
        public Dictionary<Formas, FormaGeometricaData> TotalesFormas { get; set; }

        public ITraducible CurrentLanguage { get;set;}

        private static Translator ReportTranslator { get; set; }

        private static Calculator ShapeGenerator { get; set; }

        private List<FormaGeometrica> _Formas { get; set; }

        public ReporteBase(Idiomas idioma,List<FormaGeometrica> formas)
        {
            ReportTranslator = Translator.InitializeStrategies();
            ShapeGenerator = Calculator.InitializeStrategies();
            CurrentLanguage = ReportTranslator.GetLanguage(idioma);
            _Formas = formas;
            TotalesFormas = new Dictionary<Formas, FormaGeometricaData>
            {
                { Formas.Cuadrado, new FormaGeometricaData() },
                { Formas.TrianguloEquilatero, new FormaGeometricaData() },
                { Formas.Circulo, new FormaGeometricaData() },
                { Formas.Rectangulo, new FormaGeometricaData() },
                { Formas.Trapecio, new FormaGeometricaData() }
            };
            Procesar();
        }

        public StringBuilder Header(StringBuilder sb)
        {
            sb.Append(CurrentLanguage.EncabezadoReporte());
            return sb;
        }

        public StringBuilder Body (StringBuilder sb)
        {
            foreach (Formas forma in System.Enum.GetValues(typeof(Formas)))
            {
                var datos = TotalesFormas[forma];
                sb.Append(ObtenerLinea(datos.Numero, datos.Area, datos.Perimetro, forma));
            }
            return sb;
        }

        public StringBuilder Footer(StringBuilder sb)
        {
            int totalNumero = 0;
            decimal totalPerimetro = 0;
            decimal totalArea = 0;

            foreach (Formas forma in System.Enum.GetValues(typeof(Formas)))
            {
                var datos = TotalesFormas[forma];

                totalNumero += datos.Numero;
                totalPerimetro += datos.Perimetro;
                totalArea += datos.Area;
            }

            sb.Append("TOTAL:<br/>");
            sb.Append(totalNumero + " " + CurrentLanguage.Formas() + " ");
            sb.Append(CurrentLanguage.Perimetro() + " " + totalPerimetro.ToString("#.##") + " ");
            sb.Append("Area " + totalArea.ToString("#.##"));

            return sb;
        }

        private void Procesar()
        {
            foreach (var forma in _Formas)
            {
                var currentShape = ShapeGenerator.GetShape(forma, CurrentLanguage.Idioma);

                if (TotalesFormas.TryGetValue(forma.Tipo, out var total))
                {
                    total.Numero++;
                    total.Area += currentShape.CalcularArea();
                    total.Perimetro += currentShape.CalcularPerimetro();
                }
                else
                {
                    throw new System.ArgumentOutOfRangeException($"Forma desconocida: {forma.Tipo}");
                }
            }
        }



        private string ObtenerLinea(int cantidad, decimal area, decimal perimetro, Formas tipo)
        {
            if (cantidad > 0)
            {
                return $"{cantidad} {TraducirForma(tipo, cantidad)} | {CurrentLanguage.Area()} {area:#.##} | {CurrentLanguage.Perimetro()} {perimetro:#.##} <br/>";
            }

            return string.Empty;
        }

        private string TraducirForma(Formas tipo, int cantidad)
        {
            var funcionesPorForma = new Dictionary<Formas, System.Func<bool, string>>
            {
                { Formas.Cuadrado, CurrentLanguage.Cuadrado },
                { Formas.Circulo, CurrentLanguage.Circulo },
                { Formas.TrianguloEquilatero, CurrentLanguage.TrianguloEquilatero },
                { Formas.Rectangulo, CurrentLanguage.Rectangulo },
                { Formas.Trapecio, CurrentLanguage.Trapecio }
            };

            if (funcionesPorForma.TryGetValue(tipo, out var funcion))
            {
                return funcion(cantidad == 1);
            }

            return string.Empty;
        }
    }
}
