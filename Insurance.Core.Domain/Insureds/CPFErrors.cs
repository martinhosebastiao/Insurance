using Insurance.Core.Domain.Abstractions;

namespace Insurance.Core.Domain.Insureds
{
    public static class CPFErrors
    {
        public static readonly Error InvalidFormat
            = new(
                "CPF.InvalidFormat",
                "O formato do CPF é invalido");

        public static readonly Error Empty = new("CPF.Empty", "O CPF é vazio");
    }
}

