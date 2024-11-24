using DevelopmentChallenge.Data.GeoShapeGenerator.Interfaces;

namespace DevelopmentChallenge.Data.GeoShapeGenerator.Abstract
{
    public abstract class TranslationStrategy
    {
        public abstract int Idioma { get; set; }
        protected TranslationStrategy() { }
        protected TranslationStrategy(int idioma) => Idioma = idioma;
        public abstract ITraducible GenerateDictionary();
    }
}