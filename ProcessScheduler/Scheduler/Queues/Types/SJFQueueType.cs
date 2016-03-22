using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessScheduler.Scheduler.Queues.Types
{
  public class SJFQueueType : QueueType
  {
    public override Queue.QueueNode Add(Queue.QueueNode head, Process process)
    {
      Queue.QueueNode newNode = new Queue.QueueNode(process);

      // Before head
      if (isBetter(process, head.Process))
      {
        newNode.Next = head;
        return newNode;
      }

      // Search for the node before the inserted one
      while (head.Next != null)
      {
        if (isBetter(process, head.Next.Process))
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

    private bool isBetter(Process first, Process second)
    {
      return (
        (first.GetRemainingTime() < second.GetRemainingTime()) ||
        (first.GetRemainingTime() == second.GetRemainingTime() && first.ArrivalTime < second.ArrivalTime)
      );
    }

  }
}
