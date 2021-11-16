using PrimeFactorizationNumbers.Domain.Core.Interfaces.Repositories;
using PrimeFactorizationNumbers.Domain.Entities;

namespace PrimeFactorizationNumbers.Infrastructure.Data.Repositories
{
    public class RepositoryNumber : RepositoryBase<Number>, IRepositoryNumber
    {
        private readonly SqlContext sqlContext;

        public RepositoryNumber(SqlContext sqlContext) : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }
    }
}
