using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.GeoShapeGenerator.Enums;
using DevelopmentChallenge.Data.GeoShapeGenerator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.GeoShapeGenerator.Concrete.Circulo
{
    public class Circulo : ICalculable
    {
        public decimal Lado { get ; set ; }
        public Idiomas Idioma { get; set; }

        public decimal CalcularArea()
        {
            return (decimal)Math.PI * (Lado / 2) * (Lado / 2);
        }

        public decimal CalcularPerimetro()
        {
            return (decimal)Math.PI * Lado;
        }

        public string TraducirForma(int tipo, int cantidad, int idioma)
        {
            throw new NotImplementedException();
        }

        public Circulo(FormaGeometrica forma, Enums.Idiomas idioma)
        {
            Lado = forma._lado;
            Idioma = idioma;
        }
    }
}


