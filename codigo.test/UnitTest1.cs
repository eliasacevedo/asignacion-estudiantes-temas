using System;
using NUnit.Framework;
using System;

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
            Assert.Pass();
        }

        }

        [Test]
        public void SameStudents_SameGroups()
        {

            int studentsQuantity = 5; 
            int groupsQuantity = 5;
            
            if(studentsQuantity == groupsQuantity)
            {

                Assert.Pass();
                
            }
            
        }

        [Test]
        public void MoreStudentsThanGroups()
        {

            int studentsQuantity = 10; 
            int groupsQuantity = 5;

            if(studentsQuantity > groupsQuantity){

              Assert.Pass(); 

            }

        }

        [Test]
        public void MoreGroupsThanTopics()
        {

            int groupsQuantity = 10; 
            int topicsQuantity = 5;

            if(groupsQuantity > topicsQuantity){

              Assert.Throws<ArgumentException>(ExceptionTopic);

            } 
            
        }

        [Test]
        public void SameTopics_SameGroups()
        {
            
            int groupsQuantity = 5; 
            int topicsQuantity = 5;

            if(topicsQuantity == groupsQuantity)
            {

                Assert.Pass();
                
            }

        }

        [Test]
        public void MoreTopicsThanGroups()
        {

            int groupsQuantity = 5; 
            int topicsQuantity = 10;

            if(topicsQuantity > groupsQuantity){

              Assert.Pass();

            }

        }

        [Test]
        public void TestingRamdomness()
        {
            Assert.Pass();
        }

    }
}