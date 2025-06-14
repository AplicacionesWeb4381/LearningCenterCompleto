namespace LearningCenterPlatform.Publishing.Interfaces.REST.Resources;
/// <summary>
///     Update category resource for REST API
/// </summary>
/// <param name="Name">
///     The name of the category
/// </param>
public record UpdateCategoryResource(int Id, string Name);