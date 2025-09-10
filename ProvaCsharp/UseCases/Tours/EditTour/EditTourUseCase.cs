using Microsoft.OpenApi.Expressions;
using ProvaCsharp.Models;
using Microsoft.EntityFrameworkCore;
namespace ProvaCsharp.UseCases.Tours.EditTour;

public class EditTourUseCase(ProvaCscharpDbContext ctx)
{
    public async Task<Result<EditTourResponse>> Do(EditTourRequest request)
    {
        var user = await ctx.Users.FirstAsync(u => u.UserID == request.UserID);
        var tour = await ctx.Tours.FirstAsync(t => t.TourID == request.TourID);

        if (tour.UserID != user.UserID)
            return Result<EditTourResponse>.Fail("Forbidden");

        if (tour is null)
            return Result<EditTourResponse>.Fail("Tour not found");

        tour.PointID = request.PointID;

        ctx.Update(tour);
        await ctx.SaveChangesAsync();

        return Result<EditTourResponse>.Ok(new());

    }
}