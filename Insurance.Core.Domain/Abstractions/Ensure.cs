using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Insurance.Core.Domain.Abstractions
{
    public static class Ensure
    {
        public static void NotNullOrEmpty(
            [NotNull] string? value,
            [CallerArgumentExpression(nameof(value))] string? param = default)
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentNullException(param);
        }
    }
}

