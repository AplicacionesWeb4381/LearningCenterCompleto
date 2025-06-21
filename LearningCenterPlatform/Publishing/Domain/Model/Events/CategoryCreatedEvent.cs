using LearningCenterPlatform.Shared.Domain.Model.Events;
using System.ComponentModel.Design;

namespace LearningCenterPlatform.Publishing.Domain.Model.Events
{
    public class CategoryCreatedEvent(string name ) : IEvent
    {
        public string Name { get; } = name;
    }
}
