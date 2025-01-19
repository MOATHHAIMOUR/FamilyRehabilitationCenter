using AutoMapper;
using FamilyRehabilitationCenter.Domain.Entites;
using FamilyRehabilitationCenter.Domain.IRepositories;
using FamilyRehabilitationCenter.Infrastructure.Data;
using FamilyRehabilitationCenter.Infrastructure.Repositories.Base;

namespace FamilyRehabilitationCenter.Infrastructure.Repositories
{
    public class MinistryEducationRepository : GenericRepository<MinistryEducation>, IMinistryEducationRepository
    {
        public MinistryEducationRepository(AppDbContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
