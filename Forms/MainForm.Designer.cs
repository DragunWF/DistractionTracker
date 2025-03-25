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
            distractionDataGridView = new DataGridView();
            DistractionName = new DataGridViewTextBoxColumn();
            DistractionCount = new DataGridViewTextBoxColumn();
            submitBtn = new Button();
            distractionComboBox = new ComboBox();
            saveBtn = new Button();
            label2 = new Label();
            viewSessionsBtn = new Button();
            viewOverallStatsBtn = new Button();
            resetBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)distractionDataGridView).BeginInit();
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
            // distractionDataGridView
            // 
            distractionDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            distractionDataGridView.Columns.AddRange(new DataGridViewColumn[] { DistractionName, DistractionCount });
            distractionDataGridView.Location = new Point(12, 148);
            distractionDataGridView.Name = "distractionDataGridView";
            distractionDataGridView.RowHeadersVisible = false;
            distractionDataGridView.Size = new Size(269, 288);
            distractionDataGridView.TabIndex = 2;
            // 
            // DistractionName
            // 
            DistractionName.HeaderText = "Distraction Name";
            DistractionName.Name = "DistractionName";
            DistractionName.Width = 216;
            // 
            // DistractionCount
            // 
            DistractionCount.HeaderText = "Count";
            DistractionCount.Name = "DistractionCount";
            DistractionCount.Width = 50;
            // 
            // submitBtn
            // 
            submitBtn.Location = new Point(12, 91);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(183, 23);
            submitBtn.TabIndex = 3;
            submitBtn.Text = "Submit";
            submitBtn.UseVisualStyleBackColor = true;
            submitBtn.Click += submitBtn_Click;
            // 
            // distractionComboBox
            // 
            distractionComboBox.FormattingEnabled = true;
            distractionComboBox.Location = new Point(12, 62);
            distractionComboBox.Name = "distractionComboBox";
            distractionComboBox.Size = new Size(269, 23);
            distractionComboBox.TabIndex = 4;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(12, 119);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(269, 23);
            saveBtn.TabIndex = 5;
            saveBtn.Text = "Save and Start New Session";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
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
            viewSessionsBtn.Location = new Point(12, 442);
            viewSessionsBtn.Name = "viewSessionsBtn";
            viewSessionsBtn.Size = new Size(108, 23);
            viewSessionsBtn.TabIndex = 7;
            viewSessionsBtn.Text = "View Sessions";
            viewSessionsBtn.UseVisualStyleBackColor = true;
            viewSessionsBtn.Click += viewSessionsBtn_Click;
            // 
            // viewOverallStatsBtn
            // 
            viewOverallStatsBtn.Location = new Point(126, 442);
            viewOverallStatsBtn.Name = "viewOverallStatsBtn";
            viewOverallStatsBtn.Size = new Size(155, 23);
            viewOverallStatsBtn.TabIndex = 8;
            viewOverallStatsBtn.Text = "View Overall Stats";
            viewOverallStatsBtn.UseVisualStyleBackColor = true;
            // 
            // resetBtn
            // 
            resetBtn.Location = new Point(201, 91);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(80, 23);
            resetBtn.TabIndex = 9;
            resetBtn.Text = "Reset";
            resetBtn.UseVisualStyleBackColor = true;
            resetBtn.Click += resetBtn_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(295, 477);
            Controls.Add(resetBtn);
            Controls.Add(viewOverallStatsBtn);
            Controls.Add(viewSessionsBtn);
            Controls.Add(label2);
            Controls.Add(saveBtn);
            Controls.Add(distractionComboBox);
            Controls.Add(submitBtn);
            Controls.Add(distractionDataGridView);
            Controls.Add(label1);
            Name = "MainForm";
            Text = "Distraction Tracker";
            ((System.ComponentModel.ISupportInitialize)distractionDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private DataGridView distractionDataGridView;
        private Button submitBtn;
        private ComboBox distractionComboBox;
        private Button saveBtn;
        private Label label2;
        private Button viewSessionsBtn;
        private Button viewOverallStatsBtn;
        private Button resetBtn;
        private DataGridViewTextBoxColumn DistractionName;
        private DataGridViewTextBoxColumn DistractionCount;
    }
}
