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
      this.dataGridView = new System.Windows.Forms.DataGridView();
      this.lbl = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
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
      // dataGridView
      // 
      this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Info;
      this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView.Location = new System.Drawing.Point(12, 151);
      this.dataGridView.Name = "dataGridView";
      this.dataGridView.RowTemplate.ReadOnly = true;
      this.dataGridView.Size = new System.Drawing.Size(725, 150);
      this.dataGridView.TabIndex = 2;
      // 
      // lbl
      // 
      this.lbl.AutoSize = true;
      this.lbl.Font = new System.Drawing.Font("Tahoma", 10F);
      this.lbl.Location = new System.Drawing.Point(295, 24);
      this.lbl.Name = "lbl";
      this.lbl.Size = new System.Drawing.Size(42, 17);
      this.lbl.TabIndex = 3;
      this.lbl.Text = "label1";
      // 
      // ResultForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(749, 341);
      this.Controls.Add(this.lbl);
      this.Controls.Add(this.dataGridView);
      this.Controls.Add(this.panel);
      this.MinimumSize = new System.Drawing.Size(660, 380);
      this.Name = "ResultForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Result";
      this.Resize += new System.EventHandler(this.ResultForm_Resize);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Panel panel;
    private System.Windows.Forms.DataGridView dataGridView;
    private System.Windows.Forms.Label lbl;
  }
}