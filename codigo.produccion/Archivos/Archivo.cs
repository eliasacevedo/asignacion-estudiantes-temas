using System.Collections.Generic;
using codigo.produccion.Interfaces;
namespace codigo.produccion.Archivos
{
    public class Archivo : IArchivo
    {
        public List<string> Lineas { get; set; }
        public string Leer(string ruta)
        {
            string line;  
            System.IO.StreamReader file = new System.IO.StreamReader(ruta);  
            while((line = file.ReadLine()) != null)  
            {  
                Lineas.Add(line);
            }  
            
            file.Close();  
            return "";
        }
    }
}