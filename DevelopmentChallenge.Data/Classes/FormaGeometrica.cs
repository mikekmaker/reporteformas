/******************************************************************************************************************/
/******* ¿Qué pasa si debemos soportar un nuevo idioma para los reportes, o agregar más formas geométricas? *******/
/******************************************************************************************************************/

/*
 * TODO: 
 * Refactorizar la clase para respetar principios de la programación orientada a objetos.
 * Implementar la forma Trapecio/Rectangulo. 
 * Agregar el idioma Italiano (o el deseado) al reporte.
 * Se agradece la inclusión de nuevos tests unitarios para validar el comportamiento de la nueva funcionalidad agregada (los tests deben pasar correctamente al entregar la solución, incluso los actuales.)
 * Una vez finalizado, hay que subir el código a un repo GIT y ofrecernos la URL para que podamos utilizar la nueva versión :).
 */

using DevelopmentChallenge.Data.GeoShapeGenerator.Enums;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevelopmentChallenge.Data.Classes
{
    public class FormaGeometrica
    {
        public Formas Tipo { get; set; }
        internal readonly decimal _lado;
        internal readonly decimal? _altura;
        internal readonly decimal? _lado2;
        internal readonly decimal? _baseMayor;
        internal readonly decimal? _baseMenor;
        public FormaGeometrica(Formas tipo, decimal ancho, decimal? altura = null, decimal? lado2 = null, decimal? baseMayor = null, decimal? baseMenor = null)
        {
            Tipo = tipo;
            _lado = ancho;
            _altura = altura;
            _lado2 = lado2;
            _baseMayor = baseMayor;
            _baseMenor = baseMenor;
        }

        public static string Imprimir(List<FormaGeometrica> formas, Idiomas idioma)
        {
            var sb = new StringBuilder();
            
            ReporteBase reporte = new ReporteBase(idioma, formas);
            
            if (!formas.Any())
            {
                sb.Append(reporte.CurrentLanguage.ListaVacia());
            }
            else
            {
                sb = reporte.Header(sb);
                sb = reporte.Body(sb);
                sb = reporte.Footer(sb); //agrego comentario
            }

            return sb.ToString();
        }
    }
}
