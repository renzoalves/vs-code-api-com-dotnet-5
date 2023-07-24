using Pets.Domain.ValueObjects;

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
    }
}