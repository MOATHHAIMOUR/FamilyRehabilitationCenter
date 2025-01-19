namespace FamilyRehabilitationCenter.Domain.IRepositories.Base
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        public Task<IEnumerable<TEntity>> GetAll();
        public Task<IEnumerable<DTO>> GetAllAsync<DTO>();
        public Task<IEnumerable<TEntity>> GetAllPaginatedAsync(int pageNumber, int pageSize);
        public Task<IEnumerable<DTO>> GetAllPaginatedAsync<DTO>(int pageNumber, int pageSize);
        public Task<TEntity?> GetById(int Id);
        public Task<bool> Update(TEntity entity);
        public Task<bool> Delete(TEntity entity);
        public Task<int> Add(TEntity entity);
    }
}
