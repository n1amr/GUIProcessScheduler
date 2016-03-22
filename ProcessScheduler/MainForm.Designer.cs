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
      this.label1 = new System.Windows.Forms.Label();
      this.numUpDn_Quantum = new System.Windows.Forms.NumericUpDown();
      this.chk_Preemptive = new System.Windows.Forms.CheckBox();
      this.cmb_QueueType = new System.Windows.Forms.ComboBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.btn_RemoveAll = new System.Windows.Forms.Button();
      this.btn_MoveDown = new System.Windows.Forms.Button();
      this.btn_MoveUp = new System.Windows.Forms.Button();
      this.btn_Edit = new System.Windows.Forms.Button();
      this.btn_Remove = new System.Windows.Forms.Button();
      this.btn_Add = new System.Windows.Forms.Button();
      this.lstBox_Processes = new System.Windows.Forms.ListBox();
      this.btn_Calculate = new System.Windows.Forms.Button();
      this.dataGridView = new System.Windows.Forms.DataGridView();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numUpDn_Quantum)).BeginInit();
      this.groupBox2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.numUpDn_Quantum);
      this.groupBox1.Controls.Add(this.chk_Preemptive);
      this.groupBox1.Controls.Add(this.cmb_QueueType);
      this.groupBox1.Location = new System.Drawing.Point(12, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(252, 82);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Scheduling Method";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(122, 55);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(51, 13);
      this.label1.TabIndex = 3;
      this.label1.Text = "Quantum";
      // 
      // numUpDn_Quantum
      // 
      this.numUpDn_Quantum.Location = new System.Drawing.Point(179, 53);
      this.numUpDn_Quantum.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
      this.numUpDn_Quantum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numUpDn_Quantum.Name = "numUpDn_Quantum";
      this.numUpDn_Quantum.Size = new System.Drawing.Size(67, 20);
      this.numUpDn_Quantum.TabIndex = 2;
      this.numUpDn_Quantum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // chk_Preemptive
      // 
      this.chk_Preemptive.AutoSize = true;
      this.chk_Preemptive.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.chk_Preemptive.Location = new System.Drawing.Point(122, 30);
      this.chk_Preemptive.Name = "chk_Preemptive";
      this.chk_Preemptive.Size = new System.Drawing.Size(80, 17);
      this.chk_Preemptive.TabIndex = 1;
      this.chk_Preemptive.Text = "Preemptive";
      this.chk_Preemptive.UseVisualStyleBackColor = true;
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
      this.cmb_QueueType.Location = new System.Drawing.Point(6, 28);
      this.cmb_QueueType.Name = "cmb_QueueType";
      this.cmb_QueueType.Size = new System.Drawing.Size(100, 21);
      this.cmb_QueueType.TabIndex = 0;
      this.cmb_QueueType.SelectedIndexChanged += new System.EventHandler(this.cmb_QueueType_SelectedIndexChanged);
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.btn_RemoveAll);
      this.groupBox2.Controls.Add(this.btn_MoveDown);
      this.groupBox2.Controls.Add(this.btn_MoveUp);
      this.groupBox2.Controls.Add(this.btn_Edit);
      this.groupBox2.Controls.Add(this.btn_Remove);
      this.groupBox2.Controls.Add(this.btn_Add);
      this.groupBox2.Controls.Add(this.lstBox_Processes);
      this.groupBox2.Location = new System.Drawing.Point(12, 100);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(252, 199);
      this.groupBox2.TabIndex = 1;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Processes";
      // 
      // btn_RemoveAll
      // 
      this.btn_RemoveAll.Enabled = false;
      this.btn_RemoveAll.Location = new System.Drawing.Point(165, 107);
      this.btn_RemoveAll.Name = "btn_RemoveAll";
      this.btn_RemoveAll.Size = new System.Drawing.Size(75, 23);
      this.btn_RemoveAll.TabIndex = 4;
      this.btn_RemoveAll.Text = "Remove All";
      this.btn_RemoveAll.UseVisualStyleBackColor = true;
      this.btn_RemoveAll.Click += new System.EventHandler(this.btn_RemoveAll_Click);
      // 
      // btn_MoveDown
      // 
      this.btn_MoveDown.Location = new System.Drawing.Point(167, 165);
      this.btn_MoveDown.Name = "btn_MoveDown";
      this.btn_MoveDown.Size = new System.Drawing.Size(75, 23);
      this.btn_MoveDown.TabIndex = 6;
      this.btn_MoveDown.Text = "Move Down";
      this.btn_MoveDown.UseVisualStyleBackColor = true;
      this.btn_MoveDown.Click += new System.EventHandler(this.btn_MoveDown_Click);
      // 
      // btn_MoveUp
      // 
      this.btn_MoveUp.Location = new System.Drawing.Point(167, 136);
      this.btn_MoveUp.Name = "btn_MoveUp";
      this.btn_MoveUp.Size = new System.Drawing.Size(75, 23);
      this.btn_MoveUp.TabIndex = 5;
      this.btn_MoveUp.Text = "Move Up";
      this.btn_MoveUp.UseVisualStyleBackColor = true;
      this.btn_MoveUp.Click += new System.EventHandler(this.btn_MoveUp_Click);
      // 
      // btn_Edit
      // 
      this.btn_Edit.Enabled = false;
      this.btn_Edit.Location = new System.Drawing.Point(165, 49);
      this.btn_Edit.Name = "btn_Edit";
      this.btn_Edit.Size = new System.Drawing.Size(75, 23);
      this.btn_Edit.TabIndex = 2;
      this.btn_Edit.Text = "Edit";
      this.btn_Edit.UseVisualStyleBackColor = true;
      this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
      // 
      // btn_Remove
      // 
      this.btn_Remove.Enabled = false;
      this.btn_Remove.Location = new System.Drawing.Point(165, 78);
      this.btn_Remove.Name = "btn_Remove";
      this.btn_Remove.Size = new System.Drawing.Size(75, 23);
      this.btn_Remove.TabIndex = 3;
      this.btn_Remove.Text = "Remove";
      this.btn_Remove.UseVisualStyleBackColor = true;
      this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
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
      // lstBox_Processes
      // 
      this.lstBox_Processes.DisplayMember = "Name";
      this.lstBox_Processes.FormattingEnabled = true;
      this.lstBox_Processes.Location = new System.Drawing.Point(7, 20);
      this.lstBox_Processes.Name = "lstBox_Processes";
      this.lstBox_Processes.Size = new System.Drawing.Size(152, 173);
      this.lstBox_Processes.TabIndex = 0;
      this.lstBox_Processes.SelectedIndexChanged += new System.EventHandler(this.lstBox_Processes_SelectedIndexChanged);
      // 
      // btn_Calculate
      // 
      this.btn_Calculate.Location = new System.Drawing.Point(19, 305);
      this.btn_Calculate.Name = "btn_Calculate";
      this.btn_Calculate.Size = new System.Drawing.Size(233, 34);
      this.btn_Calculate.TabIndex = 2;
      this.btn_Calculate.Text = "Calculate";
      this.btn_Calculate.UseVisualStyleBackColor = true;
      this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
      // 
      // dataGridView
      // 
      this.dataGridView.AllowUserToResizeColumns = false;
      this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView.Location = new System.Drawing.Point(270, 12);
      this.dataGridView.Name = "dataGridView";
      this.dataGridView.Size = new System.Drawing.Size(428, 322);
      this.dataGridView.TabIndex = 3;
      this.dataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellEndEdit);
      this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
      // 
      // MainForm
      // 
      this.AcceptButton = this.btn_Calculate;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(710, 346);
      this.Controls.Add(this.dataGridView);
      this.Controls.Add(this.btn_Calculate);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Process Scheduler";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numUpDn_Quantum)).EndInit();
      this.groupBox2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
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
    private System.Windows.Forms.Button btn_Edit;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.NumericUpDown numUpDn_Quantum;
    private System.Windows.Forms.Button btn_MoveDown;
    private System.Windows.Forms.Button btn_MoveUp;
    private System.Windows.Forms.Button btn_RemoveAll;
    private System.Windows.Forms.DataGridView dataGridView;
  }
}