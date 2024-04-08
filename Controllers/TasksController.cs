using Microsoft.AspNetCore.Mvc;
using TaskManager.Application.UseCases.Task.Delete;
using TaskManager.Application.UseCases.Task.Get;
using TaskManager.Application.UseCases.Task.Register;
using TaskManager.Application.UseCases.Task.Update;
using TaskManager.Communication.Request;
using TaskManager.Communication.Response;

namespace TaskManager.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class TasksController : ControllerBase
{
    [HttpGet]
    [ProducesResponseType(typeof(ResponseGetTaskByIdJson), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseGetTaskByIdJson), StatusCodes.Status404NotFound)]
    public IActionResult GetAllTasks()
    {
        var useCase = new GetTasksUseCase();

        var response = useCase.Execute();

        return Ok(response);
    }

    [HttpGet]
    [Route("{taskId}")]
    [ProducesResponseType(typeof(ResponseGetTaskByIdJson), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseGetTaskByIdJson), StatusCodes.Status404NotFound)]
    public IActionResult GetTaskById([FromRoute] Guid taskId)
    {
        var useCase = new GetTaskByIdUseCase();

        var response = useCase.Execute(taskId);

        return Ok(response);
    }

    [HttpPost]
    [ProducesResponseType(typeof(ResponseCreateTaskJson),StatusCodes.Status201Created)]
    public IActionResult CreateTask([FromBody] RequestTaskJson request)
    {
        var useCase = new RegisterTaskUseCase();

        var response = useCase.Execute(request);

        return Created(string.Empty, response);
    }

    [HttpPut]
    [Route("{taskId}")]
    [ProducesResponseType(typeof(ResponseUpdateTaskJson), StatusCodes.Status204NoContent)]
    public IActionResult UpdateTask([FromRoute] Guid taskId, [FromBody] RequestTaskJson request)
    {
        var useCase = new UpdateTaskUseCase();

        useCase.Execute(taskId, request);

        return NoContent();
    }

    [HttpDelete]
    [Route("{taskId}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrosJson), StatusCodes.Status404NotFound)]
    public IActionResult DeleteTask([FromRoute] Guid taskId)
    {
        var useCase = new DeleteTaskByIdUseCase();

        useCase.Execute(taskId);

        return NoContent();
    }
}
