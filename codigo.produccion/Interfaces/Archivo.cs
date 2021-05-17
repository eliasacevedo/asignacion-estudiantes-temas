using System.Collections.Generic;

namespace codigo.produccion.Interfaces
{
    public interface IArchivo {
        string Leer(string ruta);
        List<string> Lineas {get;set;}
    }
}