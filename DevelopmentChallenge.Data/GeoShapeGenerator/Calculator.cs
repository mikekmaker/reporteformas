using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.GeoShapeGenerator.Abstract;
using DevelopmentChallenge.Data.GeoShapeGenerator.Interfaces;
using System.Collections.Generic;

namespace DevelopmentChallenge.Data.GeoShapeGenerator
{
    public class Calculator
    {
        private readonly Dictionary<Enums.Formas, CalculationStrategy> _strategies;
        private Calculator()
        {
            _strategies = new Dictionary<Enums.Formas, CalculationStrategy>();

            foreach (Enums.Formas formas in System.Enum.GetValues(typeof(Enums.Formas)))
            {
                var strategyName = System.Enum.GetName(typeof(Enums.Formas), formas);
                var GeoFormRefType = System.Type.GetType($"DevelopmentChallenge.Data.GeoShapeGenerator.Concrete.{strategyName}.{strategyName}Strategy", true, true);
                var strategy = (CalculationStrategy)System.Activator.CreateInstance(GeoFormRefType);
                _strategies.Add(formas, strategy);
            }
        }
        public static Calculator InitializeStrategies() => new Calculator();
        public ICalculable GetShape(FormaGeometrica forma, Enums.Idiomas idioma) => _strategies[forma.Tipo].GenerateShape(forma, idioma);

    }
}