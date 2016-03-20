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

    public void Insert(Process process)
    {
      process.ResetRemainingTime();
      insertions.Add(new Insertion(process, process.ArrivalTime));
    }


    private void printQueue()
    {
      foreach (Process process in queue)
      {
        Console.WriteLine("    " + process);
      }
    }


    public List<Execution> StartExecution()
    {
      insertions.Sort();

      foreach (Insertion i in insertions)
      {
        Console.WriteLine(i.Process);
      }

      Process runningProcess = null;
      Execution execution = null;
      for (int t = 0; insertions.Count != 0 || !queue.isEmpty() || runningProcess != null; t++)
      {
        Console.WriteLine("<<<<  Time #" + t + "  >>>>");

        // Add processes
        while (insertions.Count != 0 && t == insertions[0].InsertionTime)
        {
          processes.Add(insertions[0].Process);
          queue.add(insertions[0].Process);
          insertions.RemoveAt(0);
        }

        // Select Process
        if (!queue.isEmpty())
        {
          if (runningProcess == null)
          {
            runningProcess = queue.getFirst();
            queue.remove();
            execution = new Execution(runningProcess, t, t);
          }
          else if (preemptive)
          {
            bool switchProcess = false;

            if (queue.getQueueType() == QueueType.FCFS)
            {
              switchProcess = false;
            }
            else if (queue.getQueueType() == QueueType.SHORTEST_REMAINING_TIME)
            {
              switchProcess = (runningProcess.GetRemainingTime() > queue.getFirst().GetRemainingTime());
            }
            else if (queue.getQueueType() == QueueType.PRIORITY)
            {
              switchProcess = (runningProcess.Priority > queue.getFirst().Priority);
            }
            else if (queue.getQueueType() is RoundRobinQueueType)
            {
              switchProcess = (execution.EndTime - execution.StartTime) >= ((RoundRobinQueueType)queue.getQueueType()).getPeriod();
            }

            if (switchProcess)
            {
              executionList.Add(execution);
              queue.add(runningProcess);
              runningProcess = queue.getFirst();
              queue.remove();
              execution = new Execution(runningProcess, t, t);
            }
          }
        }

        Console.WriteLine(" -> " + runningProcess);
        printQueue();

        // Execute unit time of a process
        if (runningProcess != null)
        {
          runningProcess.decrementRemiainingTime();
          execution.EndTime++;

          // Remove process from queue and add an execution entry
          if (runningProcess.isFinished())
          {
            executionList.Add(execution);
            runningProcess = null;
            execution = null;
          }
        }
      }
      return executionList;
    }
    public class Insertion : IComparable<Insertion>
    {
      public Process Process { get; set; }
      public int InsertionTime { get; set; }

      public Insertion(Process Process, int TimeOfInsertion)
      {
        this.Process = Process;
        this.InsertionTime = TimeOfInsertion;
      }

      public int CompareTo(Insertion o)
      {
        return InsertionTime - o.InsertionTime;
      }
    }

    public class Execution : IComparable<Execution>
    {
      public Process Process { get; set; }
      public int StartTime { get; set; }
      public int EndTime { get; set; }

      public Execution(Process Process, int StartTime, int EndTime)
      {
        this.Process = Process;
        this.StartTime = StartTime;
        this.EndTime = EndTime;
      }

      public int CompareTo(Execution o)
      {
        return StartTime - o.StartTime;
      }
    }
  }
}
