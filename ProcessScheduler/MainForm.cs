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
    private int queue_type;
    private List<Process> processes;

    public MainForm()
    {
      InitializeComponent();
      cmb_QueueType.SelectedIndex = 0;

      processes = new List<Process>();

      Random random = new Random(System.Environment.TickCount);
      //for (int i = 1; i <= 5; i++)
      //{
      //  Process p = new Process(String.Format("P{0}", i), i, random.Next(1, 10), random.Next(1, 10), i + random.Next(0, 20));
      //  lstBox_Processes.Items.Add(p);
      //}
      //lstBox_Processes.Items.Add(new Process("P1", 0, 10, -1, 0));
      //lstBox_Processes.Items.Add(new Process("P2", 0, 2, -1, 6));
      //lstBox_Processes.Items.Add(new Process("P3", 0, 2, -1, 7));
      //lstBox_Processes.Items.Add(new Process("P4", 0, 4, -1, 8));
      //lstBox_Processes.Items.Add(new Process("P5", 0, 4, -1, 9));

      refreshGrid();

      CheckButtonsStatus();
    }

    private void refreshGrid()
    {
      DataTable dataTable = new DataTable();
      dataTable.Columns.Add(new DataColumn("Name", typeof(string)));
      dataTable.Columns.Add(new DataColumn("Burst time", typeof(int)));
      if (queue_type == 2)
        dataTable.Columns.Add(new DataColumn("Priority", typeof(int)));
      dataTable.Columns.Add(new DataColumn("Arrival time", typeof(int)));

      foreach (Process p in processes)
      {
        if (queue_type == 2)
          dataTable.Rows.Add(new object[] { p.Name, p.BurstTime, p.Priority, p.ArrivalTime });
        else
          dataTable.Rows.Add(new object[] { p.Name, p.BurstTime, p.ArrivalTime });
      }
      dataGridView.DataSource = dataTable;
    }
    private void refreshProcesses()
    {
      while (processes.Count != 0)
        processes.RemoveAt(0);


      for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
      {
        DataGridViewRow r = dataGridView.Rows[i];
        string name = r.Cells[0].Value as string;
        int? bursttime = r.Cells[1].Value as int?;
        int? priority = -1, arrivaltime;
        arrivaltime = r.Cells[2].Value as int?;
        if (queue_type == 2)
        {
          priority = r.Cells[2].Value as int?;
          arrivaltime = r.Cells[3].Value as int?;
        }
        processes.Add(new Process(name ?? "Untitled", 0, bursttime ?? 1, priority ?? -1, arrivaltime ?? 0));
      }
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
        processes.Add(process);
      }
      refreshGrid();
      CheckButtonsStatus();
    }

    private void btn_Edit_Click(object sender, EventArgs e)
    {
      //int index = lstBox_Processes.SelectedIndex;
      //if (index >= 0)
      //{
      //  Process process = (Process)lstBox_Processes.Items[index];
      //  EditProcessForm form = new EditProcessForm(process, queue_type == 2);
      //  form.StartPosition = FormStartPosition.CenterParent;
      //  form.ShowDialog();
      //  if (form.DialogResult == DialogResult.OK)
      //    lstBox_Processes.Items[index] = form.getProcess();
      //}

      List<int> rows = new List<int>();
      foreach (DataGridViewCell c in dataGridView.SelectedCells)
        if (!rows.Contains(c.RowIndex))
          rows.Add(c.RowIndex);
      rows.Sort();

      for (int i = 0; i < rows.Count; i++)
      {
        Process process = processes[i];
        EditProcessForm form = new EditProcessForm(process, queue_type == 2);
        form.StartPosition = FormStartPosition.CenterParent;
        form.ShowDialog();
        if (form.DialogResult == DialogResult.OK)
        {
          processes[i] = form.getProcess();
        }
      }
      refreshGrid();
    }

    private void btn_Remove_Click(object sender, EventArgs e)
    {
      //int index = lstBox_Processes.SelectedIndex;
      //if (index >= 0)
      //  lstBox_Processes.Items.RemoveAt(index);

      List<int> rows = new List<int>();
      foreach (DataGridViewCell c in dataGridView.SelectedCells)
        if (!rows.Contains(c.RowIndex))
          rows.Add(c.RowIndex);
      rows.Sort();
      for (int i = rows.Count - 1; i >= 0; i--)
        processes.RemoveAt(i);

      refreshGrid();
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

        //foreach (Process p in lstBox_Processes.Items)
        //  cpu.Insert(p);
        foreach (Process p in processes)
          cpu.Insert(p);

        List<CPUScheduler.Execution> executionList = cpu.StartExecution();
        //List<Process> processes = new List<Process>();
        //foreach (Process p in lstBox_Processes.Items)
        //  processes.Add(p);

        ResultForm resultForm = new ResultForm(processes, executionList, queue_type == 2);
        resultForm.Show();
      }

      foreach (Process p in lstBox_Processes.Items)
      {
        Console.WriteLine(p);
        Console.WriteLine("Arrival: " + p.ArrivalTime);
        Console.WriteLine("Departure: " + p.GetDepartureTime());
        Console.WriteLine("TurnAround: " + p.GetTurnAroundTime());
        Console.WriteLine("Waiting: " + p.GetWaitingTime());
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
      if (processes != null)
        refreshGrid();
    }

    private void btn_MoveUp_Click(object sender, EventArgs e)
    {
      //int index = lstBox_Processes.SelectedIndex;
      int index = lstBox_Processes.SelectedIndex;
      if (index > 0)
      {

        //object temp = lstBox_Processes.Items[index];
        //lstBox_Processes.Items[index] = lstBox_Processes.Items[index - 1];
        //lstBox_Processes.Items[index - 1] = temp;
        //lstBox_Processes.SelectedIndex--;

        Process temp = processes[index];
        processes[index] = processes[index - 1];
        processes[index - 1] = temp;
        //lstBox_Processes.SelectedIndex--;
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

      //while (lstBox_Processes.Items.Count != 0)
      //  lstBox_Processes.Items.RemoveAt(0);
      while (processes.Count != 0)
        processes.RemoveAt(0);

      refreshGrid();
      CheckButtonsStatus();
    }

    private void CheckButtonsStatus()
    {
      //bool enable = lstBox_Processes.SelectedIndex != -1; // lstBox_Processes.Items.Count == 0 || 
      bool enable = dataGridView.SelectedCells.Count != 0;


      btn_Edit.Enabled = enable;
      btn_Remove.Enabled = enable;
      //btn_RemoveAll.Enabled = enable || lstBox_Processes.Items.Count != 0;
      btn_RemoveAll.Enabled = enable || dataGridView.Rows.Count > 0;
      btn_MoveUp.Enabled = enable;
      btn_MoveDown.Enabled = enable;
    }

    private void lstBox_Processes_SelectedIndexChanged(object sender, EventArgs e)
    {
      CheckButtonsStatus();
    }

    private void dataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
    {
      refreshProcesses();
    }

    private void dataGridView_SelectionChanged(object sender, EventArgs e)
    {
      CheckButtonsStatus();
    }
  }
}
