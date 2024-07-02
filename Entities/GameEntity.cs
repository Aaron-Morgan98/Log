namespace Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class GameEntity
{  
    
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int GameId { get; set; }

    public required string Title { get; set; }
    public required string DateReleased { get; set; }
    public string? DateStarted { get; set; }
    public string? DateCompleted { get; set; }
    public string? Review { get; set; }
    public int? Rating { get; set; }
    public int? Difficulty { get; set; }
    public int? Story { get; set; }
}
