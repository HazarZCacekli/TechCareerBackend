using Day6_EFC.Context;
using Day6_EFC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Day6_EFC.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PlayersController : ControllerBase
{
    private readonly AppDBContext _context;

    public PlayersController(AppDBContext context)
    {
        _context = context;
    }

    [HttpPost]
    public IActionResult Add(Player player)
    {
        _context.Players.Add(player);
        _context.SaveChanges();
        return Ok();
    }

    [HttpGet]
    public IActionResult GetAllPlayers()
    {
        var players = _context.Players.ToList();
        return Ok(players);
    }


}
