using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessScheduler.Scheduler.Queues.Types
{
  public class RoundRobinQueueType : QueueType
  {
    private int period;

    public RoundRobinQueueType(int period)
    {
      this.period = period;
    }

    public int getPeriod()
    {
      return period;
    }

    public override Queue.QueueNode add(Queue.QueueNode head, Process process)
    {
      while (head.Next != null)
        head = head.Next;
      head.Next = new Queue.QueueNode(process);
      return null;
    }
  }
}
