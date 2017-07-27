using Microsoft.EntityFrameworkCore;

namespace SimApi.Data.EFCore
{
    public class SqlServerUnitOfWork : BaseUnitOfWork
    {
        public SqlServerUnitOfWork() : this(CreateContext(string.Empty))
        {
        }

        public SqlServerUnitOfWork(string nameOrConnectionString) : this(CreateContext(nameOrConnectionString))
        {
        }

        public SqlServerUnitOfWork(SimApiContext dbContext) : base(dbContext)
        {
        }

        private static SimApiContext CreateContext(string nameOrConnectionString)
        {
            var builder = new DbContextOptionsBuilder<SimApiContext>();
            builder.UseSqlServer(nameOrConnectionString);
            return new SimApiContext(builder.Options);
        }
    }
}
