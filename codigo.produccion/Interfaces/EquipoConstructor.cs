using System.Collections.Generic;

namespace codigo.produccion.Interfaces
{
    public interface IEquipoConstructor{
        List<string> Estudiantes{get;set;}
        List<string> Temas {get;set;}
        List<IEquipo> Equipos {get;set;}

        void ObtenerEstudiantes(string rutaArchivoEstudiantes);
        void ObtenerTemas(string rutaArchivoTemas);
        void GenerarEquipos(int cantidadEquipos);
        void AsignarTemas();
        
    }
}