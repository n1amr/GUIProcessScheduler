using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProcessScheduler.Scheduler;

namespace ProcessScheduler
{
  public class Process
  {
    public String Name { get; set; }
    public int PID { get; set; }
    public int BurstTime { get; private set; }
    private int remainingTime { get; set; }
    public int Priority { get; set; }
    public int ArrivalTime { get; set; }
    public System.Drawing.Color Color { get; set; }
    private List<CPUScheduler.Execution> ExecutionList;
    private int departureTime;
    public Process(String processName, int pid, int time, int priority, int arrivalTime)
    {
      this.Name = processName;
      this.PID = pid;
      this.BurstTime = time;
      this.Priority = priority;
      this.ArrivalTime = arrivalTime;
      this.Color = System.Drawing.Color.FromArgb(0xffffff);


      ResetCalculations();
    }

    public Process(int pid)
      : this(null, pid, 1, -1, 0)
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

    public void ResetCalculations()
    {
      remainingTime = BurstTime;
      ExecutionList = new List<CPUScheduler.Execution>();
      departureTime = -1;
    }

    public void SetBurstTime(int time)
    {
      this.BurstTime = time;
      ResetCalculations();
    }

    public override String ToString()
    {
      return String.Format("Process\tname: {0}\tPID: {1}\tduration: {2}\tremaining_time: {3}\tpriority: {4}", Name, PID, BurstTime, remainingTime, Priority);
    }

    public int GetDepartureTime()
    {
      if (departureTime == -1)
        foreach (CPUScheduler.Execution e in ExecutionList)
          if (departureTime < e.EndTime)
            departureTime = e.EndTime;

      return departureTime;
    }

    public int GetTurnAroundTime()
    {
      return GetDepartureTime() - ArrivalTime;
    }

    public int GetWaitingTime()
    {
      return GetTurnAroundTime() - BurstTime;
    }

    public void AddExecution(CPUScheduler.Execution e)
    {
      departureTime = -1;
      ExecutionList.Add(e);
    }
  }
}
