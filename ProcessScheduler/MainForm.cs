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
  public partial class MainForm : Form
  {
    public MainForm()
    {
      InitializeComponent();
    }

    private void btn_Add_Click(object sender, EventArgs e)
    {
      NewProcessForm form = new NewProcessForm();
      form.StartPosition = FormStartPosition.CenterParent;
      form.ShowDialog();
      if (form.DialogResult == DialogResult.OK)
      {
        lstBox_Processes.Items.Add(form.process.getProcessName());
      }
    }

    private void btn_Remove_Click(object sender, EventArgs e)
    {
      object item = lstBox_Processes.SelectedItem;
      if (item != null)
      {
        lstBox_Processes.Items.Remove(item);
      }
    }
  }
}
