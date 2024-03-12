using SolarLab.Academy.AppServices.Users.Repositories;
using SolarLab.Academy.Contracts.Users;

namespace SolarLab.Academy.DataAccess.User.Repository
{
    ///<inheritdoc />
    public class UserRepository : IUserRepository
    {
        ///<inheritdoc /> 
        public Task<IEnumerable<UserDto>> GetAll(CancellationToken cancellationToken)
        {
            var users = UserList();
            return Task.Run(() => users.Select(u => new UserDto
            {
                Id = u.Id,
                FirstName = u.FirstName,
                LastName = u.LastName,
                MiddleName = u.MiddleName,
                FullName = $"{u.LastName} {u.FirstName} {u.MiddleName}"
            }), cancellationToken);
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
