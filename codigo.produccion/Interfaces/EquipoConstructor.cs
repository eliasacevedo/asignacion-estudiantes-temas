using System.Collections.Generic;

namespace codigo.produccion.Interfaces
{
    public interface EquipoConstructor{
        List<string> Estudiantes{get;set;}
        List<string> Temas {get;set;}
        List<Equipo> Equipos {get;set;}

        void GenerarEquipos(uint cantidadEquipos, string rutaArchivoEstudiantes);
        void AsignarTemasEquipos(string rutaArchivoTemas, List<Equipo> Equipos);
    }
}