namespace LearningCenterPlatform.Publishing.Domain.Model.Commands;


/// <summary>
///     Command to update a category.
/// </summary>
/// <param name="Name">
///     The name of the category to update.
/// </param>
public record UpdateCategoryCommand(int Id, string Name);