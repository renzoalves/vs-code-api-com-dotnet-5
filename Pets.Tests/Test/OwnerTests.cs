using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pets.Domain.Etities.PetContext;
using Pets.Domain.ValueObjects;
using Pets.Domain.Enums;

namespace Pets.Tests.Tests
{
    [TestClass]
    public class OwnerTests
    {
        [TestMethod]
        public void Dado_um_nome_invalido_deve_passar()
        {
            var owner = new Owner(
                name: new Name("Bru", "Wayne"),
                email: "bruce.wayne@hotmail.com",
                document: new Document("79720836067", EDocumentType.CPF)
                );

            Assert.AreEqual(false, owner.Validation());
        }

        [TestMethod]
        public void Dado_um_email_invalido_deve_passar()
        {
            var owner = new Owner(
                name: new Name("Bru", "Wayne"),
                email: "bruce.waynehotmail.com",
                document: new Document("79720836067", EDocumentType.CPF)
                );

            Assert.AreEqual(false, owner.Validation());
        }
        
        [TestMethod]
        public void Dado_um_documento_invalido_deve_passar()
        {
            var owner = new Owner(
                name: new Name("Bru", "Wayne"),
                email: "bruce.wayne@hotmail.com",
                document: new Document("797208360", EDocumentType.CPF)
                );

            Assert.AreEqual(false, owner.Validation());
        }
        
    }
}