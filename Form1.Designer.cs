namespace ProcessNote
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ProcessName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cPU_usage = new System.Windows.Forms.Label();
            this.memory_usage = new System.Windows.Forms.Label();
            this.running_time = new System.Windows.Forms.Label();
            this.start_time = new System.Windows.Forms.Label();
            this.threads = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProcessName,
            this.ID,
            this.Comment});
            this.dataGridView1.Location = new System.Drawing.Point(2, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(466, 327);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // ProcessName
            // 
            this.ProcessName.HeaderText = "Process Name";
            this.ProcessName.Name = "ProcessName";
            this.ProcessName.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Comment
            // 
            this.Comment.HeaderText = "Comment";
            this.Comment.Name = "Comment";
            this.Comment.Width = 300;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "CPU usage:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(205, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Running time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(98, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Memory usage:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(299, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Start time:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(372, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Threads:";
            // 
            // cPU_usage
            // 
            this.cPU_usage.AutoSize = true;
            this.cPU_usage.Location = new System.Drawing.Point(13, 288);
            this.cPU_usage.Name = "cPU_usage";
            this.cPU_usage.Size = new System.Drawing.Size(35, 13);
            this.cPU_usage.TabIndex = 6;
            this.cPU_usage.Text = "label6";
            // 
            // memory_usage
            // 
            this.memory_usage.AutoSize = true;
            this.memory_usage.Location = new System.Drawing.Point(101, 288);
            this.memory_usage.Name = "memory_usage";
            this.memory_usage.Size = new System.Drawing.Size(35, 13);
            this.memory_usage.TabIndex = 7;
            this.memory_usage.Text = "label6";
            // 
            // running_time
            // 
            this.running_time.AutoSize = true;
            this.running_time.Location = new System.Drawing.Point(208, 288);
            this.running_time.Name = "running_time";
            this.running_time.Size = new System.Drawing.Size(35, 13);
            this.running_time.TabIndex = 8;
            this.running_time.Text = "label6";
            // 
            // start_time
            // 
            this.start_time.AutoSize = true;
            this.start_time.Location = new System.Drawing.Point(302, 288);
            this.start_time.Name = "start_time";
            this.start_time.Size = new System.Drawing.Size(35, 13);
            this.start_time.TabIndex = 9;
            this.start_time.Text = "label6";
            // 
            // threads
            // 
            this.threads.AutoSize = true;
            this.threads.Location = new System.Drawing.Point(375, 288);
            this.threads.Name = "threads";
            this.threads.Size = new System.Drawing.Size(35, 13);
            this.threads.TabIndex = 10;
            this.threads.Text = "label6";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Khaki;
            this.panel1.Location = new System.Drawing.Point(2, 256);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 52);
            this.panel1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 329);
            this.Controls.Add(this.threads);
            this.Controls.Add(this.start_time);
            this.Controls.Add(this.running_time);
            this.Controls.Add(this.memory_usage);
            this.Controls.Add(this.cPU_usage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcessName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label cPU_usage;
        private System.Windows.Forms.Label memory_usage;
        private System.Windows.Forms.Label running_time;
        private System.Windows.Forms.Label start_time;
        private System.Windows.Forms.Label threads;
        private System.Windows.Forms.Panel panel1;
    }
}

