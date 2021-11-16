using PrimeFactorizationNumbers.Domain.Core.Interfaces.Repositories;
using PrimeFactorizationNumbers.Domain.Entities;

namespace PrimeFactorizationNumbers.Infrastructure.Data.Repositories
{
    public class RepositoryUser : RepositoryBase<User>, IRepositoryUser
    {
        private readonly SqlContext sqlContext;

        public RepositoryUser(SqlContext sqlContext) : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }
    }

}
