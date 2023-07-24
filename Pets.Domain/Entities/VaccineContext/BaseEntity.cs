using System;

namespace Pets.Domain.Etities.VaccineContext
{
    public abstract class BaseEntity
    {
        protected BaseEntity(string description)
        {
            Id = Guid.NewGuid();
            CreateDate = DateTime.UtcNow;
            Description = description;
        }

        public Guid Id { get; private set; }
        public DateTime CreateDate { get; private set; }
        public string Description { get; private set; }

        public virtual void SetDescription(string description){
            Description = description;
        }

    }

}