using Insurance.Core.Domain.Abstractions;
using Insurance.Core.Domain.Vehicles;

namespace Insurance.Core.Domain.Assurances
{
    public interface IAssuranceService
    {
        /// <summary>
        /// Mostra um relatorio contendo as medias aritmetricas de todos os
        /// seguros existentes.
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns>Retorna um relatorio com as medias dos seguros</returns>
        Task<Result> GenerateReportWithArithmeticAverangesAsync(
            CancellationToken cancellationToken);

        /// <summary>
        /// Criar um novo seguro para o veiculo
        /// </summary>
        /// <param name="insured">Dados do segurado</param>
        /// <param name="vehicle">Dados do veiculo</param>
        /// <returns>Retorna o valor do seguro referente ao veiculo</returns>
        Result CreateInsurance(
            Guid insuredId, Guid vehicleId, Money vehicleAmount);

        /// <summary>
        /// </summary>
        /// <param name="assurance"></param>
        /// <param name="cancellationToken"></param>
        /// <returns>Retorna os dados de um seguro</returns>
        Task<Result> SearchAsync(
            Assurance assurance,CancellationToken cancellationToken);
    }
}

