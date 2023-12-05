using System;
using Insurance.Core.Domain.Abstractions;

namespace Insurance.Core.Domain.Insureds
{
	public static class NameErrors
	{
        public static readonly Error InvalidCharacter
            = new(
                "Name.InvalidCharacter",
                "Caracter invalido");

        public static readonly Error Empty = new("Name.Empty", "O Nome é vazio");
    }
}

