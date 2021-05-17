using System;
using System.Collections.Generic;
using codigo.produccion.Equipo;

namespace codigo.console
{
    class Program
    {
        static void Main(string[] args)
        {
            var ec = new EquipoConstructor();
            ec.Temas = new List<string>() {
                "A", "B", "C", "D", "E", "F", "G", "H", "I","J","K","L","M"
            };
            ec.Estudiantes = new List<string>() {
                "E1", "E2", "E3", "E4", "E5", "E6", "E7", "E8", "E9",
                "E10", "E20", "E30", "E40", "E50", "E60", "E70", "E80", "E90",
                "E110", "E210", "E130", "E140", "E510", "E601", "E710", "E810", "E901"
            };

            ec.GenerarEquipos(9);
            ec.AsignarTemas();
            
            Console.Write(ec.Equipos);
        }
    }
}
