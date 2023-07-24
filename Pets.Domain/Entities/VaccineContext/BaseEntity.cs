using System;

namespace Pets.Domain.Etities.VaccineContext
{
    public abstract class BaseEntity
    {
        protected BaseEntity()
        {
            Id = Guid.NewGuid();
            CreateDate = DateTime.UtcNow;
        }

        public Guid Id { get; private set; }
        public DateTime CreateDate { get; private set; }

    }

}