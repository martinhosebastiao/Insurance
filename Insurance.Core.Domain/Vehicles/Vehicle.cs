using Insurance.Core.Domain.Abstractions;
using Insurance.Core.Domain.Insureds;

namespace Insurance.Core.Domain.Vehicles
{
    public sealed class Vehicle : Entity
    {
        private Vehicle(Guid id, Brand brand,
            Model model, Money amount) : base(id)
        {
            Brand = brand;
            Model = model;
            Amount = amount;
        }

        public Guid InsuredId { get; private set; }
        public Brand Brand { get; private set; }
        public Model Model { get; private set; }
        public Money Amount { get; private set; }

        public Insured? Insured { get; private set; }

        public static Vehicle Create(Brand brand, Model model, Money amount)
        {
            var newGuid = GenerateGuid();
            var vehicle = new Vehicle(newGuid, brand, model, amount);

            return vehicle;
        }
    }
}

