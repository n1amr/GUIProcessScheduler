namespace ProcessScheduler
{
  partial class ResultForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.panel = new System.Windows.Forms.Panel();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // panel
      // 
      this.panel.AutoSize = true;
      this.panel.Location = new System.Drawing.Point(12, 69);
      this.panel.Name = "panel";
      this.panel.Size = new System.Drawing.Size(120, 76);
      this.panel.TabIndex = 1;
      this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
      // 
      // dataGridView1
      // 
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new System.Drawing.Point(12, 151);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(725, 150);
      this.dataGridView1.TabIndex = 2;
      // 
      // ResultForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(749, 337);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.panel);
      this.Name = "ResultForm";
      this.Text = "ResultForm";
      this.Resize += new System.EventHandler(this.ResultForm_Resize);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Panel panel;
    private System.Windows.Forms.DataGridView dataGridView1;
  }
}