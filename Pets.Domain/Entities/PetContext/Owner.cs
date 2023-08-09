using Pets.Domain.ValueObjects;
using Pets.Domain.Validations;
using Pets.Domain.Validations.Interfaces;

namespace Pets.Domain.Etities.PetContext
{
    public class Owner : BaseEntity, IContract
    {
        public Owner(Name name, string email, Document document)
        : base(name)
        {
            Email = email;
            Document = document;
        }

        public string Email { get; private set; }
        public Document Document { get; private set; }

        public void SetEmail(string email)
        {
            Email = email;
        }

        public override bool Validation()
        {
            var contracts = new ContractValidations<Owner>()
            .FirstNameIsOk(this.Name, 20, 5, "O primeiro nome deve ter entre 5 e 20 caracteres", "FirstName")
            .LastNameIsOk(this.Name, 20, 5, "O primeiro nome deve ter entre 5 e 20 caracteres", "LastName")
            .EmailIsValid(this.Email, "O e-mail não é válido", "Email")
            .DocumentIsValid(this.Document, "O documento não é válido", "Document");

            return contracts.IsValid();
        }
    }
}