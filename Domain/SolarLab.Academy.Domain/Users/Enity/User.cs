using SolarLab.Academy.Domain.Base;

namespace SolarLab.Academy.Domain.Users.Enity
{
    /// <summary>
    /// Пользоватьель.
    /// </summary>
    public class User: BaseEntity
    {
        /// <summary>
        /// Имя.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Фамилия.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Отечество.
        /// </summary>
        public string MiddleName { get; set; }

    }
}
