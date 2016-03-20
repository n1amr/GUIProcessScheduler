using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessScheduler.Scheduler.Queues.Types
{
  public class SRTQueueType : QueueType
  {
    public override Queue.QueueNode add(Queue.QueueNode head, Process process)
    {
      Queue.QueueNode newNode = new Queue.QueueNode(process);

      // Before head
      if (process.GetRemainingTime() < head.Process.GetRemainingTime())
      {
        newNode.Next = head;
        return newNode;
      }

      // Search for the node before the inserted one
      while (head.Next != null)
      {
        if (process.GetRemainingTime() < head.Next.Process.GetRemainingTime())
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
