using breakfast.Models;

namespace breakfast.Services.Breakfasts;

public interface IBreakfastService
{
    void CreateBreakfast(Breakfast request);
    void DeleteBreakfast(Guid id);
    Breakfast GetBreakfast(Guid id);
    void UpsertBreakfast(Breakfast breakfast);
}