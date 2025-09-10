using System.ComponentModel.DataAnnotations;

namespace ProvaCsharp.UseCases.Tours.CreateTour;

public record CreateTourRequest
{
    [Required]
    public int UserID { get; init; }

    [Required]
    [MaxLength(20)]
    public string Title { get; init; }

    [Required]
    [MaxLength(200)]
    [MinLength(40)]
    public string Description { get; init; }
}