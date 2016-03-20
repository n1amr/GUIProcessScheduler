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
    private int queue_type;

    public MainForm()
    {
      InitializeComponent();
      processes = new List<Process>();
      cmb_QueueType.SelectedIndex = 0;

      //for (int i = 0; i < 5; i++)
      //{
      //  Process p = new Process(String.Format("P{0}", i), i, i, 10 - i, 0);
      //  processes.Add(p);
      //  lstBox_Processes.Items.Add(p.getProcessName());
      //}

      //btn_Calculate_Click(this, null);
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
        btn_Edit.Enabled = true;
        btn_Remove.Enabled = true;
      }
    }

    private void btn_Edit_Click(object sender, EventArgs e)
    {
      int index = lstBox_Processes.SelectedIndex;
      if (index >= 0)
      {
        NewProcessForm form = new NewProcessForm(processes[index]);
        form.StartPosition = FormStartPosition.CenterParent;
        form.ShowDialog();
        if (form.DialogResult == DialogResult.OK)
        {
          Process process = form.getProcess();
          lstBox_Processes.Items[index] = process.getProcessName();
          processes[index] = process;
        }
      }
    }


    private void btn_Remove_Click(object sender, EventArgs e)
    {
      int index = lstBox_Processes.SelectedIndex;
      if (index >= 0)
      {
        lstBox_Processes.Items.RemoveAt(index);
        processes.RemoveAt(index);

        if (processes.Count == 0)
        {
          btn_Edit.Enabled = false;
          btn_Remove.Enabled = false;
        }
      }
    }

    private void btn_Calculate_Click(object sender, EventArgs e)
    {
      CPUScheduler cpu = null;
      int pid = 0;

      if (cmb_QueueType.SelectedItem != null)
      {
        QueueType queueType = null;
        if (queue_type == 0)
        {
          queueType = QueueType.FCFS;
        }
        else if (queue_type == 1)
        {
          queueType = QueueType.SHORTEST_REMAINING_TIME;
        }
        else if (queue_type == 2)
        {
          queueType = QueueType.PRIORITY;
        }
        else if (queue_type == 3)
        {
          queueType = new RoundRobinQueueType((int)numUpDn_Quantum.Value);
        }

        cpu = new CPUScheduler(queueType, chk_Preemptive.Checked);

        foreach (Process p in processes)
        {
          cpu.Insert(p);
        }
        List<CPUScheduler.Execution> executionList = cpu.startExecution();
        ResultForm resultForm = new ResultForm(executionList);
        resultForm.Show();

      }
    }



    private void cmb_QueueType_SelectedIndexChanged(object sender, EventArgs e)
    {
      string selection = cmb_QueueType.SelectedItem.ToString();
      if (selection.Equals("FCFS"))
      {
        queue_type = 0;
        chk_Preemptive.Checked = false;
      }
      else if (selection.Equals("SJF"))
      {
        queue_type = 1;
      }
      else if (selection.Equals("Priority"))
      {
        queue_type = 2;
      }
      else if (selection.Equals("Round Robin"))
      {
        queue_type = 3;
        chk_Preemptive.Checked = true;
      }

      chk_Preemptive.Enabled = queue_type == 1 || queue_type == 2;
      numUpDn_Quantum.Enabled = queue_type == 3;
    }
  }
}
