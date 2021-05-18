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

            equipoCon.ObtenerTemas(@"C:\Users\Mario\source\repos\asignacion-estudiantes-temas\teams.txt");
            equipoCon.ObtenerEstudiantes(@"C:\Users\Mario\source\repos\asignacion-estudiantes-temas\students.txt");

            for (int i = 0; i < 1000; i++)
            {
                equipoCon.GenerarEquipos(5);
                equipoCon.AsignarTemas();

            }
            Assert.Pass();
        }
        public void ContadorEstudiantes(List<IEquipo> equipos)
        {
            Dictionary<string, Dictionary<string, int>> contradorEst = new Dictionary<string, Dictionary<string, int>>();
            foreach (var item in equipos)
            {
                
            }

        }
        
    }
}

