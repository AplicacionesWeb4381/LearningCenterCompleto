using LearningCenterPlatform.Publishing.Domain.Model.Aggregate;
using LearningCenterPlatform.Shared.Domain.Repositories;

namespace LearningCenterPlatform.Publishing.Domain.Repositories;

/// <summary>
///     Represents the tutorial repository in the ACME Learning Center Platform.
/// </summary>
public interface ITutorialRepository : IBaseRepository<Tutorial>
{
    /// <summary>
    ///     Finds a tutorial by category id asynchronously.
    /// </summary>
    /// <param name="categoryId">
    ///     The id of the category to find tutorials by.
    /// </param>
    /// <returns>
    ///     A collection of tutorials that belong to the category.
    /// </returns>
    Task<IEnumerable<Tutorial>> FindByCategoryIdAsync(int categoryId);

    Task<bool> ExistsByTitleAsync(string title);
}