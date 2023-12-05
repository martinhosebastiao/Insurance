namespace Insurance.Core.Domain.Abstractions
{
    public interface IBaseRepository<TEntity> where TEntity : class
	{
        Task<IList<TEntity?>> GetAllAsync(CancellationToken cancellationToken);
        Task<TEntity?> GetByIdAsync(Guid id, CancellationToken cancellationToken);

        void Insert(TEntity entity);
    }
}

