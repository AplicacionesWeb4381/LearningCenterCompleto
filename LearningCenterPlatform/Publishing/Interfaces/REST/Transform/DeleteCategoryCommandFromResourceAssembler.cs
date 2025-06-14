using LearningCenterPlatform.Publishing.Domain.Model.Commands;
using LearningCenterPlatform.Publishing.Interfaces.REST.Resources;

namespace LearningCenterPlatform.Publishing.Interfaces.REST.Transform
{
    public class DeleteCategoryCommandFromResourceAssembler
    {
        public static DeleteCategoryCommand ToCommandFromResource(DeleteCategoryResource resource)
        {
            return new DeleteCategoryCommand(resource.Id);
        }
    }
}
