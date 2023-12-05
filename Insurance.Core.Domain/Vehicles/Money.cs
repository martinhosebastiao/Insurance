using System;
namespace Insurance.Core.Domain.Vehicles
{
	public sealed record Money
	{
        private Money(decimal value) => Value = value;

        public decimal Value { get; init; }
    }
}

