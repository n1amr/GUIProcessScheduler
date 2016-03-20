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
  public partial class MainForm : Form
  {
    private List<Process> processes;

    public MainForm()
    {
      InitializeComponent();
      processes = new List<Process>();
    }

    private void btn_Add_Click(object sender, EventArgs e)
    {
      NewProcessForm form = new NewProcessForm();
      form.StartPosition = FormStartPosition.CenterParent;
      form.ShowDialog();
      if (form.DialogResult == DialogResult.OK)
      {
        Process process = form.process;
        lstBox_Processes.Items.Add(process.getProcessName());
        processes.Add(process);
      }
    }

    private void btn_Remove_Click(object sender, EventArgs e)
    {
      int index = lstBox_Processes.SelectedIndex;
      MessageBox.Show(index.ToString());
      if (index >= 0)
      {
        lstBox_Processes.Items.RemoveAt(index);
        processes.RemoveAt(index);
      }
    }

    private void btn_Calculate_Click(object sender, EventArgs e)
    {
      CPUScheduler cpu = null;
      int pid = 0;

      if (cmb_QueueType.SelectedItem != null)
      {
        if (cmb_QueueType.SelectedItem.ToString() == "FCFS")
        {
          cpu = new CPUScheduler(QueueType.FCFS, chk_Preemptive.Checked);
          cpu.makeInsertion(processes[0], 0);
          cpu.printQueue();
        }
      }

    }
  }
}
