using System.Collections.Generic;

namespace codigo.produccion.Interfaces
{
    public interface IEquipo {
        string Nombre { get; }
        List<string> Estudiantes { get; }
        void AgregarParticipante(string estudiante);
        List<string> Temas { get; set; }
    }
    
}