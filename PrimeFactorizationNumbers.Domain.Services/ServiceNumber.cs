using PrimeFactorizationNumbers.Domain.Core.Interfaces.Repositories;
using PrimeFactorizationNumbers.Domain.Core.Interfaces.Services;
using PrimeFactorizationNumbers.Domain.Entities;

namespace PrimeFactorizationNumbers.Domain.Services
{
    public class ServiceNumber : ServiceBase<Number>, IServiceNumber
    {
        private readonly IRepositoryNumber repositoryNumber;

        public ServiceNumber(IRepositoryNumber repositoryNumber) : base(repositoryNumber)
        {
            this.repositoryNumber = repositoryNumber;
        }
    }
}
