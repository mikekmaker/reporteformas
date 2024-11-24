using DevelopmentChallenge.Data.GeoShapeGenerator.Abstract;
using DevelopmentChallenge.Data.GeoShapeGenerator.Interfaces;
using System.Collections.Generic;

namespace DevelopmentChallenge.Data.GeoShapeGenerator
{
    public class Translator
    {
        private readonly Dictionary<Enums.Idiomas, TranslationStrategy> _strategies;
        private Translator()
        {
            _strategies = new Dictionary<Enums.Idiomas, TranslationStrategy>();

            foreach (Enums.Idiomas idiomas in System.Enum.GetValues(typeof(Enums.Idiomas)))
            {
                var strategyName = System.Enum.GetName(typeof(Enums.Idiomas), idiomas);
                var TranslatorRefType = System.Type.GetType($"DevelopmentChallenge.Data.GeoShapeGenerator.Concrete.{strategyName}.{strategyName}Strategy", true, true);
                var strategy = (TranslationStrategy)System.Activator.CreateInstance(TranslatorRefType);
                _strategies.Add(idiomas, strategy);
            }
        }
        public static Translator InitializeStrategies() => new Translator();
        public ITraducible GetLanguage(Enums.Idiomas idioma) => _strategies[idioma].GenerateDictionary();

    }
}