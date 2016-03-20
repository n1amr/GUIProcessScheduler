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
    private int totalTime = 0;
    public ResultForm(List<CPUScheduler.Execution> executionList)
    {
      InitializeComponent();
      this.executionList = executionList;
      foreach (CPUScheduler.Execution exec in executionList)
      {
        totalTime += exec.getEndTime() - exec.getStartTime();
      }
      ResultForm_Resize(this, null);
    }

    private void panel_Paint(object sender, PaintEventArgs e)
    {
      base.OnPaint(e);
      using (Graphics g = e.Graphics)
      {
        Pen pen = new Pen(Color.Black, 3);
        SolidBrush brush = new SolidBrush(Color.Red);
        StringFormat sf = new StringFormat();
        sf.FormatFlags = StringFormatFlags.DirectionRightToLeft;

        Point leftTop = new Point(panel.Width * 1 / 10, panel.Height * 5 / 100);
        foreach (CPUScheduler.Execution exec in executionList)
        {
          int height = panel.Height * 50 / 100;
          int width = (panel.Width * 8 / 10) * (exec.getEndTime() - exec.getStartTime()) / totalTime;
          Point leftBottom = new Point(leftTop.X, leftTop.Y + height);
          Point rightBottom = new Point(leftTop.X + width, leftTop.Y + height);
          Point rightTop = new Point(leftTop.X + width, leftTop.Y);
          Point centerPoint = new Point(leftTop.X + width / 2, leftTop.Y + height / 2);
          Point namePosition = centerPoint;
          Point timePosition = rightBottom;

          g.DrawString(exec.getProcess().getProcessName(), this.Font, brush, namePosition, sf);
          g.DrawString(exec.getEndTime().ToString(), this.Font, brush, timePosition, sf);

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
      panel.Height = this.Height;
      panel.Width = this.Width;
      panel.Top = 0;
      panel.Left = 0;
      panel.Refresh();
    }
  }
}
