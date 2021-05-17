using System.Collections.Generic;
using codigo.produccion.Archivos;
using codigo.produccion.Interfaces;

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
            throw new System.NotImplementedException();
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