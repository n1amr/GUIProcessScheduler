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
      form.ShowDialog();
      if (form.DialogResult == DialogResult.OK)
      {
        lstBox_Processes.Items.Add(form.process.getProcessName());
      }
    }
  }
}
