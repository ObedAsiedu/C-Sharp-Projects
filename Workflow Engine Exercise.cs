using System;
using System.Collections.Generic;

namespace CSharpIntermediate;



  class Program
{
    static void Main(String[] args)
    {
        var workFlow = new WorkFlow();
        workFlow.Add(new VideoUploader());
        workFlow.Add(new CallwebService());
        workFlow.Add(new SendEmail());
        workFlow.Add(new ChangeStatus());

        var engine = new WorkFlowEngine();

        engine.Run(workFlow);

        Console.ReadLine();

    }
}

 public interface ITask
{
    void Execute();

} 
public interface IWorkFlow
{
    void Add(ITask task);
    void Remove(ITask task);
    public IEnumerable<ITask> GetTasks();

}


public class WorkFlow : IWorkFlow
{
    private readonly List<ITask> _task;


    public WorkFlow()
    {
        _task = new List<ITask>();
    }

    public void Add(ITask task)
    {
        _task.Add(task);
    }

    public void Remove(ITask task)
    {
        _task.Remove(task);

    }
    public IEnumerable<ITask> GetTasks()
    {
        return _task;
    }

}
class VideoUploader : ITask
    {
    public void Execute()
    {
        Console.WriteLine("Uploading a video!");
    }

}

class CallwebService : ITask    
    {
    public void Execute()
    {
        Console.WriteLine("Calling WEB Service...");
    }
}

class SendEmail : ITask  
    {
    public void Execute()
    {
        Console.WriteLine( "Sending an Email..");
    }
}

class ChangeStatus : ITask
{
    public void Execute()
    {
        Console.WriteLine("Status changed..");
    }
}

 public class WorkFlowEngine
{
  

    public void Run(IWorkFlow workFlow)
    {
        foreach (ITask I in workFlow.GetTasks())
        {
            I.Execute();
        }
    }
}
