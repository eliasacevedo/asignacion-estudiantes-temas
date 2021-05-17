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
        private IUtilidad utilidad;
        public EquipoConstructor()
        {
            utilidad = new Utilidad();
            Equipos = new List<IEquipo>();
            Estudiantes = new List<string>();
            Temas = new List<string>();
        }

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
            if (Temas.Count < Equipos.Count) {
                throw new System.Exception("No pueden haber mas temas que equipos");
            }

            var indices = utilidad.AsignarAleatoriamente<string, IEquipo>(Temas, Equipos);
            
            for (int i = 0; i < indices.Count; i++)
            {
                Equipos[indices[i]].Temas.Add(Temas[i]);
            }
        }

        public void GenerarEquipos(int cantidadEquipos)
        {
            if (Estudiantes.Count < cantidadEquipos) {
                throw new System.Exception("No pueden haber menos estudiantes que equipos");
            }

            for (int i = 0; i < cantidadEquipos; i++)
            {
                Equipos.Add(new Equipo($"Equipo {i + 1}"));
            }

            var indices = utilidad.AsignarAleatoriamente<string, IEquipo>(Estudiantes, Equipos);
            
            for (int i = 0; i < indices.Count; i++)
            {
                Equipos[indices[i]].AgregarParticipante(Estudiantes[i]);
            }
        }
    }
}