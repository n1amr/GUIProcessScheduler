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

      for (int i = 0; i < 5; i++)
      {
        Process p = new Process(String.Format("P{0}", i), i, i, 10 - i, 0);
        processes.Add(p);
        lstBox_Processes.Items.Add(p.getProcessName());
      }
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

      //if (cmb_QueueType.SelectedItem != null)
      {
        //if (cmb_QueueType.SelectedItem.ToString() == "FCFS")
        {
          //cpu = new CPUScheduler(QueueType.FCFS, chk_Preemptive.Checked);
          cpu = new CPUScheduler(QueueType.FCFS, false);

          foreach (Process p in processes)
          {
            cpu.makeInsertion(p, p.getArrivalTime());
          }
        }
      }
      List<CPUScheduler.Execution> executionList = cpu.startExecution();
      ResultForm resultForm = new ResultForm(executionList);
      resultForm.Show();
    }
  }
}
