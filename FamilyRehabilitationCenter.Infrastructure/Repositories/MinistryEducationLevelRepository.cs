using AutoMapper;
using AutoMapper.QueryableExtensions;
using FamilyRehabilitationCenter.Domain.Entites;
using FamilyRehabilitationCenter.Domain.IRepositories;
using FamilyRehabilitationCenter.Infrastructure.Data;
using FamilyRehabilitationCenter.Infrastructure.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace FamilyRehabilitationCenter.Infrastructure.Repositories
{
    public class MinistryEducationLevelRepository : GenericRepository<MinistryEducationLevel>, IMinistryEducationLevelRepository
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public MinistryEducationLevelRepository(AppDbContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<DTO>> GetAllMinistryEducationLevlesByMinistryEducationId<DTO>(int MinistryEducationId)
        {
            return await _context.MinistryEducationLevels
                .Where(x => x.MinistryEducationId == MinistryEducationId)
                .ProjectTo<DTO>(_mapper.ConfigurationProvider).ToListAsync();
        }
    }
}
