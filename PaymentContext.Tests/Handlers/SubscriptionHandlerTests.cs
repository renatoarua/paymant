using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Commands;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.Handlers;
using PaymentContext.Tests.Moks;

namespace PaymentContext.Tests.Handlers
{
    [TestClass]
    public class SubscriptionHandlerTests
    {
        // red, green, refactory
        [TestMethod]
        public void ShouldReturnErrorWhenDocumentExists()
        {
            var handler = new SubscriptionHandler(new FakeStudentRepository(), new FakeEmailService());
            var command = new CreateBoletoSubscriptionCommand
            {
                FirstName = "Renato",
                LastName = "Miranda",
                Document = "99999999999",
                Email = "re@gmail.com",
                BarCode = "23423423423",
                BoletoNumber = "24323423",
                PaymentNumber = "23464",
                PaidDate = DateTime.Now,
                ExpireDate = DateTime.Now.AddMonths(1),
                Total = 60,
                TotalPaid = 60,
                Payer = "Mountain WEB",
                PayerDocument = "12345678909",
                PayerDocumentType = EDocumentType.CPF,
                PayerEmail = "mountain@gmail.com",
                Street = "Av Marachal",
                Number = "234",
                Neighborhood = "ttt",
                City = "Curitiba",
                State = "PR",
                Country = "BR",
                ZipCode = "83948473",
            };

            handler.Handle(command);
            Assert.AreEqual(false, handler.Valid);
        }
    }
}