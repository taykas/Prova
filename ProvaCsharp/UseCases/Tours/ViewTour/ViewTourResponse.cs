using ProvaCsharp.Models;
namespace ProvaCsharp.UseCases.Tours.ViewTour;

public record ViewTourResponse(
    string Title,
    string Description,
    string Point,
    string CreatorName
);