namespace DistractionsTracker.Forms
{
    partial class ViewAllSessionsForm
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
            sessionDataGridView = new DataGridView();
            label1 = new Label();
            resetBtn = new Button();
            refreshBtn = new Button();
            Id = new DataGridViewTextBoxColumn();
            StartDate = new DataGridViewTextBoxColumn();
            EndDate = new DataGridViewTextBoxColumn();
            TotalDistractionCount = new DataGridViewTextBoxColumn();
            DistractionTypes = new DataGridViewTextBoxColumn();
            ViewBtn = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)sessionDataGridView).BeginInit();
            SuspendLayout();
            // 
            // sessionDataGridView
            // 
            sessionDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            sessionDataGridView.Columns.AddRange(new DataGridViewColumn[] { Id, StartDate, EndDate, TotalDistractionCount, DistractionTypes, ViewBtn });
            sessionDataGridView.Location = new Point(12, 53);
            sessionDataGridView.Name = "sessionDataGridView";
            sessionDataGridView.RowHeadersVisible = false;
            sessionDataGridView.Size = new Size(604, 291);
            sessionDataGridView.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(190, 9);
            label1.Name = "label1";
            label1.Size = new Size(259, 30);
            label1.TabIndex = 1;
            label1.Text = "Deep Work Sessions";
            // 
            // resetBtn
            // 
            resetBtn.Location = new Point(486, 351);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(130, 23);
            resetBtn.TabIndex = 2;
            resetBtn.Text = "Reset Data";
            resetBtn.UseVisualStyleBackColor = true;
            resetBtn.Click += resetBtn_Click;
            // 
            // refreshBtn
            // 
            refreshBtn.Location = new Point(12, 350);
            refreshBtn.Name = "refreshBtn";
            refreshBtn.Size = new Size(130, 23);
            refreshBtn.TabIndex = 3;
            refreshBtn.Text = "Refresh Data";
            refreshBtn.UseVisualStyleBackColor = true;
            refreshBtn.Click += refreshBtn_Click;
            // 
            // Id
            // 
            Id.HeaderText = "ID";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // StartDate
            // 
            StartDate.HeaderText = "Start Date";
            StartDate.Name = "StartDate";
            StartDate.Width = 150;
            // 
            // EndDate
            // 
            EndDate.HeaderText = "End Date";
            EndDate.Name = "EndDate";
            EndDate.Width = 150;
            // 
            // TotalDistractionCount
            // 
            TotalDistractionCount.HeaderText = "Total Distraction Count";
            TotalDistractionCount.Name = "TotalDistractionCount";
            // 
            // DistractionTypes
            // 
            DistractionTypes.HeaderText = "Distraction Types";
            DistractionTypes.Name = "DistractionTypes";
            // 
            // ViewBtn
            // 
            ViewBtn.HeaderText = "Details";
            ViewBtn.Name = "ViewBtn";
            ViewBtn.Text = "View More";
            ViewBtn.UseColumnTextForButtonValue = true;
            // 
            // SessionsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 386);
            Controls.Add(refreshBtn);
            Controls.Add(resetBtn);
            Controls.Add(label1);
            Controls.Add(sessionDataGridView);
            Name = "SessionsForm";
            Text = "Deep Work Sessions Form";
            ((System.ComponentModel.ISupportInitialize)sessionDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView sessionDataGridView;
        private Label label1;
        private Button resetBtn;
        private Button refreshBtn;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn StartDate;
        private DataGridViewTextBoxColumn EndDate;
        private DataGridViewTextBoxColumn TotalDistractionCount;
        private DataGridViewTextBoxColumn DistractionTypes;
        private DataGridViewButtonColumn ViewBtn;
    }
}