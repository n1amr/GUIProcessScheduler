namespace ProcessScheduler
{
  partial class NewProcessForm
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
      this.components = new System.ComponentModel.Container();
      this.txtBox_ProcessName = new System.Windows.Forms.TextBox();
      this.imageList1 = new System.Windows.Forms.ImageList(this.components);
      this.label1 = new System.Windows.Forms.Label();
      this.numUpDn_BurstTime = new System.Windows.Forms.NumericUpDown();
      this.numUpDn_ArrivalTime = new System.Windows.Forms.NumericUpDown();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.numUpDn_Prioriity = new System.Windows.Forms.NumericUpDown();
      this.btn_Ok = new System.Windows.Forms.Button();
      this.btn_Cancel = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.numUpDn_BurstTime)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numUpDn_ArrivalTime)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numUpDn_Prioriity)).BeginInit();
      this.SuspendLayout();
      // 
      // txtBox_ProcessName
      // 
      this.txtBox_ProcessName.Location = new System.Drawing.Point(96, 9);
      this.txtBox_ProcessName.Name = "txtBox_ProcessName";
      this.txtBox_ProcessName.Size = new System.Drawing.Size(120, 20);
      this.txtBox_ProcessName.TabIndex = 0;
      // 
      // imageList1
      // 
      this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
      this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
      this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(74, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Process Name";
      // 
      // numUpDn_BurstTime
      // 
      this.numUpDn_BurstTime.Location = new System.Drawing.Point(96, 36);
      this.numUpDn_BurstTime.Name = "numUpDn_BurstTime";
      this.numUpDn_BurstTime.Size = new System.Drawing.Size(120, 20);
      this.numUpDn_BurstTime.TabIndex = 2;
      // 
      // numUpDn_ArrivalTime
      // 
      this.numUpDn_ArrivalTime.Location = new System.Drawing.Point(96, 62);
      this.numUpDn_ArrivalTime.Name = "numUpDn_ArrivalTime";
      this.numUpDn_ArrivalTime.Size = new System.Drawing.Size(120, 20);
      this.numUpDn_ArrivalTime.TabIndex = 3;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 36);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(57, 13);
      this.label2.TabIndex = 4;
      this.label2.Text = "Burst Time";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(12, 64);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(63, 13);
      this.label3.TabIndex = 5;
      this.label3.Text = "Arrival Time";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(12, 89);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(41, 13);
      this.label4.TabIndex = 7;
      this.label4.Text = "Priority";
      // 
      // numUpDn_Prioriity
      // 
      this.numUpDn_Prioriity.Enabled = false;
      this.numUpDn_Prioriity.Location = new System.Drawing.Point(96, 87);
      this.numUpDn_Prioriity.Name = "numUpDn_Prioriity";
      this.numUpDn_Prioriity.Size = new System.Drawing.Size(120, 20);
      this.numUpDn_Prioriity.TabIndex = 6;
      // 
      // btn_Ok
      // 
      this.btn_Ok.Location = new System.Drawing.Point(36, 123);
      this.btn_Ok.Name = "btn_Ok";
      this.btn_Ok.Size = new System.Drawing.Size(75, 23);
      this.btn_Ok.TabIndex = 8;
      this.btn_Ok.Text = "Ok";
      this.btn_Ok.UseVisualStyleBackColor = true;
      // 
      // btn_Cancel
      // 
      this.btn_Cancel.Location = new System.Drawing.Point(117, 123);
      this.btn_Cancel.Name = "btn_Cancel";
      this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
      this.btn_Cancel.TabIndex = 9;
      this.btn_Cancel.Text = "Cancel";
      this.btn_Cancel.UseVisualStyleBackColor = true;
      // 
      // Scheduler
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(227, 158);
      this.Controls.Add(this.btn_Cancel);
      this.Controls.Add(this.btn_Ok);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.numUpDn_Prioriity);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.numUpDn_ArrivalTime);
      this.Controls.Add(this.numUpDn_BurstTime);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtBox_ProcessName);
      this.Name = "Scheduler";
      this.Text = "Process Scheduler";
      ((System.ComponentModel.ISupportInitialize)(this.numUpDn_BurstTime)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numUpDn_ArrivalTime)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numUpDn_Prioriity)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtBox_ProcessName;
    private System.Windows.Forms.ImageList imageList1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.NumericUpDown numUpDn_BurstTime;
    private System.Windows.Forms.NumericUpDown numUpDn_ArrivalTime;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.NumericUpDown numUpDn_Prioriity;
    private System.Windows.Forms.Button btn_Ok;
    private System.Windows.Forms.Button btn_Cancel;
  }
}

