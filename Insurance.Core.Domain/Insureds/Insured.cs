using Insurance.Core.Domain.Abstractions;

namespace Insurance.Core.Domain.Insureds
{
    public sealed class Insured : Entity
    {

        private Insured(Guid id, Name name,
            CPF cpf, Age age) : base(id)
        {
            Name = name;
            CPF = cpf;
            Age = age;
        }

        public Name Name { get; private set; } = default!;
        public CPF CPF { get; private set; } = default!;
        public Age Age { get; private set; } = default!;
    }
}

