using System;
using Pets.Domain.ValueObjects;

namespace Pets.Domain.Etities.PetContext
{
    public abstract class BaseEntity
    {
        protected BaseEntity(Name name)
        {
            Id = Guid.NewGuid();
            CreateDate = DateTime.UtcNow;
            Name = name;
        }

        public Guid Id { get; private set; }
        public Name Name { get; private set; }
        public DateTime CreateDate { get; private set; }
    }

}