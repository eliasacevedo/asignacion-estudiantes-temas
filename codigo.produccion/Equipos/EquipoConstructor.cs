using System.Collections.Generic;
using codigo.produccion.Archivos;
using codigo.produccion.Interfaces;
using codigo.produccion.Utilidades;

namespace codigo.produccion.Equipo
{
    public class EquipoConstructor : IEquipoConstructor
    {
        public List<string> Estudiantes { get ; set ; }
        public List<string> Temas { get ; set; }
        public List<IEquipo> Equipos { get; set; }

        public void ObtenerTemas(string rutaArchivoTemas)
        {
            var archivo = new Archivo();
            archivo.Leer(rutaArchivoTemas);
            Temas.AddRange(archivo.Lineas);
        }

        public void ObtenerEstudiantes(string rutaArchivoEstudiantes)
        {
            var archivo = new Archivo();
            archivo.Leer(rutaArchivoEstudiantes);
            Estudiantes.AddRange(archivo.Lineas);
        }

        public void AsignarTemas()
        {                                                       
            if (Temas.Count > Equipos.Count) {
                throw new System.Exception("No pueden haber mas temas que equipos");
            }

            var a = new Utilidad();
            var indices = a.AsignarAleatoriamente<string, IEquipo>(Temas, Equipos);
            
        }

        public void GenerarEquipos(int cantidadEquipos)
        {
            if (Estudiantes.Count < cantidadEquipos) {
                throw new System.Exception("No pueden haber menos estudiantes que equipos");
            }

            
        }

        private void GenerarEquiposBase(int cantidadEquipos) {

        }
    }
}