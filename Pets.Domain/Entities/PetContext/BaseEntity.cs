using System;
using System.Collections.Generic;
using Pets.Domain.ValueObjects;
using Pets.Domain.Validations.Iterfaces;
using Pets.Domain.Notifications;

namespace Pets.Domain.Etities.PetContext
{
    public abstract class BaseEntity : IValidations
    {
        protected BaseEntity(Name name)
        {
            Id = Guid.NewGuid();
            CreateDate = DateTime.UtcNow;
            Name = name;
        }

        private List<Notification> _notifications;
        public Guid Id { get; private set; }
        public Name Name { get; private set; }
        public DateTime CreateDate { get; private set; }
        public IReadOnlyCollection<Notification> Notifications => _notifications;

        protected void SetNotificationsList(List<Notification> notifications)
        {
            _notifications = notifications;
        }

        public abstract bool Validation();
    }
}