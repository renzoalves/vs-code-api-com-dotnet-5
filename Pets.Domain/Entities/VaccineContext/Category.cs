using Pets.Domain.Validations;
using Pets.Domain.Validations.Interfaces;
using Pets.Domain.ValueObjects;

namespace Pets.Domain.Etities.VaccineContext
{
    public class Category : BaseEntity, IContract
    {

        public Category(string description) : base(description)
        {
        }

        public override void SetDescription(string description)
        {
            base.SetDescription(description);
        }

        public override bool Validation()
        {
            var contracts = new ContractValidations<Category>()
            .DescriptionIsOk(this.Description, 64, 12, "A descrição deve conter entre 12 e 64 caracterees.", "Description");

            return contracts.IsValid();
        }
    }
}