using Microsoft.EntityFrameworkCore;

namespace ChessApi.Models
{
    public class ChessContext : DbContext
    {
        public ChessContext(DbContextOptions<ChessContext> options) : base(options) { }

        public DbSet<Player> Players { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<Opening> Openings { get; set; }
    }

    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Rating { get; set; }
    }

    public class Match
    {
        public int Id { get; set; }
        public int PlayerId { get; set; }
        public string Opponent { get; set; }
        public int OpponentRating { get; set; }
        public string Result { get; set; }
        public string Opening { get; set; }
        public int NewRating { get; set; }
        public string Note { get; set; }
        public DateTime Date { get; set; }
    }

    public class Opening
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
