using System.Collections.Generic;
using codigo.produccion.Interfaces;

namespace codigo.produccion.Equipo
{
    public class Equipo : IEquipo
    {
        public Equipo(string Nombre)
        {
            this.Nombre = Nombre;
            Estudiantes = new List<string>();
        }
        public string Nombre { get; }
        public List<string> Estudiantes { get; }
        public List<string> Temas { get; set; }

        public void AgregarParticipante(string estudiante)
        {
            Estudiantes.Add(estudiante);
            Temas = new List<string>();
        }

    }
}