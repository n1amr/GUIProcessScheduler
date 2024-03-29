﻿using System;
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
    private int queue_type;

    public MainForm()
    {
      InitializeComponent();
      cmb_QueueType.SelectedIndex = 0;

      Random random = new Random(System.Environment.TickCount);
      for (int i = 1; i <= 5; i++)
      {
        Process p = new Process(String.Format("P{0}", i), i, random.Next(1, 10), random.Next(1, 10), i + random.Next(0, 20));
        lstBox_Processes.Items.Add(p);
      }

      CheckButtonsStatus();
    }

    private void btn_Add_Click(object sender, EventArgs e)
    {
      EditProcessForm form = new EditProcessForm(null, queue_type == 2);
      form.StartPosition = FormStartPosition.CenterParent;
      form.Text = "New Process";
      form.ShowDialog();
      if (form.DialogResult == DialogResult.OK)
      {
        Process process = form.process;
        lstBox_Processes.Items.Add(process);
      }
      CheckButtonsStatus();
    }

    private void btn_Edit_Click(object sender, EventArgs e)
    {
      foreach (int index in lstBox_Processes.SelectedIndices)
      {
        Process process = (Process)lstBox_Processes.Items[index];
        EditProcessForm form = new EditProcessForm(process, queue_type == 2);
        form.StartPosition = FormStartPosition.CenterParent;
        form.ShowDialog();
        if (form.DialogResult == DialogResult.OK)
          lstBox_Processes.Items[index] = form.getProcess();
      }
    }

    private void btn_Remove_Click(object sender, EventArgs e)
    {
      for (int i = lstBox_Processes.SelectedItems.Count - 1; i >= 0; i--)
        lstBox_Processes.Items.RemoveAt(lstBox_Processes.SelectedIndices[i]);

      CheckButtonsStatus();
    }

    private void btn_Calculate_Click(object sender, EventArgs e)
    {
      CPUScheduler cpu = null;
      int pid = 0;

      if (cmb_QueueType.SelectedItem != null)
      {
        QueueType queueType = null;
        if (queue_type == 0)
          queueType = QueueType.FCFS;
        else if (queue_type == 1)
          queueType = QueueType.SJF;
        else if (queue_type == 2)
          queueType = QueueType.PRIORITY;
        else if (queue_type == 3)
          queueType = new RoundRobinQueueType((int)numUpDn_Quantum.Value);

        cpu = new CPUScheduler(queueType, chk_Preemptive.Checked);

        foreach (Process p in lstBox_Processes.Items)
          cpu.Insert(p);

        List<CPUScheduler.Execution> executionList = cpu.StartExecution();
        List<Process> processes = new List<Process>();
        foreach (Process p in lstBox_Processes.Items)
          processes.Add(p);

        ResultForm resultForm = new ResultForm(processes, executionList, queue_type == 2);
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
        queue_type = 1;
      else if (selection.Equals("Priority"))
        queue_type = 2;
      else if (selection.Equals("Round Robin"))
      {
        queue_type = 3;
        chk_Preemptive.Checked = true;
      }

      chk_Preemptive.Enabled = queue_type == 1 || queue_type == 2;
      numUpDn_Quantum.Enabled = queue_type == 3;
    }

    private void btn_MoveUp_Click(object sender, EventArgs e)
    {
      int index = lstBox_Processes.SelectedIndex;
      if (index > 0)
      {

        object temp = lstBox_Processes.Items[index];
        lstBox_Processes.Items[index] = lstBox_Processes.Items[index - 1];
        lstBox_Processes.Items[index - 1] = temp;
        lstBox_Processes.SelectedIndex--;
      }
    }

    private void btn_MoveDown_Click(object sender, EventArgs e)
    {
      int index = lstBox_Processes.SelectedIndex;
      if (index + 1 < lstBox_Processes.Items.Count)
      {
        object temp = lstBox_Processes.Items[index];
        lstBox_Processes.Items[index] = lstBox_Processes.Items[index + 1];
        lstBox_Processes.Items[index + 1] = temp;
        lstBox_Processes.SelectedIndex++;
      }
    }

    private void btn_RemoveAll_Click(object sender, EventArgs e)
    {
      lstBox_Processes.Items.Clear();
      CheckButtonsStatus();
    }

    private void CheckButtonsStatus()
    {
      bool enable = lstBox_Processes.SelectedIndex != -1;

      btn_Edit.Enabled = enable;
      btn_Remove.Enabled = enable;
      btn_RemoveAll.Enabled = enable || lstBox_Processes.Items.Count != 0;
      btn_MoveUp.Enabled = enable;
      btn_MoveDown.Enabled = enable;
    }

    private void lstBox_Processes_SelectedIndexChanged(object sender, EventArgs e)
    {
      CheckButtonsStatus();
    }

    private void lstBox_Processes_DoubleClick(object sender, EventArgs e)
    {
      btn_Edit_Click(sender, e);
    }
  }
}
