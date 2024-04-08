using TaskManager.Communication.Response;

namespace TaskManager.Application.UseCases.Task.Get;
public class GetTasksUseCase
{
    public ResponseGetTasksJson Execute()
    {
        return new ResponseGetTasksJson 
        { 
            Tasks = new List<string> {"a", "b", "c"},
        };
    }
}
