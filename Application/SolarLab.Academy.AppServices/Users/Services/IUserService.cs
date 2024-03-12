using SolarLab.Academy.Contracts.Users;

namespace SolarLab.Academy.AppServices.Users.Services
{
    /// <summary>
    /// Сервис работы с пользователями.
    /// </summary>
    public interface IUserService
    {
        /// <summary>
        /// Возращает всех польхователей.
        /// </summary>
        /// <returns>Список полбзователей <see cref="UserDto"/>.</returns>
        Task<IEnumerable<UserDto>> GetUsersAsync(CancellationToken cancellationToken);
    }
}
