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
    public QueueType QueueType { get; set; }

    public Queue(QueueType queueType)
    {
      head = null;
      this.QueueType = queueType;
    }

    public void remove()
    {
      if (!isEmpty())
        head = head.Next;
    }

    public Process getFirst()
    {
      return head.Process;
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
        QueueNode response = QueueType.Add(head, process);
        if (response != null)
        {
          head = response;
        }
      }
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
      private QueueNode althead;
      private QueueNode front;
      private QueueNode current;
      public virtual Process Current
      {
        get
        {
          return current.Process;
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
        althead = new QueueNode(null);
        althead.Next = f;
        current = althead;
      }

      public bool MoveNext()
      {
        if (current != null && current.Next != null)
        {
          current = current.Next;
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
      public Process Process { get; set; }
      public QueueNode Next { get; set; }

      public QueueNode(Process Process)
      {
        this.Process = Process;
      }
    }

  }
}
