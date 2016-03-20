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
    public ResultForm(List<CPUScheduler.Execution> executionList)
    {
      InitializeComponent();
      this.Text = executionList.Count.ToString();
    }
  }
}
