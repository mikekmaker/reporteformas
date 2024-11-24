using DevelopmentChallenge.Data.GeoShapeGenerator.Abstract;
using DevelopmentChallenge.Data.GeoShapeGenerator.Interfaces;

namespace DevelopmentChallenge.Data.GeoShapeGenerator.Concrete.Castellano
{
    public class CastellanoStrategy : TranslationStrategy
    {
        public override int Idioma { get; set; }
        public override ITraducible GenerateDictionary()
        {
            Castellano diccionario = new Castellano(Enums.Idiomas.Castellano);
            return diccionario;
        }
    }
}
