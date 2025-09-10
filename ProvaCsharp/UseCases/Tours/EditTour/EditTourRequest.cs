namespace ProvaCsharp.UseCases.Tours.EditTour;

public record EditTourRequest(
    int UserID,
    int PointID,
    int TourID
);
