using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.GeoShapeGenerator.Enums;
using DevelopmentChallenge.Data.GeoShapeGenerator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.GeoShapeGenerator.Concrete.Cuadrado
{
    public class Cuadrado : ICalculable
    {
        public decimal Lado { get ; set ; }
        public Idiomas Idioma { get; set; }

        public decimal CalcularArea()
        {
            return Lado * Lado;
        }

        public decimal CalcularPerimetro()
        {
            return Lado * 4;
        }

        public string TraducirForma(int tipo, int cantidad, int idioma)
        {
            throw new NotImplementedException();
        }

        public Cuadrado(FormaGeometrica forma, Idiomas idioma)
        {
            Lado = forma._lado;
            Idioma = idioma;
        }
    }
}


