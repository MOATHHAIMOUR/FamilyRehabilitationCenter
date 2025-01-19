using AutoMapper;
using AutoMapper.QueryableExtensions;
using FamilyRehabilitationCenter.Domain.Entites;
using FamilyRehabilitationCenter.Infrastructure.Data;
using FamilyRehabilitationCenter.Infrastructure.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace FamilyRehabilitationCenter.Domain.IRepositories
{
    public class DistrictRepository : GenericRepository<District>, IDistrictRepository
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        public DistrictRepository(AppDbContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<DTO>> GetAllDistrictsByRegionIdByCityId<DTO>(int RegionId, int CityId)
        {
            return await _context.Districts
               .Where(c => c.RegionId == RegionId && c.CityId == CityId)
               .ProjectTo<DTO>(_mapper.ConfigurationProvider).ToListAsync();
        }
    }
}
