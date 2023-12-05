using System.Diagnostics.CodeAnalysis;
namespace Insurance.Core.Domain.Abstractions
{
    public class Result
    {
        protected internal Result(bool isSuccess, Error error)
        {
            if (isSuccess && error != Error.None ||
                IsFailure && error == Error.None)
            {
                throw new ArgumentException("Erro invalido", nameof(error));
            }

            Error = error;
            IsSuccess = isSuccess;
        }

        public static Result Success() => new(true, Error.None);
        public static Result Failure(Error error) => new(false, error);

       /* public static Result<TValue> Success<TValue>(TValue value)
            => new(value, true, Error.None);
        public static Result<T> Failure<T>(Error error)
            => new(default, false, error);
        */

        public Error Error { get; }
        public bool IsSuccess { get; }
        public bool IsFailure => !IsSuccess;
    }
}

