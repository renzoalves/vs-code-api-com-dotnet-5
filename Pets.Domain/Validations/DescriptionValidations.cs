using Pets.Domain.Notifications;

namespace Pets.Domain.Validations
{
    public partial class ContractValidations<T>
    {
        public ContractValidations<T> DescriptionIsOk(string description, short maxLength, short minLength, string message, string porpertyName)
        {
            if (string.IsNullOrEmpty(description) || (description.Length < minLength) || (description.Length > maxLength))
                AddNotification(new Notification(message, porpertyName));

            return this;
        }
    }
}