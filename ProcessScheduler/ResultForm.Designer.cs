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
      this.lstBox_Queue = new System.Windows.Forms.ListBox();
      this.SuspendLayout();
      // 
      // lstBox_Queue
      // 
      this.lstBox_Queue.FormattingEnabled = true;
      this.lstBox_Queue.Location = new System.Drawing.Point(75, 35);
      this.lstBox_Queue.Name = "lstBox_Queue";
      this.lstBox_Queue.Size = new System.Drawing.Size(120, 199);
      this.lstBox_Queue.TabIndex = 0;
      // 
      // ResultForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 261);
      this.Controls.Add(this.lstBox_Queue);
      this.Name = "ResultForm";
      this.Text = "ResultForm";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ListBox lstBox_Queue;
  }
}