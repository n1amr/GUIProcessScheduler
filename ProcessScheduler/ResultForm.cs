using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ProcessScheduler.Scheduler;
using ProcessScheduler.Scheduler.Queues;
using ProcessScheduler.Scheduler.Queues.Types;

namespace ProcessScheduler
{
  public partial class ResultForm : Form
  {
    private List<CPUScheduler.Execution> executionList;
    private int totalTime;
    private int processesCount;

    public ResultForm(List<Process> processes, List<CPUScheduler.Execution> executionList, bool priority = false)
    {
      InitializeComponent();
      this.executionList = executionList;

      totalTime = executionList[executionList.Count - 1].EndTime;
      processesCount = executionList.Count;

      DataTable dataTable = new DataTable();
      dataTable.Columns.Add(new DataColumn("Name", typeof(string)));
      dataTable.Columns.Add(new DataColumn("Burst time", typeof(int)));
      if (priority)
        dataTable.Columns.Add(new DataColumn("Priority", typeof(int)));
      dataTable.Columns.Add(new DataColumn("Arrival time", typeof(int)));
      dataTable.Columns.Add(new DataColumn("Departure time", typeof(int)));
      dataTable.Columns.Add(new DataColumn("Turn around time", typeof(int)));
      dataTable.Columns.Add(new DataColumn("Waiting time", typeof(int)));

      int totalWaitingTime = 0;
      foreach (Process p in processes)
      {
        if (priority)
          dataTable.Rows.Add(new object[] { p.Name, p.BurstTime, p.Priority, p.ArrivalTime, p.GetDepartureTime(), p.GetTurnAroundTime(), p.GetWaitingTime() });
        else
          dataTable.Rows.Add(new object[] { p.Name, p.BurstTime, p.ArrivalTime, p.GetDepartureTime(), p.GetTurnAroundTime(), p.GetWaitingTime() });
        totalWaitingTime += p.GetWaitingTime();
      }

      dataGridView.DataSource = dataTable;

      lbl.Text = String.Format("Average Waiting Time = {0}", (float)totalWaitingTime / processesCount);

      ResultForm_Resize(this, null);
    }

    private void panel_Paint(object sender, PaintEventArgs e)
    {
      base.OnPaint(e);
      using (Graphics g = e.Graphics)
      {
        int lastTime = 0;
        foreach (CPUScheduler.Execution exec in executionList)
        {
          if (exec.StartTime > lastTime)
            DrawSlot(g, panel, lastTime, exec.StartTime, totalTime, "N/A");

          DrawSlot(g, panel, exec.StartTime, exec.EndTime, totalTime, exec.Process.Name);
          lastTime = exec.EndTime;
        }
      }
    }

    private void DrawSlot(Graphics g, Panel panel, int start_time, int end_time, int total_time, string process_text)
    {
      Pen pen = new Pen(Color.Black, 2);
      SolidBrush brush = new SolidBrush(Color.Black);
      StringFormat sf = new StringFormat();
      sf.FormatFlags = StringFormatFlags.DirectionRightToLeft;

      int HMargin = 50;
      int total_width = panel.Width - HMargin * 2;

      int height = panel.Height * 50 / 100;
      int width = total_width * (end_time - start_time) / total_time;

      Point leftTop = new Point(HMargin + total_width * start_time / total_time, panel.Height * 5 / 100);
      Point leftBottom = new Point(leftTop.X, leftTop.Y + height);
      Point rightBottom = new Point(leftTop.X + width, leftTop.Y + height);
      Point rightTop = new Point(leftTop.X + width, leftTop.Y);
      Point centerPoint = new Point(leftTop.X + width / 2, leftTop.Y + height / 2);
      Point textPosition = centerPoint;
      Point timePosition = rightBottom;

      textPosition.X += (int)(process_text.Count() * 4.5);
      textPosition.Y -= 5;
      g.DrawString(process_text, this.Font, brush, textPosition, sf);
      g.DrawString(end_time.ToString(), this.Font, brush, timePosition, sf);

      g.DrawLine(pen, leftTop, leftBottom);
      g.DrawLine(pen, rightTop, rightBottom);
      g.DrawLine(pen, leftTop, rightTop);
      g.DrawLine(pen, leftBottom, rightBottom);
    }

    private void ResultForm_Resize(object sender, EventArgs e)
    {
      panel.Width = this.Width;
      panel.Left = 0;
      panel.Refresh();

      dataGridView.Left = 0;
      dataGridView.Width = this.Width - 15;
      dataGridView.Height = this.Height - dataGridView.Top - 40;

      lbl.Left = (this.Width - lbl.Width) / 2;
    }
  }
}
