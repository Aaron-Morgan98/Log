namespace Entities;
using System.ComponentModel.DataAnnotations;

public class GameEntity
{
    [Key]
    public required int GameId { get; set; }
    public required string Title { get; set; }
    public required DateOnly DateReleased { get; set; }
    public required DateOnly DateStarted { get; set; }
    public DateOnly DateCompleted { get; set; }
    public string? Review { get; set; }
    public int Rating { get; set; }
}
