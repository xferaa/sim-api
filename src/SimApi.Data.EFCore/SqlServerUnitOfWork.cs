using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimApi.Data.EFCore
{
    public class SqlServerUnitOfWork : BaseUnitOfWork
    {
        public SqlServerUnitOfWork(SimApiContext dbContext) : base(dbContext)
        {
        }

        private static SimApiContext CreateContext()
        {
            return new SimApiContext()
        }
    }
}
