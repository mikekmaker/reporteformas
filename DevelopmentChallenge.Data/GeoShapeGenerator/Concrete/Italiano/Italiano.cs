using DevelopmentChallenge.Data.GeoShapeGenerator.Enums;
using DevelopmentChallenge.Data.GeoShapeGenerator.Interfaces;
using System;

namespace DevelopmentChallenge.Data.GeoShapeGenerator.Concrete.Italiano
{
    public class Italiano : ITraducible
    {
        public Idiomas Idioma { get; set; }
       

        public Italiano(Idiomas i)
        {
            Idioma = i;
        }

        string ITraducible.ListaVacia()
        {
            return "<h1>Elenco vuoto di forme!</h1>";
        }

        string ITraducible.EncabezadoReporte()
        {
            return "<h1>Rapporto sulle forme</h1>";
        }

        string ITraducible.Cuadrado(bool singular)
        {
            return singular ? "Quadrato" : "Quadrati";
        }

        string ITraducible.Area()
        {
            return "Area";
        }

        string ITraducible.Perimetro()
        {
            return "Perimetro";
        }

        string ITraducible.Circulo(bool singular)
        {
            return singular ? "Cerchio" : "Cerchi";
        }

        string ITraducible.TrianguloEquilatero(bool singular)
        {
            return singular ? "Triangolo equilatero" : "Triangoli equilateri";
        }

        string ITraducible.Formas()
        {
            return "forme";
        }

        string ITraducible.Rectangulo(bool singular)
        {
            return singular ? "Rettangolo" : "Rettangoli";
        }

        string ITraducible.Trapecio(bool singular)
        {
            return singular ? "Trapezio" : "Trapezi";
        }
    }
}


