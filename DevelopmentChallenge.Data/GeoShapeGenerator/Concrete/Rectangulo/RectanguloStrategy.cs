using DevelopmentChallenge.Data.GeoShapeGenerator.Abstract;
using DevelopmentChallenge.Data.GeoShapeGenerator.Interfaces;
using DevelopmentChallenge.Data.GeoShapeGenerator.Enums;
using DevelopmentChallenge.Data.Classes;

namespace DevelopmentChallenge.Data.GeoShapeGenerator.Concrete.Rectangulo
{
    public class RectanguloStrategy : CalculationStrategy
    {
        public override int Forma { get; set; }
        public string Descripcion { get; set; }

        public override ICalculable GenerateShape(FormaGeometrica forma, Idiomas idioma)
        {
            Descripcion = System.Enum.GetName(typeof(Formas), Formas.Rectangulo);
            Rectangulo formaGeometrica = new Rectangulo(forma, idioma);
            return formaGeometrica;
        }
    }
}
