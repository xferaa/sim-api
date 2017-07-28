using Microsoft.EntityFrameworkCore;

namespace SimApi.Data.EFCore
{
    public class InMemoryUnitOfWork : BaseUnitOfWork
    {
        public InMemoryUnitOfWork() : this(CreateContext(string.Empty))
        {
        }

        public InMemoryUnitOfWork(string nameOrConnectionString) : this(CreateContext(nameOrConnectionString))
        {
        }

        public InMemoryUnitOfWork(SimApiContext dbContext) : base(dbContext)
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
