using Pets.Domain.ValueObjects;

namespace Pets.Domain.Etities.PetContext
{
    public class Owner : BaseEntity
    {
        protected Owner(Name name, string email, Document document)
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
    }
}