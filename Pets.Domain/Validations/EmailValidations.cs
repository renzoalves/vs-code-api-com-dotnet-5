using System.Text.RegularExpressions;
using Pets.Domain.Notifications;

namespace Pets.Domain.Validations
{
    public partial class ContractValidations<T>
    {
        public ContractValidations<T> EmailIsValid(string email, string message, string porpertyName)
        {
            if (string.IsNullOrEmpty(email) || !Regex.IsMatch(email, @"^([\w-]+(?:\.[w-]+)*)@((?:\.[w-]+)*\w[\w-]{0,66})\.([a-z]{2,66})"))
                AddNotification(new Notification(message, porpertyName));

            return this;
        }
    }
}