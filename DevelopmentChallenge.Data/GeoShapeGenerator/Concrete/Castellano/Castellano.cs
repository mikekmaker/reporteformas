using DevelopmentChallenge.Data.GeoShapeGenerator.Enums;
using DevelopmentChallenge.Data.GeoShapeGenerator.Interfaces;
using System;

namespace DevelopmentChallenge.Data.GeoShapeGenerator.Concrete.Castellano
{
    public class Castellano : ITraducible
    {
        public Idiomas Idioma { get; set; }
       

        public Castellano(Idiomas i)
        {
            Idioma = i;
        }

        string ITraducible.ListaVacia()
        {
            return "<h1>Lista vacía de formas!</h1>";
        }

        string ITraducible.EncabezadoReporte()
        {
            return "<h1>Reporte de Formas</h1>";
        }

        string ITraducible.Area()
        {
            return "Area";
        }

        string ITraducible.Perimetro()
        {
            return "Perimetro";
        }

        string ITraducible.Cuadrado(bool singular)
        {
            return singular ? "Cuadrado" : "Cuadrados";
        }

        string ITraducible.Circulo(bool singular)
        {
            return singular ? "Círculo" : "Círculos";
        }

        string ITraducible.TrianguloEquilatero(bool singular)
        {
            return singular ? "Triángulo" : "Triángulos";
        }

        string ITraducible.Formas()
        {
            return "formas";
        }

        string ITraducible.Rectangulo(bool singular)
        {
            return singular ? "Rectangulo" : "Rectangulos";
        }

        string ITraducible.Trapecio(bool singular)
        {
            return singular ? "Trapecio" : "Trapecios";
        }
    }  
}


