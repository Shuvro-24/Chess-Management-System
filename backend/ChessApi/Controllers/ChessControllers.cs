using ChessApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ChessApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlayersController : ControllerBase
    {
        private readonly ChessContext _context;
        public PlayersController(ChessContext context) => _context = context;

        [HttpGet]
        public async Task<IActionResult> GetPlayers() => Ok(await _context.Players.ToListAsync());

        [HttpPost]
        public async Task<IActionResult> AddPlayer(Player player)
        {
            _context.Players.Add(player);
            await _context.SaveChangesAsync();
            return Ok(player);
        }
    }

    [ApiController]
    [Route("api/[controller]")]
    public class MatchesController : ControllerBase
    {
        private readonly ChessContext _context;
        public MatchesController(ChessContext context) => _context = context;

        [HttpGet]
        public async Task<IActionResult> GetMatches() => Ok(await _context.Matches.ToListAsync());

        [HttpPost]
        public async Task<IActionResult> AddMatch(Match match)
        {
            match.Date = DateTime.UtcNow;
            _context.Matches.Add(match);
            await _context.SaveChangesAsync();
            return Ok(match);
        }
    }

    [ApiController]
    [Route("api/[controller]")]
    public class OpeningsController : ControllerBase
    {
        private readonly ChessContext _context;
        public OpeningsController(ChessContext context) => _context = context;

        [HttpGet]
        public async Task<IActionResult> GetOpenings() => Ok(await _context.Openings.ToListAsync());

        [HttpPost]
        public async Task<IActionResult> AddOpening(Opening opening)
        {
            _context.Openings.Add(opening);
            await _context.SaveChangesAsync();
            return Ok(opening);
        }
    }
}
