using System;
using Insurance.Core.Domain.Abstractions;

namespace Insurance.Core.Domain.Insureds
{
	public sealed record Name
	{
		private Name(string value) => Value = value;

		public string Value { get; init; }

	/*	public static Result Create(string? name)
		{
			if (string.IsNullOrEmpty(name))
			{
				return Result.Failure<Name>(NameErrors.Empty);
			}

			return new Name(name);
		}
	*/
	}
}

