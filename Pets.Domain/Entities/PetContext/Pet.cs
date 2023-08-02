using Pets.Domain.ValueObjects;
using Pets.Domain.Validations;
using Pets.Domain.Validations.Interfaces;

namespace Pets.Domain.Etities.PetContext
{
    public class Pet : BaseEntity, IContract
    {
        protected Pet(Name name, int identifier)
        : base(name)
        {
            Identifier = identifier;
        }

        public string DocumentNumber { get; private set; }
        public int Identifier { get; private set; }

        public void SetEmail(int identifier)
        {
            Identifier = identifier;
        }

        public override bool Validation()
        {
            var contracts = new ContractValidations<Pet>()
            .FirstNameIsOk(this.Name, 20, 5, "O primeiro nome deve ter entre 5 e 20 caracteres", "FirstName")
            .LastNameIsOk(this.Name, 20, 5, "O primeiro nome deve ter entre 5 e 20 caracteres", "LastName");

            return contracts.IsValid();
        }
    }
}