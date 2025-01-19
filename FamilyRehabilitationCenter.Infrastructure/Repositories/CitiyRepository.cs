using AutoMapper;
using AutoMapper.QueryableExtensions;
using FamilyRehabilitationCenter.Domain.Entites;
using FamilyRehabilitationCenter.Infrastructure.Data;
using FamilyRehabilitationCenter.Infrastructure.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace FamilyRehabilitationCenter.Domain.IRepositories
{
    public class CityRepository : GenericRepository<City>, ICitiyRepository
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public CityRepository(AppDbContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<DTO>> GetAllCitiesByRegionIdAsync<DTO>(int RegionId)
        {
            return await _context.Cities
                .Where(c => c.RegionId == RegionId)
                .ProjectTo<DTO>(_mapper.ConfigurationProvider).ToListAsync();
        }
    }
}
