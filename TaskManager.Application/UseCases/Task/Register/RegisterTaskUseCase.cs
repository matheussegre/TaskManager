using TaskManager.Communication.Request;
using TaskManager.Communication.Response;

namespace TaskManager.Application.UseCases.Task.Register;
public class RegisterTaskUseCase
{
    public ResponseCreateTaskJson Execute(RequestTaskJson request)
    {
        return new ResponseCreateTaskJson 
        {
            Name = request.Name,
        };
    }
}
