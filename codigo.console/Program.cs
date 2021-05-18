using System;
using codigo.produccion.Equipo;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Data;
using System.Linq;
using GemBox.Spreadsheet;
using System.Collections.Generic;

namespace codigo.console
{
    class Program
    {
        static void Main(string[] args)
        {
        
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");
            
            if (args.Length == 3)
            {   
                string students_path = args[0];
                string topics_path = args[1];
                bool success = Int32.TryParse(args[2], out int teams_quantity);
                
                if(success)
                {
                    Console.WriteLine($"{students_path} {topics_path} {teams_quantity}");
                    var s = new EquipoConstructor();
                    s.ObtenerEstudiantes(students_path);
                    s.ObtenerTemas(topics_path);
                    s.GenerarEquipos(teams_quantity);
                    s.AsignarTemas();
                    string json = JsonConvert.SerializeObject(s.Equipos, Formatting.Indented);
                    Console.WriteLine(json);
                    
                }
                else
                {
                    usage();
                }
            }
            else if (args.Length < 3)
            {
                usage();
            }
            
            else if (args.Length > 3)
            {
                usage();
            }
        }
        
        static void usage()
        {
            Console.WriteLine("Uso: ./program.exe /ruta/del/archivo/de/estudiantes /ruta/archivo/de/temas cantidad de equipoos que quieres generar");
            Environment.Exit(1);
        }
    }
}
