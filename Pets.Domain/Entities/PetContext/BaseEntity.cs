using System;

namespace Pets.Domain.Etities.PetContext
{
    public abstract class BaseEntity
    {
        protected BaseEntity(string firstName, string lastName)
        {
            Id = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            CreateDate = DateTime.UtcNow;
        }

        public Guid Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public DateTime CreateDate { get; private set; }

    }

}