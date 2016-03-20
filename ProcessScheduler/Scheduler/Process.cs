using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessScheduler
{
  public class Process
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
      remainingTime = duration;
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
      return String.Format("Process\n\tname: {0}\n\tPID: {1}\n\tduration: {2}\n\tremaining_time: {3}\n\tpriority: {4}", processName, pid, duration, remainingTime, priority);
    }


  }
}
