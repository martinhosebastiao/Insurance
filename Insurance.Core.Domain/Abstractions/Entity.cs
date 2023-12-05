namespace Insurance.Core.Domain.Abstractions
{
    public abstract class Entity
	{
		protected Entity(Guid id) => Id = id;

		public Guid Id { get; init; }

		internal static Guid GenerateGuid()
		{
			var result = Guid.NewGuid();

			return result;
        }
	}
}