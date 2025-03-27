namespace DistractionsTracker.Forms
{
    partial class ViewSession
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
            label2 = new Label();
            distractionsDataGridView = new DataGridView();
            Distraction = new DataGridViewTextBoxColumn();
            Count = new DataGridViewTextBoxColumn();
            label1 = new Label();
            sessionIdLabel = new Label();
            label3 = new Label();
            totalDistractionCountLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)distractionsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(280, 23);
            label2.TabIndex = 7;
            label2.Text = "Distractions from Session";
            // 
            // distractionsDataGridView
            // 
            distractionsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            distractionsDataGridView.Columns.AddRange(new DataGridViewColumn[] { Distraction, Count });
            distractionsDataGridView.Location = new Point(12, 70);
            distractionsDataGridView.Name = "distractionsDataGridView";
            distractionsDataGridView.RowHeadersVisible = false;
            distractionsDataGridView.Size = new Size(280, 332);
            distractionsDataGridView.TabIndex = 8;
            // 
            // Distraction
            // 
            Distraction.HeaderText = "Distraction";
            Distraction.Name = "Distraction";
            Distraction.Width = 177;
            // 
            // Count
            // 
            Count.HeaderText = "Count";
            Count.Name = "Count";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 41);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 9;
            label1.Text = "Session ID:";
            // 
            // sessionIdLabel
            // 
            sessionIdLabel.AutoSize = true;
            sessionIdLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sessionIdLabel.Location = new Point(81, 41);
            sessionIdLabel.Name = "sessionIdLabel";
            sessionIdLabel.Size = new Size(87, 15);
            sessionIdLabel.TabIndex = 10;
            sessionIdLabel.Text = "[ID of Session]";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 414);
            label3.Name = "label3";
            label3.Size = new Size(131, 15);
            label3.TabIndex = 11;
            label3.Text = "Total Distraction Count:";
            // 
            // totalDistractionCountLabel
            // 
            totalDistractionCountLabel.AutoSize = true;
            totalDistractionCountLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalDistractionCountLabel.Location = new Point(149, 414);
            totalDistractionCountLabel.Name = "totalDistractionCountLabel";
            totalDistractionCountLabel.Size = new Size(145, 15);
            totalDistractionCountLabel.TabIndex = 12;
            totalDistractionCountLabel.Text = "[Number of Distractions]";
            // 
            // ViewSession
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(307, 442);
            Controls.Add(totalDistractionCountLabel);
            Controls.Add(label3);
            Controls.Add(sessionIdLabel);
            Controls.Add(label1);
            Controls.Add(distractionsDataGridView);
            Controls.Add(label2);
            Name = "ViewSession";
            Text = "View Individual Session";
            ((System.ComponentModel.ISupportInitialize)distractionsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private DataGridView distractionsDataGridView;
        private Label label1;
        private Label sessionIdLabel;
        private Label label3;
        private Label totalDistractionCountLabel;
        private DataGridViewTextBoxColumn Distraction;
        private DataGridViewTextBoxColumn Count;
    }
}