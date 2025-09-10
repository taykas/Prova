namespace ProvaCsharp.UseCases.Tours.ViewTour;

public record ViewTourRequest(
    int ToursPointID,
    int PointID,
    int UserID
);