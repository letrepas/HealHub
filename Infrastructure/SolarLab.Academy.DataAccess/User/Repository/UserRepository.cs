using Microsoft.EntityFrameworkCore;
using SolarLab.Academy.AppServices.Users.Repositories;
using SolarLab.Academy.Contracts.Users;
using SolarLab.Academy.Infrastructure.Repository;

namespace SolarLab.Academy.DataAccess.User.Repository
{
    ///<inheritdoc />
    public class UserRepository : IUserRepository
    {
        private readonly IRepository<Domain.Users.Enity.User> _repository;
        ///<inheritdoc /> 
        public async Task<IEnumerable<UserDto>> GetAll(CancellationToken cancellationToken)
        {
            //var users = UserList();

            var users = await _repository.GetAll().AsNoTracking().ToListAsync(cancellationToken);
            return users.Select(u => new UserDto
            {
                Id = u.Id,
                FirstName = u.FirstName,
                LastName = u.LastName,
                MiddleName = u.MiddleName,
                FullName = $"{u.LastName} {u.FirstName} {u.MiddleName}"
            });
        }
        /// <summary>
        /// Данные якобы из БД
        /// </summary>
        /// <returns></returns>
        public static List<Domain.Users.Enity.User> UserList()
        {
            return new List<Domain.Users.Enity.User>()
            {
                new Domain.Users.Enity.User()
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Иван",
                    LastName ="Иванов",
                    MiddleName = "Иванович"
                }
            };
        }
    }
}
