using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.GeoShapeGenerator.Interfaces;

namespace DevelopmentChallenge.Data.GeoShapeGenerator.Abstract
{
    public abstract class CalculationStrategy
    {
        public abstract int Forma { get; set; }
        protected CalculationStrategy() { }
        protected CalculationStrategy(int forma) => Forma = forma;

        public abstract ICalculable GenerateShape(FormaGeometrica forma, Enums.Idiomas idioma); 
    }
}
