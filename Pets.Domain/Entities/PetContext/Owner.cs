namespace Pets.Domain.Etities.PetContext
{
    public class Owner : BaseEntity
    {
        protected Owner(string firstName, string lastName, string email, string documentNumber, int documentType)
        : base(firstName, lastName)
        {
            Email = email;
            DocumentNumber = documentNumber;
            DocumentType = documentType;
        }

        public string Email { get; private set; }
        public string DocumentNumber { get; private set; }
        public int DocumentType { get; private set; }

        public void SetEmail(string email)
        {
            Email = email;
        }
    }

}