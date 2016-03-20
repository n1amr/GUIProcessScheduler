using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessScheduler
{
  public partial class NewProcessForm : Form
  {
    public Process process;

    public NewProcessForm()
    {
      InitializeComponent();
      process = new Process(0);
    }

    public NewProcessForm(Process process, bool priority = false)
    {
      InitializeComponent();
      this.process = process;

      txtBox_ProcessName.Text = process.Name;
      numUpDn_BurstTime.Value = process.BurstTime;
      numUpDn_Prioriity.Value = process.Priority;
      numUpDn_ArrivalTime.Value = process.ArrivalTime;

      numUpDn_Prioriity.Enabled = priority;
    }

    private void btn_Ok_Click(object sender, EventArgs e)
    {
      this.DialogResult = DialogResult.OK;
      this.Close();
    }

    private void txtBox_ProcessName_TextChanged(object sender, EventArgs e)
    {
      process.Name = txtBox_ProcessName.Text;
    }

    private void numUpDn_BurstTime_ValueChanged(object sender, EventArgs e)
    {
      process.SetBurstTime((int)numUpDn_BurstTime.Value);
    }

    private void numUpDn_ArrivalTime_ValueChanged(object sender, EventArgs e)
    {
      process.ArrivalTime = ((int)numUpDn_ArrivalTime.Value);
    }

    private void numUpDn_Prioriity_ValueChanged(object sender, EventArgs e)
    {
      process.Priority = ((int)numUpDn_Prioriity.Value);
    }

    public Process getProcess()
    {
      return process;
    }
  }
}
