using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessScheduler.Scheduler.Queues.Types
{
  public class PriorityQueueType : QueueType
  {
    public override Queue.QueueNode Add(Queue.QueueNode head, Process process)
    {
      Queue.QueueNode newNode = new Queue.QueueNode(process);

      // Before head
      if (process.Priority < head.Process.Priority)
      {
        newNode.Next = head;
        return newNode;
      }

      // Search for the node before the inserted one
      while (head.Next != null)
      {
        if (process.Priority < head.Next.Process.Priority)
        {
          newNode.Next = head.Next;
          head.Next = newNode;
          return null;
        }

        head = head.Next;
      }

      head.Next = newNode;

      return null;
    }
  }
}
