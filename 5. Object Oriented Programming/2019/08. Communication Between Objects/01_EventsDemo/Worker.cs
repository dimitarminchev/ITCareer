using System;
using System.Threading;

// Work
public class Worker
{
    // Delegate
    public delegate void WorkPerfHandler(WorkPerformedEventArgs e);

    // Event
    public event WorkPerfHandler WorkPerformed;

    // Job Start
    public virtual void DoWork(WorkPerformedEventArgs e)
    {
        // Time Consuming Work
        Console.WriteLine("Start {0} ...", e.Name);
        var time = e.Hours * 1000;
        Thread.Sleep(time);

        // Event Invocation
        WorkPerformed?.Invoke(e);
    }

    // On Job Finished
    public void workPerformed(WorkPerformedEventArgs e)
    {
        Console.WriteLine("Finished after {0} hours", e.Hours);
    }

}