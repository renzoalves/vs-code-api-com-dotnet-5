using System;
using System.Collections.Generic;
using Pets.Domain.ValueObjects;
using Pets.Domain.Validations.Iterfaces;
using Pets.Domain.Notifications;

namespace Pets.Domain.Etities.VaccineContext
{
    public abstract class BaseEntity: IValidations
    {
        private List<Notification> _notifications;
        protected BaseEntity(string description)
        {
            Id = Guid.NewGuid();
            CreateDate = DateTime.UtcNow;
            Description = description;
        }

        public Guid Id { get; private set; }
        public DateTime CreateDate { get; private set; }
        public string Description { get; private set; }
        public IReadOnlyCollection<Notification> Notifications => _notifications;

        public void SetNotificationsList(List<Notification> notifications)
        {
            _notifications = notifications;
        }

        public virtual void SetDescription(string description)
        {
            Description = description;
        }

        public abstract bool Validation();

    }

}