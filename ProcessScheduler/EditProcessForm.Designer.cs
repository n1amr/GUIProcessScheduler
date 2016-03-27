namespace ProcessScheduler
{
  partial class EditProcessForm
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
      this.txtBox_ProcessName = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.numUpDn_BurstTime = new System.Windows.Forms.NumericUpDown();
      this.numUpDn_ArrivalTime = new System.Windows.Forms.NumericUpDown();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.numUpDn_Prioriity = new System.Windows.Forms.NumericUpDown();
      this.btn_Ok = new System.Windows.Forms.Button();
      this.btn_Cancel = new System.Windows.Forms.Button();
      this.colorDialog = new System.Windows.Forms.ColorDialog();
      this.btn_ColorChange = new System.Windows.Forms.Button();
      this.label5 = new System.Windows.Forms.Label();
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
      this.txtBox_ProcessName.TextChanged += new System.EventHandler(this.txtBox_ProcessName_TextChanged);
      this.txtBox_ProcessName.Enter += new System.EventHandler(this.txtBox_ProcessName_Enter);
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
      this.numUpDn_BurstTime.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
      this.numUpDn_BurstTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numUpDn_BurstTime.Name = "numUpDn_BurstTime";
      this.numUpDn_BurstTime.Size = new System.Drawing.Size(120, 20);
      this.numUpDn_BurstTime.TabIndex = 2;
      this.numUpDn_BurstTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numUpDn_BurstTime.ValueChanged += new System.EventHandler(this.numUpDn_BurstTime_ValueChanged);
      this.numUpDn_BurstTime.Enter += new System.EventHandler(this.numUpDn_BurstTime_Enter);
      // 
      // numUpDn_ArrivalTime
      // 
      this.numUpDn_ArrivalTime.Location = new System.Drawing.Point(96, 62);
      this.numUpDn_ArrivalTime.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
      this.numUpDn_ArrivalTime.Name = "numUpDn_ArrivalTime";
      this.numUpDn_ArrivalTime.Size = new System.Drawing.Size(120, 20);
      this.numUpDn_ArrivalTime.TabIndex = 3;
      this.numUpDn_ArrivalTime.ValueChanged += new System.EventHandler(this.numUpDn_ArrivalTime_ValueChanged);
      this.numUpDn_ArrivalTime.Enter += new System.EventHandler(this.numUpDn_ArrivalTime_Enter);
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
      this.numUpDn_Prioriity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
      this.numUpDn_Prioriity.Name = "numUpDn_Prioriity";
      this.numUpDn_Prioriity.Size = new System.Drawing.Size(120, 20);
      this.numUpDn_Prioriity.TabIndex = 6;
      this.numUpDn_Prioriity.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
      this.numUpDn_Prioriity.ValueChanged += new System.EventHandler(this.numUpDn_Prioriity_ValueChanged);
      this.numUpDn_Prioriity.Enter += new System.EventHandler(this.numUpDn_Prioriity_Enter);
      // 
      // btn_Ok
      // 
      this.btn_Ok.Location = new System.Drawing.Point(35, 142);
      this.btn_Ok.Name = "btn_Ok";
      this.btn_Ok.Size = new System.Drawing.Size(75, 23);
      this.btn_Ok.TabIndex = 8;
      this.btn_Ok.Text = "Ok";
      this.btn_Ok.UseVisualStyleBackColor = true;
      this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
      // 
      // btn_Cancel
      // 
      this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btn_Cancel.Location = new System.Drawing.Point(116, 142);
      this.btn_Cancel.Name = "btn_Cancel";
      this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
      this.btn_Cancel.TabIndex = 9;
      this.btn_Cancel.Text = "Cancel";
      this.btn_Cancel.UseVisualStyleBackColor = true;
      // 
      // btn_ColorChange
      // 
      this.btn_ColorChange.Location = new System.Drawing.Point(96, 113);
      this.btn_ColorChange.Name = "btn_ColorChange";
      this.btn_ColorChange.Size = new System.Drawing.Size(119, 23);
      this.btn_ColorChange.TabIndex = 10;
      this.btn_ColorChange.UseVisualStyleBackColor = true;
      this.btn_ColorChange.Click += new System.EventHandler(this.btn_ColorChange_Click);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(12, 113);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(32, 13);
      this.label5.TabIndex = 11;
      this.label5.Text = "Color";
      // 
      // EditProcessForm
      // 
      this.AcceptButton = this.btn_Ok;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.btn_Cancel;
      this.ClientSize = new System.Drawing.Size(227, 173);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.btn_ColorChange);
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
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "EditProcessForm";
      this.Text = "Edit Process";
      ((System.ComponentModel.ISupportInitialize)(this.numUpDn_BurstTime)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numUpDn_ArrivalTime)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numUpDn_Prioriity)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtBox_ProcessName;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.NumericUpDown numUpDn_BurstTime;
    private System.Windows.Forms.NumericUpDown numUpDn_ArrivalTime;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.NumericUpDown numUpDn_Prioriity;
    private System.Windows.Forms.Button btn_Ok;
    private System.Windows.Forms.Button btn_Cancel;
    private System.Windows.Forms.ColorDialog colorDialog;
    private System.Windows.Forms.Button btn_ColorChange;
    private System.Windows.Forms.Label label5;
  }
}

