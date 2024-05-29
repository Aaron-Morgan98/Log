using System;
using System.ComponentModel.DataAnnotations;

namespace DTOs
{


    public record class CreateGameDto
        (
            [Required][StringLength(50)] string Title,
            [Required] string DateReleased,
            [Required] string DateStarted,
            string DateCompleted,
            [Range(0, 10)] string Review,
            int Rating

        );

}
