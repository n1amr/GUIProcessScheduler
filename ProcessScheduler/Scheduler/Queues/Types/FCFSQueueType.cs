using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessScheduler.Scheduler.Queues.Types
{
  public class FCFSQueueType : QueueType
  {
    public override Queue.QueueNode Add(Queue.QueueNode head, Process process)
    {
      while (head.Next != null)
        head = head.Next;
      head.Next = new Queue.QueueNode(process);
      return null;
    }
  }
}
