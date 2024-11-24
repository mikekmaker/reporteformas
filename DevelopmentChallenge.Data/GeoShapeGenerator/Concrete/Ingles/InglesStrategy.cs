using DevelopmentChallenge.Data.GeoShapeGenerator.Abstract;
using DevelopmentChallenge.Data.GeoShapeGenerator.Interfaces;

namespace DevelopmentChallenge.Data.GeoShapeGenerator.Concrete.Ingles
{
    public class InglesStrategy : TranslationStrategy
    {
        public override int Idioma { get; set; }
        public override ITraducible GenerateDictionary()
        {
            Ingles diccionario = new Ingles(Enums.Idiomas.Castellano);
            return diccionario;
        }
    }
}
