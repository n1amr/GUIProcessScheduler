using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessScheduler
{
  class Process
  {
    private String processName;
    private int pid;
    private int duration;
    private int remainingTime;
    private int priority;

    public Process(String processName, int pid, int time, int priority)
    {
      this.processName = processName;
      this.pid = pid;
      this.duration = time;
      this.priority = priority;
      remainingTime = duration;
    }

    public Process(int pid) : this(null, pid, 0, -1)
    {
    }

    public void decrementRemiainingTime()
    {
      if (!isFinished())
        remainingTime--;
    }

    public int getRemainingTime()
    {
      return remainingTime;
    }

    public bool isFinished()
    {
      return remainingTime == 0;
    }

    public void setDuration(int time)
    {
      this.duration = time;
    }

    public int getduration()
    {
      return duration;
    }

    public String getProcessName()
    {
      return processName;
    }

    public void setProcessName(String processName)
    {
      this.processName = processName;
    }

    public int getPid()
    {
      return pid;
    }

    public void setPid(int pid)
    {
      this.pid = pid;
    }

    public int getPriority()
    {
      return priority;
    }

    public void setPriority(int priority)
    {
      this.priority = priority;
    }

    public override String ToString()
    {
      return String.Format("Process: { name: %s, PID: %d, duration: %d, remaining_time: %d, priority: %d }", processName, pid, duration, remainingTime, priority);
    }


  }
}
