﻿using TaskManager.Communication.Enums;

namespace TaskManager.Communication.Response;
public class ResponseGetTaskByIdJson
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public Priority Priority { get; set; }
    public DateOnly Deadline { get; set; }
    public Status Status { get; set; } = Status.AWAITING;
}
