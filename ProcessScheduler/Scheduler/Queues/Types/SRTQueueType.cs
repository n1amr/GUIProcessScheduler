﻿using System;
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
      if (process.getRemainingTime() < head.getProcess().getRemainingTime())
      {
        newNode.setNext(head);
        return newNode;
      }

      // Search for the node before the inserted one
      while (head.getNext() != null)
      {
        if (process.getRemainingTime() < head.getNext().getProcess().getRemainingTime())
        {
          newNode.setNext(head.getNext());
          head.setNext(newNode);
          return null;
        }

        head = head.getNext();
      }

      head.setNext(newNode);

      return null;
    }
  }
}