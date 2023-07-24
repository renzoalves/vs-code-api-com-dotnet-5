using Pets.Domain.ValueObjects;
using Pets.Domain.Validations;

namespace Pets.Domain.Etities.PetContext
{
    public class Pet : BaseEntity
    {
        protected Pet(Name name, int identifier)
        : base(name)
        {
            Identifier = identifier;
        }

        public string Email { get; private set; }
        public string DocumentNumber { get; private set; }
        public int Identifier { get; private set; }

        public void SetEmail(int identifier)
        {
            Identifier = identifier;
        }

        public override bool Validation()
        {
            if (NameValidations.IsValidName(this.Name))
                return false;

            return true;
        }
    }
}