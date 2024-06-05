using System;
using System.ComponentModel.DataAnnotations;

namespace DTOs
{


    public record class GameInformationDto
        (
            int GameId,
            [Required][StringLength(50)] string Title,
            [Required] string DateReleased,
            [Required] string DateStarted,
            string? DateCompleted,
            string? Review,
            [Range(0, 10)] int Rating

        );

}
