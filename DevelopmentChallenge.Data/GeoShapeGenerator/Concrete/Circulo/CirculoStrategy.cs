using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.GeoShapeGenerator.Abstract;
using DevelopmentChallenge.Data.GeoShapeGenerator.Interfaces;

namespace DevelopmentChallenge.Data.GeoShapeGenerator.Concrete.Circulo
{
    public class CirculoStrategy : CalculationStrategy
    {
        public override int Forma { get; set; }
        public string Descripcion { get; set; }

        public override ICalculable GenerateShape(FormaGeometrica forma, Enums.Idiomas idioma)
        {
            Descripcion = System.Enum.GetName(typeof(Enums.Formas), Enums.Formas.Circulo);
            Circulo formaGeometrica = new Circulo(forma,idioma);
            return formaGeometrica;
        }
    }
}
