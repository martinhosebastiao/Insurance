using Insurance.Core.Domain.Abstractions;
using Insurance.Core.Domain.Insureds;
using Insurance.Core.Domain.Vehicles;

namespace Insurance.Core.Domain.Assurances
{
    public class AssuranceService : IAssuranceService
    {
        private readonly IAssuranceRepository _assuranceRepository;

        public AssuranceService(IAssuranceRepository assuranceRepository)
        {
            _assuranceRepository = assuranceRepository;
        }

        public Result CreateInsurance(
            Guid insuredId, Guid vehicleId, Money vehicleAmount)
        {
            try
            {
                var assurance = Assurance.Create(
                    insuredId, vehicleId, vehicleAmount);

                _assuranceRepository.Insert(assurance);

                return Result.Success();
            }
            catch (Exception)
            {
                // Registar no logs de erro

                return Result.Failure(AssuranceErrors.ThereWasAnException);
            }
        }

        public async Task<Result> GenerateReportWithArithmeticAverangesAsync(
            CancellationToken cancellationToken)
        {
            try
            {
                var assurances =
                    await _assuranceRepository.GetAllAsync(cancellationToken);

                if (assurances is null)
                    return Result.Failure(AssuranceErrors.NotFoundAssurance);

                // Calcular a media aritmetica
                var arithmeticAverage =
                    assurances.Sum(x => x?.Amount) / assurances.Count;

                return Result.Success(arithmeticAverage);
            }
            catch (Exception)
            {
                // Registar no logs de erro

                return Result.Failure(AssuranceErrors.ThereWasAnException);
            }
        }

        public Task<Result> SearchAsync(
            Assurance assurance,
            CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}


