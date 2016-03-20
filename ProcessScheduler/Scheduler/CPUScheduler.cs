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


    public void printQueue()
    {
      foreach (Process process in queue)
      {
        Console.WriteLine("    " + process);
      }
    }


    public List<Execution> startExecution()
    {
      insertions.Sort();

      foreach (Insertion i in insertions)
      {
        Console.WriteLine(i.getProcess());
      }

      Process runningProcess = null;
      Execution execution = null;
      for (int t = 0; insertions.Count != 0 || !queue.isEmpty() || runningProcess != null; t++)
      {
        Console.WriteLine("<<<<  Time #" + t + "  >>>>");

        // Add processes
        while (insertions.Count != 0 && t == insertions[0].getTimeOfInsertion())
        {
          processes.Add(insertions[0].getProcess());
          queue.add(insertions[0].getProcess());
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
              switchProcess = (runningProcess.getRemainingTime() > queue.getFirst().getRemainingTime());
            }
            else if (queue.getQueueType() == QueueType.PRIORITY)
            {
              switchProcess = (runningProcess.getPriority() > queue.getFirst().getPriority());
            }
            else if (queue.getQueueType() is RoundRobinQueueType)
            {
              switchProcess = (execution.getEndTime() - execution.getStartTime()) >= ((RoundRobinQueueType)queue.getQueueType()).getPeriod();
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
          execution.setEndTime(execution.getEndTime() + 1);

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
