using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace SimApi.Data.EFCore
{
    /// <summary>
    /// Context factory, used for EF migrations only
    /// </summary>
    internal class SimApiContextFactory : IDbContextFactory<SimApiContext>
    {
        public SimApiContext Create(DbContextFactoryOptions options)
        {
            var builder = new DbContextOptionsBuilder<SimApiContext>();
            builder.UseSqlServer(ConfigurationHelper.GetSetting("ConnectionStrings:DefaultConnection"));
            return new SimApiContext(builder.Options);
        }
    }
}
