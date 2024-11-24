using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.GeoShapeGenerator.Enums;
using DevelopmentChallenge.Data.GeoShapeGenerator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.GeoShapeGenerator.Concrete.Trapecio
{
    public class Trapecio : ICalculable
    {
        public decimal Lado { get ; set ; }
        public decimal Lado2 { get; set; }
        public decimal BaseMayor { get; set; }
        public decimal BaseMenor { get; set; }
        public decimal Altura { get; set; }
        public Idiomas Idioma { get ; set; }

        public decimal CalcularArea()
        {
            return (BaseMayor + BaseMenor)  * Altura * 1/2;
        }

        public decimal CalcularPerimetro()
        {
            return Lado + Lado2 + BaseMenor + BaseMayor;
        }

        public string TraducirForma(int tipo, int cantidad, int idioma)
        {
            throw new NotImplementedException();
        }

        public Trapecio(FormaGeometrica f, Idiomas i)
        {
            Lado = f._lado;
            Lado2 = f._lado2?? 0;
            Altura = f._altura?? 0;
            BaseMenor = f._baseMenor ?? 0;
            BaseMayor = f._baseMayor ?? 0;
            Idioma = i;
        }
    }
}


