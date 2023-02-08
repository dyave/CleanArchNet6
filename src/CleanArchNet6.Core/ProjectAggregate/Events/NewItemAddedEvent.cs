using CleanArchNet6.SharedKernel;

namespace CleanArchNet6.Core.ProjectAggregate.Events;

public class NewItemAddedEvent : DomainEventBase
{
  public ToDoItem NewItem { get; set; }
  public Project Project { get; set; }

  public NewItemAddedEvent(Project project,
      ToDoItem newItem)
  {
    Project = project;
    NewItem = newItem;
  }
}
