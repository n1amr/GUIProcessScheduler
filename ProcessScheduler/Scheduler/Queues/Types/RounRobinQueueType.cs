using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessScheduler.Scheduler.Queues.Types
{
  public class RounRobinQueueType : QueueType
  {
    private int period;
    
    public RounRobinQueueType(int period)
    {
      this.period = period;
    }

    public int getPeriod()
    {
      return period;
    }

    public override Queue.QueueNode add(Queue.QueueNode head, Process process)
    {
      while (head.getNext() != null)
        head = head.getNext();
      head.setNext(new Queue.QueueNode(process));
      return null;
    }
  }
}
