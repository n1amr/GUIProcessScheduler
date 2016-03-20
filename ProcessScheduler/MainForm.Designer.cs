namespace ProcessScheduler
{
  partial class MainForm
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
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.cmb_QueueType = new System.Windows.Forms.ComboBox();
      this.chk_Preemptive = new System.Windows.Forms.CheckBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.lstBox_Processes = new System.Windows.Forms.ListBox();
      this.btn_Add = new System.Windows.Forms.Button();
      this.btn_Remove = new System.Windows.Forms.Button();
      this.btn_Calculate = new System.Windows.Forms.Button();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.chk_Preemptive);
      this.groupBox1.Controls.Add(this.cmb_QueueType);
      this.groupBox1.Location = new System.Drawing.Point(12, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(252, 67);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Queue Type";
      // 
      // cmb_QueueType
      // 
      this.cmb_QueueType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmb_QueueType.FormattingEnabled = true;
      this.cmb_QueueType.Items.AddRange(new object[] {
            "FCFS",
            "SJF",
            "Priority",
            "Round Robin"});
      this.cmb_QueueType.Location = new System.Drawing.Point(6, 30);
      this.cmb_QueueType.Name = "cmb_QueueType";
      this.cmb_QueueType.Size = new System.Drawing.Size(121, 21);
      this.cmb_QueueType.TabIndex = 0;
      // 
      // chk_Preemptive
      // 
      this.chk_Preemptive.AutoSize = true;
      this.chk_Preemptive.Location = new System.Drawing.Point(134, 30);
      this.chk_Preemptive.Name = "chk_Preemptive";
      this.chk_Preemptive.Size = new System.Drawing.Size(80, 17);
      this.chk_Preemptive.TabIndex = 1;
      this.chk_Preemptive.Text = "Preemptive";
      this.chk_Preemptive.UseVisualStyleBackColor = true;
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.btn_Remove);
      this.groupBox2.Controls.Add(this.btn_Add);
      this.groupBox2.Controls.Add(this.lstBox_Processes);
      this.groupBox2.Location = new System.Drawing.Point(12, 85);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(252, 243);
      this.groupBox2.TabIndex = 1;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Processes";
      // 
      // lstBox_Processes
      // 
      this.lstBox_Processes.FormattingEnabled = true;
      this.lstBox_Processes.Location = new System.Drawing.Point(7, 20);
      this.lstBox_Processes.Name = "lstBox_Processes";
      this.lstBox_Processes.Size = new System.Drawing.Size(152, 212);
      this.lstBox_Processes.TabIndex = 0;
      // 
      // btn_Add
      // 
      this.btn_Add.Location = new System.Drawing.Point(165, 20);
      this.btn_Add.Name = "btn_Add";
      this.btn_Add.Size = new System.Drawing.Size(75, 23);
      this.btn_Add.TabIndex = 1;
      this.btn_Add.Text = "Add";
      this.btn_Add.UseVisualStyleBackColor = true;
      this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
      // 
      // btn_Remove
      // 
      this.btn_Remove.Location = new System.Drawing.Point(164, 49);
      this.btn_Remove.Name = "btn_Remove";
      this.btn_Remove.Size = new System.Drawing.Size(75, 23);
      this.btn_Remove.TabIndex = 2;
      this.btn_Remove.Text = "Remove";
      this.btn_Remove.UseVisualStyleBackColor = true;
      this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
      // 
      // btn_Calculate
      // 
      this.btn_Calculate.Location = new System.Drawing.Point(96, 340);
      this.btn_Calculate.Name = "btn_Calculate";
      this.btn_Calculate.Size = new System.Drawing.Size(75, 23);
      this.btn_Calculate.TabIndex = 2;
      this.btn_Calculate.Text = "Calculate";
      this.btn_Calculate.UseVisualStyleBackColor = true;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(266, 375);
      this.Controls.Add(this.btn_Calculate);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Name = "MainForm";
      this.Text = "MainForm";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.CheckBox chk_Preemptive;
    private System.Windows.Forms.ComboBox cmb_QueueType;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.ListBox lstBox_Processes;
    private System.Windows.Forms.Button btn_Remove;
    private System.Windows.Forms.Button btn_Add;
    private System.Windows.Forms.Button btn_Calculate;
  }
}