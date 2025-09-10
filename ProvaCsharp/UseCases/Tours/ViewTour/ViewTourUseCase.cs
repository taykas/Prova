using Microsoft.AspNetCore.Components.Endpoints;
using Microsoft.EntityFrameworkCore;
using ProvaCsharp.Models;

namespace ProvaCsharp.UseCases.Tours.ViewTour;

public class ViewTourUseCase(ProvaCscharpDbContext ctx)
{
    public async Task<Result<ViewTourResponse>> Do(ViewTourRequest request)
    {
        var tour = await ctx.ToursPoint
            .Include(tp => tp.Tour)
            .Include(tp => tp.Point)
            .Include(tp => tp.User)
            .FirstOrDefaultAsync(tp => tp.ToursPointID == request.ToursPointID);

        if (tour is null)
            return Result<ViewTourResponse>.Fail("Tour not found");

        var response = new ViewTourResponse(
            tour.Tour.Title,
            tour.Tour.Description,
            tour.Point.Title,
            tour.Tour.User.Name
        );

        return Result<ViewTourResponse>.Ok(response);
    }
}