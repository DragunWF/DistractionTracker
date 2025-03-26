namespace DistractionsTracker.Forms
{
    partial class SessionsForm
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
            SessionDate = new DataGridViewTextBoxColumn();
            TotalDistractionCount = new DataGridViewTextBoxColumn();
            DistractionTypes = new DataGridViewTextBoxColumn();
            label1 = new Label();
            resetBtn = new Button();
            refeshBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)sessionDataGridView).BeginInit();
            SuspendLayout();
            // 
            // sessionDataGridView
            // 
            sessionDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            sessionDataGridView.Columns.AddRange(new DataGridViewColumn[] { SessionDate, TotalDistractionCount, DistractionTypes });
            sessionDataGridView.Location = new Point(12, 53);
            sessionDataGridView.Name = "sessionDataGridView";
            sessionDataGridView.RowHeadersVisible = false;
            sessionDataGridView.Size = new Size(393, 291);
            sessionDataGridView.TabIndex = 0;
            // 
            // SessionDate
            // 
            SessionDate.HeaderText = "Session Date";
            SessionDate.Name = "SessionDate";
            SessionDate.Width = 190;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(259, 30);
            label1.TabIndex = 1;
            label1.Text = "Deep Work Sessions";
            // 
            // resetBtn
            // 
            resetBtn.Location = new Point(138, 350);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(133, 23);
            resetBtn.TabIndex = 2;
            resetBtn.Text = "Reset Data";
            resetBtn.UseVisualStyleBackColor = true;
            resetBtn.Click += resetBtn_Click;
            // 
            // refeshBtn
            // 
            refeshBtn.Location = new Point(12, 350);
            refeshBtn.Name = "refeshBtn";
            refeshBtn.Size = new Size(120, 23);
            refeshBtn.TabIndex = 3;
            refeshBtn.Text = "Refresh Data";
            refeshBtn.UseVisualStyleBackColor = true;
            refeshBtn.Click += refeshBtn_Click;
            // 
            // SessionsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 386);
            Controls.Add(refeshBtn);
            Controls.Add(resetBtn);
            Controls.Add(label1);
            Controls.Add(sessionDataGridView);
            Name = "SessionsForm";
            Text = "SessionsForm";
            ((System.ComponentModel.ISupportInitialize)sessionDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView sessionDataGridView;
        private Label label1;
        private DataGridViewTextBoxColumn SessionDate;
        private DataGridViewTextBoxColumn TotalDistractionCount;
        private DataGridViewTextBoxColumn DistractionTypes;
        private Button resetBtn;
        private Button refeshBtn;
    }
}