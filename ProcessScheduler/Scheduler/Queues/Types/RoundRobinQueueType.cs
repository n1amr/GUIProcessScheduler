using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessScheduler.Scheduler.Queues.Types
{
  public class RoundRobinQueueType : QueueType
  {
    public int Quantum { get; set; }

    public RoundRobinQueueType(int quantum)
    {
      this.Quantum = quantum;
    }

    public override Queue.QueueNode Add(Queue.QueueNode head, Process process)
    {
      while (head.Next != null)
        head = head.Next;
      head.Next = new Queue.QueueNode(process);
      return null;
    }
  }
}
