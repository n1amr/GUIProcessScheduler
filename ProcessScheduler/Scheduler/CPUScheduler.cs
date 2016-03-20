using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProcessScheduler.Scheduler.Queues;
using ProcessScheduler.Scheduler.Queues.Types;


namespace ProcessScheduler.Scheduler
{
  public class CPUScheduler
  {
    private bool preemptive;
    private Queue queue;
    private List<Insertion> insertions;
    private List<Execution> executionList;
    private List<Process> processes;

    public CPUScheduler(QueueType queueType, bool preemptive)
    {
      queue = new Queue(queueType);
      this.preemptive = preemptive;
      insertions = new List<Insertion>();
      executionList = new List<Execution>();
      processes = new List<Process>();
    }

    public void makeInsertion(Process process, int timeOfInsertion)
    {
      insertions.Add(new Insertion(process, timeOfInsertion));
    }


    public void printQueue() {
    foreach(Process process in queue) {
      Console.WriteLine("    " + process);
    }
  }

    public class Insertion : IComparable<Insertion>
    {
      private Process process;
      private int timeOfInsertion;

      public Insertion(Process process, int timeOfInsertion)
      {
        this.process = process;
        this.timeOfInsertion = timeOfInsertion;
      }

      public int CompareTo(Insertion o)
      {
        return timeOfInsertion - o.timeOfInsertion;
      }

      public Process getProcess()
      {
        return process;
      }

      public void setProcess(Process process)
      {
        this.process = process;
      }

      public int getTimeOfInsertion()
      {
        return timeOfInsertion;
      }

      public void setTimeOfInsertion(int timeOfInsertion)
      {
        this.timeOfInsertion = timeOfInsertion;
      }
    }

    public class Execution : IComparable<Execution>
    {
      private Process process;
      private int startTime;
      private int endTime;

      public Execution(Process process, int startTime, int endTime)
      {
        this.process = process;
        this.startTime = startTime;
        this.endTime = endTime;
      }

      public int CompareTo(Execution o)
      {
        return startTime - o.startTime;
      }

      public Process getProcess()
      {
        return process;
      }

      public void setProcess(Process process)
      {
        this.process = process;
      }

      public int getStartTime()
      {
        return startTime;
      }

      public void setStartTime(int startTime)
      {
        this.startTime = startTime;
      }

      public int getEndTime()
      {
        return endTime;
      }

      public void setEndTime(int endTime)
      {
        this.endTime = endTime;
      }
    }
  }
}
