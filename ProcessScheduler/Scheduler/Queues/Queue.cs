using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProcessScheduler.Scheduler.Queues.Types;

namespace ProcessScheduler.Scheduler.Queues
{
  public class Queue : IEnumerable<Process>
  {
    private QueueNode head;
    private QueueType queueType;

    public Queue(QueueType queueType)
    {
      head = null;
      this.queueType = queueType;
    }

    public void remove()
    {
      if (!isEmpty())
        head = head.getNext();
    }

    public Process getFirst()
    {
      return head.getProcess();
    }

    public bool isEmpty()
    {
      return head == null;
    }

    public void add(Process process)
    {
      if (head == null)
        head = new QueueNode(process);
      else
      {
        QueueNode response = queueType.add(head, process);
        if (response != null)
        {
          head = response;
        }
      }
    }

    public void setQueueType(QueueType queueType)
    {
      this.queueType = queueType;
    }

    public QueueType getQueueType()
    {
      return queueType;
    }

    public IEnumerator<Process> GetEnumerator()
    {
      return new Iterator(head);
    }

    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
      return GetEnumerator();
    }

    private class Iterator : IEnumerator<Process>
    {
      private QueueNode front;
      private QueueNode current;
      public virtual Process Current
      {
        get
        {
          return current.getProcess();
        }
      }

      object System.Collections.IEnumerator.Current
      {
        get
        {
          return Current;
        }
      }


      public Iterator(QueueNode f)
      {
        front = f;
        current = front;
      }

      public bool MoveNext()
      {
        if (current != null && current.getNext() != null)
        {
          current = current.getNext();
          return true;
        }
        else
        {
          return false;
        }
      }

      public void Reset()
      {
        current = front;
      }

      public void Dispose()
      {

        //throw new Exception("Unsupported Operation");
      }
    }


    public class QueueNode
    {
      private Process process;
      private QueueNode next;

      public QueueNode(Process process)
      {
        this.process = process;
      }

      public Process getProcess()
      {
        return process;
      }

      public void setProcess(Process process)
      {
        this.process = process;
      }

      public QueueNode getNext()
      {
        return next;
      }

      public void setNext(QueueNode next)
      {
        this.next = next;
      }

    }

  }
}
