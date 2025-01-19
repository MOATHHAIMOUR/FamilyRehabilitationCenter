using AutoMapper;
using FamilyRehabilitationCenter.Domain.Entites;
using FamilyRehabilitationCenter.Infrastructure.Data;
using FamilyRehabilitationCenter.Infrastructure.Repositories.Base;

namespace FamilyRehabilitationCenter.Domain.IRepositories
{
    public class RegionRepository : GenericRepository<Region>, IRegionRepository
    {
        public RegionRepository(AppDbContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
