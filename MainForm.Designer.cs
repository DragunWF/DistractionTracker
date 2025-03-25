namespace DistractionsTracker
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            dataGridView1 = new DataGridView();
            submitBtn = new Button();
            comboBox1 = new ComboBox();
            saveBtn = new Button();
            label2 = new Label();
            viewSessionsBtn = new Button();
            viewOverallStatsBtn = new Button();
            DistractionName = new DataGridViewTextBoxColumn();
            DistractionCount = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 44);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 1;
            label1.Text = "Distraction";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { DistractionName, DistractionCount });
            dataGridView1.Location = new Point(12, 120);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(269, 275);
            dataGridView1.TabIndex = 2;
            // 
            // submitBtn
            // 
            submitBtn.Location = new Point(12, 91);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(75, 23);
            submitBtn.TabIndex = 3;
            submitBtn.Text = "Submit";
            submitBtn.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 62);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(269, 23);
            comboBox1.TabIndex = 4;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(93, 91);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(188, 23);
            saveBtn.TabIndex = 5;
            saveBtn.Text = "Save and Start New Session";
            saveBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(269, 23);
            label2.TabIndex = 6;
            label2.Text = "Distraction Tracker App";
            // 
            // viewSessionsBtn
            // 
            viewSessionsBtn.Location = new Point(12, 401);
            viewSessionsBtn.Name = "viewSessionsBtn";
            viewSessionsBtn.Size = new Size(108, 23);
            viewSessionsBtn.TabIndex = 7;
            viewSessionsBtn.Text = "View Sessions";
            viewSessionsBtn.UseVisualStyleBackColor = true;
            // 
            // viewOverallStatsBtn
            // 
            viewOverallStatsBtn.Location = new Point(126, 401);
            viewOverallStatsBtn.Name = "viewOverallStatsBtn";
            viewOverallStatsBtn.Size = new Size(155, 23);
            viewOverallStatsBtn.TabIndex = 8;
            viewOverallStatsBtn.Text = "View Overall Stats";
            viewOverallStatsBtn.UseVisualStyleBackColor = true;
            // 
            // DistractionName
            // 
            DistractionName.HeaderText = "Distraction";
            DistractionName.Name = "DistractionName";
            DistractionName.Width = 176;
            // 
            // DistractionCount
            // 
            DistractionCount.HeaderText = "Count";
            DistractionCount.Name = "DistractionCount";
            DistractionCount.Width = 50;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 446);
            Controls.Add(viewOverallStatsBtn);
            Controls.Add(viewSessionsBtn);
            Controls.Add(label2);
            Controls.Add(saveBtn);
            Controls.Add(comboBox1);
            Controls.Add(submitBtn);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Distraction Tracker";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private DataGridView dataGridView1;
        private Button submitBtn;
        private DataGridViewTextBoxColumn DistractionName;
        private DataGridViewTextBoxColumn DistractionCount;
        private ComboBox comboBox1;
        private Button saveBtn;
        private Label label2;
        private Button viewSessionsBtn;
        private Button viewOverallStatsBtn;
    }
}
