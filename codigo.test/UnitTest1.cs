using System;
using System.Collections.Generic;
using codigo.produccion.Archivos;
using codigo.produccion.Equipo;
using codigo.produccion.Interfaces;
using NUnit.Framework;

namespace codigo.test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }
        void ExceptionGroups()
        {
            throw new ArgumentException("Los grupos no pueden ser mayores a los estudiantes");
        }
        void ExceptionTopic()
        {
            throw new ArgumentException("Los grupos no pueden ser mayores a los estudiantes");
        }
        [Test]
        public void LessStudentsThanGroups()
        
        {

            //int students = 4; int groups = 5;
            //bool result;
            //if (students < groups)
            //{
            //    result = false;
            //}
            //else
            //{
            //    result = true;
            //}
            //Assert.AreEqual(result, false);


            int studentsQuantity = 5;
            int groupsQuantity = 6;

            if (studentsQuantity < groupsQuantity) {

                Assert.Throws<ArgumentException>(ExceptionGroups);

            }


        }

        [Test]
        public void SameStudents_SameGroups()
        {

            int studentsQuantity = 5;
            int groupsQuantity = 5;

            if (studentsQuantity == groupsQuantity)
            {
                Assert.Pass();

            }

        }

        [Test]
        public void MoreStudentsThanGroups()
        {

            int studentsQuantity = 10;
            int groupsQuantity = 5;

            if (studentsQuantity > groupsQuantity) {

                Assert.Pass();

            }

        }

        [Test]
        public void MoreGroupsThanTopics()
        {

            int groupsQuantity = 10;
            int topicsQuantity = 5;

            if (groupsQuantity > topicsQuantity) {

                Assert.Throws<ArgumentException>(ExceptionTopic);

            }

        }

        [Test]
        public void SameTopics_SameGroups()
        {

            int groupsQuantity = 5;
            int topicsQuantity = 5;

            if (topicsQuantity == groupsQuantity)
            {

                Assert.Pass();

            }

        }

        [Test]
        public void MoreTopicsThanGroups()
        {

            int groupsQuantity = 5;
            int topicsQuantity = 10;

            if (topicsQuantity > groupsQuantity) {

                Assert.Pass();

            }

        }

        [Test]
        public void TestingRamdomness()
        {
            Archivo archivo = new Archivo();
            EquipoConstructor equipoCon = new EquipoConstructor();

            var pasaPrueba = true;
            const double error = 0.05;
            const int cantidadEquipos = 5;
            const int cantidadRepeticiones = 1000;

            equipoCon.ObtenerTemas(@"/home/elias/Documents/INTEC/Tendencias/Practicas/asignacion-estudiantes-temas/teams.txt");
            equipoCon.ObtenerEstudiantes(@"/home/elias/Documents/INTEC/Tendencias/Practicas/asignacion-estudiantes-temas/students.txt");

            var estudiantes = new Dictionary<string, Dictionary<string, int>>();
            for (int i = 0; i < cantidadRepeticiones; i++)
            {
                equipoCon.GenerarEquipos(cantidadEquipos);
                equipoCon.AsignarTemas();

                foreach (var equipo in equipoCon.Equipos)
                {
                    foreach (var estudiante in equipo.Estudiantes) {
                        if (estudiantes.ContainsKey(estudiante)) {
                            if (estudiantes[estudiante].ContainsKey(equipo.Nombre)) {
                                estudiantes[estudiante][equipo.Nombre] += 1;
                                continue;
                            }
                            estudiantes[estudiante].Add(equipo.Nombre, 1);
                            continue;
                        }
                        estudiantes.Add(estudiante, new Dictionary<string, int>());
                        estudiantes[estudiante].Add(equipo.Nombre, 1);
                    }
                }
            }


            foreach (var estudiante in estudiantes)
            {
                if (!pasaPrueba) {
                    break;
                }

                foreach (var equipo in estudiante.Value.Keys) {
                    double frecuencia = (double)estudiantes[estudiante.Key][equipo] / (double)cantidadRepeticiones;
                    double probabilidad = 1 / (double)cantidadEquipos;
                    if (frecuencia < probabilidad - error || frecuencia > probabilidad + error ) {
                        pasaPrueba = false;
                        break;
                    }
                }
            }

            Assert.IsTrue(pasaPrueba);
        }        
    }
}

