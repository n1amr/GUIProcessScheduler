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

    public ResultForm(List<Process> processes, List<CPUScheduler.Execution> executionList)
    {
      InitializeComponent();
      this.executionList = executionList;

      totalTime = 0;
      foreach (CPUScheduler.Execution exec in executionList)
        totalTime += exec.EndTime - exec.StartTime;

      ResultForm_Resize(this, null);

      DataTable dataTable = new DataTable();
      dataTable.Columns.Add(new DataColumn("Name", typeof(string)));
      dataTable.Columns.Add(new DataColumn("Burst time", typeof(int)));
      dataTable.Columns.Add(new DataColumn("Arrival time", typeof(int)));
      dataTable.Columns.Add(new DataColumn("Departure time", typeof(int)));
      dataTable.Columns.Add(new DataColumn("Turn around time", typeof(int)));
      dataTable.Columns.Add(new DataColumn("Waiting time", typeof(int)));
      dataTable.Columns.Add(new DataColumn("Priority", typeof(int)));
      

      foreach (Process p in processes)
      {
        dataTable.Rows.Add(new object[] { p.Name,p.BurstTime, p.ArrivalTime,p.GetDepartureTime(),p.GetTurnAroundTime(), p.GetWaitingTime() ,p.Priority});
      }

      dataGridView1.DataSource = dataTable;
    }

    private void panel_Paint(object sender, PaintEventArgs e)
    {
      base.OnPaint(e);
      using (Graphics g = e.Graphics)
      {
        Pen pen = new Pen(Color.Black, 3);
        SolidBrush brush = new SolidBrush(Color.Black);
        StringFormat sf = new StringFormat();
        sf.FormatFlags = StringFormatFlags.DirectionRightToLeft;

        int HMargin = 50;
        Point leftTop = new Point(HMargin, panel.Height * 5 / 100);
        foreach (CPUScheduler.Execution exec in executionList)
        {
          int height = panel.Height * 50 / 100;
          int width = (panel.Width - HMargin * 2) * (exec.EndTime - exec.StartTime) / totalTime;
          Point leftBottom = new Point(leftTop.X, leftTop.Y + height);
          Point rightBottom = new Point(leftTop.X + width, leftTop.Y + height);
          Point rightTop = new Point(leftTop.X + width, leftTop.Y);
          Point centerPoint = new Point(leftTop.X + width / 2, leftTop.Y + height / 2);
          Point namePosition = centerPoint;
          Point timePosition = rightBottom;

          g.DrawString(exec.Process.Name, this.Font, brush, namePosition, sf);
          g.DrawString(exec.EndTime.ToString(), this.Font, brush, timePosition, sf);

          g.DrawLine(pen, leftTop, leftBottom);
          g.DrawLine(pen, rightTop, rightBottom);
          g.DrawLine(pen, leftTop, rightTop);
          g.DrawLine(pen, leftBottom, rightBottom);

          leftTop.X += width;
        }
      }
    }

    private void ResultForm_Resize(object sender, EventArgs e)
    {
      panel.Width = this.Width;
      panel.Left = 0;
      panel.Refresh();
    }
  }
}
