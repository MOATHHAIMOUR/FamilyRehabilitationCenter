using AutoMapper;
using AutoMapper.QueryableExtensions;
using FamilyRehabilitationCenter.Domain.IRepositories.Base;
using FamilyRehabilitationCenter.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace FamilyRehabilitationCenter.Infrastructure.Repositories.Base
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private DbSet<TEntity> Entity { set; get; }
        private AppDbContext Context { set; get; }
        private IMapper Mapper { get; set; }

        public GenericRepository(AppDbContext context, IMapper mapper)
        {
            Entity = context.Set<TEntity>();
            Context = context;
            Mapper = mapper;
        }


        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await Entity.AsNoTracking().ToListAsync();
        }

        public async Task<IEnumerable<DTO>> GetAllAsync<DTO>()
        {
            return await Entity.AsNoTracking()
                .ProjectTo<DTO>(Mapper.ConfigurationProvider)
                .ToListAsync();
        }


        public async Task<IEnumerable<TEntity>> GetAllPaginatedAsync(int pageNumber, int pageSize)
        {
            return await Entity
                    .AsNoTracking()
                    .Skip((pageNumber - 1) * pageSize)
                    .Take(pageSize)
                    .ToListAsync();
        }

        public async Task<IEnumerable<DTO>> GetAllPaginatedAsync<DTO>(int pageNumber, int pageSize)
        {
            return await Entity.AsNoTracking()
                     .Skip((pageNumber - 1) * pageSize)
                     .Take(pageSize)
                     .ProjectTo<DTO>(Mapper.ConfigurationProvider)
                     .ToListAsync();
        }

        public async Task<TEntity?> GetById(int Id)
        {
            return await Entity.FindAsync(Id);
        }

        public async Task<int> Add(TEntity entity)
        {
            await Entity.AddAsync(entity);
            await Context.SaveChangesAsync();
            return (int)(typeof(TEntity).GetProperty("Id")?.GetValue(entity) ?? 0);
        }

        public async Task<bool> Delete(TEntity entity)
        {
            Entity.Remove(entity);

            int numbweOfRowsAffected = await Context.SaveChangesAsync();

            return numbweOfRowsAffected > 0;
        }

        public async Task<bool> Update(TEntity entity)
        {
            Entity.Update(entity);
            int numbweOfRowsAffected = await Context.SaveChangesAsync();
            return numbweOfRowsAffected > 0;
        }
    }
}
