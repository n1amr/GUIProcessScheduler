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
  public partial class EditProcessForm : Form
  {
    public Process process;

    public EditProcessForm(Process process, bool priority = false)
    {
      InitializeComponent();

      if (process == null)
        process = new Process(0);
      this.process = process;

      txtBox_ProcessName.Text = process.Name;
      numUpDn_BurstTime.Value = process.BurstTime;
      numUpDn_Prioriity.Value = process.Priority;
      numUpDn_ArrivalTime.Value = process.ArrivalTime;

      numUpDn_Prioriity.Enabled = priority;

      btn_ColorChange.BackColor = process.Color;
    }

    private void btn_Ok_Click(object sender, EventArgs e)
    {
      if (process.Name == null)
        process.Name = "Process";
      
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

    private void btn_ColorChange_Click(object sender, EventArgs e)
    {
      colorDialog.ShowDialog();
      process.Color = colorDialog.Color;
      btn_ColorChange.BackColor = colorDialog.Color;
    }
  }
}
