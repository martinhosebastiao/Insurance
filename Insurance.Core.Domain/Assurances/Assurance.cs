using Insurance.Core.Domain.Abstractions;
using Insurance.Core.Domain.Insureds;
using Insurance.Core.Domain.Vehicles;

namespace Insurance.Core.Domain.Assurances
{
    public sealed class Assurance : Entity
    {
        #region - Default Value -
        /// <summary>
        /// A margem de segurança é igual 3%
        /// </summary>
        private const decimal SafetyMargin = 3 / 100;

        /// <summary>
        /// A margem de lucro é igual 5%
        /// </summary>
        private const decimal Profit = 5 / 100;
        #endregion


        private Assurance(Guid id, Guid insuredId, Guid vehicleId) : base(id)
        {
            InsuredId = insuredId;
            VehicleId = vehicleId;
        }

        public Guid InsuredId { get; private set; }
        public Guid VehicleId { get; private set; }
        public decimal Amount { get; private set; } = default!;

        public Insured? Insured { get; private set; }
        public Vehicle? Vehicle { get; private set; }

        /// <summary>
        /// Calcular o valor do seguro com base na regra de negocio informada
        /// </summary>
        private void CalculatingVehicleInsurance()
        {
            var vehicleAmount = Vehicle?.Amount.Value ?? 0;
            var riskRate = (vehicleAmount * 5) / (2 * vehicleAmount);
            var riskPremium = riskRate * vehicleAmount;
            var purePremium = riskPremium * (1 + SafetyMargin);
            var commercialPremium = Profit * purePremium;

            Amount = commercialPremium;
        }

        public static Assurance Create(Insured insured, Vehicle vehicle)
        {
            var newAssuranceGuid = GenerateGuid();

            Assurance assurance = new(
                newAssuranceGuid,
                insured.Id,
                vehicle.Id);

            assurance.Insured = insured;
            assurance.Vehicle = vehicle;

            assurance.CalculatingVehicleInsurance();

            return assurance;
        }
    }
}

