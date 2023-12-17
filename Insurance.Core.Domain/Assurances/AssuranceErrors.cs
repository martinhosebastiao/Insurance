using Insurance.Core.Domain.Abstractions;

namespace Insurance.Core.Domain.Assurances
{
    public static class AssuranceErrors
    {
        public static readonly Error NotFoundAssurance
        = new(
            $"Assurance.NotFoundAssurance",
            $"Seguro(s) não encontrado(s)");

        public static readonly Error ThereWasAnException
            = new(
                "Assurance.ThereWasAnException",
                "Ocorreu uma excepção durante o processamento.!");
    }
}

