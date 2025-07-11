using System.Net.Mime;
using LearningCenterPlatform.Publishing.Domain.Model.Queries;
using LearningCenterPlatform.Publishing.Domain.Services;
using LearningCenterPlatform.Publishing.Interfaces.REST.Resources;
using LearningCenterPlatform.Publishing.Interfaces.REST.Transform;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace LearningCenterPlatform.Publishing.Interfaces.REST;

[ApiController]
[Route("api/v1/categories/{categoryId:int}/tutorials")]
[Produces(MediaTypeNames.Application.Json)]
[Tags("Categories")]
public class CategoryTutorialsController(ITutorialQueryService tutorialQueryService) : ControllerBase
{
    /// <summary>
    ///     Get all tutorials by category id
    /// </summary>
    /// <param name="categoryId">
    ///     The category id
    /// </param>
    /// <returns>
    ///     The list of <see cref="TutorialResource" /> tutorials
    /// </returns>
    [HttpGet]
    [SwaggerOperation(
        Summary = "Get all tutorials by category id",
        Description = "Get all tutorials by category id",
        OperationId = "GetAllTutorialsByCategoryId")]
    [SwaggerResponse(StatusCodes.Status200OK, "The list of tutorials", typeof(IEnumerable<TutorialResource>))]
    public async Task<IActionResult> GetTutorialsByCategoryId(int categoryId)
    {
        var getTutorialsByCategoryIdQuery = new GetAllTutorialsByCategoryIdQuery(categoryId);
        var tutorials = await tutorialQueryService.Handle(getTutorialsByCategoryIdQuery);
        var tutorialResources = tutorials.Select(TutorialResourceFromEntityAssembler.ToResourceFromEntity);
        return Ok(tutorialResources);
    }
}