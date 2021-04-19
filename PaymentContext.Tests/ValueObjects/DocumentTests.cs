using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests.valueObjects
{
    [TestClass]
    public class DocumentTests
    {
        // red, green, refactory
        [TestMethod]
        public void ShouldReturnErrorWhenCNPJIsInvalid()
        {
            var doc = new Document("123", EDocumentType.CNJP);
            Assert.IsTrue(doc.Invalid);
        }

        [TestMethod]
        public void ShouldReturnSuccessWhenCNPJIsValid()
        {
            var doc = new Document("98767898767898", EDocumentType.CNJP);
            Assert.IsTrue(doc.Valid);
        }

        [TestMethod]
        public void ShouldReturnErrorWhenCPFIsInvalid()
        {
            var doc = new Document("123", EDocumentType.CPF);
            Assert.IsTrue(doc.Invalid);
        }

        [TestMethod]
        public void ShouldReturnSuccessWhenCPFIsValid()
        {
            var doc = new Document("09384758693", EDocumentType.CPF);
            Assert.IsTrue(doc.Valid);
        }
    }
}