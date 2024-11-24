using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.GeoShapeGenerator.Enums;
using DevelopmentChallenge.Data.GeoShapeGenerator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.GeoShapeGenerator.Concrete.Rectangulo
{
    public class Rectangulo : ICalculable
    {
        public decimal Lado { get ; set ; }
        public decimal Altura { get; set; }
        public Idiomas Idioma { get ; set; }

        public decimal CalcularArea()
        {
            return Lado * Altura;
        }

        public decimal CalcularPerimetro()
        {
            return 2 * (Lado + Altura);
        }

        public string TraducirForma(int tipo, int cantidad, int idioma)
        {
            throw new NotImplementedException();
        }

        public Rectangulo(FormaGeometrica f, Idiomas i)
        {
            Lado = f._lado;
            Altura = f._altura?? 0;
            Idioma = i;
        }
    }
}


