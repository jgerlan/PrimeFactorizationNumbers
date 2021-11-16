using PrimeFactorizationNumbers.Domain.Core.Interfaces.Repositories;
using PrimeFactorizationNumbers.Domain.Core.Interfaces.Services;
using PrimeFactorizationNumbers.Domain.Entities;

namespace PrimeFactorizationNumbers.Domain.Services
{
    public class ServiceUser : ServiceBase<User>, IServiceUser
    {
        private readonly IRepositoryUser repositoryUser;

        public ServiceUser(IRepositoryUser repositoryUser) : base(repositoryUser)
        {
            this.repositoryUser = repositoryUser;
        }
    }
}
