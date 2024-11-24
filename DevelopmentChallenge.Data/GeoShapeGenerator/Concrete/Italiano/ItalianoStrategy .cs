using DevelopmentChallenge.Data.GeoShapeGenerator.Abstract;
using DevelopmentChallenge.Data.GeoShapeGenerator.Interfaces;

namespace DevelopmentChallenge.Data.GeoShapeGenerator.Concrete.Italiano
{
    public class ItalianoStrategy : TranslationStrategy
    {
        public override int Idioma { get; set; }
        public override ITraducible GenerateDictionary()
        {
            Italiano diccionario = new Italiano(Enums.Idiomas.Italiano);
            return diccionario;
        }
    }
}
