﻿namespace ProcessScheduler
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
      this.panel = new System.Windows.Forms.Panel();
      this.SuspendLayout();
      // 
      // lstBox_Queue
      // 
      this.lstBox_Queue.FormattingEnabled = true;
      this.lstBox_Queue.Location = new System.Drawing.Point(12, 12);
      this.lstBox_Queue.Name = "lstBox_Queue";
      this.lstBox_Queue.Size = new System.Drawing.Size(120, 199);
      this.lstBox_Queue.TabIndex = 0;
      // 
      // panel
      // 
      this.panel.AutoSize = true;
      this.panel.Location = new System.Drawing.Point(169, 37);
      this.panel.Name = "panel";
      this.panel.Size = new System.Drawing.Size(120, 101);
      this.panel.TabIndex = 1;
      this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
      // 
      // ResultForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(749, 337);
      this.Controls.Add(this.panel);
      this.Controls.Add(this.lstBox_Queue);
      this.Name = "ResultForm";
      this.Text = "ResultForm";
      this.Resize += new System.EventHandler(this.ResultForm_Resize);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ListBox lstBox_Queue;
    private System.Windows.Forms.Panel panel;
  }
}