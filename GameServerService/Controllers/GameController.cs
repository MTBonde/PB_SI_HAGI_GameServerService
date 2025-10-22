using GameService;
using Microsoft.AspNetCore.Mvc;

namespace GameServerService.Controllers;

[ApiController]
[Route($"api/{ApiVersion.Route}/[controller]")]
public class GameController : ControllerBase
{
    [HttpPost("join")]
    public IActionResult Join([FromBody] JoinRequest? request)
    {
        // Dummy join - always succeeds with hardcoded player ID
        return Ok(new
        {
            message = "Player joined",
            playerId = "player-123"
        });
    }
}

public record JoinRequest();
