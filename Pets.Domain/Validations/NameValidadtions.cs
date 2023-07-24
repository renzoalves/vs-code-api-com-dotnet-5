using Pets.Domain.ValueObjects;

namespace Pets.Domain.Validations
{
    public static class NameValidations
    {
        public static bool IsValidName(Name name)
        {
            return string.IsNullOrEmpty(name.FirstName) && string.IsNullOrEmpty(name.LastName);
        }
    }

}