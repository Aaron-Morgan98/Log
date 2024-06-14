namespace Entities;
using System.ComponentModel.DataAnnotations;

public class GameEntity
{   //TODO: make DateStarted optional
    //TODO: add difficulty column?
    [Key]
    public required int GameId { get; set; }
    public required string Title { get; set; }
    public required string DateReleased { get; set; }
    public string? DateStarted { get; set; }
    public string? DateCompleted { get; set; }
    public string? Review { get; set; }
    public int Rating { get; set; }
}
