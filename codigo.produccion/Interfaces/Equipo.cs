using System.Collections.Generic;

namespace codigo.produccion.Interfaces
{
    public interface Equipo {
        int Id { get; set; }
        List<string> Estudiantes { get; set; }
        void Crear(string Nombre);
        void AgregarParticipante(string estudiante);
        string Tema { get; set; }
    }
    
}