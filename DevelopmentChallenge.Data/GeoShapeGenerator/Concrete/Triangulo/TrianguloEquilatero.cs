using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.GeoShapeGenerator.Enums;
using DevelopmentChallenge.Data.GeoShapeGenerator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.GeoShapeGenerator.Concrete.TrianguloEquilatero
{
    public class TrianguloEquilatero : ICalculable
    {
        public decimal Lado { get ; set ; }
        public Idiomas Idioma { get ; set; }

        public decimal CalcularArea()
        {
            return ((decimal)Math.Sqrt(3) / 4) * Lado * Lado;
        }

        public decimal CalcularPerimetro()
        {
            return Lado * 3;
        }

        public string TraducirForma(int tipo, int cantidad, int idioma)
        {
            throw new NotImplementedException();
        }

        public TrianguloEquilatero(FormaGeometrica f, Idiomas i)
        {
            Lado = f._lado;
            Idioma = i;
        }
    }
}


