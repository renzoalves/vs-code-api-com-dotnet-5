using System;

namespace Pets.Domain.Etities.VaccineContext
{
    public class Vaccine : BaseEntity
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



    }

}