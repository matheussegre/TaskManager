using TaskManager.Communication.Response;

namespace TaskManager.Application.UseCases.Task.Get;
public class GetTaskByIdUseCase
{
    public ResponseGetTaskByIdJson Execute(Guid taskId)
    {
        return new ResponseGetTaskByIdJson { Id = taskId, Name = "Task_Name" };
    }
}
