using Microsoft.AspNetCore.Mvc;
using SolarLab.Academy.AppServices.Users.Services;

namespace SolarLab.Academy.Api.Controllers;

/// <summary>
/// Контроллер для работы с пользователями.
/// </summary>
[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;

    /// <summary>
    /// Инциализирует экземляр <see cref="UserController"/>
    /// </summary>
    /// <param name="userService">Сервис работы с пользователями.</param>
    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    /// <summary>
    /// Возращает список пользователей.
    /// </summary>
    /// <param name="cancellationToken">Токены отмены операции.</param>
    /// <returns>Список пользователей</returns>
    [HttpGet]
    [Route("all")] // вот про это надо узнать
    public async Task<IActionResult> GetAllUsers(CancellationToken cancellationToken)
    {
        var result = await _userService.GetUsersAsync(cancellationToken);

        return Ok(result);
    }
}
