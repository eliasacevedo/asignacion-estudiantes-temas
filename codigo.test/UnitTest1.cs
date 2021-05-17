using System;
using NUnit.Framework;

namespace codigo.test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
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
        }

        [Test]
        public void SameStudents_SameGroups()
        {
            Assert.Pass();
        }

        [Test]
        public void MoreStudentsThanGroups()
        {
            Assert.Pass();
        }

        [Test]
        public void MoreGroupsThanTopics()
        {
            Assert.Pass();
        }

        [Test]
        public void SameTopics_SameGroups()
        {
            Assert.Pass();
        }

        [Test]
        public void MoreTopicsThanGroups()
        {
            Assert.Pass();
        }

        [Test]
        public void TestingRamdomness()
        {
            Assert.Pass();
        }
        
    }
}