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
    public int BurstTime { get; private set; }
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

    public void ResetRemainingTime()
    {
      remainingTime = BurstTime;
    }

    public void SetBurstTime(int time)
    {
      this.BurstTime = time;
      ResetRemainingTime();
    }

    public override String ToString()
    {
      return String.Format("Process\tname: {0}\tPID: {1}\tduration: {2}\tremaining_time: {3}\tpriority: {4}", Name, PID, BurstTime, remainingTime, Priority);
    }
  }
}
