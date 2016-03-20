using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessScheduler
{
  public class Process
  {
    public String Name { get; set; }
    public int PID { get; set; }
    public int BurstTime { get; set; }
    public int remainingTime { get; private set; }
    public int Priority { get; set; }
    public int ArrivalTime { get; set; }

    public Process(String processName, int pid, int time, int priority, int arrivalTime)
    {
      this.Name = processName;
      this.PID = pid;
      this.BurstTime = time;
      this.Priority = priority;
      this.remainingTime = BurstTime;
      this.ArrivalTime = arrivalTime;
    }

    public Process(int pid)
      : this(null, pid, 0, -1, 0)
    {
    }

    public void decrementRemiainingTime()
    {
      if (!isFinished())
        remainingTime--;
    }

    public int GetRemainingTime()
    {
      return remainingTime;
    }

    public bool isFinished()
    {
      return remainingTime == 0;
    }

    public void setDuration(int time)
    {
      this.BurstTime = time;
      remainingTime = BurstTime;
    }

    public int getduration()
    {
      return BurstTime;
    }

    public String getProcessName()
    {
      return Name;
    }

    public void setProcessName(String processName)
    {
      this.Name = processName;
    }

    public int getPid()
    {
      return PID;
    }

    public void setPid(int pid)
    {
      this.PID = pid;
    }

    public int getPriority()
    {
      return Priority;
    }

    public void setPriority(int priority)
    {
      this.Priority = priority;
    }
    public int getArrivalTime()
    {
      return ArrivalTime;
    }

    public void setArrivalTime(int arrivalTime)
    {
      this.ArrivalTime = arrivalTime;
    }

    public override String ToString()
    {
      //return String.Format("Process\n\tname: {0}\n\tPID: {1}\n\tduration: {2}\n\tremaining_time: {3}\n\tpriority: {4}", processName, pid, duration, remainingTime, priority);
      return String.Format("Process\tname: {0}\tPID: {1}\tduration: {2}\tremaining_time: {3}\tpriority: {4}", Name, PID, BurstTime, remainingTime, Priority);
    }


  }
}
