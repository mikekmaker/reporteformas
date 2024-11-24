using DevelopmentChallenge.Data.GeoShapeGenerator.Abstract;
using DevelopmentChallenge.Data.GeoShapeGenerator.Interfaces;
using DevelopmentChallenge.Data.GeoShapeGenerator.Enums;
using DevelopmentChallenge.Data.Classes;

namespace DevelopmentChallenge.Data.GeoShapeGenerator.Concrete.Trapecio
{
    public class TrapecioStrategy : CalculationStrategy
    {
        public override int Forma { get; set; }
        public string Descripcion { get; set; }

        public override ICalculable GenerateShape(FormaGeometrica forma, Idiomas idioma)
        {
            Descripcion = System.Enum.GetName(typeof(Formas), Formas.Trapecio);
            Trapecio formaGeometrica = new Trapecio(forma, idioma);
            return formaGeometrica;
        }
    }
}
