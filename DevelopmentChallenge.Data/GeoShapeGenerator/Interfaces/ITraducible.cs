
namespace DevelopmentChallenge.Data.GeoShapeGenerator.Interfaces
{
    public interface ITraducible
    {
        Enums.Idiomas Idioma { get; set; }

        string ListaVacia();

        string EncabezadoReporte();

        string Area();

        string Perimetro();

        string Cuadrado(bool singular);

        string Circulo(bool singular);

        string TrianguloEquilatero(bool singular);

        string Formas();

        string Rectangulo(bool singular);

        string Trapecio(bool singular);
    }
}
