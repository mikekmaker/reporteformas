using System.Collections.Generic;

namespace DevelopmentChallenge.Data.GeoShapeGenerator.Interfaces
{
    public interface ICalculable
    {
        decimal CalcularArea();
        decimal CalcularPerimetro();
        string TraducirForma(int tipo, int cantidad, int idioma);
        decimal Lado { get; set; }
        Enums.Idiomas Idioma { get; set; }
    }
}
