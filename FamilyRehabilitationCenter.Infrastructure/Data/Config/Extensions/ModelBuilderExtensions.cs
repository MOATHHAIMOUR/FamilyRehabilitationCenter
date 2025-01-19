using Microsoft.EntityFrameworkCore;

namespace FamilyRehabilitationCenter.Infrastructure.Data.Config.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void UseRestrictDeleteBehavior(this ModelBuilder modelBuilder)
        {
            foreach (var foreignKey in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetForeignKeys()))
            {
                foreignKey.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }
    }
}
