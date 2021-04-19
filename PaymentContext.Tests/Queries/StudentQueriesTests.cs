using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.Queries;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests.Queries
{
    [TestClass]
    public class StudentQueriesTests
    {
        private IList<Student> _students;

        public StudentQueriesTests()
        {
            _students = new List<Student>();

            for (int i = 0; i <= 9; i++)
            {
                _students.Add(new Student(new Name("Anluno", i.ToString()),
                                new Document("1111111111" + i.ToString(), EDocumentType.CPF),
                                new Email(i.ToString() + "@gmail.com")));
            }
        }

        // red, green, refactory
        [TestMethod]
        public void ShouldReturnNullWhenDocumentNotExistis()
        {
            var exp = StudentQueries.GetStudentInfo("12345678909");
            var student = _students.AsQueryable().Where(exp).FirstOrDefault();

            Assert.AreEqual(null, student);
        }

        [TestMethod]
        public void ShouldReturnStudentWhenDocumentExistis()
        {
            var exp = StudentQueries.GetStudentInfo("11111111111");
            var student = _students.AsQueryable().Where(exp).FirstOrDefault();

            Assert.AreNotEqual(null, student);
        }
    }
}