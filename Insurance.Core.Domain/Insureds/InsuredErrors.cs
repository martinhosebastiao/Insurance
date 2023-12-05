using Insurance.Core.Domain.Abstractions;

namespace Insurance.Core.Domain.Insureds
{
    public static class InsuredErrors
    {
        public static Error InvalidName(Name name)
            => new(
                $"Insured.{nameof(name)}",
                $"{name} não é uma idade valida para o segurado");

        public static Error InvalidAge(Age age)
            => new(
                $"Insured.{nameof(age)}",
                $"{age} não é uma idade valida para o segurado");

        public static Error InvalidCPF(CPF cpf)
            => new(
                $"Insured.{nameof(cpf)}",
                $"O numero de CPF {cpf} é invalido");

        public static Error NotFoundCPF(CPF cpf)
            => new(
                $"Insured.{nameof(cpf)}",
                $"O numero de CPF {cpf} não foi encontrado");

        public static readonly Error CPFNotUnique
            = new(
                "Insured.CPF",
                "O CPF forncedido não é unico");
    }
}

