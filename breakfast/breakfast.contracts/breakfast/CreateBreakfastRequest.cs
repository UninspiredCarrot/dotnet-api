namespace breakfast.contracts.breakfast;

public record CreateBreakfastRequest(
    string Name,
    string Description,
    DateTime StartDateTime,
    DateTime EndDateTime,
    List<string> Savory,
    List<string> Sweet
);