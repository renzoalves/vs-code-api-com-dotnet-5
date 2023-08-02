using System;
using Pets.Domain.Validations;
using Pets.Domain.Validations.Interfaces;

namespace Pets.Domain.Etities.VaccineContext
{
    public class Vaccine : BaseEntity, IContract
    {
        public Vaccine(string description, Guid categoryId, Guid petId) : base(description)
        {
            CategoryId = categoryId;
            PetId = petId;
        }

        public Guid CategoryId { get; private set; }
        public Guid PetId { get; private set; }
        public override void SetDescription(string description)
        {
            base.SetDescription(description);
        }

        public override bool Validation()
        {
            var contracts = new ContractValidations<Vaccine>()
            .DescriptionIsOk(this.Description, 31, 10, "A descrição deve conter entre 12 e 64 caracterees.", "Description")
            .IsGuid(this.CategoryId, "A categoria deve ser um guid válido", "Vaccine")
            .IsGuid(this.PetId, "O pet deve ser um guid válido", "Vaccine");

            return contracts.IsValid();
        }
    }
}