using DevelopmentChallenge.Data.GeoShapeGenerator.Enums;
using DevelopmentChallenge.Data.GeoShapeGenerator.Interfaces;
using System;

namespace DevelopmentChallenge.Data.GeoShapeGenerator.Concrete.Ingles
{
    public class Ingles : ITraducible
    {
        public Idiomas Idioma { get; set; }
       

        public Ingles(Idiomas i)
        {
            Idioma = i;
        }

        string ITraducible.ListaVacia()
        {
            return "<h1>Empty list of shapes!</h1>";
        }

        string ITraducible.EncabezadoReporte()
        {
            return "<h1>Shapes report</h1>"; 
        }

        string ITraducible.Cuadrado(bool singular)
        {
            return singular ? "Square" : "Squares";
        }

        string ITraducible.Area()
        {
            return "Area";
        }

        string ITraducible.Perimetro()
        {
            return "Perimeter";
        }

        string ITraducible.Circulo(bool singular)
        {
            return singular ? "Circle" : "Circles";
        }

        string ITraducible.TrianguloEquilatero(bool singular)
        {
           return singular ? "Triangle" : "Triangles";
        }

        string ITraducible.Formas()
        {
            return "shapes";
        }

        public string Rectangulo(bool singular)
        {
            return singular ? "Rectangle" : "Rectangles";
        }

        string ITraducible.Trapecio(bool singular)
        {
            return singular ? "Trapezoid" : "Trapezoids";
        }

    }
}


