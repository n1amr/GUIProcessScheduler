﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessScheduler.Scheduler.Queues.Types
{
  public abstract class QueueType
  {
    /***
 * return a node if you want to replace it with head node, otherwise you
 * <b>must</b> return null
  ***/
    public abstract Queue.QueueNode add(Queue.QueueNode list, Process process);

    public static readonly QueueType FCFS = new FCFSQueueType();

  }
}